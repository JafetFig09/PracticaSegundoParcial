using System.Security.Cryptography;

namespace PracticaCinco
{
    public partial class Form1 : Form
    {
        List<PalabraAgrupada> wordGroups = new List<PalabraAgrupada>();
        public Form1()
        {
            InitializeComponent();
        }





        private void AgruparPalabra(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra))
            {
                return; // Finaliza el bucle si se presiona Enter.
            }

            char primeraLetra = palabra[0];
            PalabraAgrupada grupoExistente = wordGroups.Find(group => group.FirstLetter == primeraLetra);

            if (grupoExistente != null)
            {
                grupoExistente.Words.Add(palabra);
            }
            else
            {
                PalabraAgrupada nuevoGrupo = new PalabraAgrupada(primeraLetra);
                nuevoGrupo.Words.Add(palabra);
                wordGroups.Add(nuevoGrupo);
            }
        }

        private void MostrarPalabras()
        {


            foreach (var palabra in wordGroups)
            {
                palabra.Words.Sort();
            }

            wordGroups.Sort((a, b) => a.FirstLetter.CompareTo(b.FirstLetter));

            foreach (var palabra in wordGroups)
            {
                
                listBox1.Items.Add($"---- {palabra.FirstLetter} ----");
                foreach (var item in palabra.Words)
                {
                   listBox1.Items.Add(item);
                }
                
            }
        }
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                string palabra = textBox1.Text.Trim();

                AgruparPalabra(palabra);

                textBox1.Text = "";
            }

            private void btnMostrar_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                MostrarPalabras();
            }


    }
    
}