Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int AkkFunct(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkFunct(m - 1, 1);
    if (m > 0 && n > 0) return AkkFunct(m - 1, AkkFunct(m, n - 1));
    else return 0;
}
Console.WriteLine(AkkFunct(m,n));