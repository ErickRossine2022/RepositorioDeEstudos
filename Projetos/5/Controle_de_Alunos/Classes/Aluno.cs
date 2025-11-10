class Aluno
{
    public string? nome;
    public int idade;
    public double nota;
   

    //Metodo Para Calcular Media da Nota 
    public double NotaMedia(double notaMaxima)
    {
        return nota / notaMaxima;
    }

    //Metodo que Calcula Nota e Verifica se o Aluno Passou

    public string Validacao()
    {
        if (NotaMedia(10) < 0.6)
        {
            return "O aluno repetiu de ano.";
        } 
        else
        {
            return "O aluno passou de ano!";
        }
        
    }

   public override string ToString()
    {
        return $"Nome do Aluno: {nome} | Nota Média: {NotaMedia(10):P0}";
    }

    
}