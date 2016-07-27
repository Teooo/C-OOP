using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Area(Box box)
        {
            return 2 * box.length * box.width + 2 * box.length * box.height + 2 * box.width * box.height;
        }

        public double SurfaceArea(Box box)
        {

            return (2 * box.length * box.height) + (2 * box.width * box.height);
        }
        //Lateral Surface Area = 2lh + 2wh
        public double Volume(Box box)
        {
            //Volume = lwh
            return box.length * box.width * box.height;
        }
    }
    public class ClassBox
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double[] numbers = new double[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] += double.Parse(Console.ReadLine());
            }
            Box n = new Box(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine("Surface Area - {0:F2}",
            n.Area(n));
            Console.WriteLine("Lateral Surface Area - {0:F2}",
           n.SurfaceArea(n));
            Console.WriteLine("Volume - {0:F2}",
           n.Volume(n));
        }
    }
}