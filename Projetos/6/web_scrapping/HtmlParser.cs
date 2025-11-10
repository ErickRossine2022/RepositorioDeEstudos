using HtmlAgilityPack;
using Microsoft.VisualBasic;

class HtmlParser
{
    private string HTML { get; set; }

    private HtmlDocument Document { get; set; }

    // 1️⃣ Construtor recebe o HTML cru
    public HtmlParser(string html)
    {
        HTML = html ?? throw new ArgumentNullException(nameof(html));

        // 2️⃣ Cria o objeto do HtmlAgilityPack e carrega o HTML
        Document = new HtmlDocument();
        Document.LoadHtml(HTML);
    }

    // 3️⃣ Exemplo de método que mostra como pegar dados do HTML
    public void MostrarExemploDeDados()
    {
        // Busca todos os elementos com a classe "eael-restaurant-menu-content"
        var nodes = Document.DocumentNode.SelectNodes("//div[@class='eael-restaurant-menu-content']");

        if (nodes == null)
        {
            Console.WriteLine("Nenhum item encontrado no HTML!");
            return;
        }

        foreach (var node in nodes)
        {
            // Pega o nome do prato
            var nome = node.SelectSingleNode(".//span[@class='eael-restaurant-menu-title-text']")?.InnerText?.Trim();

            // Pega a descrição
            var descricao = node.SelectSingleNode(".//div[@class='eael-restaurant-menu-description']")?.InnerText?.Trim();

            // Pega o preço
            var preco = node.SelectSingleNode(".//span[@class='eael-restaurant-menu-price-discount']")?.InnerText?.Trim();

            Console.WriteLine($"Prato: {nome}");
            Console.WriteLine($"Descrição: {descricao}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine("------------------------------------");
        }
    }
}