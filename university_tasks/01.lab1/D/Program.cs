using System;

namespace Helloworld {
    public class Program {
        public static void Main() {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            string[] str = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++) {
                array[i] = Convert.ToInt32(str[i]);
            }
            int count = 0;
            for (int i = 0; i < n; i++) {
                if (i == 0) {
                    count += 1;
                    continue;
                }
                if (array[i] != array[i-1]) {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}