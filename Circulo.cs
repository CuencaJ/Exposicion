using System;
namespace Expo
{
    class Circulo:Ifigura
    {
        public double pi=3.1416;
        public double r2{set;get;}

        public Circulo(double r2)
        {
            this.r2=r2;
        }

        public void CalcularArea()
        {
            double area;
            area=pi*Math.Pow(r2,2);
            Console.WriteLine("El área del circulo es: " +area);
        }
    }
}