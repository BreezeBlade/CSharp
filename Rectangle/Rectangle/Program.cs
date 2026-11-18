using System;
namespace RectangleApplication
{
    class Rectangle
    {
        public double length;
        public double width;

        // initialize the Rectangle
        public void AcceptDetails()
        {
            length = 3.0;
            width = 6.0;
        }
        // get the area of the rectangle
        public double GetArea()
        {
            return length * width;
        }

        // show the details of the rectangle
        public void Display()
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", GetArea());
        }

    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle MyRectangle = new Rectangle();
            MyRectangle.AcceptDetails();
            MyRectangle.Display();
            Console.In.ReadLine();
            MyRectangle.length = 3.5;
            MyRectangle.width = 4.0;
            MyRectangle.Display();
        }
    }
}