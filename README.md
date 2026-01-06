# 🖥️ Aprendizado em C#

Repositório dedicado ao **aprendizado prático em C#**, com foco em **Programação Orientada a Objetos (POO)** e **lógica de programação**.

---

## 📚 Índice

1. **[Conceitos Fundamentais](#conceitos-fundamentais)**
   - [Classes](#classes)
   - [Atributos e Variáveis](#atributos-e-variaveis)
   - [Construtores](#construtores)
   - [Métodos](#metodos)
   - [Listas](#listas)
   - [Vetores (Arrays)](#vetores-arrays)

2. **[Tópicos Avançados](#topicos-avancados)**
   - [Palavra `this` e Referenciais](#palavra-this-e-referenciais)
   - [Sobrecarga (Overloading)](#sobrecarga-overloading)
   - [Classes vs Structs](#classe-vs-struct)
   - [Tipos Valor e Referência](#tipos-valor-vs-tipos-referencia)
   - [Garbage Collector](#garbage-collector)
   - [Modificador `params` e Tuplas](#modificador-params-e-tuplas)
     - [Modificadores `ref` e `out`](#modificadores-ref-e-out)
     - [Boxing e Unboxing](#boxing-e-unboxing)
     - [Enumerações (`enum`)](#enum)
     - [LINQ](#linq)
     - [async/await & HttpClient](#async-await-httpclient)
     - [Serialização JSON](#serializacao-json)

3. **[Estrutura do Repositório](#estrutura-do-repositorio)**
4. **[Dicas de Projeto e Estrutura](#dicas-de-projeto-e-estrutura)**
5. **[Ferramentas Recomendadas](#ferramentas-recomendadas)**
6. **[Sobre o Autor](#sobre-o-autor)**

---

<a id="conceitos-fundamentais"></a>

## 🎯 Conceitos Fundamentais

<a id="classes"></a>

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

<a id="atributos-e-variaveis"></a>

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

<a id="construtores"></a>

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

<a id="metodos"></a>

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

<a id="listas"></a>

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

<a id="vetores-arrays"></a>

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

        Console.WriteLine("\n========== RELATÓRIO ==========\n
" );

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

<a id="topicos-avancados"></a>
<a id="-tópicos-avancados"></a>

## 🎯 Tópicos Avançados

<a id="palavra-this-e-referenciais"></a>

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

<a id="sobrecarga-overloading"></a>

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

<a id="classe-vs-struct"></a>

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

<a id="tipos-valor-vs-tipos-referencia"></a>

### 📘 Tipos Valor vs Tipos Referência

Esta é uma diferença fundamental em C#. Entender bem melhora drasticamente sua capacidade de escrever código correto.

**Classes compartilham referência** → modificações afetam todas as variáveis que apontam para o mesmo objeto.

**Structs criam cópias** → cada variável possui seus próprios dados independentes.

---

<a id="garbage-collector"></a>

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

<a id="modificador-params-e-tuplas"></a>

### ⚙️ Modificador `params` e Tuplas

**`params`** permite que um método aceite **0 ou mais** argumentos do mesmo tipo sem precisar criar um array manualmente.

- Regras simples:
  - Deve ser **o último parâmetro**.
  - Apenas **um `params`** por método.

**Exemplo — `params`:**
```csharp
public static int Somar(params int[] numeros) => numeros.Sum();
// Uso:
var total = Somar(1, 2, 3); // 6
```

**Tuplas** são formas rápidas de agrupar valores sem criar uma classe ou struct. Prefira tuplas **nomeadas** para clareza.

**Exemplo — Tupla nomeada:**
```csharp
(string Nome, int Idade) GetPessoa() => ("Alice", 25);
var pessoa = GetPessoa();
Console.WriteLine(pessoa.Nome);
```

**Combinação (útil para APIs flexíveis):**
```csharp
public void RegistrarMultiplos(params (string Username, string Email)[] users)
{
    foreach (var u in users) Console.WriteLine(u.Username);
}
```

> 💡 Dica rápida: para retornar múltiplos valores, prefira **tuplas** sobre `out` em APIs públicas — são mais legíveis e testáveis.

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

<a id="modificadores-ref-e-out"></a>

### 🔹 Modificadores `ref` e `out`

- `ref`: a variável **precisa** estar inicializada antes da chamada; o método pode **ler e escrever** o valor.
- `out`: a variável **não precisa** estar inicializada; o método **deve** atribuir um valor antes de retornar.

**Exemplo `ref` (swap):**
```csharp
void Swap(ref int a, ref int b) { int t = a; a = b; b = t; }
```

**Exemplo `out` (padrão Try):**
```csharp
bool TryParseInt(string s, out int value) => int.TryParse(s, out value);
if (TryParseInt("123", out var n)) Console.WriteLine(n);
```

**Boas práticas:**
- Use `out` para métodos do tipo `TryXxx`.
- Prefira **retornar tuplas ou objetos** em APIs públicas para evitar efeitos colaterais e melhorar legibilidade.

---


<a id="boxing-e-unboxing"></a>

### 🔹 Boxing e Unboxing

`Boxing` e `Unboxing` são conceitos ligados à diferença entre **tipos por valor** (value types — ex: `int`, `struct`) e **tipos por referência** (reference types — ex: `object`, classes).

- **Boxing**: é a conversão implícita de um value type para `object` (ou para uma interface que ele implementa). Isso copia o valor para o heap e cria um objeto.
- **Unboxing**: é a conversão explícita do `object` de volta para um value type. Requer um cast e pode lançar `InvalidCastException` se o tipo não corresponder.

Exemplo simples:

```csharp
int a = 123;         // value type, armazenado na stack
object o = a;        // boxing: o agora referencia um objeto no heap
int b = (int)o;      // unboxing: cast explícito
```

Impactos e desempenho:
- Boxing aloca memória no heap e envolve custo de gerenciamento, GC e cópia de dados.
- Unboxing faz um cast e leitura do valor; também tem custo e risco de exceção se o tipo não bater.
- Operações frequentes de boxing/unboxing em loops podem degradar significativamente a performance.

Como evitar:
- Use **generics** para manter tipos fortes sem boxing: `List<int>` evita boxing vs `ArrayList`.
- Evite armazenar value types em coleções não genéricas (`ArrayList`, `List<object>`) quando possível.
- Para structs grandes, considere passar por referência (`in` / `ref`) para evitar cópias, mas cuidado com semântica.

Observação sobre `Nullable<T>`:
- Ao fazer boxing de um `Nullable<T>` que tem valor (`HasValue == true`), o valor subjacente é boxed (ex.: `int? x = 5; object o = x;` resulta em um boxed `int`). Se `x` for `null`, o resultado do boxing é `null`.

Exemplo prático mostrando problema comum:

```csharp
object sum = 0; // boxed int (0)
for (int i = 0; i < 10000; i++)
{
    // cada operação pode causar boxing/unboxing se não usar tipos genéricos
    sum = (int)sum + i; // unboxing + soma + boxing novamente
}
```

Alternativas sem boxing:
- Usar `int`/`long` nativos e coleções genéricas (`List<int>`).
- Usar `Span<T>` e `Memory<T>` para trabalhar com buffers sem alocações quando apropriado.

Resumo rápido:
- **Boxing**: value type -> object (alocação no heap, custo)
- **Unboxing**: object -> value type (cast explícito, pode lançar)
- **Evitar** quando performance/GC for crítica; prefira generics e passagem por referência quando adequado.

---

<a id="enum"></a>

### 🔹 Enumerações (`enum`)

`enum` representa um conjunto nomeado de constantes — ótimo para estados e opções legíveis (evita números "mágicos").

**Exemplo simples:**
```csharp
public enum OrderStatus { PendingPayment = 0, Processing = 1, Shipped = 2, Delivered = 3 }
```

**Operações comuns:**
- Para obter nome: `OrderStatus.Processing.ToString()`
- Para parse seguro: `Enum.TryParse<OrderStatus>(input, ignoreCase: true, out var status)`
- Para obter valor numérico: `int v = (int)OrderStatus.Shipped`
- Para converter de int: `if (Enum.IsDefined(typeof(OrderStatus), 2)) status = (OrderStatus)2;`

**JSON & Flags:**
- Use `JsonStringEnumConverter` para serializar como nomes em JSON.
- Para máscaras bitwise, use `[Flags]` com valores em potências de 2.

**Exemplo prático — Projeto `EnumeracoesDotnet` (compacto):**
- Local: `Projetos/Projeto_015/EnumeracoesDotnet/EnumeracoesDotnet`
- Como executar:
```bash
cd Projetos/Projeto_015/EnumeracoesDotnet/EnumeracoesDotnet
dotnet run
```
- O projeto cria um `Order`, mostra o `Status` e demonstra conversões `enum ⇄ string` e `enum ⇄ int`.
- Recomendações rápidas: teste parsing inválido, use `TryParse(..., ignoreCase:true)`, e adicione `JsonStringEnumConverter` se for serializar em APIs.

> ✅ Mantive o exemplo do projeto aqui de forma compacta para não poluir a seção, mas com todas as informações essenciais.

---

### 🔹 LINQ

<a id="linq"></a>
LINQ (Language Integrated Query) facilita consultas em coleções (`IEnumerable<T>`, `IQueryable<T>`). Exemplos comuns: `Where`, `Select`, `OrderBy`, `FirstOrDefault`, `Sum`.

Exemplo curto:
```csharp
int[] nums = {1,2,3,4,5};
var pares = nums.Where(n => n % 2 == 0).Select(n => n * 2);
Console.WriteLine(string.Join(", ", pares)); // 4, 8
```

Boas práticas: prefira consultas sobre `IEnumerable<T>` para memória e `IQueryable<T>` para tradução em bancos (EF). Use `FirstOrDefault()` com checagem nula.

---

### 🔹 async/await & HttpClient

<a id="async-await-httpclient"></a>
Use `async`/`await` para operações I/O não bloqueantes; `HttpClient` é a API recomendada para chamadas HTTP. Sempre trate exceções e reutilize `HttpClient` quando possível.

Exemplo curto:
```csharp
using var client = new HttpClient();
async Task<string> GetHtmlAsync(string url)
{
    try
    {
        return await client.GetStringAsync(url);
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Erro HTTP: {ex.Message}");
        return string.Empty;
    }
}
```

Dica: evite criar muitas instâncias de `HttpClient`; prefira singleton ou factory (IHttpClientFactory em apps ASP.NET).

---

### 🔹 Serialização JSON

<a id="serializacao-json"></a>
Explique como serializar/deserializar com `System.Text.Json` e como configurar enums para serializarem como string.

Exemplo curto:
```csharp
using System.Text.Json;
using System.Text.Json.Serialization;

var options = new JsonSerializerOptions()
{
    Converters = { new JsonStringEnumConverter() },
    WriteIndented = true
};
string json = JsonSerializer.Serialize(myObject, options);
var obj = JsonSerializer.Deserialize<MyType>(json, options);
```

Obs: `JsonStringEnumConverter` permite que enums sejam serializados como nome ("Processing") em vez de inteiro.

---

### ✅ Tópicos adicionais recomendados (encontrados no código)

Pelo conteúdo das pastas e exemplos no repositório, recomendo incluir pequenas notas/links para estes tópicos em **Tópicos Avançados** ou no índice:

- **LINQ** (ex.: `System.Linq` aparece em vários exercícios) — exemplos de `Where`, `Select`, `Sum`, `FirstOrDefault`.
- **async/await + HttpClient** (há exemplos de `HttpClient` e métodos `async Task` em `web_scrapping`) — boas práticas e tratamento de exceções.
- **Serialização JSON** (usado/consultado em exemplos e `System.Text.Json`) — exemplificar `JsonSerializer` e `JsonStringEnumConverter`.
- **Exceções e tratamento (`try/catch`)** — padrão para entradas inválidas e validações.
- **Delegates / Events / Lambda expressions** — ensino rápido e exemplos práticos, se houver material nos projetos.
- **Extension methods / Records / Pattern matching** — conceitos modernos do C# para atualizar conteúdo.
- **Top-level statements / Global usings** (projetos usam recursos modernos do .NET 6+/9) — breve nota explicativa.

> 💡 Sugestão: posso incluir seções curtas com exemplos e links para os projetos que já demonstram esses conceitos.

<a id="estrutura-do-repositorio"></a>

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
│   └── EnumeracoesDotnet/  # Exemplo prático de uso de enums
├── Dicas/               # Dicas, padrões e estruturas de projetos
│   └── EstruturaProjeto/  # Estrutura padrão profissional de projetos .NET
├── README.md            # Este arquivo
└── Documentação.md      # Documentação adicional
```

---

<a id="dicas-de-projeto-e-estrutura"></a>

## 💡 Dicas de Projeto e Estrutura

### 🏗️ Como Estruturar um Projeto .NET/C#

Se você está começando um novo projeto e quer saber **como organizar o código**, temos um guia completo na pasta `Dicas/EstruturaProjeto/`.

#### ⚡ Resumo Rápido

Um projeto profissional em C# segue a **Clean Architecture** com 4 camadas principais:

```
┌─────────────────────────────────┐
│   Presentation (API/Web)        │  ← Controllers, endpoints
├─────────────────────────────────┤
│   Application (Orquestração)    │  ← Services, DTOs
├─────────────────────────────────┤
│   Domain (Lógica de Negócio)    │  ← Entidades, Interfaces
├─────────────────────────────────┤
│   Infrastructure (Persistência) │  ← Banco, Repositórios
└─────────────────────────────────┘
```

#### 📚 O que cada camada faz?

| Camada | Responsabilidade | Exemplo |
|---|---|---|
| **Domain** | Lógica pura de negócio | `User.IsValid()` |
| **Application** | Coordena fluxos | `UserService.CreateUserAsync()` |
| **Infrastructure** | Persistência e dados | `UserRepository.AddAsync()` |
| **Presentation** | Interface com usuário | `UserController` (API) |

#### 🔗 Fluxo de uma Requisição

```
Cliente HTTP
    ↓
[Controller] ← POST /users (CreateUserDto)
    ↓
[Service] ← Valida e coordena
    ↓
[Repository] ← Persiste no banco
    ↓
[Database] ← INSERT
    ↓
[Response] → JSON ao cliente
```

---

### 📁 Explicação Detalhada de Cada Pasta

#### 🔴 **src/** - Código-Fonte Principal

A pasta `src/` contém **todo o código de produção** da sua aplicação. É aqui que você coloca as 4 camadas da arquitetura.

```
src/
├── Domain/              # Coração da aplicação
├── Application/         # Orquestração de negócio
├── Infrastructure/      # Acesso a dados
└── Presentation/        # Interface com usuário
```

---

#### 🎯 **src/Domain/** - Núcleo de Negócio

**Para quê serve?** Aqui fica a **lógica pura de negócio**, independente de banco de dados, web frameworks ou qualquer coisa técnica.

**O que vai aqui:**
- ✔ **Models** - Entidades de domínio (User, Product, Order)
- ✔ **Interfaces** - Contratos que outras camadas implementam
- ✔ Validações de negócio
- ✔ Enums e tipos de valor

**Exemplo:**

```csharp
// src/Domain/Models/User.cs
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    // Validação de domínio - regra de negócio pura
    public bool IsValid()
    {
        return !string.IsNullOrEmpty(Name) && 
               !string.IsNullOrEmpty(Email) && 
               Email.Contains("@");
    }
}
```

**Por que separar?**
- Domain **não depende de nada** → Pode ser testado facilmente
- Se mudar o banco de dados, Domain não é afetado
- Reutilizável em diferentes contextos (Web API, Console, Desktop)

---

#### 📋 **src/Domain/Models/** - Entidades

**Para quê serve?** Armazena as **classes que representam conceitos do seu negócio**.

**Exemplo de pastas:**

```
src/Domain/Models/
├── User.cs           # Usuário do sistema
├── Product.cs        # Produto à venda
├── Order.cs          # Pedido de compra
└── Payment.cs        # Pagamento
```

Cada arquivo `Models/XYZ.cs` representa uma **entidade importante** do seu domínio.

---

#### 🔗 **src/Domain/Interfaces/** - Contratos

**Para quê serve?** Define **interfaces** que serão implementadas por outras camadas (sem criar dependência).

**Exemplo:**

```csharp
// src/Domain/Interfaces/IUserRepository.cs
public interface IUserRepository
{
    Task<User> GetByIdAsync(int id);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
}
```

**Por que usar interfaces?**
- Desacopla as camadas
- Facilita testes (pode mockar a interface)
- Permite trocar a implementação sem mexer em Domain

---

#### 🟡 **src/Application/** - Orquestração de Negócio

**Para quê serve?** Coordena entre Domain e Infrastructure. É aqui que você coloca a **lógica de fluxo da aplicação**.

```
src/
├── Domain/              # Coração da aplicação
├── Application/         # Orquestração de negócio
├── Infrastructure/      # Acesso a dados
└── Presentation/        # Interface com usuário
```

---

#### 📤 **src/Application/Services/** - Casos de Uso

**Para quê serve?** Aqui você implementa a **lógica de cada funcionalidade**.

```
src/Application/Services/
├── UserService.cs          # Criar, buscar, atualizar usuários
├── ProductService.cs       # Gerenciar produtos
├── OrderService.cs         # Processar pedidos
└── PaymentService.cs       # Processar pagamentos
```

**Responsabilidades:**
- ✔ Orquestrar chamadas entre Domain e Infrastructure
- ✔ Validar dados de entrada
- ✔ Converter DTOs em entidades de domínio
- ✔ Implementar lógica de negócio complexa

---

#### 📦 **src/Application/DTOs/** - Transferência de Dados

**Para quê serve?** Define as **estruturas de dados** que trafegam entre camadas, sem expor as entidades de domínio.

```csharp
// src/Application/DTOs/UserDto.cs

// Input - o que a API recebe
public class CreateUserDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

// Output - o que a API retorna
public class UserResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

**Por que usar DTOs?**
- Não expõe a entidade de domínio (segurança)
- Diferencia dados de entrada (create) de saída (response)
- Permite serializar/desserializar corretamente

---

#### 🟢 **src/Infrastructure/** - Implementação Técnica

**Para quê serve?** Implementa os detalhes técnicos: banco de dados, APIs externas, arquivos, cache, etc.

```
src/Infrastructure/
├── Data/               # Configuração de banco de dados
└── Repositories/       # Implementação do padrão Repository
```

---

#### 💾 **src/Infrastructure/Data/** - Persistência

**Para quê serve?** Configurar **como os dados são armazenados** (SQL, NoSQL, arquivos, etc).

```csharp
// src/Infrastructure/Data/AppDbContext.cs
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("connection-string");
    }
}
```

**Aqui você coloca:**
- ✔ Entity Framework DbContext
- ✔ Migrations (versionamento de schema)
- ✔ Configurações de banco

---

#### 📚 **src/Infrastructure/Repositories/** - Acesso a Dados

**Para quê serve?** Implementar a interface de repositório definida em Domain, **isolando a lógica de persistência**.

```csharp
// src/Infrastructure/Repositories/UserRepository.cs
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<User> GetByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    
    public async Task AddAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}
```

**Vantagem:**
- Se trocar de SQL para MongoDB, **apenas este arquivo muda**
- Domain continua igual
- Application continua igual
- Apenas a implementação técnica muda

---

#### 🔵 **src/Presentation/** - Interface com Usuário

**Para quê serve?** Receber requisições HTTP (ou UI Desktop) e delegá-las para Application.

```
src/Presentation/
└── Controllers/        # Endpoints da API REST
```

---

#### 🎮 **src/Presentation/Controllers/** - Endpoints da API

**Para quê serve?** Definir os **endpoints HTTP** que o cliente consome.

```csharp
// src/Presentation/Controllers/UserController.cs
[ApiController]
[Route("api/[controller]")]
public class UserController
{
    private readonly UserService _userService;
    
    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserDto dto)
    {
        try
        {
            var result = await _userService.CreateUserAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _userService.GetUserAsync(id);
        return Ok(result);
    }
}
```

**Responsabilidades:**
- ✔ Receber requisições HTTP
- ✔ Validar formato (JSON, headers)
- ✔ Chamar Services
- ✔ Retornar respostas HTTP corretas

---

#### 🧪 **tests/** - Testes Automatizados

**Para quê serve?** Garantir que o código funciona corretamente.

```
tests/
├── Unit/               # Testa partes isoladas
└── Integration/        # Testa fluxos completos
```

---

#### ✅ **tests/Unit/** - Testes Unitários

**Para quê serve?** Testar **uma única classe ou método** isoladamente, sem dependências externas.

```csharp
// tests/Unit/UserServiceTests.cs
public class UserServiceTests
{
    [Fact]
    public async Task CreateUser_WithValidData_ReturnsUserDto()
    {
        // Arrange - preparar
        var mockRepository = new Mock<IUserRepository>();
        var service = new UserService(mockRepository.Object);
        var dto = new CreateUserDto 
        { 
            Name = "João", 
            Email = "joao@example.com", 
            Password = "123456" 
        };

        // Act - executar
        var result = await service.CreateUserAsync(dto);

        // Assert - verificar
        Assert.NotNull(result);
        Assert.Equal("João", result.Name);
    }
}
```

**Características:**
- ✔ Testa lógica de uma classe
- ✔ Usa Mocks para isolar dependências
- ✔ Rápido de executar
- ✔ Deve passar 100% das vezes

---

#### 🔗 **tests/Integration/** - Testes de Integração

**Para quê serve?** Testar **fluxos completos**, com banco de dados real, API real, etc.

```csharp
// tests/Integration/UserControllerTests.cs
public class UserControllerIntegrationTests
{
    [Fact]
    public async Task CreateUser_WithRealDatabase_SavesUser()
    {
        // Arrange - criar banco de dados em memória
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("test-db")
            .Options;
        
        using (var context = new AppDbContext(options))
        {
            var repository = new UserRepository(context);
            var service = new UserService(repository);
            var controller = new UserController(service);
            
            // Act - enviar requisição
            var result = await controller.Create(new CreateUserDto
            {
                Name = "João",
                Email = "joao@example.com",
                Password = "123456"
            });
            
            // Assert - verificar se foi salvo no banco
            var savedUser = await context.Users.FirstOrDefaultAsync(u => u.Email == "joao@example.com");
            Assert.NotNull(savedUser);
            Assert.Equal("João", savedUser.Name);
        }
    }
}
```

---

#### 📖 Exemplo Prático

Na pasta `Dicas/EstruturaProjeto/` você encontra:

- **Arquivos de exemplo** em cada camada:
  - `src/Domain/Models/User.cs` - Entidade
  - `src/Application/Services/UserService.cs` - Service
  - `src/Infrastructure/Repositories/UserRepository.cs` - Repository
  - `src/Presentation/Controllers/UserController.cs` - API
  - `tests/Unit/UserServiceTests.cs` - Testes

- **README.md completo** explicando:
  - O que é cada camada
  - Por que separar responsabilidades
  - Padrões de design (Repository, Dependency Injection)
  - Boas práticas

#### 🚀 Próximas Vezes que Criar um Projeto

1. Crie a estrutura de pastas (veja a pasta `Dicas/EstruturaProjeto/`)
2. Comece pela camada **Domain** (entidades e interfaces)
3. Implemente a camada **Infrastructure** (repositories)
4. Crie a camada **Application** (services)
5. Finalize com a camada **Presentation** (controllers)
6. Adicione testes na pasta `tests/`

---

<a id="ferramentas-recomendadas"></a>

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

1. **Comece pelos conceitos fundamentais** → Leia a seção [Conceitos Fundamentais](#conceitos-fundamentais)
2. **Explore os exercícios** → Veja as pastas em `Exercicios/`
3. **Estude os projetos** → Projetos maiores em `Projetos/`
4. **Clone e pratique** → Rode os exemplos localmente
5. **Aprofunde em tópicos** → Leia as seções [Tópicos Avançados](#-tópicos-avançados)

---

<a id="sobre-o-autor"></a>

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
