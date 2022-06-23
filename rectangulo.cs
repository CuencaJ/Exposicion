using System;
namespace Expo
{
    class rectangulo: Ifigura
    {
        public int bas{set;get;}
        public int altura{set;get;}

        public rectangulo(int altura,int bas)
        {
            this.altura=altura;
            this.bas=bas;
        }
        public void CalcularArea()
        {
            int area;
            area=bas*altura;
            Console.WriteLine("El área del rectángulo es: " +area);
        }
    }
}