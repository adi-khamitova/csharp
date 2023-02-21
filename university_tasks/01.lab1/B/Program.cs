int n;
n = int.Parse(Console.ReadLine()!);
int factorial = 1;
for (int i = 1; i <= n; i++) {
    factorial *= i;
}
Console.WriteLine(factorial);