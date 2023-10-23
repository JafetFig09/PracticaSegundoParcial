using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSiete
{
    public class Palindromo
    {
        private string texto { get; set; }

        public Palindromo(string texto)
        {

            this.texto = texto.Replace(" ","").ToLower();

        }


        public string RevertirPalabra()
        {
            string textoInverso = "";
            for (int i = texto.Length -1 ; i >= 0; i--)
            {
                textoInverso += texto[i];
            }

            return textoInverso;
        }

        public void EsPalindromo()
        {
            string text = RevertirPalabra();

            if(text == texto)
            {
                MessageBox.Show("Es palindromo", "Correcto", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No es palindromo", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
