namespace ProjetoEvent_.Interfaces
{
    public interface TipoEvento
    {
        List<TipoEvento> Listar();
        void Cadastrar(TipoEvento novoTipoEvento);

        void Atualizar(Guid id, TipoEvento tipoEvento);

        void Deletar(Guid id);

        TipoEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoEvento tipoEvento);



    }
}
