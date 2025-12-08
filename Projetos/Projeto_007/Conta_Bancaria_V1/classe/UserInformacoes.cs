using System.Globalization;

class UserInformacoes
{

    //Ler minha Lista usuario
    public static readonly List<User> usuarios = 
    [
        new User("RotMart", "os123", 1234343535)
    ];
    

    //Exemplo de como adicionar um usuario
    //usuarios.Add("Nome Usuario", "Senha Usuario", "CPF");

    //Declarar Variavel para pegar o Nome do Usuario
    private string? nomeu;

    //Declarar Variavel para pegar a Senha do Usuario

    private string? passWord;

    //Declarar Variavel para Pegar o CPF
    private string? Cppf;

    //Declarar Variavel De Repetição da Pergunta
    private bool sucesso;
        
    //Declarar Variavel que Verifica se o Usuario Pressionou Sim ou Não
    private string? Opcao;

    private double CPF;

    
    //Metodo que Começa o Sistema
    public  void Sistema()
    {
        //Repetir Pergunta se o Nome for Nullo ou tiver espaço
        do
        {
            //Pergunta o nome
            Console.WriteLine("Digite seu nome: ");
            nomeu = Console.ReadLine(); //ler oque o usuario escreveu

            sucesso = !string.IsNullOrWhiteSpace(nomeu);

            if (!string.IsNullOrWhiteSpace(nomeu) && char.IsDigit(nomeu[0]))
            {
                Console.WriteLine("\nVocê não pode Colocar numero como Opção\n");
                sucesso = false;
            }
            //Verificar se o usuario deixou em branco ou com espaço o nome
            if(!sucesso)
            {
                //Enviar Menssagem de Erro
                Console.WriteLine("Você não digitou o Nome Corretamente Tente Novamente!");
            }


        } while (!sucesso);
        

        //Verificar se o Usuario está registrado
        //ou seja verificar se meu nome está na lista de usuarios
        Autenticacao();
    }

