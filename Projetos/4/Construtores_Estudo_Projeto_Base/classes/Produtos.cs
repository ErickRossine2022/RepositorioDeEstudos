using System.Globalization;
class Produtos
{

    public string? ProdutoNome;
    public double ValorProduto;
    public int QuantidadeP;

    public double ValorTotal()
    {
        return ValorProduto * QuantidadeP;
    }

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