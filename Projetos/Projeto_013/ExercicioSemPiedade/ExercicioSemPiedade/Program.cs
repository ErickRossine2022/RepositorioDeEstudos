namespace ExercicioSemPiedade
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Quantas Linhas Sua Matriz vai ter?: ");
            int M = int.Parse(Console.ReadLine() ?? "Nada Digitado");

            Console.WriteLine("Quantas Colunas Sua Matriz vai ter?: ");
            int N = int.Parse(Console.ReadLine() ?? "Nada Digitado");

            int[,] mat = new int[M, N];

            //Pegar os Valores das Linhas e Colunas
            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int Mateu = 0; Mateu < N; Mateu++)
                {
                    mat[i, Mateu] = int.Parse(values[Mateu]);
                }
            }

            //Perguntar um dos Numeros Que tem dentro da matriz
            Console.WriteLine("Digite Numero X da Matriz: ");
            int X = int.Parse(Console.ReadLine() ?? "Nada Digitado");


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(mat[i, j] == X)
                    {
                        if(j > 0)
                        {
                            Console.WriteLine($"Valor de X a Esquerda: {mat[i, j - 1 ]}");
                        }
                        else
                        {
                            Console.WriteLine("a X Esquerda não Existe");
                        }
                        if(j < N -1)
                        {
                            Console.WriteLine($"Valor de X a Direita {mat[i, j + 1]}");
                        }
                        else
                        {
                            Console.WriteLine("a X Direita não Existe");
                        }

                        if(i > 0)
                        {
                            Console.WriteLine($"Valor de X a Cima {mat[i - 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("o X Acima não Existe");
                        }
                        if(i < M - 1)
                        {
                            Console.WriteLine($"Valor de X a Baixo {mat[i + 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("o X Abaxo não Existe");
                        }
                    }
                }
            }
        }
    }
}


//Console.WriteLine($"Valor de X a Esquerda: {mat[i, j - 1 ]}\tValor de X a Direita {mat[i, j + 1]}\tValor de X a Cima {mat[i - 1, j]}\tValor de X a Baixo {mat[i + 1, j]}");