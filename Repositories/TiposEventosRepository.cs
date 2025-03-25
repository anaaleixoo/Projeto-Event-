using Event_Plus.Domains;
using EventPlus.Context;
using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Interfaces;

namespace EventPlus_.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventContext _Context;
        public TipoEventoRepository(EventContext context)
        {
            _Context = context;
        }

        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            try
            {
                TipoEvento tipoEventobuscado = _Context.TiposEventos.Find(id)!;
                if (tipoEventobuscado != null)
                {
                    tipoEventobuscado.TituloTipoEvento = tipoEvento.ituloTipoEvento;
                }
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                TipoEvento tipoEventoBuscado = _Context.TiposEventos.Find(id)!;
                return tipoEventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoEvento novoTipoEvento)
        {
            try
            {
                _Context.TiposEventos.Add(novoTipoEvento);

                _Context.SaveChanges();
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
                TipoEvento tipoEventoBuscado = _Context.TiposEventos.Find(id); 

                if(tipoEventoBuscado != null)
                {
                    _Context.TiposEventos.Remove(tipoEventoBuscado);
                }
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEvento> Listar()
        {
            try
            {
                List<TipoEvento> listaDeEventos = _Context.TiposEventos.ToList(); 
                return listaDeEventos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
