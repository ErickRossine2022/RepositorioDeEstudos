# 🖥️ Aprendizado em C#

Repositório dedicado ao **aprendizado prático em C#**, com foco em **Programação Orientada a Objetos (POO)** e **lógica de programação**.

---

## 📚 Índice

1. **[Conceitos Fundamentais](#-conceitos-fundamentais)**
   - [Classes](#️-classes)
   - [Atributos e Variáveis](#-atributos--variáveis)
   - [Construtores](#️-construtores)
   - [Métodos](#-métodos)
   - [Listas](#️-listas)
   - [Vetores (Arrays)](#️-vetores-arrays)

2. **[Tópicos Avançados](#-tópicos-avançados)**
   - [Palavra `this` e Referenciais](#-palavra-this-e-referenciais)
   - [Sobrecarga (Overloading)](#️-sobrecarga-overloading)
   - [Classes vs Structs](#-classe-vs-struct)
   - [Tipos Valor e Referência](#-tipos-valor-vs-tipos-referência)
   - [Garbage Collector](#-garbage-collector)
   - [Modificador `params` e Tuplas](#️-modificador-params-e-tuplas)

3. **[Estrutura do Repositório](#-estrutura-do-repositório)**
4. **[Ferramentas Recomendadas](#️-ferramentas-recomendadas)**
5. **[Sobre o Autor](#-sobre-o-autor)**

---

## 🎯 Conceitos Fundamentais

### 🏷️ Classes

Uma **classe** é um modelo que define estrutura e comportamento de objetos. Ela agrupa **atributos** (dados), **métodos** (comportamentos) e **construtores** (inicialização).

**Exemplo prático:**

```csharp
public class Pessoa
{
    public string Nome { get; set; }  // Atributo público
    private int idade;                // Atributo privado

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        this.idade = idade;
    }

    // Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
    }
}
```

> 💡 **Dica:** Pense na classe como um **molde**. Cada `new Pessoa()` cria uma **nova instância** desse molde.

### 💾 Atributos / Variáveis

Variáveis que armazenam dados dentro de uma classe. Possuem **modificadores de acesso** que controlam sua visibilidade:

| Modificador | Visibilidade | Uso |
|---|---|---|
| `public` | Acessível de qualquer lugar | Dados que devem ser compartilhados |
| `private` | Apenas dentro da classe | Dados internos e protegidos |
| `static` | Pertence à classe, não a instâncias | Dados compartilhados entre objetos |
| `readonly` | Só pode ser definido no construtor | Dados que não mudam após criação |

**Exemplo:**

```csharp
private static readonly List<Pessoa> pessoas = new List<Pessoa>();
```

### ⚙️ Construtores

Métodos especiais que **inicializam objetos** quando criados com `new`. Executam antes do objeto estar disponível.

**Características:**
- ✔ Mesmo nome da classe
- ✔ Sem tipo de retorno
- ✔ Podem ser sobrecarregados
- ✔ Inicializam atributos

**Exemplo:**

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    private int idade;

    // Construtor com parâmetros
    public Pessoa(string nome, int idade)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        this.idade = idade;
    }
}
```

> 💡 **Dica:** Use `this.atributo` para diferenciar o **atributo da classe** do **parâmetro recebido**.

### 📝 Métodos

Funções definidas dentro de uma classe que implementam **comportamentos** e **ações**.

**Tipos:**
- `public` - acessível externamente
- `private` - apenas uso interno
- `static` - não precisa instância
- `override` - sobrescreve método da classe pai

**Exemplo com sobrescrita de `ToString()`:**

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    private int idade;

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {idade}";
    }
}

// Uso:
Pessoa p = new Pessoa { Nome = "Alice", idade = 25 };
Console.WriteLine(p); // Chama automaticamente ToString()
```

> 💡 **Dica:** `Console.WriteLine(objeto)` automaticamente chama `ToString()` do objeto.

### 🗂️ Listas

Estrutura de dados que **armazena múltiplos objetos** do mesmo tipo em ordem.

**Operações básicas:**

```csharp
// Criar lista
List<Pessoa> pessoas = new List<Pessoa>();

// Adicionar elementos
pessoas.Add(new Pessoa("Alice", 25));
pessoas.Add(new Pessoa("Bob", 30));

// Percorrer com foreach
foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p);
}

// Acessar por índice
Pessoa primeiro = pessoas[0];

// Remover elemento
pessoas.RemoveAt(0);
```

> 💡 **Dica:** Use `foreach` para iterar sobre listas de forma simples e segura.

---

### 🗃️ Vetores (Arrays)

Um **vetor (array)** é uma estrutura que armazena **múltiplos valores do mesmo tipo** em posições **contíguas na memória**, com **tamanho fixo**.

> **Diferença entre Lista e Vetor:**
> - **Lista:** tamanho variável, podem adicionar/remover elementos
> - **Vetor:** tamanho fixo definido na criação, acesso rápido por índice

#### 🔹 Criando Vetores

**Sintaxe básica:**

```csharp
// Declarar e criar um vetor de inteiros com 5 posições
int[] numeros = new int[5];

// Declarar e inicializar com valores
int[] numeros2 = new int[] { 10, 20, 30, 40, 50 };

// Forma simplificada
int[] numeros3 = { 10, 20, 30, 40, 50 };

// Descobrir o tamanho
int tamanho = numeros.Length; // 5
```

#### 🔹 Tipos de Vetores

**1️⃣ Vetor de `int` (inteiros):**

```csharp
int[] idades = new int[3];
idades[0] = 25;
idades[1] = 30;
idades[2] = 35;

Console.WriteLine($"Idade 1: {idades[0]}"); // 25
Console.WriteLine($"Tamanho: {idades.Length}"); // 3
```

**2️⃣ Vetor de `double` (números decimais):**

```csharp
double[] precos = { 19.99, 49.50, 99.90 };

// Somar todos os preços
double total = 0;
foreach (double preco in precos)
{
    total += preco;
}

Console.WriteLine($"Total: {total}"); // 169.39
```

**3️⃣ Vetor de `string` (textos):**

```csharp
string[] frutas = { "maçã", "banana", "laranja", "uva" };

// Listar todas as frutas
foreach (string fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}

// Acessar por índice
Console.WriteLine(frutas[0]); // maçã
```

**4️⃣ Vetor de `decimal` (valores monetários):**

```csharp
decimal[] saldos = { 100.50m, 250.75m, 50.25m };

// Encontrar maior saldo
decimal maior = saldos[0];
foreach (decimal saldo in saldos)
{
    if (saldo > maior)
        maior = saldo;
}

Console.WriteLine($"Maior saldo: {maior}"); // 250.75
```

**5️⃣ Vetor de `float` (números com ponto flutuante):**

```csharp
float[] notas = { 7.5f, 8.0f, 9.5f, 6.0f };

// Calcular média
float media = 0;
foreach (float nota in notas)
{
    media += nota;
}
media = media / notas.Length;

Console.WriteLine($"Média: {media:f2}"); // 7.75
```

---

#### 🔹 Operações Comuns com Vetores

**Percorrer com `for`:**

```csharp
int[] nums = { 10, 20, 30, 40 };

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Posição {i}: {nums[i]}");
}
```

**Percorrer com `foreach`:**

```csharp
int[] nums = { 10, 20, 30, 40 };

foreach (int num in nums)
{
    Console.WriteLine($"Valor: {num}");
}
```

**Encontrar o maior valor:**

```csharp
double[] numeros = { 15.5, 23.3, 8.9, 45.2, 12.1 };

double maximo = numeros[0];
foreach (double num in numeros)
{
    if (num > maximo)
        maximo = num;
}

Console.WriteLine($"Maior: {maximo}"); // 45.2
```

**Encontrar o menor valor:**

```csharp
int[] numeros = { 15, 23, 8, 45, 12 };

int minimo = numeros[0];
foreach (int num in numeros)
{
    if (num < minimo)
        minimo = num;
}

Console.WriteLine($"Menor: {minimo}"); // 8
```

**Calcular soma e média:**

```csharp
double[] valores = { 10.5, 20.3, 30.2, 40.0 };

double soma = 0;
foreach (double valor in valores)
{
    soma += valor;
}

double media = soma / valores.Length;

Console.WriteLine($"Soma: {soma}");     // 101.0
Console.WriteLine($"Média: {media:f2}"); // 25.25
```

---

#### 🔹 Vetores com Classes

Você também pode criar vetores de objetos:

```csharp
// Classe Produto
public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

// Criar vetor de produtos
Produto[] produtos = new Produto[3];

produtos[0] = new Produto { Nome = "Notebook", Preco = 3000.00 };
produtos[1] = new Produto { Nome = "Mouse", Preco = 50.00 };
produtos[2] = new Produto { Nome = "Teclado", Preco = 150.00 };

// Listar todos
foreach (Produto p in produtos)
{
    Console.WriteLine($"{p.Nome} - R$ {p.Preco:f2}");
}
```

---

#### 📋 Exemplo Prático: Sistema de Notas

Este exemplo é baseado no projeto `Projeto_011/Vetores` do repositório:

```csharp
using System;

class Program
{
    static void Main()
    {
        // Pedir quantidade de alunos
        Console.WriteLine("Quantos alunos? ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        // Criar vetores para armazenar dados
        string[] nomes = new string[quantidade];
        double[] notas = new double[quantidade];

        // Entrada de dados
        Console.WriteLine($"Digite o nome e a nota de {quantidade} alunos:\n");

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine() ?? "Sem nome";

            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("\n========== RELATÓRIO ==========\n");

        // Exibir dados
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Aluno: {nomes[i]}\tNota: {notas[i]:f2}");
        }

        // Calcular média
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }

        double media = soma / notas.Length;

        Console.WriteLine($"\nMédia da turma: {media:f2}");

        // Encontrar maior e menor nota
        double maior = notas[0];
        double menor = notas[0];

        foreach (double nota in notas)
        {
            if (nota > maior) maior = nota;
            if (nota < menor) menor = nota;
        }

        Console.WriteLine($"Maior nota: {maior:f2}");
        Console.WriteLine($"Menor nota: {menor:f2}");
    }
}
```

---

#### 📊 Comparação: Tipos de Vetores

| Tipo | Uso | Exemplo |
|---|---|---|
| **`int[]`** | Números inteiros | Idades, quantidades, IDs |
| **`double[]`** | Números decimais (mais precisão) | Preços, medidas, cálculos |
| **`string[]`** | Textos | Nomes, descrições |
| **`decimal[]`** | Valores monetários (maior precisão) | Salários, transações |
| **`float[]`** | Números decimais (menos memória) | Coordenadas, physics |

---

#### ⚠️ Erros Comuns com Vetores

**1️⃣ IndexOutOfRangeException (acessar posição inválida):**

```csharp
int[] nums = { 10, 20, 30 };
Console.WriteLine(nums[5]); // ❌ Erro! Só tem 3 elementos (0, 1, 2)
```

**2️⃣ Esquecer de inicializar:**

```csharp
int[] nums; // ❌ Não foi criado com new
nums[0] = 10; // Erro!

int[] nums2 = new int[5]; // ✓ Correto
nums2[0] = 10; // OK
```

**3️⃣ Tentar redimensionar:**

```csharp
int[] nums = { 10, 20, 30 };
nums.Length = 5; // ❌ Não pode redimensionar!

// Solução: criar novo vetor
int[] novoVetor = new int[5];
Array.Copy(nums, novoVetor, nums.Length);
```

---

## 🎯 Tópicos Avançados

### 🔹 Palavra `this` e Referenciais

A palavra **`this`** é uma **referência para o próprio objeto da classe**. Tem três usos principais:

#### 1️⃣ Diferenciar atributo de parâmetro

```csharp
public class Produto
{
    public string Nome;
    public int Quantidade;

    public Produto(string nome, int quantidade)
    {
        this.Nome = nome;           // this.Nome = atributo da classe
        this.Quantidade = quantidade; // quantidade = parâmetro
    }
}
```

#### 2️⃣ Chamar outro construtor (reutilizar código)

```csharp
public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto() { Quantidade = 0; }

    public Produto(string nome, double preco) : this()
    {
        Nome = nome;
        Preco = preco;
    }

    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
}
```

#### 3️⃣ Passar o próprio objeto como argumento

```csharp
public class Produto
{
    public string Nome;

    public void RegistrarEmEstoque(Estoque estoque)
    {
        estoque.AdicionarProduto(this); // Passa a si mesmo
    }
}
```

---

### ⚙️ Sobrecarga (Overloading)

**Sobrecarga** é criar **múltiplos métodos/construtores com o mesmo nome**, mas **parâmetros diferentes** (tipo, quantidade ou ordem).

#### ✅ Vantagens

- Código mais **limpo** e **intuitivo**
- Evita nomes confusos tipo `SomarInteiros()`, `SomarDoubles()`
- Melhor **experiência do desenvolvedor**

#### Exemplo: Sobrecarga de Construtores

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor 1: apenas nome
    public Pessoa(string nome)
    {
        Nome = nome;
        Idade = 0;
    }

    // Construtor 2: nome e idade
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Construtor 3: sem parâmetros
    public Pessoa() : this("Sem nome", 0) { }
}
```

#### Exemplo: Sobrecarga de Métodos

```csharp
public class Calculadora
{
    // Soma dois inteiros
    public int Somar(int a, int b) => a + b;

    // Soma dois doubles
    public double Somar(double a, double b) => a + b;

    // Soma três inteiros
    public int Somar(int a, int b, int c) => a + b + c;
}
```

---

### 💯 Classe vs Struct

#### 📌 Tipo de Referência (Class)

Uma **classe** é um **tipo por referência**. Quando você cria um objeto, a variável armazena o **endereço de memória**, não o objeto.

```csharp
public class Produto
{
    public string Nome { get; set; }
    public double Valor { get; set; }
}

Produto p1 = new Produto { Nome = "TV", Valor = 900 };
Produto p2 = p1; // p2 aponta para O MESMO objeto

p2.Valor = 200;
Console.WriteLine(p1.Valor); // 200 (alterou junto!)
```

#### 📌 Tipo de Valor (Struct)

Um **struct** é um **tipo por valor**. A variável armazena os **dados diretamente**, não uma referência.

```csharp
public struct ProdutoStruct
{
    public string Nome { get; set; }
    public double Valor { get; set; }
}

ProdutoStruct a = new ProdutoStruct { Nome = "TV", Valor = 900 };
ProdutoStruct b = a; // b recebe UMA CÓPIA de a

b.Valor = 200;
Console.WriteLine(a.Valor); // 900 (não alterou!)
```

#### 📊 Comparação Rápida

| Característica | Class | Struct |
|---|---|---|
| **Tipo** | Referência | Valor |
| **Armazena** | Endereço de memória | Dados diretos |
| **Memória** | Heap | Stack |
| **Cópia** | Copia a referência | Copia os valores |
| **Modificação** | Afeta ambas as variáveis | Afeta apenas uma |
| **Ideal para** | Objetos complexos | Dados simples/leves |

#### ✅ Quando usar cada um?

**Use Class quando:**
- O objeto é **grande ou complexo**
- Precisa ser **compartilhado** entre múltiplos lugares
- Exemplo: `Usuário`, `Produto`, `ContaBancária`

**Use Struct quando:**
- Os dados são **pequenos e simples**
- Quer **cópias independentes**
- Exemplo: `Ponto(X, Y)`, `Data`, `Hora`, `Cor(R, G, B)`

---

### 📘 Tipos Valor vs Tipos Referência

Esta é uma diferença fundamental em C#. Entender bem melhora drasticamente sua capacidade de escrever código correto.

**Classes compartilham referência** → modificações afetam todas as variáveis que apontam para o mesmo objeto.

**Structs criam cópias** → cada variável possui seus próprios dados independentes.

---

### 🗑️ Garbage Collector

O **Garbage Collector (GC)** é o **sistema automático de limpeza de memória** do .NET. Você não precisa liberar memória manualmente — ele faz isso automaticamente.

#### 🔄 Como funciona?

O GC trabalha em **3 fases**:

1. **Mark** → Marca todos os objetos que **ainda têm referência**
2. **Sweep** → Identifica objetos **sem referência**
3. **Compact** → Remove objetos inúteis e **reorganiza o heap**

#### ⏱️ Quando executa?

- Quando a **memória está baixa**
- Quando você chama `GC.Collect()` (força execução)
- Em **intervalos regulares** do .NET

#### 🧪 Exemplo Prático

```csharp
using System;

class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
        Console.WriteLine($"Pessoa '{Nome}' criada.");
    }

    // Destrutor (finalizer) - executado pelo GC
    ~Pessoa()
    {
        Console.WriteLine($"Pessoa '{Nome}' destruída pelo GC.");
    }
}

class Program
{
    static void Main()
    {
        CriarPessoa();

        Console.WriteLine("\nForçando Garbage Collector...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Programa finalizado.");
    }

    static void CriarPessoa()
    {
        Pessoa p = new Pessoa("João");
        // p sai do escopo e perde referência
    }
}

// Saída esperada:
// Pessoa 'João' criada.
// Forçando Garbage Collector...
// Pessoa 'João' destruída pelo GC.
// Programa finalizado.
```

---

### ⚙️ Modificador `params` e Tuplas

O `params` é um modificador que permite métodos aceitar um **número variável de argumentos**. Combinado com **tuplas**, cria APIs flexíveis e intuitivas.

#### 🔹 O que é `params`?

`params` permite chamar um método passando vários valores sem precisar criar um array manualmente.

**Regras importantes:**
- ✔ Deve ser o **último parâmetro** do método
- ✔ Apenas **um `params` por método**
- ✔ Não funciona com `ref` ou `out`

**Exemplo simples:**

```csharp
public class Calculadora
{
    // Método com params
    public static int Somar(params int[] numeros)
    {
        int total = 0;
        foreach (int n in numeros)
            total += n;
        return total;
    }
}

// Duas formas de chamar:
int resultado1 = Calculadora.Somar(1, 2, 3, 4);        // Sem array
int resultado2 = Calculadora.Somar(new int[] { 5, 6 }); // Com array
```

---

#### 🔹 O que são Tuplas?

Uma **tupla** é uma estrutura simples que agrupa **múltiplos valores** sem precisar criar uma classe. Ideal para retornar múltiplos dados.

**Sintaxe básica:**

```csharp
// Tupla com nomes (recomendado)
(string Nome, int Idade, string Email) usuario = ("Alice", 25, "alice@email.com");

// Acessando os valores
Console.WriteLine(usuario.Nome);   // Alice
Console.WriteLine(usuario.Idade);  // 25
Console.WriteLine(usuario.Email);  // alice@email.com
```

**Tuplas sem nomes (menos comum):**

```csharp
(string, int, string) dados = ("Bob", 30, "bob@email.com");
Console.WriteLine(dados.Item1); // Bob
Console.WriteLine(dados.Item2); // 30
```

> 💡 **Dica:** Sempre use tuplas com nomes! Ficam muito mais legíveis: `usuario.Nome` em vez de `usuario.Item1`.

---

#### 🔹 Combinando `params` com Tuplas

Combine `params` com tuplas para métodos que aceitam **múltiplos registros**:

```csharp
public class AuthService
{
    private List<(string Username, string Password, string Email)> usuarios = new();

    // Registrar um usuário (sem params)
    public void Registrar(string username, string password, string email)
    {
        usuarios.Add((username, password, email));
        Console.WriteLine($"✓ Usuário '{username}' registrado.");
    }

    // Registrar múltiplos usuários (com params)
    public void RegistrarMultiplos(params (string Username, string Password, string Email)[] users)
    {
        foreach (var user in users)
        {
            Registrar(user.Username, user.Password, user.Email);
        }
    }

    // Autenticar
    public bool Autenticar(string username, string password)
    {
        foreach (var user in usuarios)
        {
            if (user.Username == username && user.Password == password)
                return true;
        }
        return false;
    }
}
```

**Usando o serviço:**

```csharp
var servico = new AuthService();

// Registrar um usuário
servico.Registrar("alice", "senha123", "alice@example.com");

// Registrar múltiplos com params + tuplas
servico.RegistrarMultiplos(
    ("bob", "senhaB", "bob@example.com"),
    ("maria", "senhaM", "maria@example.com"),
    ("carlos", "senhaC", "carlos@example.com")
);

// Autenticar
if (servico.Autenticar("alice", "senha123"))
    Console.WriteLine("✓ Login bem-sucedido!");
```

> **Vantagem:** Em uma única chamada, registra 3 usuários sem criar um array manualmente!

---

#### 📊 Exemplos Práticos com `params`

**1️⃣ Soma flexível:**

```csharp
public static double Somar(params double[] numeros)
{
    double total = 0;
    foreach (var num in numeros)
        total += num;
    return total;
}

// Uso:
Somar(1.5, 2.3, 4.7);                    // 3 argumentos
Somar(10, 20);                             // 2 argumentos
Somar();                                   // 0 argumentos → retorna 0
```

**2️⃣ Concatenar strings:**

```csharp
public static string Juntar(string separador, params string[] palavras)
{
    return string.Join(separador, palavras);
}

// Uso:
string resultado = Juntar(" - ", "C#", "é", "incrível");
Console.WriteLine(resultado); // C# - é - incrível
```

**3️⃣ Imprimir genérico:**

```csharp
public static void Imprimir<T>(params T[] itens)
{
    Console.WriteLine($"Total: {itens.Length} item(ns)");
    foreach (var item in itens)
        Console.WriteLine($"  • {item}");
}

// Uso:
Imprimir(10, 20, 30);                          // Inteiros
Imprimir("maçã", "banana", "laranja");         // Strings
```

---

#### ⚠️ Parâmetros Normais vs `params`

| Aspecto | Parâmetros Normais | Com `params` |
|---|---|---|
| **Número de argumentos** | Fixo | Variável (0+) |
| **Forma de chamar** | `Metodo(a, b)` | `Metodo(a, b, c, d)` |
| **Array manual?** | Sim, se precisar | Não, automático |
| **Exemplo** | `void Soma(int a, int b)` | `void Soma(params int[] nums)` |

---

#### 🔒 Segurança: Hashing de Senhas

⚠️ **Nunca armazene senhas em texto puro!** Use hashing com salt:

```csharp
using System.Security.Cryptography;

public static class PasswordHelper
{
    // Gera hash seguro da senha
    public static string HashPassword(string password)
    {
        using var rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[16];
        rng.GetBytes(salt);

        using var pbkdf2 = new Rfc2898DeriveBytes(
            password, 
            salt, 
            100_000,  // iterações
            HashAlgorithmName.SHA256
        );
        byte[] hash = pbkdf2.GetBytes(32); // 256-bit

        return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
    }

    // Verifica se a senha está correta
    public static bool VerificarPassword(string hashArmazenado, string senhaEntrada)
    {
        var partes = hashArmazenado.Split(':');
        if (partes.Length != 2) return false;

        byte[] salt = Convert.FromBase64String(partes[0]);
        byte[] hash = Convert.FromBase64String(partes[1]);

        using var pbkdf2 = new Rfc2898DeriveBytes(
            senhaEntrada, 
            salt, 
            100_000,
            HashAlgorithmName.SHA256
        );
        byte[] hashCalc = pbkdf2.GetBytes(32);

        return CryptographicOperations.FixedTimeEquals(hash, hashCalc);
    }
}
```

**Como usar:**

```csharp
// Ao registrar
string hashPassword = PasswordHelper.HashPassword("minhaSenha123");
usuarios.Add(("alice", hashPassword, "alice@mail.com"));

// Ao autenticar
if (PasswordHelper.VerificarPassword(usuarioArmazenado.Password, senhaEntrada))
    Console.WriteLine("✓ Autenticado!");
```

---

#### 📋 Resumo: `params` + Tuplas

| Conceito | O que é | Quando usar |
|---|---|---|
| **`params`** | Parâmetro de número variável | Métodos que aceitam 0+ argumentos |
| **Tuplas** | Grupo de valores nomeados | Retornar/agrupar dados simples |
| **Combinação** | `params` com tuplas | Registrar/processar múltiplos registros |

---


## 📁 Estrutura do Repositório

```
RepositorioDeEstudos/
├── Exercicios/          # Exercícios de prática (1-8)
│   ├── 1/, 2/, 3/ ...  # Cada pasta contém um exercício
│   └── [Program.cs, *.csproj]
├── Projetos/            # Projetos maiores de aprendizado
│   ├── 01-ProjetoDeAprendizado_1/
│   ├── Aula_Metodos_Staticos/
│   ├── Construtores_Estudo_Pratica/
│   ├── Controle_de_Alunos/
│   ├── web_scrapping/
│   ├── Conta_Bancaria/
│   ├── SobreCarga/
│   └── EcapslumentoThis/
├── README.md            # Este arquivo
└── Documentação.md      # Documentação adicional
```

---

## 🛠️ Ferramentas Recomendadas

| Ferramenta | Descrição |
|---|---|
| **Visual Studio Code** | Editor de código leve e poderoso |
| **C# Kit Dev** | Extensão C# para VSCode |
| **.NET SDK** | Framework e compilador |
| **.NET Runtime** | Ambiente de execução |
| **Git** | Controle de versão |

**Instalação rápida (Linux):**

```bash
# .NET SDK
wget https://dot.net/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --version latest

# Verificar instalação
dotnet --version
```

---

## 🎯 Objetivo do Repositório

✔️ Documentar meu **aprendizado em C#**  
✔️ Compartilhar **exercícios e práticas** úteis  
✔️ Consolidar **conceitos de POO** de forma clara  
✔️ Servir como **referência rápida** para conceitos

---

## 📖 Como Usar Este Repositório

1. **Comece pelos conceitos fundamentais** → Leia a seção [Conceitos Fundamentais](#-conceitos-fundamentais)
2. **Explore os exercícios** → Veja as pastas em `Exercicios/`
3. **Estude os projetos** → Projetos maiores em `Projetos/`
4. **Clone e pratique** → Rode os exemplos localmente
5. **Aprofunde em tópicos** → Leia as seções [Tópicos Avançados](#-tópicos-avançados)

---

## 📞 Sobre o Autor

**Erick Rossine** *(Blank1ll The Dev)*

Desenvolvedor apaixonado por educação em programação, compartilhando conhecimento através de projetos práticos e documentação clara.

🔗 **Links para contato:**

- 🪪 **Discord:** Blank1ll the dev
- 📺 **YouTube:** [@erickd7s](https://www.youtube.com/@erickd7s)
- 💬 **Servidor Discord:** [Entrar no servidor](https://discord.gg/sfUSVgvdrV)
- 🐙 **GitHub:** [ErickRossine2022](https://github.com/ErickRossine2022)

---

## ❤️ Agradecimentos

Obrigado por visitar este repositório e fazer parte da jornada de aprendizado em C#! 

Se este material foi útil, considere:
- ⭐ Dar uma estrela no repositório
- 🔗 Compartilhar com outros aprendizes
- 💬 Enviar feedback e sugestões

---

**Última atualização:** Dezembro de 2025
