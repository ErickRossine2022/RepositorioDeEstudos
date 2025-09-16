namespace EstruturaCondicinalExercicio5
{
    class Program
    {
        static void Main()
        {
            //Exercicio Condicional If Else #1
            Console.Write("Digite um Número Inteiro: ");
            int numberinter = int.Parse(Console.ReadLine());

            if (numberinter < 0)
            {
                Console.WriteLine(numberinter);
                Console.WriteLine("Número Negativo!");
            }
            else if (numberinter >= 0)
            {
                Console.WriteLine(numberinter);
                Console.WriteLine("Número Positivo");
            }

            //Exercicio Condicional If Else #2

            Console.Write("Digite um Número Inteiro: ");

            int numberinter2 = int.Parse(Console.ReadLine());

            if (numberinter2 % 2 == 0)
            {
                Console.WriteLine("Pár");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            //Exercicio Condicional If Else #3
                    
            Console.Write("Digite um Número Inteiro: ");

            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite outro Número Inteiro: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            //Exercicio Condicional If Else #4

            Console.Write("Que Hora Começa o Jogo: ");
            int HoraInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite Hora Final do Jogo: ");
            int HoraFinal = int.Parse(Console.ReadLine());

            if (HoraFinal > HoraInicial)
            {
                int result = HoraFinal - HoraInicial;
                Console.WriteLine($"o jogo Durou {result} horas");
            }
            else if (HoraFinal < HoraInicial)
            {
                int result2 = (24 - HoraInicial) + HoraFinal;
                Console.WriteLine($"o Jogo Durou {result2} horas");
            }
            else
            {
                Console.WriteLine("o Jogo Durou 24 horas");
            }
        }
    }
}