namespace MeuProjeto.Domain.Models
{
    /// <summary>
    /// Entidade de domínio representando um Usuário.
    /// Esta classe contém apenas a lógica de negócio relacionada a usuários.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        public User()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Valida se o usuário tem dados corretos
        /// </summary>
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && 
                   !string.IsNullOrEmpty(Email) && 
                   Email.Contains("@");
        }
    }
}
