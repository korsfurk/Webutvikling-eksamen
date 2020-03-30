using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class admin{
        
        [Key] 
        public int AdminId { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }

    
}