using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main()
        {
            double resultado = 0;

            //Exemplo de Vectores do Tipo Struct o tipo Valor

            Console.Clear();
            Console.WriteLine("Entre com um numero: ");
            int input = int.Parse(Console.ReadLine() ?? "Bloco Vazio");

            double[] vect = new double[input];

            Console.WriteLine("Digite 3 numeros Double: ");

            for (int i = 0; i < input; i++)
            {
                vect[i] = double.Parse(Console.ReadLine() ?? "Bloco Vazio", CultureInfo.InvariantCulture);
            }

            for (int d = 0; d < vect.Length; d++)
            {
                Console.WriteLine($"Nùmero: {vect[d]}");
            }

            for (int c = 0; c < vect.Length; c++)
            {
                resultado += vect[c];
            }

            resultado = resultado / vect.Length;          
            Console.WriteLine($"Resultado da Media: {resultado.ToString("f2", CultureInfo.InstalledUICulture)}");
            
            Console.WriteLine("\nAperte 'ENTER' ou Qualquer Tecla Para Continuar!");
            Console.ReadLine();
            Console.Clear();

            //Exemplo de Vector do Tipo Classe o Tipo Referencia

            //Perguntar o Numero De Produtos que terá no Array
            Console.WriteLine("Entre com um numero: ");
            //Ler o Input como Inteiro
            int input2 = int.Parse(Console.ReadLine() ?? "Bloco Vazio");

            //Declarar a Variavel Product do tipo VetoresClass
            VetoresClass product;

            //Instanciar o Objeto do tipo array string e array double
            product = new (new string[input2], new double[input2]); 

            //Mandar o Usuario Digitar o Nome dos Produtos
            Console.WriteLine($"Digite o Nome de {input2} produtos: ");

            //Repetir o Loop até o Usuario Colocar todos os nomes
            for (int e = 0; e < product.VectorName.Length; e++)
            {
                product.VectorName[e] = Console.ReadLine() ?? "Vazio";
            }
            
            //Limpar Console
            Console.WriteLine("\nAperte 'ENTER' ou Qualquer Tecla Para Continuar!");
            Console.ReadLine();
            Console.Clear();

            //Mostrar nome de produtos
            foreach (var f in product.VectorName)
            {
                Console.WriteLine($"Nome do Produto: {f}");
            }
            
            Console.WriteLine("");

            //Mandar o Usuario Digitar o preço dos Produtos
            Console.WriteLine($"Digite o preço de {input2} produtos: ");

            //Repetir o Loop Até o Usuario Digitar o Preço de todos os produtos
            for (int G = 0; G < product.VectorDouble.Length; G++)
            {
                product.VectorDouble[G] = double.Parse(Console.ReadLine() ?? "Bloco Vazio", CultureInfo.InvariantCulture);
            }

            //Limpa o Console
            for (int i = 0; i < product.VectorName.Length; i++)
            {
                Console.WriteLine($"Nome do Produto: {product.VectorName[i]}\t\tPreço Produto: {product.VectorDouble[i].ToString("f2", CultureInfo.InvariantCulture)} reais");
            }

            Console.WriteLine("");

            //Calcular Media
            resultado = 0; // Resetar resultado para calcular a nova média
            for (int k = 0; k < product.VectorDouble.Length; k++)
            {
                resultado += product.VectorDouble[k];
            }
            //Mostrar a media dos produtos
            resultado = resultado / product.VectorDouble.Length;
            Console.WriteLine($"Media de Preço: {resultado.ToString("f2", CultureInfo.InvariantCulture)} reais");
        }
    }
}
