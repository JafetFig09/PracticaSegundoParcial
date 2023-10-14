using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Entidades
{
    public class Producto
    {

        public string nombre { get; set; }

        public int cantidad { get; set; }

        public  double precio { get; set; }

        private Random aleatorio = new Random();

       

        public Producto( string nombre)
        {
            this.nombre = nombre;
            this.cantidad = aleatorio.Next(1, 101);
            this.precio = Math.Round(aleatorio.NextDouble()*100,2);
            
        }

        public Producto( string nombre, int cantidad, double precio)
        {
            this.nombre= nombre;
            this.cantidad= cantidad;
            this.precio = precio;
        }
    }
}
