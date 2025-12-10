namespace MeuProjeto.Infrastructure.Repositories
{
    /// <summary>
    /// Implementação do repositório para acesso a dados de usuários.
    /// Aqui fica a lógica de persistência (banco de dados, cache, etc).
    /// </summary>
    public class UserRepository : IUserRepository
    {
        // Simulando banco de dados em memória
        private static List<User> _users = new();

        public Task<User> GetByIdAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            return Task.FromResult(user);
        }

        public Task<List<User>> GetAllAsync()
        {
            return Task.FromResult(_users);
        }

        public Task AddAsync(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
                _users.Remove(user);
            return Task.CompletedTask;
        }
    }
}
