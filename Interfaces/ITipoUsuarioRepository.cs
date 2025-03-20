using Event_Plus.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TipoUsuario tipoUsuario);

        void Deletar(Guid id);
        List<TipoUsuario> Listar();

        void Atualizar(Guid id, TipoUsuario tipoUsuario);

        TipoUsuario BuscarPorId(Guid id);
    }
}
