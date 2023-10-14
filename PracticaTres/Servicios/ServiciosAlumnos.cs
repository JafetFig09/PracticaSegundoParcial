using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaTres.Entidades;

namespace PracticaTres.Servicios
{
    public class ServiciosAlumnos
    {
         private List<Alumno> _alumnoList;
         private List<Alumno> _reprobados;
         private List<Alumno> _aprobados;


       

        public ServiciosAlumnos()
        {

            _alumnoList = new List<Alumno>()
            {
                new Alumno("Jaime", 8.9),
                new Alumno("Luisa", 8),
                new Alumno("Jose", 7.7),
                new Alumno("Maria", 7.9),
            
            };

            _aprobados = new List<Alumno>();
            _reprobados = new List<Alumno>();
        }

   

        public void SolicitarAlumno( string nombre , double calificacion)
        {
            Alumno alumno = new Alumno(nombre, calificacion);
            AgregarAlumno(alumno);
            
        }


        public void AgregarAlumno( Alumno alumno )
        {
            if(_alumnoList.Any(a => a.nombre == alumno.nombre))
            {
                MessageBox.Show("El alumno ya sido registrado","Advertencia",MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Alumno Agregado con exito", "Exito", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information);
                _alumnoList.Add(alumno);
            }
           
        }

        public void SepararLista()
        {
            _aprobados.Clear(); // Limpia la lista antes de agregar alumnos
            _reprobados.Clear();

            foreach (Alumno alumno in _alumnoList)
            {
                if (alumno.calificacion > 7)
                {
                    if (!_aprobados.Contains(alumno)) // Verifica si ya está en la lista
                    {
                        _aprobados.Add(alumno);
                    }
                }
                else
                {
                    if (!_reprobados.Contains(alumno)) // Verifica si ya está en la lista
                    {
                        _reprobados.Add(alumno);
                    }
                }
            }
        }


        public void MostrarLista(ListBox list)
        {
            SepararLista(); 
            OrdenarPorPropiedad(_alumnoList, alumno => alumno.nombre);

            if (_alumnoList.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene alumnos",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            list.Items.Clear();
            foreach (var item in _alumnoList)
            {
                list.Items.Add(item);
            }
        }


       

        public void MostrarAprovados(ListBox list)
        {
            OrdenarPorPropiedad(_aprobados, alumno => alumno.nombre);
            if (_aprobados.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene alumnos",
               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            list.Items.Clear();
            foreach (var item in _aprobados)
            {
                list.Items.Add(item);
            }
        }

        public void MostrarReprobados(ListBox list)
        {
            OrdenarPorPropiedad(_reprobados, alumno => alumno.nombre);
            if (_reprobados.Count == 0)
            {
                MessageBox.Show("La lista aún no tiene alumnos",
               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            list.Items.Clear();
            foreach (var item in _reprobados)
            {
                list.Items.Add(item);
            }
        }
        public void OrdenarPorPropiedad<T, TKey>(List<T> lista, Func<T, TKey> selector)
        {
            int n = lista.Count;
            bool intercambio;
            do
            {
                intercambio = false;
                for (int i = 1; i < n; i++)
                {
                    if (Comparer<TKey>.Default.Compare(selector(lista[i - 1]), selector(lista[i])) > 0)
                    {
                        T temp = lista[i - 1];
                        lista[i - 1] = lista[i];
                        lista[i] = temp;
                        intercambio = true;
                    }
                }
                n--;
            } while (intercambio);
        }


        //public void MostrarOrdenados( ListBox listBox)
        //{
        //    OrdenarPorPropiedad(_alumnoList, alumno => alumno.nombre);

        //    foreach (var item in _alumnoList)
        //    {
        //        listBox.Items.Add(item);
        //    }
        //}
    }

}
