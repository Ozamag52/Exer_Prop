using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_Prop.Entities.Class
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }


        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        // Criação do metodo SubTotal

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }

}
