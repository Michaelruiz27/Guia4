using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Alumno
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public carreras Carrera { get; set; }
        public string Carnet { get; set; }
        public List<double> Calificaciones { get; set; }

        //Constructor para inicializar las propiedades del alumno
        public Alumno(string nombre, int edad, carreras carrera, string carnet)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carrera = carrera;
            this.Carnet = carnet;
            Calificaciones = new List<double>();
        }

        public Alumno(string nombre, int edad, carreras carrera, string carnet, List<double> calificaciones) : this(nombre, edad, carrera, carnet)
        {
        }

        //Metodo para calcular el promedio del alumno
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0; //Si no hay Calificaciones, el promedio es 0
            }

            double sumaCalificaciones = 0;
            foreach (var Calificacion in Calificaciones)
            {
                sumaCalificaciones += Calificacion;
            }
            return sumaCalificaciones / Calificaciones.Count;
        }

        //Metodo para determinar si el alumno aprobó o reprobó ----- Aprobó (promedio >= 60) y Reprobó (promedio < 60)
        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";

            }
        }

        public enum carreras
        {
            Ingenieria_de_sistemas,
            Ingenieria_en_computacion,
            Telecounicaciones,
            Ingenieria_electronica
        }


    }
}
