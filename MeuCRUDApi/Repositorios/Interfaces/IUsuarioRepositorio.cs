using MeuCRUDApi.Models;

namespace MeuCRUDApi.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios(); //Criando uma task , pq tem que ser assincrono ??, de uma lista.
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);

        
    }
}