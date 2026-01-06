using EnumeracoesDotnet.Entities;
using EnumeracoesDotnet.Entities.Enums;

namespace EnumeracoesDotnet
{
    public class Program
    {
        static void Main()
        {
            //Variavel do Tipo DateTime para Pegar o Momento da Compra
            DateTime HoraProduto = DateTime.Now;
            //Criar o Produto
            Order Product = new Order(1, HoraProduto);
            //Imprimir o Produto na Tela
            Console.WriteLine(Product);
            // Exemplo: enum -> string
            string text = OrderStatus.Processing.ToString();
            Console.WriteLine(text);

            // Exemplo: string -> enum (usar TryParse em cenários reais)
            if (Enum.TryParse<OrderStatus>("Delivered", out var os))
            {
                Console.WriteLine(os);
            }


        }
    }
}
