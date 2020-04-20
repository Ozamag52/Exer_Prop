using System;
using System.Collections.Generic;
using System.Text;
using Exer_Prop.Entities.Enums;

namespace Exer_Prop.Entities.Class
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime date, OrderStatus orderStatus, Client client)
        {
            Moment = date;
            Status = orderStatus;
            Client = client;

        }


        public void AddItem(OrderItem orderItems)
        {
            OrderItems.Add(orderItems);
        }

        public void RemoveIntem(OrderItem orderItems)
        {
            OrderItems.Remove(orderItems);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem O in OrderItems)
            {
                sum += O.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order momment :");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.AppendLine(Client.Name);
            sb.AppendLine("Order items: ");
            foreach(OrderItem O in OrderItems)
            {
                sb.Append("Produto: ");
                sb.Append(O.Product.Name);
                sb.Append(" , ");
                sb.Append("Price ");
                sb.Append(O.Price);
                sb.Append(" , ");
                sb.Append("Quantity ");
                sb.Append(O.Quantity);
                sb.Append(" , ");
                sb.Append("Subtotal: ");
                sb.Append(O.SubTotal());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}