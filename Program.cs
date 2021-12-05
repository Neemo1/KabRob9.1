using System;

namespace LabRob9
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(0, "Продукт",0);
            Console.WriteLine("Класс Product");
            p1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Bike");
            Bike b1 = new Bike(1, "Велосипед", 5000, "Не очень большой");
            b1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс MaintainBike");
            MauntainBike mb1 = new MauntainBike(2, "Велосипед", 8000, "Не очень большой", "Многоступенчистая цепь");
            mb1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Scooter");
            Scooter s1 = new Scooter(3, "Велосипед", 3000, 15);
            s1.Print();
            Console.WriteLine("--------------");
        }
    }
}

