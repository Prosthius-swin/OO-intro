using System;

namespace OO_intro
{
    class Program
    {
        static void Main(string[] args)
        {

            PetrolCar one = new PetrolCar("Unleaded", "Toyota", "123abc", "Prius", 500);
            ElectricCar two = new ElectricCar("Tesla", "111aaa", "Model S", 500);
            Driver John = new Driver("John", "123456789");

            one.getDetails();
            //two.travel(100);
            //Console.WriteLine(one.range);
            two.getRange();
            //two.recharge();
            //two.getRange();

            //PetrolCar one = new PetrolCar("Unleaded");
            //Console.WriteLine(one.fuelType);
            Console.WriteLine(one);

            two.changeDriver(John);
        }
    }
}