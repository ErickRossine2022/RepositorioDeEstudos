using System.Globalization;

class Program
{
    static void Main()
    {
        Produtos produto = new();

        string? lerTexto;

        int Quantidadepr;

        bool sucesso;

        do
        {
            //dados do Produto
            Console.WriteLine("Entre o nome do Produto: ");
            produto.ProdutoNome = Console.ReadLine();

            //Verificar se o Produto Name está vazio ou Em Branco 
            sucesso = !string.IsNullOrWhiteSpace(produto.ProdutoNome);

            //Menssagem de Erro
            if(!sucesso)
            {
                Console.WriteLine("Você Digitou o Nome do Produto Errado Tente Novamente!");
                Console.WriteLine("Usando por Exemplo: [Sapatos] ");
                Console.WriteLine("Não deixe Apenas Espaços ou em Branco nem digite Primeiro Numeros no Produto!");
            }

        } while (!sucesso); //Repetir o Pergunta

        do
        {
            //Perguntar o Valor do Produto
            Console.Write("Valor do Produto: ");
            lerTexto = Console.ReadLine();

            //Tentar Converter lerTexto para um Numero Double
            sucesso = double.TryParse(lerTexto, out produto.ValorProduto);

            //passar a Menssagem de erro ao Usuario caso não consiga
            if(!sucesso)
            {
                Console.WriteLine("Você não digitou o Valor Corretamente Tente Novamente!");
                Console.WriteLine("Digite por Exemplo: [50,00] ou [50.00]");
                Console.WriteLine("Não Digite Textos");
            }

        } while (!sucesso); //repetir a Pergunta

        do
        {
            Console.Write("Quantidade de Produtos: ");
            lerTexto = Console.ReadLine();

            sucesso = int.TryParse(lerTexto, out produto.QuantidadeP);

            if(!sucesso)
            {
                Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                Console.WriteLine("não digite textos e pro preferencia nem numeros double");
            }

        } while (!sucesso);

        Console.WriteLine(produto);

        //Estrutura Baixo Para Remover Produtos
        //o Usuario determina se remove ou não produtos

        do
        {
            Console.WriteLine("Deseja Remover Algum Produto? (SIM/NÂO): ");
            lerTexto = Console.ReadLine();

            sucesso = !string.IsNullOrWhiteSpace(lerTexto);

            if(!sucesso)
            {
                Console.WriteLine("Você não escolheu uma Opção Corretamente Tente Novamente!");
                Console.WriteLine("Digite por Exemplo: Sim ou Não");
            }

        } while (!sucesso);

        if(lerTexto == "sim")
        {
            do
            {
                
                Console.Write("Quantidade de Produtos: ");
                lerTexto = Console.ReadLine();

                sucesso = int.TryParse(lerTexto, out Quantidadepr);

                if(!sucesso)
                {
                    Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                    Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                    Console.WriteLine("não digite textos e pro preferencia nem numeros double");
                }

            } while (!sucesso);

            produto.RemoverQuantidade(Quantidadepr);
            Console.WriteLine(produto);
        }
        else
        {
            Console.WriteLine("Você não quis remover nenhum produto!");
            return;
        }

    }
}