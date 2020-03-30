using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class restaurant{
        
        [Key] 
        public int Id { get; set; }
        public int KundeId { get; set; }

        public int AdminId { get; set; }

        public string PizzaNavn { get; set; }

        public string PizzaPris { get; set; }

        public string DrikkeNavn { get; set; }

        public string DrikkePris { get; set; }

    }

    
}