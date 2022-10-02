Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int Summ(int m, int n)
{
    if (m > n) return 0;
    else return n+Summ(m,n-1);
}
Console.WriteLine($"Сумма чисел от {m} до {n} равна " +Summ(m,n));