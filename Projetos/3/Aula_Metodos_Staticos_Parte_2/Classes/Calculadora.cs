class Calculadora
{
    public static readonly double pi = 3.14;

    //Metodo Statico que Calcula a CircunFêrencia
    public static double Circunferencia(double valor)
    {
        return 2.0 * pi * valor;
    }

    //Metodo Statico do Volume do Raio
    public static double Volume(double valor)
    {
        return  4.0 / 3.0 * pi * Math.Pow(valor, 3.0);
    }
}