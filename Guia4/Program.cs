using Guia4;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la universidad
        Universidad UniversidadNacionaldeIngenieria = new Universidad();

        // Agregar alumnos a la universidad
        Alumno alumno1 = new Alumno("Mario Diaz", 20, Alumno.carreras.Ingenieria_de_sistemas, "2023 1114u");
        alumno1.Calificaciones.Add(80);
        alumno1.Calificaciones.Add(75);
        alumno1.Calificaciones.Add(68);

        Alumno alumno2 = new Alumno("Alex lopez", 21, Alumno.carreras.Ingenieria_en_computacion, "2023 5566u");
        alumno2.Calificaciones.Add(55);
        alumno2.Calificaciones.Add(60);
        alumno2.Calificaciones.Add(50);

        Alumno alumno3 = new Alumno("Martin Diaz", 22, Alumno.carreras.Telecounicaciones, "2015 3456u");
        alumno3.Calificaciones.Add(80);
        alumno3.Calificaciones.Add(78);
        alumno3.Calificaciones.Add(85.9);

        Alumno alumno4 = new Alumno("Mario Mendez", 23, Alumno.carreras.Ingenieria_electronica, "2022 1126h");
        alumno4.Calificaciones.Add(60);
        alumno4.Calificaciones.Add(65);
        alumno4.Calificaciones.Add(78);


        UniversidadNacionaldeIngenieria.AgregarAlumno(alumno1);
        UniversidadNacionaldeIngenieria.AgregarAlumno(alumno2);
        UniversidadNacionaldeIngenieria.AgregarAlumno(alumno3);
        UniversidadNacionaldeIngenieria.AgregarAlumno(alumno4);


        List<Alumno> listaAlumnos = UniversidadNacionaldeIngenieria.ObtenerListaAlumno();
        foreach (Alumno alumno in listaAlumnos)
        {
            Console.WriteLine("**Información del Alumno**");
            Console.WriteLine("Nombre: " + alumno.Nombre);
            Console.WriteLine("Edad: " + alumno.Edad);
            Console.WriteLine("Carrera: " + alumno.Carrera);
            Console.WriteLine("Carnet: " + alumno.Carnet);

            Console.Write("Calificaciones: ");
            int contadorCalificaciones = 1;
            foreach (double calificacion in alumno.Calificaciones)
            {
                Console.Write(calificacion);
                if (contadorCalificaciones < alumno.Calificaciones.Count!)
                {
                    Console.Write(", ");
                }
                contadorCalificaciones++;
            }

            Console.WriteLine();
            Console.WriteLine("Promedio: " + alumno.CalcularPromedioCalificaciones());
            Console.WriteLine("Estado de Aprobación: " + alumno.EstadoAprobacion());
            Console.WriteLine("--------------------------");
        }
    }

}


