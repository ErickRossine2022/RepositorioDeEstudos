namespace ExecicioVetores
{
    class Program
    {
        static void Main()
        {
            Percionistas p;
            Console.Clear();
            Console.WriteLine("Digite o Numero de Quartos: ");
            int room = int.Parse(Console.ReadLine() ?? "Vazio");

            p = new (new string[room], new string[room], new int[room], new double[room]);

            Console.WriteLine("");
            Console.WriteLine("Digite o Nome de 3 pessoas: ");
            Console.WriteLine("Digite o Email de 3 Pessoas: ");

            //Array com os Preço 
            
            for (int petitionername = 0; petitionername < 3; petitionername++)
            {
                p.PetitionerName[petitionername * 2] = Console.ReadLine() ?? "Vazio";
                p.Email[petitionername * 2] = Console.ReadLine() ?? "Vazio";              
            }

            Console.WriteLine(p);
            Console.WriteLine($"\nValor medio dos quarto: {p.GetAveragePrice()} reais");
        
        }
    }
}