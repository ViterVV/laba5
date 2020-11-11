using System;

namespace laba_5_2
{
    class BellCalc
    {
        public BellCalc(double H,double R)
        {
            this.H = H;
            this.R = R;
        }
        public double H { get; set; }
        public double R { get; set; }
        public const double PI = Math.PI;
        
        public double BaseArea
        {
            get
            {
                return PI * Math.Pow(R, 2);
            }
        }
        public virtual double BellSize
        {
            get
            {
                return (BaseArea * H) / 3d;
            }
        }

        public void ShowBaseArea()
        {
            Console.WriteLine($"Base area: {BaseArea}");
        }
        public virtual void ShowBaseSize()
        {
            Console.WriteLine($"Cone area: {BellSize}");
        }
    }
}
