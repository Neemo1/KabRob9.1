using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob9
{
    class Product
    {
        private int id;
        private string name;
        private double price;
        public Product()
        {
            id = 0;
            name = "Название товара";
            price = 0;
        }
        public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public void Print()
        {
            Console.WriteLine("Значение полей");
            Console.WriteLine($"Id = {id}");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Price = {price} грн");
            
        }
    }
}
