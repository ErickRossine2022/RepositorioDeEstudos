namespace EcapslumentoThis;

class Program
{
    //Iniciar uma Lista Vazia de Produtos
    private static readonly List<Produtos> Listaproduto = [];
        
    static void Main()
    {
        //declarar umas variaveis aqui para leitura e validação de dados
        string? lername;
        string? lerprice;
        string? lerquantity;
        string? lerinput;
        
        //variaveis para converter valores do tipo string com o seu tipo int ou double
        int quantity;
        double priceproduct;
        
        //variavel boleana para repetir pergunta caso seja nescessario
        bool sucesso;
        
        
        //Pergunta do Nome
        do
        {
            //dados do Produto
            Console.WriteLine("Entre o nome do Produto: ");
            lername = Console.ReadLine();

            //Verificar se o Produto Name está vazio ou Em Branco 
            sucesso = !string.IsNullOrWhiteSpace(lername);

            //Menssagem de Erro
            if(!sucesso)
            {
                Console.WriteLine("Você Digitou o Nome do Produto Errado Tente Novamente!");
                Console.WriteLine("Usando por Exemplo: [Sapatos] ");
                Console.WriteLine("Não deixe Apenas Espaços ou em Branco nem digite Primeiro Numeros no Produto!");
            }

        } while (!sucesso); //Repetir o Pergunta
        
        
        //Pergunta do Valor
        do
        {
            //Perguntar o Valor do Produto
            Console.Write("Valor do Produto: ");
            lerprice = Console.ReadLine();

            //Tentar Converter lerTexto para um Numero Double
            sucesso = double.TryParse(lerprice, out priceproduct);

            //passar a Menssagem de erro ao Usuario caso não consiga
            if(!sucesso)
            {
                Console.WriteLine("Você não digitou o Valor Corretamente Tente Novamente!");
                Console.WriteLine("Digite por Exemplo: [50,00] ou [50.00]");
                Console.WriteLine("Não Digite Textos");
            }

        } while (!sucesso); //repetir a Pergunta
        
        //Perguntada da Quantidade
        do
        {
            Console.Write("Quantidade de Produtos: ");
            lerquantity = Console.ReadLine();

            sucesso = int.TryParse(lerquantity, out quantity);

            if(!sucesso)
            {
                Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                Console.WriteLine("não digite textos e pro preferencia nem numeros double");
            }

        } while (!sucesso);
        
        //Adicionar um Novo Produto a Lista Produtos
        Listaproduto.Add(new Produtos(lername, priceproduct, quantity));
        
        //Fazer um Loop de leitura pecorrer toda minha linha lista
        //e imprimir no Console.WriteLine
        foreach (var p in Listaproduto)
        {
            Console.WriteLine(p);
        }
        
        
        //Estrutura Baixo Para Remover Produtos
        //o Usuario determina se remove ou não produtos

        do
        {
            Console.WriteLine("Deseja Remover Algum Produto? (SIM/NÂO): ");
            lerinput = Console.ReadLine();

            sucesso = !string.IsNullOrWhiteSpace(lerinput);

            if(!sucesso)
            {
                Console.WriteLine("Você não escolheu uma Opção Corretamente Tente Novamente!");
                Console.WriteLine("Digite por Exemplo: Sim ou Não");
            }

        } while (!sucesso);

        if(lerinput == "sim")
        {
            //Perguntar Quantidade de Produtos a Serem Removidos
            do
            {
                Console.Write("Quantidade de Produtos: ");
                lerquantity = Console.ReadLine();

                sucesso = int.TryParse(lerquantity, out quantity);

                if(!sucesso)
                {
                    Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                    Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                    Console.WriteLine("não digite textos e pro preferencia nem numeros double");
                }

            } while (!sucesso);
            
            //Fazer um Loop de leitura pecorrer toda minha linha lista
            //verificar se o nome do produto existe na lista caso exista ele remove 
            //a Quantidade digitada no Console.WriteLine();
            //e depois imprimi no Console.WriteLine a Lista de Produtos
            foreach (var p in Listaproduto)
            {
                if (p.Productname == lername)
                {
                    p.RemoverQuantidade(quantity);
                }
                Console.WriteLine(p);
            }
        }
        else
        {
            Console.WriteLine("Você não quis remover nenhum produto!");
            return;
        }
        
        //Estrutura Baixo Para Adicionar Produtos
        //o Usuario determina se adiciona ou não produtos

        do
        {
            Console.WriteLine("Deseja Adicionar Algum Produto? (SIM/NÂO): ");
            lerinput = Console.ReadLine();

            sucesso = !string.IsNullOrWhiteSpace(lerinput);

            if(!sucesso)
            {
                Console.WriteLine("Você não escolheu uma Opção Corretamente Tente Novamente!");
                Console.WriteLine("Digite por Exemplo: Sim ou Não");
            }

        } while (!sucesso);
        
        if(lerinput == "sim")
        {
            //Perguntar Quantidade de Produtos a Serem Removidos
            do
            {
                Console.Write("Quantidade de Produtos: ");
                lerquantity = Console.ReadLine();

                sucesso = int.TryParse(lerquantity, out quantity);

                if(!sucesso)
                {
                    Console.WriteLine("Você não digitou a Quantidade Corretamente!");
                    Console.WriteLine("Digite por Exemplo: [1, 2, 3, 4, 5, etc...]");
                    Console.WriteLine("não digite textos e pro preferencia nem numeros double");
                }

            } while (!sucesso);
            
            //Fazer um Loop de leitura pecorrer toda minha linha lista
            //verificar se o nome do produto existe na lista caso exista ele Adiciona 
            //a Quantidade digitada no Console.WriteLine();
            //e depois imprimi no Console.WriteLine a Lista de Produtos
            foreach (var p in Listaproduto)
            {
                if (p.Productname == lername)
                {
                    p.AdicionarQuantidade(quantity);
                }
                Console.WriteLine(p);
            }
        }
        else
        {
            Console.WriteLine("Você não quis remover nenhum produto!");
        }
    }
}




