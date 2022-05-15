using System;

namespace StrykerDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create some mutant!!!");
        }

        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }

        public int product(int x, int y)
        {
            return x * y;
        }

        public int division(int x, int y)
        {
            return x / y;
        }

        public int mod(int x, int y)
        {
            return x % y;
        }
    }
}
