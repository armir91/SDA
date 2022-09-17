namespace AdvancedFeatures.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalculateArea(100, 200);
        }

        interface IPolygon
        {
            // method without body

            void CalculateArea(int l, int b);
        }

        class Rectangle : IPolygon
        {
            // implementation of methods inside interface

            public void CalculateArea(int l, int b)
            {
                int area = l * b;
                Console.WriteLine("Area of Rectangle: " + area);
            }
        }
    }
}