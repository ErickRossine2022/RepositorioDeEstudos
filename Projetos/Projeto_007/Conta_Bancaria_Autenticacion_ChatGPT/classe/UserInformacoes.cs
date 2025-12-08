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
        // Procurar se já existe um usuário com o nome digitado
        User? usuarioExistente = usuarios.FirstOrDefault(u => u.Nome == nomeu);

        // Caso o usuário já exista → processo de autenticação
        if (usuarioExistente != null)
        {
            do
            {
                Console.WriteLine("Você já tem conta em nosso sistema.");
                Console.WriteLine("Deseja carregar suas informações?");
                Console.WriteLine("Digite (sim/não): ");
                Opcao = Console.ReadLine()?.Trim().ToLower();

                sucesso = !string.IsNullOrWhiteSpace(Opcao);

                if (!sucesso)
                {
                    Console.WriteLine("Você deixou o campo opção nulo ou com espaço. Tente novamente!");
                    continue;
                }

                if (Opcao != "sim" && Opcao != "não")
                {
                    Console.WriteLine("Você não digitou corretamente (sim/não). Tente novamente!");
                    sucesso = false;
                    continue;
                }

                if (Opcao.Any(char.IsDigit))
                {
                    Console.WriteLine("Você não pode colocar número como opção.");
                    sucesso = false;
                    continue;
                }

                if (nomeu == "RotMart")
                {
                    Console.Clear();
                    Console.WriteLine("Esse usuário é apenas um usuário de teste. Tente novamente!");
                    sucesso = false;
                    continue;
                }

            } while (!sucesso);

            if (Opcao == "sim")
            {
                Console.WriteLine("====================== | Informações do Usuário | ====================");
                Console.WriteLine(usuarioExistente);
                Console.WriteLine("======================================================================");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você preferiu não ver as informações do usuário.");
            }

            return;
        }

        // Caso o usuário não exista → processo de registro
        do
        {
            Console.WriteLine("Você não tem uma conta registrada.");
            Console.WriteLine("Deseja se registrar no nosso banco?");
            Console.WriteLine("Digite (sim/não): ");

            Opcao = Console.ReadLine()?.Trim().ToLower();
            sucesso = !string.IsNullOrWhiteSpace(Opcao);

            if (!sucesso)
            {
                Console.WriteLine("Você deixou o campo opção nulo ou com espaço. Tente novamente!");
                continue;
            }

            if (Opcao != "sim" && Opcao != "não")
            {
                Console.WriteLine("Você não digitou corretamente (sim/não). Tente novamente!");
                sucesso = false;
                continue;
            }

            if (Opcao.Any(char.IsDigit))
            {
                Console.WriteLine("Você não pode colocar número como opção.");
                sucesso = false;
                continue;
            }

            if (nomeu == "RotMart")
            {
                Console.WriteLine("Esse usuário é apenas um usuário de teste. Tente novamente!");
                sucesso = false;
                continue;
            }

        } while (!sucesso);

        if (Opcao == "não")
        {
            Console.WriteLine("Ok, encerrando operação.");
            return;
        }

        // Registro do novo usuário
        do
        {
            Console.WriteLine("Digite sua senha: ");
            passWord = Console.ReadLine();

            sucesso = !string.IsNullOrWhiteSpace(passWord);

            if (!sucesso)
            {
                Console.WriteLine("Você não digitou uma senha válida! Tente novamente!");
            }

        } while (!sucesso);

        do
        {
            Console.WriteLine("Digite seu CPF: ");
            Cppf = Console.ReadLine();

            sucesso = double.TryParse(Cppf, NumberStyles.Any, CultureInfo.InvariantCulture, out CPF);

            if (!sucesso)
            {
                Console.WriteLine("Você não digitou um CPF válido! Tente novamente!");
            }

        } while (!sucesso);

        // Adiciona novo usuário com segurança (fora do foreach)
        usuarios.Add(new User(nomeu, passWord, CPF));

        Console.WriteLine("====================== | Usuário Registrado | ====================");
        Console.WriteLine($"Nome: {nomeu}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine("==================================================================\n");
    }


    public static void MostrarTodosUsuarios() //caso eu queira mostrar todos usuarios
    {
        foreach (var users in usuarios)
        {
            Console.WriteLine(users);
        }
    }
}