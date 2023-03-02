using System;

namespace Helloworld {
    public class Program {
        public static void Main() {
            Console.WriteLine("started");

            string id = Console.ReadLine()!;

            int count = 0, check = 0, curr_int;
            string curr = String.Empty;
            for (int i = 0; i < id.Length; i++) {
                if (id[i] != '.') {
                    curr += id[i];
                }
                if ((!(string.IsNullOrEmpty(curr))) && ((id[i] == '.') || (i == id.Length - 1))) {
                    count++;
                    curr_int = Convert.ToInt32(curr);
                    if ((curr_int >= 0) && (curr_int <= 255)) {
                        check++;
                    }
                    curr = String.Empty;
                }
            }

            if ((count == 4) && (check == 4)) {
                Console.WriteLine("YES");
            }
            else {
                Console.WriteLine("NO");
            }
        }
    }
}