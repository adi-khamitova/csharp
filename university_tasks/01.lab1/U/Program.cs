using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            string str = Console.ReadLine()!;
            int l = 1, count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (Char.IsNumber(str[i])) {
                    if (str[i] != '0') {
                        l = 1;
                    }
                }
                else if (l == 1) {
                    count++;
                    l = 0;
                }
            }

            Console.WriteLine(count);
        }
    }
}