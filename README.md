🖥️ Aprendizado em C#

Este repositório contém exercícios e práticas de estudo em C#, voltados para aprendizado da linguagem e desenvolvimento de conceitos de programação orientada a objetos. Aqui você encontrará explicações sobre classes, métodos, atributos, construtores, listas e outros conceitos básicos de C#, aplicáveis a qualquer projeto.

🔹 Conceitos Básicos de C#
1️⃣ Classes 📦

Uma classe é um modelo que define objetos e seu comportamento.

Classes podem conter atributos (variáveis), métodos (funções) e construtores.

Exemplo genérico de uma classe:

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

2️⃣ Atributos (Variáveis) 💾

public → acessível de qualquer lugar do programa.

private → acessível apenas dentro da própria classe.

static → pertence à classe, não a uma instância específica.

readonly → valor definido apenas na inicialização ou no construtor.

Exemplo:

private static readonly List<Pessoa> pessoas = new List<Pessoa>();

3️⃣ Construtores ⚙️

Método especial que inicializa os objetos da classe.

Pode receber parâmetros e validar valores.

public Pessoa(string nome, int idade)
{
    Nome = nome ?? throw new ArgumentNullException(nameof(nome));
    this.idade = idade;
}


💡 Dica: Você pode usar this.atributo para diferenciar o atributo da classe do parâmetro do construtor.

4️⃣ Métodos 📝

Funções definidas dentro de uma classe que executam ações.

Podem ser públicos, privados, estáticos ou não.

Exemplo de sobrescrita do método ToString():

public override string ToString()
{
    return $"Nome: {Nome}, Idade: {idade}";
}

5️⃣ Listas 🗂️

Estrutura para armazenar múltiplos objetos do mesmo tipo.

Declarando e inicializando uma lista:

List<Pessoa> pessoas = new List<Pessoa>();


Adicionando objetos à lista:

pessoas.Add(new Pessoa("Alice", 25));


Percorrendo todos os itens da lista:

foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p);
}


💡 Dica: Console.WriteLine(p) chama o método ToString() de cada objeto.

🔹 Objetivo do Repositório

Registrar meu aprendizado em C#

Compartilhar exercícios e práticas com outros estudantes

Consolidar conceitos de POO (Programação Orientada a Objetos) e lógica de programação

🔹 Ferramentas Recomendadas 🛠️

VSCode + extensão C# Kit Dev

.NET SDK e Runtime instalados

Sistema operacional: Linux ou Windows

🔹 Agradecimento 🙏

Obrigado por visitar este repositório!
💻 Criado por Blank1ll The Dev
