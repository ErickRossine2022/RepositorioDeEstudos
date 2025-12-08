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

2. **[Tópicos Avançados](#-tópicos-avançados)**
   - [Palavra `this` e Referenciais](#-palavra-this-e-referenciais)
   - [Sobrecarga (Overloading)](#️-sobrecarga-overloading)
   - [Classes vs Structs](#-classe-vs-struct)
   - [Tipos Valor e Referência](#-tipos-valor-vs-tipos-referência)
   - [Garbage Collector](#-garbage-collector)

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
