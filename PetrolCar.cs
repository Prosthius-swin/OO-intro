using System;

namespace OO_intro
{
    class PetrolCar : Car
    {
        public string fuelType;

        public PetrolCar(string pFuelType, string pMake, string pRego, string pModel, int pMaxRange) :base (pMake, pRego, pModel, pMaxRange)
        {
            fuelType = pFuelType;
        }

        public void refuel()
        {
            range = maxRange;
        }
    }
}