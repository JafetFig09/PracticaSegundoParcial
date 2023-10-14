using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCuatro.Entidades
{
    public class Producto
    {
        private static int ultimoId = 0;

        public int id { get; set; } = 0;
        public string nombre { get; set; }

        public double precio { get; set; }


        public Producto(string nombre, double precio)
        {
            this.id = ++ultimoId;
            this.nombre = nombre;
   
            this.precio = precio;
        }

        public override string ToString()
        {
            return $"Id: {id}  Producto: {nombre}  Precio: {precio} ";
        }
    }

}
