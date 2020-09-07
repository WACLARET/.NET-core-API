using System.ComponentModel.DataAnnotations;

namespace NgaoApi.Dtos
{
    public class NgaoUpdateDto{
          
           [Required]
        [MaxLength(250)] 
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
         public string platform { get; set; }
        
    }
}