using System.Globalization;

namespace TiposValorEreferencia
{
    class Produto
    {
        //Atributos
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        //Construtor
        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        //Metodos
        public int AddQuantidade(int quantidade)
        {
            return Quantidade += quantidade;          
        }

        public int RemoverQuantidade(int quantidade)
        {
            return Quantidade -= quantidade;
        }

        public double ValorTotal(double valor)
        {   
            double resultado = Quantidade * valor;
            return resultado;
        }

        public override string ToString()
        {
            return "Nome Produto: " + Nome + " " +
            "Quantidade do Produto: " + Quantidade + " " +
            "Valor Total: " + ValorTotal(Valor).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}