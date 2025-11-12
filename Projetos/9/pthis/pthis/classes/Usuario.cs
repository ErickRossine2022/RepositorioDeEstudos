namespace pthis.classes;

public class Usuario
{
    //Atributos da Minha Classe
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email  { get; set; }
    public string Password  { get; set; }
    public string Cpf  { get; set; }
    
    //Construtor com 
    public Usuario(string? nome, string? sobrenome,string? email, string? password, string? cpf)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
        Email = email ?? throw new ArgumentNullException(nameof(email));
        Password = password ?? throw new ArgumentNullException(nameof(password));
        Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
    }
}