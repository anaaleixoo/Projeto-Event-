using Event_Plus.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface IEventoRepository
    {
        List<Evento> Listar();

        void Cadastrar(Evento evento);

        void Atualizar(Guid id, Evento evento);

        void Deletar(Guid id);

        List<Evento> ListarPorId(Guid id);

        Evento BuscarPorId(Guid id);
     
       List<Evento> ListarPrximosEventos(Guid id);
    }
}
