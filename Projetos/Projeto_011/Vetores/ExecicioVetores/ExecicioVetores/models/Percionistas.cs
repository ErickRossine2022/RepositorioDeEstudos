using System.Globalization;

class Percionistas
{
    public string[] PetitionerName { get; set; }
    public string[] Email { get; set; }

    public double[] PriceRoom { get; private set; }

    public int[] RoomID { get; set; }

    private double[] prices = { 200.00, 300.00, 500.00 };

    public Percionistas(string[] name, string[] email, int[] roomID,double[] priceRoom)
    {
        PetitionerName = name;
        Email = email;
        
        for (int i = 0; i < roomID.Length; i++)
        {
            roomID[i] = i + 1;
            priceRoom[i] = prices[i % prices.Length];
        }

        RoomID = roomID;
        PriceRoom = priceRoom;
        
    }

    public double GetAveragePrice()
    {
        double result = 0;
        for (int i = 0; i < PriceRoom.Length; i++)
        {
            result += PriceRoom[i];
        }
        return result / PriceRoom.Length;
    }

    public override string ToString()
    {
        string result = "\n=== DADOS DOS PERCIONISTAS ===";
        for (int i = 0; i < PetitionerName.Length; i++)
        {
            if(!string.IsNullOrWhiteSpace(PetitionerName[i]))
            {
                result += $"\n\nQuarto ID: {RoomID[i]}\n";
                result += $"Nome: {PetitionerName[i]}\n";
                result += $"Email: {Email[i]}\n";
                result += $"Preço: R$ {PriceRoom[i].ToString("F2", CultureInfo.InvariantCulture)} reais";
            }
        }
        return result;
    }
}