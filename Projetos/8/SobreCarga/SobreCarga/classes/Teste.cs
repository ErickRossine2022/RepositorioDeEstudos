namespace SobreCarga
{
    class Teste
    {
        public string? Email;
        public string? Password;
        public string? CPF;
        
        //Construtor Padrão
        public Teste() { }

        //Construtor com 3 Paramentros
        public Teste(string? email, string? password, string? Cpf)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password)); 
            CPF = Cpf ?? throw new ArgumentNullException(nameof(Cpf)); 
        }

        //Construtor com 2 Paramentros
        public Teste(string? email, string? password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            CPF = "123.123.452-05";
        }
        //OPS PODEM TAMBEM SER USADO AS SOBRECARGAS TAMBÉM EM METODOS
    }    
}


