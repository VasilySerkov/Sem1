Console.WriteLine("Введите число a: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (max < numberB)
{
max = numberB;
}
if (max < numberC)
{
max = numberC;
}
Console.Write("max=");
Console.WriteLine(max);