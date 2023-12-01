using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_hodowlana
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Species { get; set; }
        public string Environment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
