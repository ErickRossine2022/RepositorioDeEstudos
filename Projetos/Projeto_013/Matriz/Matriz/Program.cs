namespace Matriz
{
    class Program
    {
        static void Main()
        {
            /*
                double[,] mat = new double[2, 3];
                quantos elementos a matriz tem
                Console.WriteLine(mat.Length);
                quanto tem a primeira dimensão da matriz
                ou seja quantas linhas tem
                Console.WriteLine(mat.Rank);
                perguntar sobre quantas dimensões tem alguma matriz
                ou seja quantas colunas tem uma matriz especifica
                Console.WriteLine(mat.GetLength(0));
            */

            Console.WriteLine("Digite um Numero: ");
            int n = int.Parse(Console.ReadLine() ?? "Nenhum Numero Digitado");

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os Valores das Linhas: ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; i++)
                {
                    Console.WriteLine("Digite os Valores das Colunas: ");
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");   
            }
            Console.WriteLine("");

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        count ++;
                    }
                }
            }
            Console.WriteLine($"Negative Numbers: {count}");
        
        }
    }
}