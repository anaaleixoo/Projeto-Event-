using EventPlus.Context;
using ProjetoEvent_.Interfaces;

namespace EventPlus_.Repositories
{
    public class PresencasRepository : IPresencaEventoRepository
    {
        private readonly EventContext _context;

        public PresencasRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, PresencaEvento presenca)
        {
            try
            {
                PresencaEvento presencaBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaBuscado != null)
                {
                    presencaBuscado.Situacao = presenca.Situacao;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            try
            {
                PresencaEvento presencaBuscado = _context.PresencasEventos.Find(id)!;
                return presencaBuscado;
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
                PresencaEvento presencaBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaBuscado != null)
                {
                    _context.PresencasEventos.Remove(presencaBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inscrever(PresencaEvento inscreverPresenca)
        {
            try
            {
                _context.PresencasEventos.Add(inscreverPresenca);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEvento> Listar()
        {
            try
            {
                List<PresencaEvento> listaPresenca = _context.PresencasEventos.ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEvento> ListarMinhasPresencas(Guid id)
        {
            try
            {
                List<PresencaEvento> listaPresenca = _context.PresencasEventos.Where(p => p.UsuarioID == id).ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}