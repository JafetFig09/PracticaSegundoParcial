using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace PracticaDos
{
    public class ListaAleatoria
    {
        private List<int> _listAleatoria;
        private List<int> _listPares;
        private List<int> _listImpares;

        Random aleatorio = new Random();

        public ListaAleatoria()
        {
            _listImpares = new List<int>();
            _listPares = new List<int>();
            _listAleatoria = new List<int>();
           

        }

        public void LLenarLista(int tamanio)
        {
            for (int i = 0; i < tamanio; i++)
            {
                _listAleatoria.Add(aleatorio.Next(1, 201));
            }


        }


        public void SepararLista()
        {

            foreach (int i in _listAleatoria)
            {
                if (i % 2 == 0)
                {
                    _listPares.Add(i);
                }
                else
                {
                    _listImpares.Add(i);
                }
            }



        }
        public void VaciarLista()
        {
            _listAleatoria.Clear();
            _listImpares.Clear();
            _listPares.Clear();
        }

        public void MostrarLista(ListBox list)
        {
            if (_listAleatoria.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene números",
               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            list.Items.Clear();
            foreach (var item in _listAleatoria)
            {
                list.Items.Add(item);
            }
            SepararLista();
        }

        public void MostrarListaPar(ListBox list)
        {
            if (_listPares.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene números",
               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            list.Items.Clear();
            foreach (var item in _listPares)
            {
                list.Items.Add(item);
            }
        }

        public void MostrarListaImpar(ListBox list)
        {
            if (_listImpares.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene números",
               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            list.Items.Clear();
            foreach (var item in _listImpares)
            {
                list.Items.Add(item);
            }
        }


    }
}