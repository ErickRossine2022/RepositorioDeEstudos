namespace MeuProjeto.Application.Services
{
    /// <summary>
    /// Serviço de aplicação para lógica de negócio de usuários.
    /// Coordena Domain e Infrastructure.
    /// </summary>
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponseDto> CreateUserAsync(CreateUserDto dto)
        {
            // Validar
            if (string.IsNullOrEmpty(dto.Email) || !dto.Email.Contains("@"))
                throw new ArgumentException("Email inválido");

            // Criar entidade
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = HashPassword(dto.Password)
            };

            if (!user.IsValid())
                throw new InvalidOperationException("Usuário inválido");

            // Persistir
            await _userRepository.AddAsync(user);

            // Retornar DTO
            return new UserResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                CreatedAt = user.CreatedAt
            };
        }

        public async Task<UserResponseDto> GetUserAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("Usuário não encontrado");

            return new UserResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                CreatedAt = user.CreatedAt
            };
        }

        private string HashPassword(string password)
        {
            // Aqui você colocaria a lógica de hash real
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}
