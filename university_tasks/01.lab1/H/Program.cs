using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            int n = Convert.ToInt32(Console.ReadLine()!);
            int m = Convert.ToInt32(Console.ReadLine()!);

            int x0 = 0, y0 = 0;
            int[,] array = new int[n, m];
            string[] line;
            for (int i = 0; i < n; i++) {
                line = Console.ReadLine()!.Split();
                for (int j = 0; j < m; j++) {
                    array[i,j] = Convert.ToInt32(line[j]);
                }
            }


            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (array[i,j] == 1) {
                        x0 = i;
                        y0 = j;
                        continue;
                    }
                }
            }

            for (int j = 0; j < m; j++) {
                for (int i = 0; i < n; i++) {
                    if (array[i,j] == 2) {
                        Console.Write(j - y0);
                        Console.Write(' ');
                        Console.Write(i - x0);
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }
}
