using System;

namespace StandaloneApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(string.Join(Environment.NewLine, args));
        }
    }
}
