using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_hodowlana
{
    public class Food
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Size { get; set; }
        public FoodTypeList FoodType { get; set; }
        public int FeedingInterval { get; set; }
        public enum FoodTypeList
        {
           
            Rat,
            Mouse,
            Crickets,
            Locust,
        }
      
        public string GetFoodSize(FoodTypeList foodType)
        {
            switch (foodType)
            {
                case FoodTypeList.Rat:
                    return "Large";
                case FoodTypeList.Mouse:
                    return "Small";
                case FoodTypeList.Crickets:
                    return "Tiny";
                case FoodTypeList.Locust:
                    return "Medium";
                
                default:
                    return "Unknown";
            }
        }
       
    }
}
