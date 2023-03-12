using System;

public class Pyramid {
    public string name;
    public int a, h;
    
    public Pyramid(string n, int a1, int h1) {
        name = n;
        a = a1;
        h = h1;
    }

    public Pyramid(int c, int b) {
        name = "pyramid";
        a = c;
        h = b;
    }

    public Pyramid() {
        a = 0;
        h = 0;
        name = "pyramid";
    }


    public void Input() {
        Console.Write("Enter the name: ");
        name = Console.ReadLine()!;
        Console.Write("Enter a: ");
        a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter h: ");
        h = int.Parse(Console.ReadLine()!);
    }

    public void OutputData() {
        Console.WriteLine("figure {0}, a = {1}, h = {2}", name, a, h);
    }

    public void Output() {
        Console.WriteLine("figure {0}, S = {1:f}, V = {2:f}", name, S(), V());
    }

    public void OutputAll() {
        Console.WriteLine("figure {0}, a = {1}, h = {2}, s = {2:f}, v = {3:f}", name, a, h, S(), V());
    }

    public double S() {
        double s1 = 3 * Math.Sqrt(3) * a * a / 2;
        double s2 = 3 * a * Math.Sqrt(h*h + 3*a*a/2);
        return s1 + s2;
    }

    public double V() {
        return (double)1/3 * h * (3 * Math.Sqrt(3) * a * a / 2);
    }

}

class Program {
    static void Main() {

        //  1
        Pyramid f1 = new Pyramid();
        Pyramid f2 = new Pyramid(2, 5);
        f1.Input();


        if (f1.V() > f2.V()) {
            Console.WriteLine("the biggest volume has {0}", f1.name);
        }
        else if (f1.V() < f2.V()) {
            Console.WriteLine("the biggest volume has {0}", f2.name);
        }
        else {
            Console.WriteLine("figures have the same volume");
        }


        if (Math.Abs(f1.S() - 100) > Math.Abs(f2.S() - 100)) {
            Console.WriteLine("closer to 100 is {0}", f2.name);
        }
        else if (Math.Abs(f1.S() - 100) < Math.Abs(f2.S() - 100)) {
            Console.WriteLine("closer to 100 is {0}", f1.name);
        }
        else {
            Console.WriteLine("odinakovo close to 100");
        }

        //  2
        Console.Write("Enter the number of Pyramids: ");
        int n = int.Parse(Console.ReadLine()!);

        Pyramid[] pyramids = new Pyramid[n+1];

        for (int i = 0; i < n; i++) {
            Pyramid p = new Pyramid();
            p.Input();
            pyramids[i] = p;
        }

        string longestName = "";
        int l_i = 0;
        for (int i = 0; i < n; i++) {
            if (pyramids[i].name.Length > longestName.Length) {
                longestName = pyramids[i].name;
                l_i = i;
            }
        }
        Console.Write("the longest name: ");
        pyramids[l_i].OutputData();

        pyramids[n] = new Pyramid("NewPyramid", pyramids[n-1].a * 2, pyramids[n-1].h * 2);
        pyramids[n].OutputAll();


        double min_s = pyramids[0].S();
        int min_i = 0;
        Console.WriteLine("Areas of all figures:");
        for (int i = 0; i < n+1; i++) {
            Console.WriteLine("{0}: {1:f}", pyramids[i].name, pyramids[i].S());
            if (pyramids[i].S() < min_s) {
                min_s = pyramids[i].S();
                min_i = i;
            }
        }

        pyramids[min_i].name = "MIN" + pyramids[min_i].name;
        Console.Write("the min s: ");
        pyramids[min_i].OutputData();

        int pl15 = 0;
        for (int i = 0; i < n+1; i++) {
            if (pyramids[i].S() > 15) {
                pl15 += 1;
            }
        }
        Console.WriteLine("S < 15: " + pl15);

        double sum = 0;
        for (int i = 0; i < n+1; i++) {
            Console.WriteLine("V of {0} is {1:f}", pyramids[i].name, pyramids[i].V());
            sum += pyramids[i].V();
        }
        Console.WriteLine("Sum of volumes: {0:f}", sum);

    }
}