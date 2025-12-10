# Modificador `params` — Exemplos e explicações

Este repositório contém exemplos simples em C# que demonstram o modificador `params` em diferentes cenários.

TL;DR: você vai aprender o que é o modificador `params`, ver exemplos práticos (soma, impressão genérica, concatenação, estatísticas) e um exemplo simples de autenticação (`AuthService`) que mostra como `params` pode receber vários registros de usuário. Há também um `PasswordHelper` em `models/PasswordHelper.cs` com um exemplo de hashing (PBKDF2) para aprendizado.

Arquivos adicionados em `models/` (explicação simples e direta):

- `Calculator.cs` : mostra um método `Sum(params int[] numbers)` que soma qualquer quantidade de inteiros.
- `GenericPrinter.cs` : exemplo de método genérico `PrintAll<T>(params T[] items)` para imprimir itens de qualquer tipo.
- `Logger.cs` : exemplo usando `params object[]` para formatar mensagens flexíveis.
- `Concatenator.cs` : exemplo simples que junta strings com um separador e `params string[]`.
- `Stats.cs` : funções estatísticas (`Average`, `Min`, `Max`) que aceitam `params double[]`.
- `StringExtensions.cs` : método de extensão `JoinWith(this string separator, params string[] parts)` que usa `params`.
- `AuthService.cs` : novo exemplo (serviço de autenticação simples) que demonstra `params` com tuplas para registrar múltiplos usuários.

O objetivo é fornecer exemplos pequenos e didáticos para entender como `params` funciona.

O que é `params` (explicação simples):

- `params` é um modificador que você coloca antes do último parâmetro de um método para permitir que ele receba um número variável de argumentos.
- Você pode chamar o método passando vários valores separados por vírgula ou um array do tipo esperado.
- Regras importantes:
  - `params` deve ser o último parâmetro do método.
  - Só é permitido um `params` por método.
  - Não funciona com `ref` ou `out`.

Exemplos de uso (trechos simplificados):

1) Soma de inteiros (em `Calculator.cs`):

```
int total = Calculator.Sum(1, 2, 3, 4);
int total2 = Calculator.Sum(new int[] { 5, 6, 7 });
int empty = Calculator.Sum(); // arrays vazio -> comportamento tratado no método
```

2) Impressão genérica (em `GenericPrinter.cs`):

```
# Modificador `params` — Exemplos e explicações

Este repositório contém exemplos simples em C# que demonstram o modificador `params` em diferentes cenários.

Arquivos adicionados em `models/` (explicação simples e direta):

- `Calculator.cs` : mostra um método `Sum(params int[] numbers)` que soma qualquer quantidade de inteiros.
- `GenericPrinter.cs` : exemplo de método genérico `PrintAll<T>(params T[] items)` para imprimir itens de qualquer tipo.
- `Logger.cs` : exemplo usando `params object[]` para formatar mensagens flexíveis.
- `Concatenator.cs` : exemplo simples que junta strings com um separador e `params string[]`.
- `Stats.cs` : funções estatísticas (`Average`, `Min`, `Max`) que aceitam `params double[]`.
- `StringExtensions.cs` : método de extensão `JoinWith(this string separator, params string[] parts)` que usa `params`.
- `AuthService.cs` : novo exemplo (serviço de autenticação simples) que demonstra `params` com tuplas para registrar múltiplos usuários.

O objetivo é fornecer exemplos pequenos e didáticos para entender como `params` funciona.

O que é `params` (explicação simples):

- `params` é um modificador que você coloca antes do último parâmetro de um método para permitir que ele receba um número variável de argumentos.
- Você pode chamar o método passando vários valores separados por vírgula ou um array do tipo esperado.
- Regras importantes:
  - `params` deve ser o último parâmetro do método.
  - Só é permitido um `params` por método.
  - Não funciona com `ref` ou `out`.

Exemplos de uso (trechos simplificados):

1) Soma de inteiros (em `Calculator.cs`):

```csharp
int total = Calculator.Sum(1, 2, 3, 4);
int total2 = Calculator.Sum(new int[] { 5, 6, 7 });
int empty = Calculator.Sum(); // arrays vazio -> comportamento tratado no método
```

2) Impressão genérica (em `GenericPrinter.cs`):

```csharp
GenericPrinter.PrintAll<int>(10, 20, 30);
GenericPrinter.PrintAll<string>("a", "b", "c");
```

3) Logger flexível (em `Logger.cs`):

```csharp
Logger.Log("Usuário {0} fez login em {1}", username, DateTime.Now);
```

4) Método de extensão (em `StringExtensions.cs`):

```csharp
string s = ", ".JoinWith("maçã", "banana", "laranja");
```

5) `Stats` (em `Stats.cs`):

```csharp
double avg = Stats.Average(2.0, 4.0, 6.0);
double min = Stats.Min(5.5, 1.2, 9.0);
```

6) Exemplo de sistema de login simples usando `params` (em `AuthService.cs`):

Descrição curta: `AuthService` mantém uma lista em memória de usuários (username, password, email) e fornece métodos para registrar e autenticar.

Trecho de uso:

```csharp
var service = new AuthService();
// Registrar um usuário
service.Register("alice", "senha123", "alice@example.com");

