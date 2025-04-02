using MeuCRUDApi.Models;
using MeuCRUDApi.Repositorios.Interfaces;
using MeuCRUDApi.Data;
using Microsoft.EntityFrameworkCore;


namespace MeuCRUDApi.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContex _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
        
        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            
            if(usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            
            if(usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;    //Se não cair na exceção , vai substituir no usuario que foi achado no banco(usuarioPorId) o nome e/ou o emai que foi mandado para a função
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId); //atualizando no banco
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;


        }


    }


}