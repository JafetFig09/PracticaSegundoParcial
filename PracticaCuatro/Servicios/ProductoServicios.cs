using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaCuatro.Entidades;

namespace PracticaCuatro.Servicios
{
    public class ProductoServicios
    {

        private List<Producto> _productos;

        private List<Producto> _productosOrdenados;

        public ProductoServicios()
        {
            _productos = new List<Producto>();
            _productosOrdenados = new List<Producto>();
        }


        public void AgregarProducto(string nombre, double precio)
        {
            Producto producto = new Producto(nombre, precio);
            if(_productos.Any(p => p.nombre == producto.nombre))
            {


                MessageBox.Show("El producto ya ha sido agregado anteriormente", 
                    "Error", MessageBoxButtons.OK);

                return;

            }
            if (producto != null)
            {
                _productos.Add(producto);

                MessageBox.Show("Producto Agregado Correctamente", "Éxito", MessageBoxButtons.OK);
            }
        }


        public void EliminarProducto()
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Id del producto que desea " +
                "eliminar: ");
            if (int.TryParse(nombre, out int id))
            {
                if (_productos.Any(producto => producto.id == id))
                {
                    Producto producto = _productos.First(producto => producto.id == id);


                    _productos.Remove(producto);

                    MessageBox.Show("Produco Elimnado Correctamente",
                    "Exito", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("No se encontro el Producto",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Valor no valido",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void OrdenarProducto()
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Id del producto " +
                "que desea " +
                "ordenar: ");
            if (int.TryParse(nombre, out int id))
            {
                if (_productos.Any(producto => producto.id == id))
                {
                    Producto producto = _productos.First(producto => producto.id == id);


                    _productosOrdenados.Add(producto);

                }

                else
                {
                    MessageBox.Show("No se encontro el Producto",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Valor no valido",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void MostrarProducto(ListBox listBox)
        {
            OrdenarPorPropiedad(_productos, producto => producto.nombre);

            if (_productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                listBox.Items.Clear();

                foreach (var producto in _productos)
                {

                    listBox.Items.Add(producto);
                }

              

            }

        }

        public void MostrarProductoOrdenados(ListBox listBox)
        {
            OrdenarPorPropiedad(_productosOrdenados, producto => producto.nombre);

            if (_productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                listBox.Items.Clear();

                foreach (var producto in _productosOrdenados)
                {

                    listBox.Items.Add(producto);
                }

                CalcularPrecio(listBox);


            }

        }


        public void CalcularPrecio(ListBox listBox)
        {
            if (_productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
              
                double valorTotal = 0;
                foreach (var producto in _productosOrdenados)
                {

                    valorTotal += producto.precio;
                }


                listBox.Items.Add($"El Valor total de la compra es: {valorTotal}");
            }

        }
        public void OrdenarPorPropiedad<T, TKey>(List<T> lista, Func<T, TKey> selector)
        {
            int n = lista.Count;
            bool intercambio;
            do
            {
                intercambio = false;
                for (int i = 1; i < n; i++)
                {
                    if (Comparer<TKey>.Default.Compare(selector(lista[i - 1]), selector(lista[i])) > 0)
                    {
                        T temp = lista[i - 1];
                        lista[i - 1] = lista[i];
                        lista[i] = temp;
                        intercambio = true;
                    }
                }
                n--;
            } while (intercambio);
        }
    }
}
