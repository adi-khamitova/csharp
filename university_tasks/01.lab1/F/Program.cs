using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            string[] str = Console.ReadLine()!.Split();
            for (int p = 0; p < n; p++) {
                array[p] = Convert.ToInt32(str[p]);
            }


            string[] str2 = Console.ReadLine()!.Split();
            int i = Convert.ToInt32(str2[0]);
            int j = Convert.ToInt32(str2[1]);
            int sum = 0;
            for (int p = i; p < j; p++) {
                sum += array[p];
            }

            Console.WriteLine(sum);
        }
    }
}