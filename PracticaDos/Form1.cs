

namespace PracticaDos
{

    public partial class Form1 : Form
    {

        ListaAleatoria list = new ListaAleatoria();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            list.VaciarLista();
            if (int.TryParse(tbSize.Text.Trim(), out int size))
            {
                list.LLenarLista(size);

                tbSize.Text = "";

            }
            else
            {
                tbSize.Text = "";
                return;
            }

        }

        private void btnListaPar_Click(object sender, EventArgs e)
        {
            list.MostrarListaPar(listBox2);
        }

        private void btnListaImpar_Click(object sender, EventArgs e)
        {
            list.MostrarListaImpar(listBox2);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            list.MostrarLista(listBox2);
        }
    }
}