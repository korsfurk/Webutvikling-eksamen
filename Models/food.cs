using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class food{
        
        [Key] 
        public int FoodId { get; set; }
        public string PizzaName { get; set; }

        public string PizzaPrice { get; set; }

        public string PizzaDescription { get; set; }

        public string PizzaLabel { get; set; }

        public string PizzaImageSrc { get; set; }

    }

    
}