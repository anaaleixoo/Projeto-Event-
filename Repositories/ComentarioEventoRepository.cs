using EventPlus.Context;
using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace EventPlus_.Repositories
{
    public class ComentarioEventoRepository : IComentarioEventoRepository
    {
        private readonly EventContext _context;

        public ComentarioEventoRepository(EventContext context)
        {
            _context = context;
        }
        public ComentarioEvento BuscarPorIdUsuario(Guid UsuarioID, Guid EventosID)
        {
            try
            {
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEventos.Find(UsuarioID, EventosID)!;
                return comentarioEventoBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {
            try
            {
                _context.ComentarioEventos.Add(comentarioEvento);
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
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEventos.Find(id)!;
                if (comentarioEventoBuscado != null)
                {
                    _context.ComentarioEventos.Remove(comentarioEventoBuscado);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ComentarioEvento> Listar()
        {
            try
            {
                List<ComentarioEvento> listaComentarioEvento = _context.ComentarioEventos.ToList();
                return listaComentarioEvento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        List<ComentarioEvento> IComentarioEventoRepository.Listar(Guid id)
        {
            List<ComentarioEvento> listaComentarioEvento = _context.ComentarioEventos.ToList();
            return listaComentarioEvento;
        }
    }
}