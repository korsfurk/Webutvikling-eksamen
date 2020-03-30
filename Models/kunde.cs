using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class kunde{
        
        [Key] 
        public int KundeId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }

    
}