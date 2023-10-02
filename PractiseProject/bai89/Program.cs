
Console.Write("Nhap so n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so k : ");
int k = Convert.ToInt32(Console.ReadLine());
int gt = 1;
int gt2 = 1;
for (int i = 1; i <= n; i++)
{
    gt = gt * i;
}
for (int i = 1; i <= k; i++)
{
    gt2 = gt2 * i;
}

int tohop = 0;
tohop = gt / gt2;
Console.WriteLine("gt1: " + gt);
Console.WriteLine("gt2: " + gt2);
Console.WriteLine("ketqua: " + tohop);
Console.ReadLine();
