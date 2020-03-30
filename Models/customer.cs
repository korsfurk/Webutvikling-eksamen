using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class customer{
        
        [Key] 
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }

    
}