using System.Globalization;
namespace EcapslumentoThis;

public class Produtos
{
    /*
       *                📘 Explicações sobre Atributos, Variáveis e Encapsulamento
       *
       * Encapsulamento serve para esconder os detalhes internos de uma classe, deixando
       * visível apenas o que é necessário para o resto do programa.
       *
       * Exemplo:
       *
       * private string ProdutoNome { get; set; }
       * Significa que apenas a própria classe pode modificar ou ler o valor de ProdutoNome.
       *
       * public string ProdutoNome { get; set; }
       * Significa que qualquer outra parte do programa pode ler e modificar o valor.
       *
       * Caso eu queira permitir que outras partes do programa apenas leiam (mas não alterem)
       * o valor, posso fazer assim:
       *
       * public string ProdutoNome { get; private set; }
       *
       * Dessa forma, ProdutoNome pode ser lido por outras classes, mas só pode ser alterado
       * dentro da própria classe. Isso ajuda a manter o controle e a segurança dos dados.
       *
       * --------------------------------------------------------
       *                🔹 Explicações sobre a palavra "this"
       * --------------------------------------------------------
       *
       * A palavra "this" serve como ponto de referência para os membros da própria classe.
       * Ela pode ser usada para se referir a atributos, métodos ou construtores.
       *
       * 🔸 Quando usada para diferenciar atributos de variáveis locais:
       *
       * Se você tiver os seguintes atributos:
       *
       * public string Nome;      // Atributo 1
       * public int Quantidade;   // Atributo 2
       * public double Valor;     // Atributo 3
       *
       * E um construtor assim:
       *
       * public Produto(string Nome, int Quantidade)
       * {
       *     this.Nome = Nome;             // Atributo Nome recebe o valor do parâmetro Nome
       *     this.Quantidade = Quantidade; // Atributo Quantidade recebe o valor do parâmetro Quantidade
       * }
       *
       * Aqui o "this" indica que estamos nos referindo ao atributo da classe e não à variável local.
       *
       * 🔸 O "this" também pode ser usado para chamar outro construtor da mesma classe:
       *
       * Exemplo:
       *
       * public Produtos() // Construtor padrão
       * {
       *     this.Quantidade = 0; // Define o valor padrão
       * }
       *
       * public Produtos(string Nome, double Valor) : this()
       * {
       *     this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
       *     this.Valor = Valor;
       * }
       *
       * Nesse exemplo, o segundo construtor chama o primeiro usando ": this()".
       * Isso faz com que o valor padrão da Quantidade definido no construtor anterior também seja aplicado.
       *
       * 🔸 Podemos continuar essa cadeia com um terceiro construtor:
       *
       * public Produtos(string Nome, double Valor, int Quantidade) : this(Nome, Valor)
       * {
       *     this.Quantidade = Quantidade;
       * }
       *
       * Assim, o terceiro construtor aproveita os valores do segundo (Nome e Valor)
       * e apenas atualiza a Quantidade, evitando repetição de código.
       *
       * --------------------------------------------------------
       *                ✅ Conclusão
       * --------------------------------------------------------
       *
       * ➤ Encapsulamento: protege os dados e controla o acesso.
       * ➤ Sobrecarga de construtores: permite criar vários construtores com diferentes comportamentos.
       * ➤ "this": referencia membros da própria classe (atributos, métodos, construtores).
       * 
     */

    
    //Atributos
    public string? Productname { get; private set; }
    private double ValueProduct { get; set; }
    private int QuantityProduct { get; set; }
    
    
    //Iniciar o Construtor Padrão com Quantidade Zerada
    public Produtos() //Construtor Padrão
    {
        QuantityProduct = 0;
    }
    
    //Construtor com 2 paramentros e receber também o Valor de Quantidade do Construtor padrão
    public Produtos(string? namep, double valor) : this()
    {
        Productname = namep ?? throw new ArgumentNullException(nameof(namep));
        ValueProduct = valor;
    }
    
    //Construtor com 3 paramentros nesse construtor pega o valor do Construtor com 2 paramentros
    //e Incrementa o Valor que o Usuario digitar no paramentro na Execução do programa
    public Produtos(string? namep, double valor, int quantidade) : this(namep, valor)
    {
        QuantityProduct = quantidade;
    }
    
    
    //Metodo que Calcula Valor Total do Produto
    public double ValorTotal()
    {
        return ValueProduct * QuantityProduct;
    }
    
    //Metodo que Adiciona Produtos no meu Objeto
    public int AdicionarQuantidade(int quantidade)
    {
        return QuantityProduct += quantidade;
    }
    
    //Metodo que Remove Produtos no meu Objeto
    public int RemoverQuantidade(int quantidade)
    {
        return QuantityProduct -= quantidade;
    }
    
    public override string ToString()
    {
        return "Nome do Produto: " + Productname + " Valor: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) + " Total Stock: " + QuantityProduct + " Reais";
    }
}