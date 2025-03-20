using API_Filmes_SENAI.Domains;
using Event_Plus.Domains;
using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Domains;

namespace EventPlus.Context
{
    public class EventContext : DbContext
    {
        internal object tipoEvento;

        public EventContext() 
        {
        }

        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }
        //Ctrl + D = Duplica a linha
        public DbSet<ComentarioEvento> ComentarioEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<PresencaEvento> PresencasEventos { get; set; }
        public DbSet<TipoEvento> TiposEventos { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public object novoTipoEvento { get; internal set; }
        public object NovoTiposUsuarios { get; internal set; }
        public object TiposUsuarios { get; internal set; }
        public object TipoUsuarios { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = NOTE02-S28\\SQLEXPRESS; Database=EventPlus;User Id= sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
