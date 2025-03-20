using Event_Plus.Domains;
using EventPlus.Context;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Repositories
{
    public class TiposUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EventContext _context;

        public TiposUsuarioRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {

            TipoUsuario tiposUsuarioBuscado = _context.TipoUsuario.Find(id)!;

            if (tiposUsuarioBuscado != null)
            {
                tiposUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;

                _context.SaveChanges();
            }
        }

        public TipoUsuario BuscarPorId(Guid id)
        {

            TipoUsuario tiposUsuarioBuscado = _context.TipoUsuario.Find(id)!;
            return tiposUsuarioBuscado;
        }

        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                _context.TipoUsuario.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {

            try
            {
                TipoUsuario tiposUsuario = _context.TipoUsuario.Find(id)!;

                if (tiposUsuario != null)
                {
                    _context.TipoUsuario.Remove(tiposUsuario);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoUsuario> Listar()
        {
            try
            {
                List<TipoUsuario> listaDeUsuarios = _context.TipoUsuario.ToList();
                return listaDeUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
