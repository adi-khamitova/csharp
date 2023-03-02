using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[l];
            string[] el = Console.ReadLine()!.Split();

            for (int i = 0; i < l; i++) {
                a[i] = Convert.ToInt32(el[i]);
            }


            int min, max;
            min = a[0];
            max = a[0];

            for (int i = 0; i!=a.Length; i++) {
                if (a[i] < min) {
                    int x = a[i];
                    min = x;
                }
                if (a[i] > max){
                    int v = a[i];
                    max = v ;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}