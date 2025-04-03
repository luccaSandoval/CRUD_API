using Microsoft.EntityFrameworkCore;
using MeuCRUDApi.Models;

namespace MeuCRUDApi.Data.Map
{

    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); //IsRequired= precisa de um nome para criar;; HasMaxLenght = tamanho maximo que o nome pode ter.
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
        }
    }

}