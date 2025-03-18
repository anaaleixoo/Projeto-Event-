using API_Filmes_SENAI.Domains;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Event_Plus.Domains;

namespace ProjetoEvent_.Domains
{
        [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
       
            [Key]
            public Guid IdComentarioEvento { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "a descrição do evento é obrigatorio")]
            public string? Descricao { get; set; }


            [Column(TypeName = "BIT")]
            [Required(ErrorMessage = "O que exibe é obrigatório")]
            public bool? Exibe { get; set; }


            [Required(ErrorMessage = "O  usuario e obrigatorio")]
            public Guid IdUsuario { get; set; }

            [ForeignKey("IdUsuario")]
            public Usuario? Usuario { get; set; }


            [Required(ErrorMessage = "evento obrigatorio")]
            public Guid IdEvento { get; set; }

            [ForeignKey("IdEvento")]
            public Evento? Evento { get; set; }
        }
    
}
