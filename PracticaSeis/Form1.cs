namespace PracticaSeis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            PalabraInvertida palabra = new PalabraInvertida(texto);
            label3.Text = palabra.RevertirPalabra();
            textBox1.Text = "";
        }
    }
}