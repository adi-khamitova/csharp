using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n;
            n = int.Parse(Console.ReadLine()!);
            int factorial = 1;
            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}