// Registrar múltiplos usuários com `params` (tuplas)
service.RegisterMultiple(
    ("bob", "senhaB", "bob@x.com"),
    ("maria", "pwM", "maria@x.com")
);

// Autenticar
bool ok = service.Authenticate("alice", "senha123");

// Listar usuários
foreach (var u in service.ListUsernames()) Console.WriteLine(u);
```

Explicação didática sobre esse exemplo:

- `RegisterMultiple` usa `params` com um array de tuplas: `params (string Username, string Password, string Email)[]`.
- Isso permite chamar `RegisterMultiple` passando qualquer número de usuários em uma única chamada.
- Internamente o método apenas itera e armazena cada tupla em uma lista em memória.

Saiba mais / boas práticas:

- `params` é ótimo para APIs convenientes (ex.: `Console.WriteLine`, `string.Join`, `params object[]`).
- Em código que exige validação estrita, pode ser melhor receber `IEnumerable<T>` ou arrays explicitamente.
- Nunca armazene senhas em texto puro — use hashing/salting para produção.

Como executar este projeto (exemplo local):

```bash
dotnet run
```

Saída esperada (exemplo): várias linhas no console demonstrando as chamadas dos exemplos.

Se quiser, posso:

- Adicionar chamadas ao `AuthService` diretamente em `Program.cs` para demonstrar no `dotnet run`.
- Adicionar testes unitários (xUnit) cobrindo `AuthService` e outros exemplos.
- Expandir o README com imagens/diagramas ou explicações mais técnicas.

---
Arquivo principal do projeto: `Program.cs` — contém chamadas de demonstração que já usam a maioria das classes acima.

**Segurança e hashing de senhas (explicação passo-a-passo)**

- Por que não armazenar senhas em texto puro:
  - Se alguém obtiver acesso ao armazenamento (arquivo, banco), todas as senhas ficam comprometidas.
  - Em vez disso, armazene apenas um *hash* seguro das senhas.

**Exemplo didático (não adicione esse código em produção sem revisão):**

```csharp
// Hash simples usando PBKDF2 (Rfc2898DeriveBytes)
// Retorna uma string contendo salt + hash (base64) separadas por ':' para armazenamento
public static string HashPassword(string password)
{
    using var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
    byte[] salt = new byte[16];
    rng.GetBytes(salt);

    using var pbkdf2 = new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt, 100_000, System.Security.Cryptography.HashAlgorithmName.SHA256);
    byte[] hash = pbkdf2.GetBytes(32); // 256-bit

    return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
}

// Verifica a senha comparando o hash
public static bool VerifyPassword(string stored, string passwordToCheck)
{
    var parts = stored.Split(':');
    if (parts.Length != 2) return false;
    byte[] salt = Convert.FromBase64String(parts[0]);
    byte[] hash = Convert.FromBase64String(parts[1]);

    using var pbkdf2 = new System.Security.Cryptography.Rfc2898DeriveBytes(passwordToCheck, salt, 100_000, System.Security.Cryptography.HashAlgorithmName.SHA256);
    byte[] hashCheck = pbkdf2.GetBytes(32);

    return System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(hash, hashCheck);
}
```

Explicação do exemplo:
- Geramos um `salt` aleatório de 16 bytes e executamos PBKDF2 com 100.000 iterações (valor ilustrativo — atualize conforme recomendação atual).
- Concatenamos `salt:hash` (ambos em Base64) para armazenamento e, na verificação, lemos o salt, recalculamos o hash e comparamos usando comparação em tempo fixo.

**Como integrar isso ao `AuthService` (passo-a-passo):**

1) Substitua o campo que armazena a senha pelo hash retornado por `HashPassword`:

   - Ao registrar um usuário: em vez de `Register(username, password, email)`, armazene `HashPassword(password)`.
    - Ao registrar um usuário: em vez de `Register(username, password, email)`, armazene `PasswordHelper.HashPassword(password)` (veja `models/PasswordHelper.cs`).

2) Ao autenticar: use `VerifyPassword(storedHash, passwordEntrada)`.

**Observações sobre `params` no contexto de autenticação**
- `params` torna simples passar vários registros de usuários em uma única chamada: `RegisterMultiple((u1,p1,e1), (u2,p2,e2))`.
- Se você passar senhas em texto na chamada, transforme-as imediatamente em hash antes de armazenar.

Se quiser, eu posso:
- Adicionar a classe `PasswordHelper` (arquivo `models/PasswordHelper.cs`) com o código de hashing/verificação mostrado acima; ou
- Atualizar `AuthService` para armazenar e verificar hashes automaticamente; ou
- Adicionar testes xUnit que comprovem o fluxo de registro/ autenticação com e sem hashing.

Escolha qual desses próximos passos prefere e eu implemento.
