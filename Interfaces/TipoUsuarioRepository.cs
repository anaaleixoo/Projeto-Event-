namespace ProjetoEvent_.Interfaces
{
    public class TipoUsuario
    {
        void Cadastrar(TipoUsuario tipoUsuario);

        void Deletar(Guid id, TipoUsuario tipoUsuario);
        List<TipoUsuario> Listar();

        void Atualizar(Guid id);

        TipoUsuario BuscarPorId(Guid id);
    }
}
