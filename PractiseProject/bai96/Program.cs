int dem = 0;
float sum = 0;
Console.Write("Nhap so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(stringArray[i]);
}
Console.Write("Cac so chan : ");
for (int i = 0; i < n; i++)
{
    if (a[i] % 2 == 0)
    {
        Console.Write(" " + a[i]);
        sum = sum + a[i];
        dem++;
    }
}
float tbc = sum / dem;

Console.WriteLine("\nTrung binh cong cua cac so trong mang:" + Math.Round(tbc, 2)); 
Console.ReadLine();


