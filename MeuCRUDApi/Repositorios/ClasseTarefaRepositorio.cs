using MeuCRUDApi.Models;
using MeuCRUDApi.Repositorios.Interfaces;
using MeuCRUDApi.Data;
using Microsoft.EntityFrameworkCore;


namespace MeuCRUDApi.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaTarefasDBContex _dbContext;
        public TarefaRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas
            .Include(x => x.Usuario)
            .FirstOrDefaultAsync(x => x.Id == id);
        }
        
        public async Task<List<TarefaModel>> BuscarTodasTarefas()
        {
            return await _dbContext.Tarefas
            .Include(x => x.Usuario)
            .ToListAsync();
        }

        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            await _dbContext.Tarefas.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<bool> Apagar(int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            
            if(tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Tarefas.Remove(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            
            if(tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados.");
            }

            tarefaPorId.Nome = tarefa.Nome;    //Se não cair na exceção , vai substituir no usuario que foi achado no banco(usuarioPorId) o nome e/ou o emai que foi mandado para a função
            tarefaPorId.Descricao = tarefa.Descricao;
            tarefaPorId.Status = tarefa.Status;
            tarefaPorId.UsuarioID = tarefa.UsuarioID;

            _dbContext.Tarefas.Update(tarefaPorId); //atualizando no banco
            await _dbContext.SaveChangesAsync();

            return tarefaPorId;


        }


    }


}