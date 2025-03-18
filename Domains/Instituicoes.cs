using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Event_Plus.Domains
{
    [Table("Instituicoes")]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Instituicoes
    {
        [Key]
        public Guid IdInstituicao { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O Cnpj do Evento é obrigatória")]
        [StringLength(14)]
        public string? CNPJ { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome da fantasia do Evento é obrigatória")]
        public string? NomeFantasia { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Endereco do Evento é obrigatória")]
        public string? Endereco { get; set; }

    }
}
