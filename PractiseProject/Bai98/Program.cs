﻿
static Boolean songuyento(int n)
{
    bool snt = true;
    for (int i = 2; i < n; i++)
        if (n % i == 0)
        {
            snt = false;
        }
    if (snt)
        return true;
    else    
        return false;
}
 
float tong = 0;
int dem = 0;
Console.Write("Nhap so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(stringArray[i]);
}
Console.Write("\n=>Cac so nguyen to :");
for (int i = 0; i < n; i++)
{
    if (songuyento(a[i]))
    {
        tong = tong + a[i];
        dem++;
        Console.Write(" " + a[i]);
    }
}
        float tbc = tong / dem;
Console.WriteLine("\nTrung binh cong cua cac so nguyen to : " + Math.Round(tbc,2));
Console.ReadLine();

