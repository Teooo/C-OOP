using System;
using System.Linq;
using System.Reflection;
namespace ClassBox
{
    public class Box
    {

        private double width;
        private double length;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
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
    public class ClassBoxDataValidation
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            try
            {
                double[] numbers = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    numbers[i] += double.Parse(Console.ReadLine());
                }
                Box box = new Box(numbers[0], numbers[1], numbers[2]);

                Console.WriteLine("Surface Area - {0:F2}",
                box.Area(box));
                Console.WriteLine("Lateral Surface Area - {0:F2}",
               box.SurfaceArea(box));
                Console.WriteLine("Volume - {0:F2}",
               box.Volume(box));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
