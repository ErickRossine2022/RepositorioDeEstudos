using pthis.classes;

namespace pthis
{
    class Programa
    {
        private static readonly List<Usuario> User = 
        [
            new Usuario("Castiel", "FuraMulher", "teste@gmail.com", "40028922", "12232483"),  
            new Usuario("Luciana", "Cavalcante", "LuciCal@gmail.com", "123456", "92832713"),
            new Usuario("Leticia", "Cavalcante", "LeticiaCavalcante123@gmail.com", "335313", "341232123"),
            new Usuario("Nailza", "Maria", "nailza12232@gmail.com", "56546", "0898767543")
        
        ];
        
        static void Main()
        {
            bool sucesso;
            string? username;
            string? usersobrenome;
            string? useremail;
            string? usersenha;
            string? usercpf;
            
            do
            {
                Console.Write("Digite seu Nome: ");
                username = Console.ReadLine();

                sucesso = !string.IsNullOrWhiteSpace(username);

                if (!sucesso)
                {
                    Console.WriteLine("Você não pode deixar o espaço vazio ou apenas com espaços!");
                    Console.WriteLine("Tente novamente!\n");
                }

            } while (!sucesso);

            do
            {
                Console.Write("Digite seu Sobrenome: ");
                usersobrenome = Console.ReadLine();

                sucesso = !string.IsNullOrWhiteSpace(usersobrenome);

                if (!sucesso)
                {
                    Console.WriteLine("Você não pode deixar o espaço vazio ou apenas com espaços!");
                    Console.WriteLine("Tente novamente!\n");
                }
            } while (!sucesso);
          
            do
            {
                Console.Write("Digite seu Email: ");
                useremail = Console.ReadLine();

                sucesso = !string.IsNullOrWhiteSpace(useremail);

                if (!sucesso)
                {
                    Console.WriteLine("Você não pode deixar o espaço vazio ou apenas com espaços!");
                    Console.WriteLine("Tente novamente!\n");
                }
            } while (!sucesso);
            
            
            do
            {
                Console.Write("Digite sua Senha: ");
                usersenha = Console.ReadLine();

                sucesso = !string.IsNullOrWhiteSpace(usersenha);

                if (!sucesso)
                {
                    Console.WriteLine("Você não pode deixar o espaço vazio ou apenas com espaços!");
                    Console.WriteLine("Tente novamente!\n");
                }
            } while (!sucesso);
            
            do
            {
                Console.Write("Digite seu CPF: ");
                usercpf = Console.ReadLine();

                sucesso = !string.IsNullOrWhiteSpace(usercpf);

                if (!sucesso)
                {
                    Console.WriteLine("Você não pode deixar o espaço vazio ou apenas com espaços!");
                    Console.WriteLine("Tente novamente!\n");
                }
            } while (!sucesso);
            
            User.Add(new Usuario(username, usersobrenome, useremail, usersenha, usercpf));
            
            
            foreach (var u in User)
            {
                Console.WriteLine(u.Nome + "\t" + u.Sobrenome + "\t" + u.Email + "\t" + u.Password + "\t" +u.Cpf);
            }
        }
    }
}