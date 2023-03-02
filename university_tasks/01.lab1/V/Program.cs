using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");
            string str1 = Console.ReadLine()!;
            int k = Convert.ToInt32(Console.ReadLine()!);
            string str2 = String.Empty;
            for (int i = 0; i < str1.Length; i++) {
                if (str1[i] == ' ') {
                    str2 += str1[i];
                }
                if (str1[i] - k < (int)('A')) {
                    str2 += (char)((int)(str1[i] - k - 32));
                }
                else {
                    str2 += (char)((int)(str1[i] - k));
                }

            }
            Console.WriteLine(str2);
        }
    }
}