using PracticaTres.Entidades;
using PracticaTres.Servicios;

namespace PracticaTres
{
    public partial class Form1 : Form
    {
        ServiciosAlumnos servicios = new ServiciosAlumnos();
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            listBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            listBox1.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbCalificacion.Text = "";

            panel1.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            if (double.TryParse(tbCalificacion.Text.Trim(), out double calificacion))
            {
                if(calificacion <= 10)
                {
                    Alumno alumno = new Alumno(nombre, calificacion);
                    servicios.AgregarAlumno(alumno);
                    tbCalificacion.Text = "";
                    tbNombre.Text = "";

                }
                else
                {
                    MessageBox.Show("La calificacion debe ser de 0-10",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCalificacion.Text = "";
                    tbNombre.Text = "";
                }
            
            }
            else
            {
                MessageBox.Show("Valor no permitido",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCalificacion.Text = "";
                tbNombre.Text = "";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            listBox1.Visible = true;
            servicios.MostrarLista(listBox1);
        }

        private void btnAlumnosAprobados_Click(object sender, EventArgs e)
        {
            servicios.MostrarAprovados(listBox1);
        }

        private void btnAlumnosReprobados_Click(object sender, EventArgs e)
        {
            servicios.MostrarReprobados(listBox1);
        }
    }
}