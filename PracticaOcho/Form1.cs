namespace PracticaOcho
{
    public partial class Form1 : Form
    {
        Pilas pilas = new Pilas();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string numero1 = textBox1.Text.Trim();
            string numero2 = textBox2.Text.Trim();

            pilas.Add(numero1, numero2);
            pilas.Sumar(listBox1);

            textBox2.Text = "";
            textBox1.Text = "";

        }
    }
}