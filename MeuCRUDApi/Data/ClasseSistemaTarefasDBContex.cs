using MeuCRUDApi.Models;
using Microsoft.EntityFrameworkCore;

//Criando o contexto do DB
namespace MeuCRUDApi.Data
{
    public class SistemaTarefasDBContex : DbContext
{
    public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) //extraindo esse contexto para a variavel "options"
        : base(options)
    {

    }

    public DbSet <UsuarioModel> Usuarios {get; set;} //UsuarioModel representa uma tabela no banco de dados com o nome Usuarios
    public DbSet <TarefaModel> Tarefas {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }


}
}
