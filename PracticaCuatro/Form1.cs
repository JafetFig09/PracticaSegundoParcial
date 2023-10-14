using PracticaCuatro.Servicios;
using PracticaCuatro.Entidades;

namespace PracticaCuatro
{
    public partial class Form1 : Form
    {

        ProductoServicios servcio = new ProductoServicios();
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            listBox1.Visible = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            panel1.Visible = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            listBox1.Visible = false;
            panel1.Visible = false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            if (double.TryParse(tbPrecio.Text.Trim(), out double precio))
            {
                servcio.AgregarProducto(nombre, precio);
                tbNombre.Text = "";
                tbPrecio.Text = "";
            }
            else
            {
                MessageBox.Show("Valor no valido",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            listBox1.Visible = true;
            panel1.Visible = false;

            servcio.MostrarProducto(listBox1);
        }

        private void btnComprarProductos_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            listBox1.Visible = false;
            panel1.Visible = false;

            servcio.OrdenarProducto();
        }

        private void btnMostrarOrden_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            listBox1.Visible = true;
            panel1.Visible = false;

            servcio.MostrarProductoOrdenados(listBox1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            panel1.Visible = false;
            servcio.EliminarProducto();
        }
    }
}