using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
    }
}