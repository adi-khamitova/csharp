using System;

public class RationalNumber {
    private int numerator;
    private int denominator;

    public RationalNumber() {
        this.numerator = 0;
        this.denominator = 1;
    }
    public RationalNumber(int p, int q) {
        this.numerator = p;
        Denominator = q;
    }

    public RationalNumber(int IntegerPart, int p, int q) {
        Denominator = q;
        this.numerator = IntegerPart * denominator + p;
    }

    public RationalNumber(RationalNumber other) {
        this.numerator = other.numerator;
        this.denominator = other.denominator;
    }

    public int Numerator {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator {
        get { return denominator; }
        set {
            if (value == 0) {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            this.denominator = value;
        }
    }

    public void Input() {
        Console.Write("Enter the numerator: ");
        Numerator = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the denominator: ");
        Denominator = int.Parse(Console.ReadLine()!);
    }

    public void Output() {
        Normalize();
        int IntegerPart = GetIntegerPart();
        int n = GetNumerator();
        int d = Denominator;
        if (n == 0) {
            Console.WriteLine(IntegerPart);
        }
        else if ((IntegerPart == 0) || (n < d)) {
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }
        else {
            Console.WriteLine("{0} {1}/{2}", IntegerPart, numerator, denominator);
        }
    }

    public int GetIntegerPart() {
        return numerator / denominator;
    }

    public int GetNumerator() {
        return numerator % denominator;
    }

    public void Normalize() {
        int gcd = Gcd(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    private int Gcd(int a, int b) {
        if (b == 0) {
            return a;
        }
        return Gcd(b, a % b);
    }


    public static RationalNumber operator -(RationalNumber n1, RationalNumber n2) {
        RationalNumber difference = new RationalNumber();
        difference.Denominator = n1.denominator * n2.denominator;
        difference.Numerator = n1.numerator * n2.denominator - n1.denominator * n2.numerator;
        difference.Normalize();
        return difference;
    }

    public static RationalNumber operator +(RationalNumber n1, RationalNumber n2) {
        RationalNumber sum = new RationalNumber();
        sum.Denominator = n1.denominator * n2.denominator;
        sum.Numerator = n1.numerator * n2.denominator + n1.denominator * n2.numerator;
        sum.Normalize();
        return sum;
    }

    public static RationalNumber operator *(RationalNumber n1, RationalNumber n2) {
        RationalNumber prod = new RationalNumber();
        prod.Denominator = n1.denominator * n2.denominator;
        prod.Numerator = n1.numerator * n2.numerator;
        prod.Normalize();
        return prod;
    }

    public static bool operator >(RationalNumber n1, RationalNumber n2) {
        n1.Normalize();
        n2.Normalize();
        n1.Denominator *= n2.denominator;
        n1.Numerator *= n2.denominator;
        n2.Denominator *= n1.denominator;
        n2.Numerator *= n1.denominator;

        if (n1.numerator > n2.numerator) 
            return true;
        else
            return false;
    }

    public static bool operator <(RationalNumber n1, RationalNumber n2) {
        n1.Normalize();
        n2.Normalize();
        n1.Denominator *= n2.denominator;
        n1.Numerator *= n2.denominator;
        n2.Denominator *= n1.denominator;
        n2.Numerator *= n1.denominator;

        if (n1.numerator > n2.numerator) 
            return false;
        else
            return true;
    }


}




class Program {
    static void Main() {



        // 1
        RationalNumber num1 = new RationalNumber();
        RationalNumber num2 = new RationalNumber();

        num1.Input();
        num2.Input();

        Console.WriteLine("a)");
        num1.Output();
        num2.Output();

        Console.WriteLine("b)");
        Console.WriteLine("The numerator of num1: " + num1.Numerator);
        Console.WriteLine("The numerator of num2: " + num2.Numerator);

        Console.WriteLine("c)");
        Console.WriteLine("sum of denominators: " + Convert.ToString(num1.Denominator + num2.Denominator));

        Console.WriteLine("d)");
        if (num1.Numerator > num2.Numerator) {
            Console.Write("The num with the biggest numenator: ");
            num1.Output();
        }
        else if (num2.Numerator > num1.Numerator) {
            Console.Write("The num with the biggest numenator: ");
            num2.Output();
        }
        else {
            Console.WriteLine("The numbers have the same numenators.");
        }



        Console.WriteLine();
        // 2
        Console.WriteLine("The Integer Part of num1: " + num1.GetIntegerPart());

        Console.WriteLine("The numenator after getting the integer part of num2: " + num2.GetNumerator());

        num1.Normalize();
        Console.Write("Normalized num1: ");
        num1.Output();



        Console.WriteLine();
        // 3
        RationalNumber r1 = new RationalNumber(4, 3);
        RationalNumber r2 = new RationalNumber(5, 1, 7);
        RationalNumber r3 = new RationalNumber(r1);

        Console.WriteLine("numbers:");
        r1.Output();
        r2.Output();
        r3.Output();

        r1.Numerator = 5;
        r1.Denominator *= 3;

        r2.Denominator -= 2;

        r3.Numerator += 10;
        r3.Denominator *= 10;

        Console.WriteLine("numbers after changes:");
        r1.Output();
        r2.Output();
        r3.Output();



        Console.WriteLine();
        // 4

        
        RationalNumber[] arr = new RationalNumber[5];
        Console.WriteLine("Enter the elements of array:");
        for (int i = 0; i < 5; i++) {
            RationalNumber el = new RationalNumber();
            el.Input();
            arr[i] = el;
        }
    
        RationalNumber sum = new RationalNumber(0, 1);
        RationalNumber prod = new RationalNumber(1, 1);
        for (int i = 0; i < 5; i++) {
            sum += arr[i];
            prod *= arr[i];
        }

        Console.Write("the sum = ");
        sum.Output();

        Console.Write("the product = ");
        prod.Output();

        RationalNumber max = arr[0];
        RationalNumber min = arr[0];
        for (int i = 1; i < 5; i++) {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
            max.Output();
            min.Output();
        }

        Console.Write("Max: ");
        max.Output();
        Console.Write("Min: ");
        min.Output();
        Console.WriteLine("Difference: ");
        (max - min).Output();
    }
}
