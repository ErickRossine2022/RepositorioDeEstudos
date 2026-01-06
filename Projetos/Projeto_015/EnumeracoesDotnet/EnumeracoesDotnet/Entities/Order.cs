using System;

//Aqui Chama a Pasta Enums de Entidades
using EnumeracoesDotnet.Entities.Enums;

//Aqui Pega o Nome do Projeto mais o Nome da Pasta Entities
namespace EnumeracoesDotnet.Entities
{
    // Classe que representa um pedido
    public class Order
    {
        //Atributo Codigo do Produto
        public int Id { get; set; }

        //Atributo Pegar o Instante do Pedido
        public DateTime Moment { get; set; }

        //Atributo Pegar o Estado que o Produto Está
        public OrderStatus Status { get; set; }

        //Fazer com que o Construtor Pegue o ID do Produto e o Momento da Compra
        public Order(int id, DateTime moment)
        {
            Id = id;
            Moment = moment;
            Status = OrderStatus.PendingPayment;
        }

        //Metodo que retorna o Nome do Produto se Baseando no ID
        public string OrderName(int id)
        {
            string name;

            switch (id)
            {
                case 1:
                    name = "TV";
                    break;
                case 2:
                    name = "BIKE";
                    break;
                case 3:
                    name = "DOLL";
                    break;
                default:
                    name = "Invalid Product!";
                    break;
            }
            return name;
        }

        public override string ToString()
        {
            return $"Product Name: {OrderName(Id)} | ID: {Id} | Date and Time: {Moment} | Status: {Status}";
        }
    }
}
