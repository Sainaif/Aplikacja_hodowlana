using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_hodowlana
{
    public class Reptiles : Animals
    {
        // Reptile-specific properties and methods
        public string Morph { get; set; }
        public double Lenght { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfLastShedding { get; set; }

        // Create usage

    }

}
