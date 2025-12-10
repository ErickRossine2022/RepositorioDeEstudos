namespace MeuProjeto.Tests.Unit
{
    /// <summary>
    /// Testes unitários para o UserService.
    /// Testam a lógica de negócio isoladamente.
    /// </summary>
    public class UserServiceTests
    {
        [Fact]
        public async Task CreateUser_WithValidData_ReturnsUserDto()
        {
            // Arrange (Preparar)
            var mockRepository = new Mock<IUserRepository>();
            var service = new UserService(mockRepository.Object);
            var dto = new CreateUserDto 
            { 
                Name = "João", 
                Email = "joao@example.com", 
                Password = "123456" 
            };

            // Act (Agir)
            var result = await service.CreateUserAsync(dto);

            // Assert (Verificar)
            Assert.NotNull(result);
            Assert.Equal("João", result.Name);
            Assert.Equal("joao@example.com", result.Email);
        }

        [Fact]
        public async Task CreateUser_WithInvalidEmail_ThrowsException()
        {
            // Arrange
            var mockRepository = new Mock<IUserRepository>();
            var service = new UserService(mockRepository.Object);
            var dto = new CreateUserDto 
            { 
                Name = "João", 
                Email = "email-invalido", 
                Password = "123456" 
            };

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() => service.CreateUserAsync(dto));
        }
    }
}
