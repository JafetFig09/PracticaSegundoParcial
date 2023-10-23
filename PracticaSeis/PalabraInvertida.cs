using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSeis
{
    public class PalabraInvertida
    {
        private string _texto;
        public PalabraInvertida(string texto)
        {

           this._texto = texto;

        }

        public string RevertirPalabra()
        {
            string textoInverso = "";
            for (int i = _texto.Length - 1; i >= 0; i--)
            {
                textoInverso += _texto[i];
            }

            return textoInverso;
        }
    }
}
