using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob9
{
    class Bike : Product //Наследует значения с класса Продукти
    {
       
        private string wheel;

        public Bike( int id, string name, double price, string wheel) : base(id, name, price)
        {
            base.Id = id;
            this.Name = name;
            this.Price = price;

            this.wheel = wheel;
        }
       
        public string Wheel { get => wheel; set => wheel = value; }
        public new void Print()
        {
            
            base.Print();
            Console.WriteLine($"Wheel = {wheel}");
            
        }
    }
}
