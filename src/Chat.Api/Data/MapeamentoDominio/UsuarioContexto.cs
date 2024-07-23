using Chat.Api.Dominio.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chat.Api.Data.MapeamentoDominio
{
    public class UsuarioContexto : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios", "chat");

            builder.HasKey(u => u.UsuarioId);

            builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p => p.NomeUsuario)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p => p.Sobrenome)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p => p.Idade)
            .IsRequired();

            builder.Property(p => p.Senha)
            .IsRequired();

            builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(255);

            builder.HasIndex(x => x.Email)
            .IsUnique();
        }
    }
}