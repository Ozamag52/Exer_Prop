using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_Prop.Entities.Class
{
    class Product
    {
        public string Name { get; set; } // Criação da proprieti autoimplementada do atributo Name da classe Product 
        public double Price { get; set; }

        //Criação do construtor padrão para a classe Product 
        public Product()
        {

        }
        // Criação do construtor customizado para a classe Product 
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
