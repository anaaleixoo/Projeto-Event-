namespace ProjetoEvent_.Interfaces
{
    public interface Evento
    {
        List<Evento> Listar();

        void Cadastrar(Evento evento);

        void Atualizar(Guid id, Evento evento);

        void Deletar(Guid id);

        List<Evento> ListarPorId(Guid id);

        Evento BuscarPorId(Guid id);


            
            > ListarProximosEventos(Guid id);
    }
}
