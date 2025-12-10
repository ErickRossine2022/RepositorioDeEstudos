# 📐 Estrutura de Projeto .NET/C# - Guia Completo

Este diretório contém um exemplo de estrutura profissional de projeto .NET C#, seguindo **clean architecture** e **boas práticas** da indústria.

## 🏗️ Visualização da Estrutura

```
MeuProjeto/
│
├── src/
│   ├── Domain/                    # Camada de Domínio (Núcleo)
│   │   ├── Models/               # Entidades de negócio
│   │   │   └── User.cs
│   │   └── Interfaces/           # Contratos (abstrações)
│   │       └── IUserRepository.cs
│   │
│   ├── Application/              # Camada de Aplicação
│   │   ├── Services/             # Lógica de negócio
│   │   │   └── UserService.cs
│   │   └── DTOs/                 # Transferência de dados
│   │       └── UserDto.cs
│   │
│   ├── Infrastructure/           # Camada de Infraestrutura
│   │   ├── Data/                 # Banco de dados, migrations
│   │   └── Repositories/         # Implementações de repositórios
│   │       └── UserRepository.cs
│   │
│   └── Presentation/             # Camada de Apresentação
│       ├── Controllers/          # API endpoints (Web API)
│       │   └── UserController.cs
│       └── Program.cs            # Configuração da aplicação
│
├── tests/
│   ├── Unit/                     # Testes unitários
│   │   └── UserServiceTests.cs
│   └── Integration/              # Testes de integração
│
├── .gitignore
├── README.md
└── MeuProjeto.sln
```

---

## 🎯 O que cada Camada Faz?

### 🔴 Domain (Domínio)
**"O coração da aplicação"**

- **Responsabilidade:** Lógica de negócio pura
- **Contém:** Entidades, interfaces, regras de negócio
- **Exemplo:** Validar se um email é válido, se uma senha é forte
- **Não depende de:** Banco de dados, Web API, frameworks externos
- **Arquivos:** `User.cs`, `IUserRepository.cs`

**Por quê separar?** → Qualquer mudança no banco ou na API não afeta o domínio.

---

### 🟡 Application (Aplicação)
**"Orquestra o domínio e a infraestrutura"**

- **Responsabilidade:** Coordenar fluxos de negócio
- **Contém:** Services, DTOs, use cases
- **Exemplo:** Criar usuário (validar + persistir + retornar)
- **Depende de:** Domain + Infrastructure
- **Arquivos:** `UserService.cs`, `UserDto.cs`

**Por quê?** → Não mexe diretamente com banco ou API. Usa Services.

---

### 🟢 Infrastructure (Infraestrutura)
**"Implementação técnica"**

- **Responsabilidade:** Persistência, banco de dados, APIs externas
- **Contém:** Repositories, EF Core DbContext, configurações
- **Exemplo:** Salvar usuário no banco de dados
- **Depende de:** Domain + bibliotecas de dados
- **Arquivos:** `UserRepository.cs`, `AppDbContext.cs`

**Por quê?** → Isola a complexidade do banco. Troca SQL por NoSQL sem mexer no resto.

---

### 🔵 Presentation (Apresentação)
**"Interface com o mundo exterior"**

- **Responsabilidade:** Receber requisições HTTP e retornar respostas
- **Contém:** Controllers (Web API), endpoints
- **Exemplo:** POST `/users` para criar usuário
- **Depende de:** Application
- **Arquivos:** `UserController.cs`, `Program.cs`

**Por quê?** → Se mudar de Web API para Desktop, Controllers saem, Services ficam.

---

### 🧪 Tests (Testes)
**"Garantir que tudo funciona"**

- **Unit:** Testa partes isoladas (UserService sem database)
- **Integration:** Testa fluxos completos (com database real)

---

## 📊 Fluxo de Dados (Arquitetura em Camadas)

```
Cliente HTTP
    ↓
[Presentation] ← POST /users
    ↓ (CreateUserDto)
[Application] ← UserService.CreateUserAsync()
    ↓
[Domain] ← User.IsValid()
    ↓
[Infrastructure] ← UserRepository.AddAsync()
    ↓
[Database] ← INSERT INTO Users
    ↓
[Infrastructure] ← Retorna User
    ↓
[Application] ← Converte para DTO
    ↓
[Presentation] ← JSON Response
    ↓
Cliente
```

---

## 🚀 Como Usar Esta Estrutura

### 1️⃣ Criar nova funcionalidade (ex: Product)

```
src/Domain/Models/Product.cs        → Entidade
src/Domain/Interfaces/IProductRepository.cs → Contrato
src/Application/Services/ProductService.cs  → Lógica
src/Application/DTOs/ProductDto.cs          → Transferência
src/Infrastructure/Repositories/ProductRepository.cs → Dados
src/Presentation/Controllers/ProductController.cs    → API
tests/Unit/ProductServiceTests.cs                    → Testes
```

### 2️⃣ Regra de Dependência (Dependency Inversion)

```
❌ ERRADO (acoplado):
public class UserService
{
    private UserRepository _repo = new UserRepository();
}

✅ CORRETO (desacoplado):
public class UserService
{
    private readonly IUserRepository _repo;
    
    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }
}
```

---

## 📋 Padrões e Conceitos Principais

### Dependency Injection (DI)
```csharp
// Program.cs (ou Startup.cs)
services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<UserService>();
```

### Repository Pattern
```csharp
// Abstrai o banco de dados
public interface IUserRepository
{
    Task<User> GetByIdAsync(int id);
    Task AddAsync(User user);
}
```

### DTO (Data Transfer Object)
```csharp
// API recebe CreateUserDto (sem password hash)
// Domain usa User (com password hash)
public class CreateUserDto { public string Password; }
public class User { public string Password; /* hash */ }
```

---

## 🛠️ Exemplo Prático: Console App

Para um **Console Application**, a estrutura é similar:

```
MeuConsoleApp/
├── src/
│   ├── Domain/Models/
│   ├── Application/Services/
│   ├── Infrastructure/
│   └── Program.cs           ← Ponto de entrada
└── tests/
```

---

## 📚 Melhores Práticas

✅ **Faça:**
- Separar responsabilidades em camadas
- Usar interfaces para abstrair dependências
- Testar camadas isoladamente (unit tests)
- Criar DTOs para transferir dados entre camadas
- Manter Domain independente de frameworks

❌ **Evite:**
- Misturar camadas (Domain com banco direto)
- Criar Services que fazem tudo
- Esquecer de testes
- Usar dados da database em Controllers diretos
- Deixar Controllers com lógica de negócio

---

## 🔗 Exemplo Completo

Veja os arquivos `.cs` nesta pasta para implementações reais de:
- `User.cs` - Entidade
- `IUserRepository.cs` - Interface
- `UserService.cs` - Service com lógica
- `UserDto.cs` - DTOs
- `UserRepository.cs` - Persistência
- `UserController.cs` - API
- `UserServiceTests.cs` - Testes

---

**Autor:** Blank1ll The Dev  
**Criado:** Dezembro 2025
