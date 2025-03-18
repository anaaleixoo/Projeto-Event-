namespace ProjetoEvent_.Interfaces
{
    public interface Usuario
    {
        void Cadastrar(Usuario novoUsuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(string email, string senha);

    }
}
