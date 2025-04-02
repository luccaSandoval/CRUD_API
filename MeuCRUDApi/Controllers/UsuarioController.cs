using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MeuCRUDApi.Models;

namespace MeuCRUDApi.Controllers;

[Route("api/[controller]")] //rota da api
[ApiController]

public class UsuarioController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
    {
        return Ok();
    }
}