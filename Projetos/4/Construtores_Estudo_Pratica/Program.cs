using System.Globalization;

class Program
{
    static void Main()
    {
        string? nomep;
        string? lerTexto;

        double ValorP;
        int Quantidade;

        bool sucesso;

        do
        {
            //dados do Produto
            Console.WriteLine("Entre o nome do Produto: ");
            nomep = Console.ReadLine();

            //Verificar se o Produto Name está vazio ou Em Branco 
            sucesso = !string.IsNullOrWhiteSpace(nomep);

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
            sucesso = double.TryParse(lerTexto, out ValorP);

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

            sucesso = int.TryParse(lerTexto, out Quantidade);

            if(!sucesso)
            {
                Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                Console.WriteLine("não digite textos e pro preferencia nem numeros double");
            }

        } while (!sucesso);

        //===========================================================================

        //Minha Explicação:
        //Instanciar Construtor com Paramentros
        //o Construtor ele vem somente no momento da instanciação do objeto
        //O construtor é chamado automaticamente no momento da criação do objeto 
        // e serve para definir os valores iniciais de seus atributos.
        //com isso ele é usado para Inicializar Atributos de uma Classe
        //Como esse construtor pega dados de um Objeto Chamado Produto
        //ele vai pegar o nome o valor e a quantidade de produtos 

        //===========================================================================
        //Explicação do Chat GPT:
        //O construtor é chamado automaticamente no momento da criação do objeto 
        //============================================================================

        Produtos produto = new(nomep, ValorP, Quantidade);

        //===========================================================================
        
        //Minha Explicação:
        //em Seguida Exibir o Objeto Produto com o Metodo ToString
        //Contendo os dados do Objeto 
        //o Metodo ToString de uma Classe serve para renomear o string que vem por padrão
        //no Metodo ToString ou seja o propio nome da Classe
        //Apos o Metodo ser Modificado ele pode ser usado para exbir dados da Classe
        //Como Metodos e Atributos

        //===========================================================================

        //===========================================================================
        //Explicação do Chat GPT:
        //O ToString(): personaliza a forma como o objeto é mostrado como texto.
        //===========================================================================
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

                sucesso = int.TryParse(lerTexto, out Quantidade);

                if(!sucesso)
                {
                    Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                    Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                    Console.WriteLine("não digite textos e pro preferencia nem numeros double");
                }

            } while (!sucesso);

            produto.RemoverQuantidade(Quantidade);
            Console.WriteLine(produto);
        }
        else
        {
            Console.WriteLine("Você não quis remover nenhum produto!");
        }

        //Perguntar se o Usuario Deseja Adicionar Produtos
        do
        {
            Console.WriteLine("Deseja Adicionar Algum Produto? (SIM/NÂO): ");
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

                sucesso = int.TryParse(lerTexto, out Quantidade);

                if(!sucesso)
                {
                    Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                    Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                    Console.WriteLine("não digite textos e pro preferencia nem numeros double");
                }

            } while (!sucesso);

            produto.AdicionarQuantidade(Quantidade);
            Console.WriteLine(produto);
        }
        else
        {
            Console.WriteLine("Você não quis Adicionar nenhum produto!");
            return;
        }

    }
}