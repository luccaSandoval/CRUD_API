using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MeuCRUDApi.Models;
using MeuCRUDApi.Repositorios.Interfaces;

namespace MeuCRUDApi.Controllers;

[Route("api/[controller]")] //rota da api
[ApiController]

public class UsuarioController : ControllerBase
{

    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
    {
        List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
        return Ok(usuarios);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult <UsuarioModel>> BuscarPorId(int id)
    {
        UsuarioModel usuario = await _usuarioRepositorio.BuscarPorId(id);
        return Ok(usuario);
    }

    [HttpPost]
    public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
    {
        UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);

        return Ok(usuario);
    } 

    [HttpPut("{id}")]
    public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel,int id)
    {
        usuarioModel.Id = id;
        UsuarioModel usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);

        return Ok(usuario);
    } 

    [HttpDelete("{id}")]
    public async Task<ActionResult<UsuarioModel>> Apagar(int id)
    {
    
        bool apagado = await _usuarioRepositorio.Apagar(id);

        return Ok(apagado);
    } 

}