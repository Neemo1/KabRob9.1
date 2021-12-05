using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob9
{
    class Scooter : Product // Наследует Значение из класса Продукти
    {
        private int weight;

        public Scooter(int id, string name, double price, int weight) : base(id, name, price)
        {
            base.Id = id;
            this.Name = name;
            this.Price = price;

            this.weight = weight;
        }

        public int Wheel { get => weight; set => weight = value; }
        public new void Print()
        {
            
            base.Print();
            Console.WriteLine($"Weight = {weight} кг");
            
        }
    }
}
