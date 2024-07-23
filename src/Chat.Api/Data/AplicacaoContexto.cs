using Chat.Api.Data.MapeamentoDominio;
using Chat.Api.Dominio.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace Chat.Api.Data
{
    public class AplicacaoContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public AplicacaoContexto(DbContextOptions<AplicacaoContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioContexto());
        }
    }
}