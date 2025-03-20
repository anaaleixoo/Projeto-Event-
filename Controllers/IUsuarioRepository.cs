using API_Filmes_SENAI.Domains;

namespace ProjetoEvent_.Controllers
{
    internal interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
    }
}