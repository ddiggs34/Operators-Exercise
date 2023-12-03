namespace OperatorExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //EXERCISE 1
            int a = 3;
            int b = 4;

            var sum = a + b;

            var sub = a - b;

            var quotient = a * b;

            var remainder = b % a;

            Console.WriteLine($"{sum} is the sum");
            Console.WriteLine($"{sub} is the sub");
            Console.WriteLine($"{quotient} is the qoutient");
            Console.WriteLine($"{remainder} is the remainder from a / b");

            //EXERCISE

            Console.WriteLine("We're getting the area of your circle. What is the radius?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCirle(radius);

            Console.WriteLine($"The area of your circle with a radius of {radius} is {area} ");


        }

        public static double AreaOfCirle(double radius)
        {
            return (Math.PI * radius * radius);
            }
    }
}
