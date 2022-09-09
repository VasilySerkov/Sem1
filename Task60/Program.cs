int[,,] FillMatrix(int m, int n, int l, int LRange, int RRange)
{
    int[,,] Mtrx = new int[m, n, l];
    int q = 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                Input:
                Console.WriteLine($"Введите {q}-е двузначное число массива:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp < 10 || tmp > 99)
                {
                    Console.WriteLine("Число не является двузначным.");
                    goto Input;
                }
                else
                {
                for (int x = 0; x < m; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        for (int z = 0; z < l; z++)
                            if (tmp == Mtrx[x, y, z])
                            {
                                Console.WriteLine("Число повторяется.");
                                goto Input;
                            }
                    }
                }
                Mtrx[i, j, k] = tmp;
                q++;
                }
                
            }
        }
    }
        return Mtrx;
    }

    void PrintMatrix(int[,,] Mtrx)
    {
        for (int i = 0; i < Mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < Mtrx.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < Mtrx.GetLength(2); k++)
                {
                    Console.Write("{0}\t", $"{Mtrx[j, k, i]}({j},{k},{i})");
                }
            }
        }
    }


    int[,,] Table = FillMatrix(2, 2, 2, 10, 99);
    PrintMatrix(Table);