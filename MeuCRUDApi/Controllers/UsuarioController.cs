using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MeuCRUDApi.Models;

namespace MeuCRUDApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsuarioController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
    {
        return Ok();
    }
}