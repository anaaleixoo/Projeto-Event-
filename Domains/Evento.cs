using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoEvent_.Domains;

namespace Event_Plus.Domains
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; }
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do Evento é obrigatória")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do Evento e obrigatorio")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A Descricao do Evento e obrigatorio")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O tipo do Evento e obrigatorio")]
        public Guid IdTipoEventos { get; set; }

        [ForeignKey("IdTipoEventos")]
        public TiposEventos? TiposEventos { get; set; }


        [Required(ErrorMessage = "A instituicao e obrigatorio")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey("IdInstituicao")]
        public Instituicao? Instituicao { get; set; }


        //public PresencaEvento PresencaEvento {get; set;}

    }
}


