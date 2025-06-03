using System.ComponentModel.DataAnnotations;

namespace WebAppNoite.Models
{
    public class Professor
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Disciplina { get; set; }
    }
}
