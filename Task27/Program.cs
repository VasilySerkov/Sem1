Console.WriteLine("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
string? a = Convert.ToString(B);
int i = 0;
int Summ = 0;
if (B < 0)
{
    Summ = 0 - int.Parse(a[1].ToString());
    i = 2;
    while (i < a.Length)
    {
        Summ = Summ + int.Parse(a[i].ToString());
        i++;
    }
}
else
{
    while (i < a.Length)
    {
        Summ = Summ + int.Parse(a[i].ToString());
        i++;
    }
}
Console.WriteLine($"Сумма цифр числа {B} равна {Summ}");