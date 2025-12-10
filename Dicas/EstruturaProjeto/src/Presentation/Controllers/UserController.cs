namespace MeuProjeto.Presentation.Controllers
{
    /// <summary>
    /// Controller (API) - Ponto de entrada da aplicação.
    /// Recebe requisições HTTP e delega para os Services.
    /// </summary>
    public class UserController
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<UserResponseDto> CreateUser(CreateUserDto dto)
        {
            return await _userService.CreateUserAsync(dto);
        }

        public async Task<UserResponseDto> GetUser(int id)
        {
            return await _userService.GetUserAsync(id);
        }
    }
}
