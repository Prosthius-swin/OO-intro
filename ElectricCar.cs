using System;

namespace OO_intro
{
    class ElectricCar : Car
    {
        public ElectricCar(string pMake, string pRego, string pModel, int pMaxRange) :base (pMake, pRego, pModel, pMaxRange)
        {
            
        }

        public void recharge()
        {
            range = maxRange;
        }
    }
}