    public void Autenticacao()
    {
        //Pecorrer toda a lista usuarios
        foreach (User u in usuarios)
        {   
            //Verificar se o Atributo Nome do Meu Objeto User é igual
            //ao nome digitado no Console.WriteLine e Lido com ReadLine
            if(u.Nome == nomeu)
            {
                //Do While para repetir pergunta
                do
                {
                    //Caso o nome digitando no Console.WriteLine
                    //seja igual ao atributo nome da minha classe User
                    //ele vai fala que o nome ja está registrado
                    //ou seja ja tem conta no sistema
                    //perguntar se quer exibir informações do usuario
                    Console.WriteLine("Você ja tem Conta em Nosso Sistema");
                    Console.WriteLine("Deseja Carregar Suas Infomrações?");
                    Console.WriteLine("Digite (Sim/Não) : ");

                    //a Variavel opção vai ler o Console.ReadLine
                    Opcao = Console.ReadLine();

                    //aqui ele vai basicamente Verificar se o usuario Digitou alguma coisa
                    //e ver se a Variavel Opcao está preenchida com um texto ou se o usuario
                    //deixou em branco ou espaço
                    sucesso = !string.IsNullOrWhiteSpace(Opcao);

                    //aqui vai retornar um erro se deixar nullo ou com espaço
                    if(!sucesso)
                    {
                        Console.WriteLine("Você deixou o Campo Opção Nulo ou Com Espaço");
                        Console.WriteLine("Tente Novamente e Selecione a Opção (Sim/Não)");
                    }

                    //Garantir que o Usuario só digita sim ou Não
                    if(Opcao != "sim" && Opcao != "não")
                    {
                        Console.WriteLine("Você não digitou corretamente (Sim/Não)");
                        Console.WriteLine("se digitou algo diferente por favor Tente Novamente! ");
                        sucesso = false;
                        
                    }
                    else if (Opcao.Any(char.IsDigit)) //Impedir que o usuario digite numeros onde é pra ser string 
                    {
                        Console.WriteLine("\nVocê não pode Colocar numero como Opção\n");
                        sucesso = false;
                    }
                    
                    if(nomeu == "RotMart") //caso digite RotMart retornar erro falando que é um usuario de teste
                    {
                        Console.Clear();
                        Console.WriteLine("esse usuario é apenas um usuario de teste");
                        Console.WriteLine("Tente Novamente!");
                        Console.WriteLine("Digite Outro Nome por Exemplo (seuUsuario): ");
                        sucesso = false;
                    }


                } while (!sucesso);
                
                if(Opcao == "sim") //caso o usuario queira ver suas informações imprimir elas
                {
                    
                    Console.WriteLine(u);
                    Console.WriteLine(Opcao);
                    return;
                }
                else if(Opcao == "não") //caso ocontrario terminar o programa
                {
                    Console.Clear();
                    Console.WriteLine("Você preferiu não ver as informações de usuario");
                    return;
                }
                
                
            }
            else
            {
                //Registro
                do
                {
                    Console.WriteLine("Você não tem uma Conta Registrada");
                    Console.WriteLine("Deseja se Registrar no Nosso Banco!");
                    Console.WriteLine("Digite (Sim/Não) : ");

                    Opcao = Console.ReadLine();

                    sucesso = !string.IsNullOrWhiteSpace(Opcao);

                    if(!sucesso)
                    {
                        Console.WriteLine("Você deixou o Campo Opção Nulo ou Com Espaço");
                        Console.WriteLine("Tente Novamente e Selecione a Opção (Sim/Não)");
                    }

                    //Garantir que o Usuario só digita sim ou Não
                    if(Opcao != "sim" && Opcao != "não")
                    {
                        Console.WriteLine("Você não digitou corretamente (Sim/Não)");
                        Console.WriteLine("se digitou algo diferente por favor Tente Novamente! ");
                        sucesso = false;

                    }
                    else if (Opcao.Any(char.IsDigit)) //Impedir que o usuario digite numeros onde é pra ser string 
                    {
                        Console.WriteLine("\nVocê não pode Colocar numero como Opção\n");
                        sucesso = false;
                    }
                    if(nomeu == "RotMart")
                    {
                        Console.WriteLine("esse usuario é apenas um usuario de teste");
                        Console.WriteLine("Tente Novamente!");
                        Console.WriteLine("Digite Outro Nome por Exemplo (seuUsuario): ");
                        sucesso = false;
                    }

                } while (!sucesso);

                if(Opcao == "sim")
                {
                    do
                    {
                        //Perguntar Senha
                        Console.WriteLine("Digite sua senha: ");
                        passWord = Console.ReadLine(); //ler oque o usuario escreveu

                        sucesso = !string.IsNullOrWhiteSpace(passWord);

                        //Verificar se o usuario deixou em branco ou com espaço o nome
                        if(!sucesso)
                        {
                            //Enviar Menssagem de Erro
                            Console.WriteLine("Você não digitou uma senha Valida! Tente Novamente!");
                        }


                    } while (!sucesso);


                    //Repetir Pergunta do CPF  
                    do
                    {
                        //Pergunta o nome
                        Console.WriteLine("Digite sua CPF: ");
                        Cppf = Console.ReadLine(); //ler oque o usuario escreveu

                        sucesso = double.TryParse(Cppf, NumberStyles.Any, CultureInfo.InvariantCulture, out CPF);

                        //Verificar se o usuario deixou em branco ou com espaço o nome
                        if(!sucesso)
                        {
                            //Enviar Menssagem de Erro
                            Console.WriteLine("Você não digitou um CPF Valido Tente Novamente!");
                        }

                    } while (!sucesso);

                    usuarios.Add(new User(nomeu, passWord, CPF));
                }

                Console.WriteLine("====================== | Usuario Registrado | ====================");
                Console.WriteLine(u);
                Console.WriteLine(Opcao);
                Console.WriteLine("==================================================================\n");
            }
        }
    }

    public static void MostrarTodosUsuarios() //caso eu queira mostrar todos usuarios
    {
        foreach (var users in usuarios)
        {
            Console.WriteLine(users);
        }
    }
}