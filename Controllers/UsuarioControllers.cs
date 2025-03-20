﻿using API_Filmes_SENAI.Domains;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEvent_.Controllers
{
    public class UsuarioControllers
    {

        [Route("api/[controller]")]
        [ApiController]
        [Produces("application/json")]
        public class UsuarioController : Controller
        {
            private readonly UsuarioController _usuarioController;
            private object _usuarioRepository;

            public UsuarioController(UsuarioController usuarioController)
            {
                _usuarioController = usuarioController;
            }

            [HttpPost]
            public IActionResult Post(Usuario usuario)
            {
                try
                {
                    object  = _usuarioController.Cadastrar(usuario);

                    return StatusCode(201, usuario);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            private object Cadastrar(Usuario usuario)
            {
                throw new NotImplementedException();
            }

            [HttpGet("{id}")]
            public IActionResult GetByid(Guid id)
            {
                try
                {
                    Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                    if (usuarioBuscado != null)
                    {
                        return Ok(usuarioBuscado);
                    }
                    return null!;
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
    }
}

