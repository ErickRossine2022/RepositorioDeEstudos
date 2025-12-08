using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        //Variaveis Iniciais do Programa
        string? lerTexto;
        bool sucesso;

        //Pedir URL
        do
        {
            Console.WriteLine("===============================================\n");
            Console.Write("Digite uma URl: \n");
            Console.WriteLine("\n===============================================");

            lerTexto = Console.ReadLine();

            sucesso = !string.IsNullOrWhiteSpace(lerTexto);

            if(!sucesso)
            {
                Console.WriteLine("Você não colocou uma URL Corretamente Tente Novamente!");
            }

        } while (!sucesso);

        //instanciar o meu Construtor 

        if(lerTexto == null)
        {
            throw new ArgumentNullException(nameof(lerTexto));
        }
        
        Scraper UrlObject = new (lerTexto);

        HttpClient client = new();
        string html = await client.GetStringAsync(UrlObject.UrlParse);
        HtmlParser parser = new(html);


        parser.MostrarExemploDeDados();

    }
}