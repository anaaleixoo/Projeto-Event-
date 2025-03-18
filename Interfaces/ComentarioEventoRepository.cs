﻿using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface ComentarioEventoRepository
    {
        void Cadastrar(ComentarioEvento comentarioEvento);

        void Deletar(Guid idComentario);

        List<ComentarioEvento> Listar(Guid idComentario);

        ComentarioEvento BuscarPorIdUsuario(Guid UsuarioID, Guid EventosID);
    }
}

 
