using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class restaurant{
        
        [Key] 
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public int AdminId { get; set; }

        public string PizzaName { get; set; }

        public string PizzaPrice { get; set; }

        public string DrinkName { get; set; }

        public string DrinkPrice { get; set; }

    }

    
}