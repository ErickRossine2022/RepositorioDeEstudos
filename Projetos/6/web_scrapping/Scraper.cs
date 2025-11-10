class Scraper
{

    public string UrlParse { get; set; }
    public Scraper(string Url) //pegar o url da Pagina
    {
        UrlParse = Url ?? throw new ArgumentNullException(nameof(Url));
    }

    public override string ToString()
    {
        return UrlParse ?? "Por Favor Caro Senhor Coloque um URL Valido";
        
    }
}