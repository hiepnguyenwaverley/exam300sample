int n;
int n1, n2, n3, n4,n5, SoNut;
Console.WriteLine("Nhap bien so xe (5 so):");
n=Convert.ToInt32(Console.ReadLine());
n5 = n % 10; n = n / 10;
n4 = n % 10; n = n / 10;
n3 = n % 10; n = n / 10;
n2 = n % 10; n = n / 10;
n1 = n;
SoNut = (n1 + n2 + n3 + n4 + n5) % 10;
Console.WriteLine("So nut la:" + SoNut);
if (SoNut == 9)
{
    Console.WriteLine("\nChuc ban may man");
}
else
{
    Console.WriteLine("\nBan chua may man");
}
Console.ReadKey();