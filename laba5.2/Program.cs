
using System;

namespace laba_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BellCalc myBell = new BellCalc(22,6);
            myBell.ShowBaseArea();
            myBell.ShowBaseSize();

            FrustumCalc myFrustum = new FrustumCalc(25, 5, 13);
            myFrustum.ShowBaseSize();
        }
    }
}
