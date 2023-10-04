Console.WriteLine("Nhap so a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so b: ");
int b=Convert.ToInt32(Console.ReadLine());
int ucln = 0;
if(a>b)
{
    ucln = a % b;
    Console.WriteLine("UCLN cua a va b: " + ucln );
}
else
{
    ucln = b % a;
    Console.WriteLine("UCLN cua a va b: " + ucln);
}
int tu = 0;
int mau = 0;
tu = a / ucln;
mau=b / ucln;
Console.WriteLine("Ket qua: {0}/{1}",tu,mau);
Console.ReadLine();
