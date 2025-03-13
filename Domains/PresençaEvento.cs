using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ProjetoEvent_.Domains
{
    public class PresençaEvento
    {
        [Table(PresençaEvento)]



        [Key]

        public Guid IdPresençaEvento { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Usuario obrigatorio!")]
    }
}
