using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class menu{
        
        [Key] 
        public int FoodId { get; set; }
        
        public int DrinkId { get; set; }

    }

    
}