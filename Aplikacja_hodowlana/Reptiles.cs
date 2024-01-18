using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_hodowlana
{
    public class Reptiles : Animals
    {
        
        public string Morph { get; set; }
        public double Lenght { get; set; }
        public double Weight { get; set; }
        public bool Supplements { get; set; }
        public DateTime DateOfLastShedding { get; set; }

        

    }

}
