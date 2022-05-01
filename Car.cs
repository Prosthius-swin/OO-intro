using System;

namespace OO_intro
{
    class Car
    {

        public string make;
        public string model;
        public string rego;
        public int maxRange;
        public int range;
        public Driver driver;

        public Car(string pMake, string pRego, string pModel, int pMaxRange)
        {
            make = pMake;
            range = pMaxRange;
            rego = pRego;
            model = pModel;
            maxRange = pMaxRange;       
        }
        public string getDetails()
        {
            return $"{make}, {model}, {rego}";
        }

        public void travel(int km)
        {
            range = range - km;
        }

        public void getRange()
        {
            Console.WriteLine($"Current range is {range}km.");
        }

        public void changeDriver(Driver newDriver)
        {
            driver = newDriver;
        }
    }
}