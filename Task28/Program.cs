Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
int[] arrayMult = new int [i];
for (int count = 0; count < i; count++) {
Console.WriteLine ($"Введите {count + 1} элемент массива");
array[count] = Convert.ToInt32(Console.ReadLine());
int mult = 1;
for (int numb = 1; numb <= array[count]; numb++)
{
mult = mult * numb;
}
arrayMult[count] = mult;
}
Console.WriteLine(string.Join(", ", arrayMult));