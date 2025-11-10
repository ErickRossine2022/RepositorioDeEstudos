using System.Threading;

class Carregando
{
    //Metodo de Carregamento com porcentagem
    public static void LoadingSystem(int number, int frameDelay, bool clearAfter = false)
    {
        //Array Mostrando como vai ficar o Efeito de Carregamento
        string[] anim = { "/", "-", "\\", "|" };

        //Vai Pegar o Total de Repetições do Loop for
        int total = number;

        //Iniciar Loop for
        for (int i = 0; i <= total; i++)
        {
            //Pegar os Efeitos do Array e fazer com ele gire de Acordo com as Repetições
            string LoadSimbol = anim[i % anim.Length];
            Console.Write($"\rCarregando [{LoadSimbol}] {i}%"); //imprimir o carregamento com a Porcentagem
            Thread.Sleep(frameDelay + (i / 10)); //colocar um dalay entre os frame suave
        }
        
        if(clearAfter) //Limpar o Console opcional
        {
            Console.Clear();
        }
        Console.WriteLine("\nCarregado com Sucesso..");
    }

    //Metodo de Carregamento Simples
    public static void LoadingSystemSimple(int number, int frameDelay, bool clearAfter = false)
    {
        //Array Mostrando como vai ficar o Efeito de Carregamento
        string[] anim = { "/", "-", "\\", "|" };
        
        //Loop
        for (int i = 0; i < number; i++)
        {
            //Imprimir Carregamento
            Console.Write($"\r[{anim[i % anim.Length]}]");
            Thread.Sleep(frameDelay + (i / 10)); //colocar um dalay entre os frame suave
        }

        if(clearAfter)
        {
            Console.Clear();
        }
        Console.WriteLine("\nCarregado com Sucesso..");
    }
}