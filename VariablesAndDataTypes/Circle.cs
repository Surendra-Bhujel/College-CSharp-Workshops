namespace VariablesAndDatatypes
{
    public class Circle
    {
        // TODO 1: Constant PI
        public const double PI = 3.14;

        // Calculate area
        public double Area(double radius)
        {
            return PI * radius * radius;
        }

        // Calculate perimeter
        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}