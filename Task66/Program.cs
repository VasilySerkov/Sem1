Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N, больше M:");
int N = int.Parse(Console.ReadLine());

void GapSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapSum(numberM, numberN, sum);
}

GapSum(M, N, 0);