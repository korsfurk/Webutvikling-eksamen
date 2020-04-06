using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class drink{
        
        [Key] 
        public int DrinkId { get; set; }

        public string DrinkName { get; set; }

        public string DrinkPrice { get; set; }

    }

    
}