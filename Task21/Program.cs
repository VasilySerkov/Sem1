﻿double[] A = new double [3];
double[] B = new double [3];
Console.WriteLine("Введите координаты точки A по оси X: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Y: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Z: ");
A[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси X: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y: ");
B[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z: ");
B[2] = Convert.ToDouble(Console.ReadLine());
double AB = Math.Sqrt(Math.Pow(B[0]-A[0], 2) + Math.Pow(B[1]-A[1], 2) + Math.Pow(B[2]-A[2], 2));
Console.WriteLine(AB);