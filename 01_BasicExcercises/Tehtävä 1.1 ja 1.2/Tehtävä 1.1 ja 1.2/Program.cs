
namespace Tehtävä_1._1_ja_1._2
{

    public class Mathematics
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public static int Remainder(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double Power(int num)
        {
            if (num > 99)
            {
                return num;
            }
            else
            {
                return Math.Pow(num, 2);
            }

        }
        public static double Square(int num)
        {
            return Math.Sqrt(num);
        }
        public static double FindSmallest(List<double> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            double smallest = list.First();
            foreach (double number in list)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            return smallest;
        }
        public static int FindMaxValue(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
        public static float CalculateAverage(List<float> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            float sum = 0;
            foreach (float number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Count;
        }
    }
}

