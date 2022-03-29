using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r = 2f;
            Console.Write("Enter radius of circle : ");
            r=float.Parse(Console.ReadLine());
            circle c = new circle("Blue",r);
            Console.WriteLine("Radius = "+c.radius);
            float area, circumference,diameter;
            area = c.Area();
            circumference=c.circumference();
            diameter = c.diameter();
            Console.WriteLine("Diameter : "+diameter);
            Console.WriteLine("Area : "+area);
            Console.WriteLine("Circumference : "+circumference);
        }
    }
}
