Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)   
{
Console.Write("max=");
Console.WriteLine(numberA);
 }
else
    if(numberA < numberB)
    {
    Console.Write("max=");
    Console.WriteLine(numberB);
    }
    else
    {
    Console.WriteLine("Эти числа равны");
    }
