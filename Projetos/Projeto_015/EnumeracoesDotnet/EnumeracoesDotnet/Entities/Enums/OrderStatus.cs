using System;


namespace EnumeracoesDotnet.Entities.Enums
{
    // Enum baseada em um tipo base (int)
    public enum OrderStatus : int
    {
        // Valores possíveis dentro da enum
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
