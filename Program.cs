using System;

namespace CsharpAdvanced_4
{
    public interface IMath // Interface
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        int Div(int a, int b);
    }

    internal class Program : IMath
    {
        public static Program p = new Program();

        static void Main(string[] args)
        {
            Console.WriteLine(p.Add(1, 1));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}