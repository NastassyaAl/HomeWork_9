Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int Numbers(int N)
{
    if (N <= 0) return 0;
    else Console.Write($"{N} ");
    return Numbers(N-1);
}
Numbers(N);