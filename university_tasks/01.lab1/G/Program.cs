using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n = Convert.ToInt32(Console.ReadLine()!);
            string[] array = Console.ReadLine()!.Split();
            int pos = Convert.ToInt32(Console.ReadLine()!);

            if (pos >= n) {
                Console.WriteLine("wrong position");
                return;
            }

            string el = array[pos];
            array[pos] = array[n - 1 - pos];
            array[n - 1 - pos] = el;

            for (int i = 0; i < n; i++) {
                if (i != 0) {
                    Console.Write(" ");
                }
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}