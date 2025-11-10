🖥️ Aprendizado em C#

Este repositório contém exercícios e práticas de estudo em C#, voltados para aprender os conceitos de Programação Orientada a Objetos (POO) e lógica de programação.

Aqui você encontrará explicações de:

🏷️ Classes

💾 Atributos / Variáveis

⚙️ Construtores

📝 Métodos

🗂️ Listas

📚 Conceitos Básicos de C#
1️⃣ Classes 📦

Uma classe é um modelo que define objetos e seu comportamento.

Pode conter atributos (variáveis), métodos (funções) e construtores.

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


💡 Dica: A classe é como um molde. Cada objeto criado a partir dela será uma instância dessa classe.

2️⃣ Atributos (Variáveis) 💾

public → acessível de qualquer lugar do programa

private → acessível apenas dentro da própria classe

static → pertence à classe, não a uma instância específica

readonly → só pode ser definido no momento da criação ou no construtor

private static readonly List<Pessoa> pessoas = new List<Pessoa>();

3️⃣ Construtores ⚙️

Método especial que inicializa os objetos da classe

Pode receber parâmetros e validar valores

public Pessoa(string nome, int idade)
{
    Nome = nome ?? throw new ArgumentNullException(nameof(nome));
    this.idade = idade;
}


💡 Dica: this.atributo diferencia o atributo da classe do parâmetro.

4️⃣ Métodos 📝

Funções definidas dentro de uma classe

Podem ser públicos, privados, estáticos ou não

Permitem que objetos executem ações

Exemplo de sobrescrita do método ToString():

public override string ToString()
{
    return $"Nome: {Nome}, Idade: {idade}";
}


💡 Dica: Console.WriteLine(objeto) automaticamente chama ToString() do objeto.

5️⃣ Listas 🗂️

Estrutura que armazena múltiplos objetos do mesmo tipo

Inicializando uma lista:

List<Pessoa> pessoas = new List<Pessoa>();


Adicionando objetos à lista:

pessoas.Add(new Pessoa("Alice", 25));


Percorrendo a lista:

foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p);
}


💡 Dica: Para imprimir todos os itens da lista, use o foreach.

🎯 Objetivo do Repositório

Registrar meu aprendizado em C#

Compartilhar exercícios e práticas com outros estudantes

Consolidar conceitos de POO e lógica de programação

🛠️ Ferramentas Recomendadas

VSCode + extensão C# Kit Dev

.NET SDK e Runtime instalados

Sistema operacional: Linux ou Windows

🙏 Agradecimento

Obrigado por visitar este repositório!
💻 Criado por Blank1ll The Dev Ou se Preferir Erick Rossine
Blank1ll the dev é meu nome no discord

canal do youtube : https://www.youtube.com/@erickd7s
grupo do discord : https://discord.gg/sfUSVgvdrV
