using System;

namespace RectangleApplication 
{
    class Rectangle
    {
        float length;
        float width;
        public void Acceptdetails()
        {
            length = 4.5f;
            width = 3.5f;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());

        }
    }
    class ExecutteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
