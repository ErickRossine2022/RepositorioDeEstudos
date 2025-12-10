namespace MeuProjeto.Application.DTOs
{
    /// <summary>
    /// DTO (Data Transfer Object) para transferir dados de usuário
    /// entre camadas (API -> Service -> Repository)
    /// </summary>
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
