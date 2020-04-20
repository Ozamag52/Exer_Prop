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

    }
}