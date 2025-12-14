namespace Listas
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();


            Console.Clear();
            Console.WriteLine("Digite primero nome: ");
            string readname = Console.ReadLine() ?? "";

            Console.WriteLine("Digite segundo nome: ");
            string readname2 = Console.ReadLine() ?? "";

            Console.WriteLine("Digite terceiro nome: ");
            string readnam3 = Console.ReadLine() ?? "";

            names.Add(readname);
            names.Add(readname2);
            names.Add(readnam3);

            foreach (var nomeid in names)
            {
                Console.WriteLine($"Nome : {nomeid}");
            }

            Console.WriteLine($"List count: {names.Count}");
        }
    }
}