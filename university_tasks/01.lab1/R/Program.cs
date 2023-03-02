using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");


            string str1 = Console.ReadLine()!;
            string ban = Console.ReadLine()!;

            string str2 = String.Empty;
            int b = 0;
            for (int i = 0; i < str1.Length; i++) {
                for (int j = 0; j < ban.Length; j++) {
                    if (str1[i] == ban[j]) {
                        b = 1;
                        break;
                    }
                }

                if (b == 1) {
                    str2 += "*";
                    b = 0;
                }
                else {
                    str2 += str1[i];
                }
            }

            Console.WriteLine(str2);
        }
    }
}