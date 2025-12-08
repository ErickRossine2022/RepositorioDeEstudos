using System.Globalization;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static readonly double pi = 3.14;
    static void Main()
    {
        double raio;
        double circ;
        double volume;
        string? lerTexto;
        bool sucesso;

        //repetir a Pergunta quando a pergunta for falsa
        do
        {
            //Pergunta
            Console.Write("Entre com o Valor do Raio: \n");

            //Ler Qualquer Coisa que o Usuario Digitar
            lerTexto = Console.ReadLine();

            //Tentar Converter String Para Double 
            //a Partir de LerTexto depois pegar o numero double
            //e Ler ele com o Pontinho
            //e passar o valor para a Variavel Raio
            sucesso = double.TryParse(lerTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out raio);

            //se for falso alem de repetir a pergunta vem menssagem de aviso
            if(!sucesso)
            {
                Console.WriteLine("Você não digitou um Numero Double Tente Novamente ");
            }

        } while (!sucesso);

        //Imprimir no Console o Valor Raio com um Pontinho
        Console.WriteLine($"Raio: {raio.ToString("F1",CultureInfo.InvariantCulture)}");
        //Pegar Circunferencia do Raio
        circ = Circunferencia(raio);
        //Imprimir CircunFêrencia do Raio
        Console.WriteLine($"Circunfêrencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        //Pegar o Volume do Raio
        volume = Volume(raio);
        //Imprimir o Volume
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        //Imprimir o Pi também
        Console.WriteLine($"PI: {pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    //Metodo Statico que Calcula a CircunFêrencia
    static double Circunferencia(double valor)
    {
        return 2.0 * pi * valor;
    }

    //Metodo Statico do Volume do Raio
    static double Volume(double valor)
    {
        return  4.0 / 3.0 * pi * Math.Pow(valor, 3.0);
    }
}