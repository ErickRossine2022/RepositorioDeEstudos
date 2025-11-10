using System.Globalization;
using System.Reflection.Emit;
class Produtos
{

    public string? ProdutoNome;
    public double ValorProduto;
    public int QuantidadeP;

    //Construtor 
    public Produtos(string? produtonome, double valorproduto, int quantidadep)
    {
        ProdutoNome = produtonome;
        ValorProduto = valorproduto;
        QuantidadeP = quantidadep;
    }

    public double ValorTotal()
    {
        return ValorProduto * QuantidadeP;
    }

    //Metodos do Programa abaixo

    public int AdicionarQuantidade(int Quantidade)
    {
        return QuantidadeP += Quantidade;
    }

    public int RemoverQuantidade(int Quantidade)
    {
        return QuantidadeP -= Quantidade;
    }

    public override string ToString()
    {
        return "Nome do Produto: " + ProdutoNome + " Valor: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) + " Total Stock: " + QuantidadeP;
    }
}