namespace Tehtävä_1
{
    public class Mathematics
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public int Remainder(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Power(int num)
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
        public double Square(int num)
        {
            return Math.Sqrt(num);
        }
    }
}