using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;

            double a;
            b = Console.ReadLine();
            a = Convert.ToDouble(b);

            Circle circle = new Circle();
            circle.Radious = a ;
            double area = circle .FindArea();
            double cicumestence = circle.Findcircumestance();
            Console.WriteLine(area);
            Console.WriteLine(cicumestence);
        }
    }
}
