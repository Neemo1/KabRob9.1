using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob9
{

    class MauntainBike : Bike // Наследует значения из класса Байк
    {
        private string chain;
        public MauntainBike(int id, string name, double price, string wheel, string chain): base(id, name, price, wheel)
        {
            base.Id=id;
            this.Name = name;
            this.Price = price;
            this.Wheel = wheel;

            this.Chain = chain;
        }

        public string Chain { get => chain; set => chain = value; }
        public new void Print()
        {
            
            base.Print();
            Console.WriteLine($"Chain = {chain}");
            
        }
    }
}
