# 🖥️ Aprendizado em C#

Este repositório contém **exercícios e práticas de estudo em C#**, voltados para aprender os conceitos de **Programação Orientada a Objetos (POO)** e **lógica de programação**.

---

## 📚 Índice

1. [📘 Conceitos Básicos de C#](#-conceitos-básicos-de-c)
    - [🏷️ Classes](#️-classes)
    - [💾 Atributos / Variáveis](#-atributos--variáveis)
    - [⚙️ Construtores](#️-construtores)
    - [📝 Métodos](#-métodos)
    - [🗂️ Listas](#️-listas)
2. [🎯 Objetivo do Repositório](#-objetivo-do-repositório)
3. [🛠️ Ferramentas Recomendadas](#️-ferramentas-recomendadas)
4. [🙏 Agradecimento](#-agradecimento)
5. [📗 Palavra `this` e Sobrecarga (Overloading)](#-documentação-sobre-a-palavra-this-e-sobrecarga)

---

## 📘 Conceitos Básicos de C#

### 🏷️ Classes 📦

Uma **classe** é um modelo que define objetos e seus comportamentos.  
Ela pode conter **atributos** (variáveis), **métodos** (funções) e **construtores**.

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

    // Método público
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
    }
}
```

💡 **Dica:** A classe é como um molde.  
Cada objeto criado a partir dela será uma **instância dessa classe**.

---

### 💾 Atributos / Variáveis

- `public` → acessível de qualquer lugar do programa
- `private` → acessível apenas dentro da própria classe
- `static` → pertence à classe, não a uma instância específica
- `readonly` → só pode ser definido no momento da criação ou no construtor

```csharp
private static readonly List<Pessoa> pessoas = new List<Pessoa>();
```

---

### ⚙️ Construtores

Métodos especiais usados para **inicializar objetos**.

```csharp
public Pessoa(string nome, int idade)
{
    Nome = nome ?? throw new ArgumentNullException(nameof(nome));
    this.idade = idade;
}
```

💡 **Dica:** `this.atributo` diferencia o atributo da classe do parâmetro recebido.

---

### 📝 Métodos

Funções definidas dentro de uma classe.  
Podem ser **públicos**, **privados**, **estáticos** ou não.

Exemplo de sobrescrita do método `ToString()`:

```csharp
public override string ToString()
{
    return $"Nome: {Nome}, Idade: {idade}";
}
```

💡 **Dica:** `Console.WriteLine(objeto)` automaticamente chama o método `ToString()` do objeto.

---

### 🗂️ Listas

Estrutura que **armazena múltiplos objetos** do mesmo tipo.

```csharp
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new Pessoa("Alice", 25));

foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p);
}
```

💡 **Dica:** Use o `foreach` para percorrer e exibir todos os elementos da lista.

---

## 🎯 Objetivo do Repositório

✔️ Registrar meu aprendizado em **C#**  
✔️ Compartilhar exercícios e práticas com outros estudantes  
✔️ Consolidar conceitos de **POO** e **lógica de programação**

---

## 🛠️ Ferramentas Recomendadas

- **Editor:** VSCode + extensão *C# Kit Dev*
- **Framework:** .NET SDK e Runtime
- **Sistema Operacional:** Linux ou Windows

---

## 🙏 Agradecimento

Obrigado por visitar este repositório! ❤️

💻 **Criado por:** *Blank1ll The Dev* (Erick Rossine)  
🪪 Discord: **Blank1ll the dev**  
📺 YouTube: [@erickd7s](https://www.youtube.com/@erickd7s)  
💬 Grupo Discord: [Entrar no servidor](https://discord.gg/sfUSVgvdrV)

---

# 📗 Documentação sobre a Palavra `this` e Sobrecarga

**Pequena Documentação Autoexplicativa para o Repositório de Estudos — Blank1ll The Dev / Erick Rossine**

---

## 🔹 O que é a palavra `this` no C#

### 1️⃣ Referência ao próprio objeto

A palavra **`this`** é uma referência para o **próprio objeto da classe**.  
Usamos `this` para distinguir o que é **atributo da classe** do que é **variável local** (parâmetro de método ou construtor).

---

### 2️⃣ Referenciar um construtor dentro de outro construtor

`this` também pode ser usado para **chamar outro construtor** da mesma classe, ajudando a **reutilizar código** e **evitar duplicação**.

---

### 3️⃣ Passar o próprio objeto como argumento

Permite **passar o próprio objeto como parâmetro** em métodos ou construtores, o que é útil em **callbacks**, **eventos** e **gerenciamento de objetos**.

---

## 💡 Exemplo — Diferenciando atributos de variáveis locais

```csharp
public class Produto
{
    public string Nome;
    public int Quantidade;

    public Produto(string Nome, int Quantidade)
    {
        this.Nome = Nome;
        this.Quantidade = Quantidade;
    }
}
```

---

## 🎗️ Exemplo — Referenciar um construtor dentro de outro

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

---

## 🚀 Exemplo — Passar o próprio objeto como argumento

```csharp
public class Produto
{
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void RegistrarEmEstoque(Estoque estoque)
    {
        estoque.AdicionarProduto(this);
    }
}

public class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque.");
    }
}
```

---

## 🔸 Sobrecarga (Overloading)

A **sobrecarga** ocorre quando criamos **métodos ou construtores com o mesmo nome**, mas com **parâmetros diferentes** (tipo, quantidade ou ordem).  
Isso permite **várias formas de executar a mesma ação**.

---

### 💡 Por que usar Sobrecarga?

- Código mais **limpo** e **legível**
- Evita métodos com nomes confusos
- Facilita **personalização de inicialização**

---

### Exemplo — Sobrecarga de Construtores

```csharp
public class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome) { Nome = nome; Idade = 0; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Pessoa() : this("Sem nome", 0) { }
}
```

---

### Exemplo — Sobrecarga de Métodos

```csharp
public class Calculadora
{
    public int Somar(int a, int b) => a + b;
    public double Somar(double a, double b) => a + b;
    public int Somar(int a, int b, int c) => a + b + c;
}
```

---

### 🧩 Combinação de `this` + Sobrecarga

```csharp
public class Jogador
{
    public string Nome;
    public int Vida;
    public int Forca;

    public Jogador(string nome) : this(nome, 100, 10) { }
    public Jogador(string nome, int vida) : this(nome, vida, 10) { }
    public Jogador(string nome, int vida, int forca)
    {
        Nome = nome;
        Vida = vida;
        Forca = forca;
    }
}
```

---

✍️ **Autor:** Erick Rossine *(Blank1ll The Dev)*  
📅 **Estudo sobre:** Palavra `this` e Sobrecarga em C#
