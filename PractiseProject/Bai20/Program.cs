int soto5000 = 0, soto2000 = 0, soto1000 = 0, sodu = 0;
Console.Write("Nhap so tien n : ");
int n = Convert.ToInt32(Console.ReadLine());
soto5000 = n / 5000;
sodu = n % 5000;
if (sodu >= 2000)
{
    soto2000 = sodu / 2000;
    sodu = sodu % 2000;
}
if (sodu >= 1000)
{
    soto1000 = sodu / 1000;
    sodu = sodu % 1000;
}
Console.WriteLine("Thu tu theo so to la 5000,2000,1000 :");
Console.WriteLine("\t" + soto5000 + " " + soto2000 + " " + soto1000);
Console.ReadLine();
