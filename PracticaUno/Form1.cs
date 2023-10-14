using PracticaUno.Servicios;

namespace PracticaUno
{
    public partial class Form1 : Form
    {

        ServiciosProducto servicios = new ServiciosProducto();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Visible = false;
            panel1.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = false;
            servicios.AgregarProducto();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = false;
            servicios.SolictarBorrar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panel1.Visible = false;
            servicios.MostrarProducto(dataGridView1);
        }

        private void btnMostrarEliminados_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panel1.Visible = false;
            servicios.MostrarProductoEliminado(dataGridView1);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.Visible = false;

        }

        private void btnEliminarCantidad_Click(object sender, EventArgs e)
        {

            string nombre = tbNombre.Text.ToLower().Trim();

            if (int.TryParse(tbCantidad.Text.Trim(), out int cantidad))
            {
                servicios.EliminarCantidad(nombre, cantidad);
                tbCantidad.Text = "";
                tbNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Valor no permitido",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCantidad.Text = "";
                tbNombre.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbCantidad.Text = "";
            tbNombre.Text = "";
            panel1.Visible = false;
            dataGridView1.Visible = false;
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}