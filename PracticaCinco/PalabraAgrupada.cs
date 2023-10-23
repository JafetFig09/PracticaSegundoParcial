using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCinco
{
    public class PalabraAgrupada
    {
        public char FirstLetter { get; set; }
        public List<string> Words { get; set; }

        public PalabraAgrupada( char FirstLetter)
        {   
            this.FirstLetter = FirstLetter;
            Words = new List<string>();
        }
    }
}
