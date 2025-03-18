using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_Filmes_SENAI.Domains;
using Event_Plus.Domains;
using Newtonsoft.Json;

[Table("Presenca")]
public class PresencaEvento
{
    [Key]
    public Guid IdPresencaEvento { get; set; }

    [Column(TypeName = "BIT")]
    public bool? Situacao { get; set; }


    [Required(ErrorMessage = "O usuario é obrigatório")]
    public Guid UsuarioID { get; set; }

    [ForeignKey("UsuarioID")]
    public Usuario? Usuario { get; set; }


    [Required(ErrorMessage = "O evento é obrigatório")]
    public Guid EventosID { get; set; }

    [ForeignKey("EventosID")]
    public Evento? Eventos { get; set; }
}