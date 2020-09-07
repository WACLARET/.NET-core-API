using System.ComponentModel.DataAnnotations;

namespace NgaoApi.Models
{
    public class ngao{
        public int id{ get; set;}


        [Required]
        [MaxLength(250)]        
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string platform { get; set; }
    }
}