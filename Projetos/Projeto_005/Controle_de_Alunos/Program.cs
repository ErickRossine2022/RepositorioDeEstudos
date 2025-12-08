class Program
{
    static void Main()
    {
        Aluno al = new();
        Provas provas = new();

        string? ValidarIdade;
        string? ValidarPerguntaProva;

        Console.Clear();

        //Do While para Repetir a pergunta Caso não digite o nome do Aluno Corretamente
        do
        {
            Console.WriteLine("=================================\n");
            Console.WriteLine("Qual Aluno quer Cadrastar?:");
            Console.WriteLine("=================================\n");

            al.nome = Console.ReadLine();
            
            //Verificar se o Usuario Deixou Vazio Nullo os Apenas Espaços no Nome
            if (string.IsNullOrWhiteSpace(al.nome))
            {
                Console.WriteLine("\nVocê não digitou o Nome do Aluno Corretamente, tente novamente!\n");
            }
            //Verificar se a Primeira Coisa Digitada foi numero e retornar um erro
            else if (char.IsDigit(al.nome[0]))
            {
                Console.WriteLine("\nO Nome do Aluno não pode ser Número, tente novamente!\n");
                al.nome = null;
            }

        } while (string.IsNullOrWhiteSpace(al.nome)); //Repetir a pergunta

        //Imprimir o Nome
        Console.WriteLine($"\nNome do Aluno: {al.nome}\n");
        
        //Do While para Repetir a Pergunta da Idade caso não Digite a Idade Corretamente
        do
        {
            //Perguntar a idade do aluno
            Console.WriteLine("=================================\n");
            Console.WriteLine("Agora Digite a Idade do Aluno:");
            Console.WriteLine("=================================\n");
            
            ValidarIdade = Console.ReadLine();
        
            if (!int.TryParse(ValidarIdade, out al.idade))
            {
                Console.WriteLine("\nVocê não Digitou a Idade Corretamente, tente Novamente!\n");
            }

        } while (!int.TryParse(ValidarIdade, out al.idade));

        Console.Clear();
        Console.WriteLine($"Nome do Aluno: {al.nome}\n");
        Console.WriteLine($"Idade do Aluno: {al.idade} anos de idade\n");
        Console.WriteLine("Matrícula Realizada com Sucesso!...\n");

        Carregando.LoadingSystem(100, 100, false);

        do
        {
            Console.WriteLine("=================================\n");
            Console.WriteLine("Deseja Fazer Alguma Prova? (Sim/Não)");
            Console.WriteLine("=================================\n");
            ValidarPerguntaProva = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ValidarPerguntaProva))
            {
                Console.WriteLine("\nVocê não digitou corretamente se é sim ou não, tente novamente!\n");
            }
            else if (char.IsDigit(ValidarPerguntaProva[0]))
            {
                Console.WriteLine("\nO nome do aluno não pode ser número, tente novamente!\n");
                ValidarPerguntaProva = null;
            }

        } while (string.IsNullOrWhiteSpace(ValidarPerguntaProva));

        if (ValidarPerguntaProva == "sim")
        {
            provas.Matemática(al, 1);
        }
        else
        {
            Carregando.LoadingSystemSimple(100, 100, true);
            Console.WriteLine("\nVocê não quis fazer uma Prova e o Programa foi Encerrado...\n");
            return;
        }

        if(provas.Final == true)
        {
            Console.WriteLine("\nProcessando Notas...\n");
            Carregando.LoadingSystemSimple(100, 100, false);

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Aluno: {al.nome}");
            Console.WriteLine($"Idade: {al.idade} anos");
            Console.WriteLine($"Total de acertos: {al.nota}");
            Console.WriteLine($"Nota média: {al.NotaMedia(10):P0}");
            Console.WriteLine($"Resultado: {al.Validacao()}");
            Console.WriteLine("=================================\n");
            provas.Final = false;
        }

        
    }
}
