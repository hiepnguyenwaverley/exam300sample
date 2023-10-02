using System;

Console.WriteLine("Nhap so n : ");
int n = Convert.ToInt32(Console.ReadLine());
int[]a= new int[n];
var stringArray=Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    a[i]= int.Parse(stringArray[i]);
}
int vt1 = 0;
int vt2 = 0;
int max = 0;
int min = 0;
for (int i = 0;i < n;i++)
{
    if (a[i]>max)
    {
        max = a[i];
        vt1 = i;
    }
    if (a[i]<min)
    {
        min = a[i];
        vt2 = i;
    }
}
Console.WriteLine("Max: " + max + " Vi Tri: " + vt1);
Console.WriteLine("Min: " + min + " Vi Tri: " + vt2);
Console.ReadLine();





