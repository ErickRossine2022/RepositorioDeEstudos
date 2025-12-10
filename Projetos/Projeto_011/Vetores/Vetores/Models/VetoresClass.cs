namespace Vetores
{
    class VetoresClass
    {
        //Criar um Atributo Array String Vazio
        public string[] VectorName { get; set; }
        //Criar um Atributo Array Double Vazio
        public double[] VectorDouble { get; set; }

        //Iniciar construtor com Valor dos paramentros
        public VetoresClass(string[] name, double[] number)
        {
            VectorName = name;
            VectorDouble = number;
        }
    }
}
