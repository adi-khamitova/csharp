using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            string[] str_a = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++) {
                a[i] = Convert.ToInt32(str_a[i]);
            }
            int[] b = new int[n];
            string[] str_b = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++) {
                b[i] = Convert.ToInt32(str_b[i]);
            }

            int scalar_product = 0;

            for (int i = 0; i < n; i++) {
                scalar_product += a[i] * b[i];
            }

            Console.WriteLine(scalar_product);

        }
    }
}