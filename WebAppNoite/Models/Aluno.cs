using System.ComponentModel.DataAnnotations;

namespace WebAppNoite.Models
{
    public class Aluno
    {
    
      
     [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]

        public string Nome { get; set; }

        [Required]
        [StringLength(70)]
        public string Email { get; set; }
         
    }
}
