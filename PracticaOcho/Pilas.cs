using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOcho
{
    public class Pilas
    {
        public Stack<int> pila1  { get; set; }
        public Stack<int> pila2  { get; set; }

        public Stack<int> resultado { get; set; }

        private int suma = 0;

        private int acarreo = 0;

        public Pilas()
        {
            pila1 = new Stack<int>();
            pila2 = new Stack<int>();
            resultado = new Stack<int>();
        }


        public void Add( string numero1 , string numero2 )
        {
            for ( int i = 0;i<numero1.Length;i++ ) 
            {
                //Verifca que en la posicion se encuentre un numero
                if (char.IsDigit(numero1[i]))
                {
                    pila1.Push((int)numero1[i]-'0');
                }
                else 
                {
                    MessageBox.Show("Valor no permitido","Error");
                    return;
                }
            
            }

            for (int i = 0; i < numero2.Length; i++)
            {
                //Verifca que en la posicion se encuentre un numero
                if (char.IsDigit(numero2[i]))
                {
                    pila2.Push((int)numero2[i]-'0');
                }
                else
                {
                    MessageBox.Show("Valor no permitido", "Error");
                    return;
                }

            }
        }



     

        public void Sumar( ListBox listbox)
        {
            listbox.Items.Clear();
            while (pila1.Count > 0 || pila2.Count > 0 || acarreo > 0)
            {
                int digito1 = pila1.Count > 0 ? pila1.Pop() : 0;
                int digito2 = pila2.Count > 0 ? pila2.Pop() : 0;

                int suma = digito1 + digito2 + acarreo;
                acarreo = suma / 10;
                resultado.Push(suma % 10);

                listbox.Items.Add($"{digito1} + {digito2}  = {suma % 10}");
            }

            string resultadoFinal = "";
            while (resultado.Count > 0)
            {
                resultadoFinal = resultado.Pop() + resultadoFinal;
            }

            resultadoFinal = RevertirCadena(resultadoFinal);
            listbox.Items.Add("Resultado: " + resultadoFinal);
        }


        public string RevertirCadena( string text)
        {
            string reverse = "";
            for ( int i = text.Length - 1; i >= 0 ; i--)
            {
                reverse += text[i];
            }

            return reverse;
        }
    }
}
