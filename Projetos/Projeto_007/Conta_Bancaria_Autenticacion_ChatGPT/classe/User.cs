using System.Globalization;

class User
{
    public string Nome { get; set; }
    public string Password { get; set; }
    public double CPF { get; set; }

    public User(string? Nome, string? PassWord, double Cpf)
    {
        this.Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
        Password = PassWord ?? throw new ArgumentNullException(nameof(PassWord));
        CPF = Cpf;
    }

    public override string ToString()
    {
        return "Usuario :" + Nome + "\t| Senha: " + Password + "\t| CPF: " + CPF.ToString("F11", CultureInfo.InvariantCulture) + "|" + "\n";
    }
}