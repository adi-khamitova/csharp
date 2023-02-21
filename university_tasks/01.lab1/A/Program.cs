int n;
n = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = 1; i <= n; i++) {
    sum += i * i;
}
Console.WriteLine(sum);