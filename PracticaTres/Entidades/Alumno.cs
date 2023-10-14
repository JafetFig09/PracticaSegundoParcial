using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTres.Entidades
{
    public class Alumno
    {
        public string nombre { get; set; }

        public double calificacion { get; set; }

        public Alumno( string nombre, double calificacion)
        {
            this.nombre = nombre;
            this.calificacion = calificacion;
        }


        public override string ToString()
        {
            return $"Nombre: {nombre}    Calificacion:  {calificacion}";
        }
    }
}
