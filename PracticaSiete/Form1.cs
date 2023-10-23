namespace PracticaSiete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;
            Palindromo palindromo = new Palindromo(text);

            palindromo.EsPalindromo();
            textBox1.Text = "";
        }
    }
}