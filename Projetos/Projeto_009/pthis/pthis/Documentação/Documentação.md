# 📘 Documentação sobre a Palavra `this` e Sobrecarga
**Pequena Documentação Autoexplicativa para o Repositório de Estudos — Blank1ll The Dev / Erick Rossine**

---

## 🔹 O que é a palavra `this` no C#

### 1. Referência ao próprio objeto
A palavra **`this`** é uma referência para o **próprio objeto** da classe.  
O uso mais comum é **diferenciar atributos de variáveis locais**, algo muito utilizado em linguagens como **Java**, onde se segue o padrão *camelCase* — começando atributos com letra minúscula.

Dessa forma, usamos `this` com frequência para distinguir o que é **um atributo da classe** do que é **uma variável local** de um método ou construtor.

---

### 2. Referenciar um construtor dentro de outro construtor
A palavra `this` também pode ser usada para **chamar outro construtor** da mesma classe.  
Isso ajuda a **reutilizar código** e **evitar duplicação** de lógica de inicialização.

---

### 3. Passar o próprio objeto como argumento
Além disso, `this` pode ser usado para **passar o próprio objeto** como argumento em uma **chamada de método ou construtor**, permitindo que outro método ou classe tenha acesso direto à instância atual.

---

## 💡 Exemplo — Diferenciando atributos de variáveis locais

```csharp
public class Produto
{
    // Declarar os atributos da classe
    public string Nome;
    public int Quantidade;
    
    // Criar o construtor com variáveis locais
    // caso tenham o mesmo nome dos atributos
    public Produto(string Nome, int Quantidade)
    {
        // Aqui indicamos ao compilador que queremos
        // atribuir os valores recebidos aos atributos da classe
        this.Nome = Nome;
        this.Quantidade = Quantidade;
    }
}
```

No C#, essa situação é menos comum, pois adotamos um padrão de nomenclatura diferente (usando letras minúsculas para parâmetros e maiúsculas para atributos), o que evita a necessidade constante de usar `this`.

---

## 🎗️ Exemplo — Referenciar um construtor dentro de outro construtor

```csharp
public class Produto
{
    // Declarar os atributos da classe
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    // Construtor padrão com Quantidade = 0
    public Produto()
    {
        Quantidade = 0;
    }
    
    // Segundo construtor com dois parâmetros (nome e preço)
    // Reaproveita o construtor padrão com : this()
    public Produto(string nome, double preco) : this()
    {
        Nome = nome;
        Preco = preco;
    }
    
    // Terceiro construtor com três parâmetros
    // Reaproveita o construtor anterior usando : this(nome, preco)
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
}
```

Ou seja, dessa forma evitamos repetição de código e deixamos a classe mais organizada.

---

## 🚀 Exemplo — Passar o próprio objeto como argumento

```csharp
// Exemplo de passar o próprio objeto como argumento usando `this`

public class Produto
{
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Produto: {Nome} - Preço: {Preco}");
    }

    // Método que passa o próprio objeto como argumento
    public void RegistrarEmEstoque(Estoque estoque)
    {
        // Passa a instância atual (o próprio objeto) para outro método
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

// Uso:
// Produto p = new Produto("Caneta", 2.5);
// Estoque e = new Estoque();
// p.RegistrarEmEstoque(e);
```

Usar `this` para passar o próprio objeto é útil quando outra classe precisa manipular, registrar ou processar a instância atual.  
Também é comum em callbacks, eventos ou sistemas de gerenciamento de objetos.

---

## 🔸 Conceito de Sobrecarga (Overloading)

A **Sobrecarga (Overloading)** ocorre quando criamos **vários métodos ou construtores com o mesmo nome**, desde que tenham **assinaturas diferentes** — ou seja, parâmetros com tipos, quantidades ou ordens diferentes.  
Isso permite oferecer **múltiplas formas de executar a mesma ação**, deixando o código mais limpo e intuitivo.

### 💡 Por que usar Sobrecarga?
- Deixa o código mais legível (mesmo nome para ações relacionadas).
- Facilita a criação de métodos com diferentes quantidades de parâmetros.
- Evita nomes confusos como `SomarInteiro`, `SomarDouble`, etc.

---

### Exemplo — Sobrecarga de Construtores

```csharp
public class Pessoa
{
    public string Nome;
    public int Idade;

    // Construtor básico
    public Pessoa(string nome)
    {
        Nome = nome;
        Idade = 0; // valor padrão
    }

    // Construtor sobrecarregado (número de parâmetros diferente)
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Outro exemplo: chamando outro construtor com this(...)
    public Pessoa() : this("Sem nome", 0)
    {
    }
}
```

---

### Exemplo — Sobrecarga de Métodos

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}

// Uso:
// Calculadora calc = new Calculadora();
// calc.Somar(1, 2);       // chama versão int
// calc.Somar(1.0, 2.0);   // chama versão double
// calc.Somar(1, 2, 3);    // chama versão com 3 parâmetros
```

O compilador escolhe automaticamente a versão correta com base nos **tipos** e **quantidade** de parâmetros.

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

Chamando `new Jogador("Erick")`, o construtor reutiliza os valores padrão de vida e força através do uso do `this(...)`, evitando duplicação de código.

---

✍️ **Autor:** Erick Rossine (Blank1ll The Dev)  
📅 **Estudo sobre:** Palavra `this` e Sobrecarga em C#
