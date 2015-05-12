namespace Methods
{
    using System;
    public class Methods
    {

        private static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentNullException("Sides cannot be 0.");
            }

            double sum = (a + b + c) / 2;
            double area = Math.Sqrt(sum * (sum - a) * (sum - b) * (sum - c));
            return area;
        }

        private static string NumberToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";  
            }

            return "Invalid number!";
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The elements must be set.");
            }

            int max = 0;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        private static void PrintFormat(object number, string format)
        {
            if (format != "f" && format != "%" && format != "r")
            {
                throw new FormatException("Invalid format.");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        private static double VerticalHorizontalChecker(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToString(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintFormat(1.3, "f");
            PrintFormat(0.75, "%");
            PrintFormat(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(VerticalHorizontalChecker(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
            Console.ReadLine();
        }
    }
}
