namespace Chat.Api.Dominio.Usuarios
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}