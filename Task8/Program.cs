Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number)
{
    Console.WriteLine(count);
    count = count + 2;
}