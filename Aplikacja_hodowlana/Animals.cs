using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplikacja_hodowlana
{
    public class Animals
    {
        // Animal-specific properties and methods used in all derived classes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Species { get; set; }
        public string Humidity { get; set; }
        public AnimalsEnvironmentList Environment { get; set; }
        public ClimateList Climate { get; set; }
        public ActivityTimeList ActivityTime { get; set; }
        public DateTime DateOfLastFeeding { get; set; }
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
        public List<Group> Groups { get; set; }
        public enum ClimateList
        {
            // List of possible climates, add more when needed
           Cold, 
           Average,
           Warm,
           Hot,
        
        }   
        public enum AnimalsEnvironmentList
        {
            // List of possible environments, add more when needed 
            Desert,
            Steppes,
            Forest,
            Tropical_Forest,
            
        }
        public enum ActivityTimeList
        {
            // List of possible activity times, add more when needed
            day,
            dusk,
            night,
            
        }
    }
}
