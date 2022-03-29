using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class circle
    {
        public circle()
        {
            radius = 1.0f;
            color="red";
        }
        public circle(int r)
        {
            radius = r;
        }
        public circle(string c, float r)
        {
            color = c;
            radius = r;
        }
        public circle(circle c)
        {
            color = c.color;
            radius = c.radius;
        }
        public float radius;
        public string color;
        public float Area()
        {
            float pi = 3.14f;
            float area = pi * radius * radius;
            return area;
        }
        public float circumference()
        {
            float pi = 3.14f;
            float cir = 2*pi * radius ;
            return cir;
        }
        public float diameter()
        {
            return 2 * radius;
        }
    }
}
