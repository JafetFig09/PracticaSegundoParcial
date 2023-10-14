using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaUno.Entidades;

namespace PracticaUno.Servicios
{
    public class ServiciosProducto
    {
        private List<Producto> _productos ;

        private List<Producto> _productosEliminados;

        public ServiciosProducto()
        {
            _productos = new List<Producto>();
            _productosEliminados = new List<Producto>();
        }


        public Producto SolictarAgregar()
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Nombre del Producto: ");
           if (string.IsNullOrEmpty(nombre))
           {
              return null; // Opcional: puedes devolver null o algún otro valor para indicar que no se ingresó un nombre
           }

            return new Producto(nombre);
        }

        public void AgregarProducto()
        {
            Producto producto = SolictarAgregar();

            if (producto != null)
            {
                _productos.Add(producto);

                MessageBox.Show("Producto Agregado Correctamente", "Éxito", MessageBoxButtons.OK);
            }
        }

        public void SolictarBorrar()
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Nombre del Producto a eliminar: ");

            
                if (string.IsNullOrEmpty(nombre))
                {
                    return; // Opcional: puedes devolver null o algún otro valor para indicar que no se ingresó un nombre
                }

            EliminarProducto( nombre );
        }


        public void EliminarProducto( string nombre)
        {
           
            if (_productos.Any(producto => producto.nombre == nombre))
            {
                Producto producto = _productos.First(producto => producto.nombre == nombre);

                _productosEliminados.Add(producto);
                _productos.Remove(producto);

                MessageBox.Show("Producto Elimnado Correctamente",
                "Exito", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("No se encontro el Producto",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void MostrarProducto(DataGridView dataGridView1)
        {
            
            if(_productos.Count == 0) 
            {
                MessageBox.Show("No hay productos registrados",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                dataGridView1.Rows.Clear();

                foreach (var producto in _productos)
                {

                    dataGridView1.Rows.Add(producto.nombre, producto.cantidad, producto.precio);
                }

                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            
            }
         
        }

        public void MostrarProductoEliminado(DataGridView dataGridView1)
        {

            if (_productosEliminados.Count == 0)
            {
                MessageBox.Show("No hay productos Eliminados",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                dataGridView1.Rows.Clear();

                foreach (var producto in _productosEliminados)
                {

                    dataGridView1.Rows.Add(producto.nombre, producto.cantidad, producto.precio);
                }

                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            }

        }

        public void EliminarCantidad(string nombre, int cantidad)
        {
            Producto producto = _productos.FirstOrDefault(p => p.nombre == nombre);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (producto.cantidad < cantidad)
            {
                MessageBox.Show("Cantidad insuficiente en stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            producto.cantidad -= cantidad;

            if (producto.cantidad == 0)
            {
                _productos.Remove(producto);
                

            }

            Producto productoEliminado = _productosEliminados.FirstOrDefault(p => p.nombre == nombre);


            if (productoEliminado == null)
            {
                productoEliminado = new Producto(nombre, cantidad, producto.precio);
                _productosEliminados.Add(productoEliminado);
            }
            else if(producto.cantidad == 0)
            {
                productoEliminado.cantidad += cantidad;
            }
            else
            {
                productoEliminado.cantidad += cantidad;
            }
           

            MessageBox.Show("Se ha hecho correctamente el retiro", "Éxito", MessageBoxButtons.OK);
        }



    }
}
