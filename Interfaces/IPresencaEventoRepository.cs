namespace ProjetoEvent_.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void Deletar(Guid id);

        PresencaEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, PresencaEvento presenca);

        List<PresencaEvento> Listar();

        List<PresencaEvento> ListarMinhasPresencas(Guid id);

        void Inscrever(PresencaEvento inscreverPresenca);

    }
}
