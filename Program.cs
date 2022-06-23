using System;
namespace Expo
{
    class Program
    {
        public static void Main (String [] args)
        {
            rectangulo rectangulo1=new rectangulo(4,3);
            rectangulo1.CalcularArea();

            Circulo circulo1=new Circulo(4);
            circulo1.CalcularArea();

        }
    }
}
