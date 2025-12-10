namespace MeuProjeto.Domain.Interfaces
{
    /// <summary>
    /// Interface que define o contrato para operações com usuários.
    /// Abstração: não importa como é implementado, apenas o que faz.
    /// </summary>
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
