﻿
Console.Write("Nhap chieu rong : ");
int r=Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap chieu dai : ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int i = 1; i <= r; i++)
{
    for (int j = 1; j <= d; j++)
    {
        if ((j == 1) || (j == d) || (i == 1) || (i == r))
        {
            Console.Write('1');
        }
        else
        {
            Console.Write('2');
        }
    }
    Console.WriteLine();
}
Console.ReadLine();



