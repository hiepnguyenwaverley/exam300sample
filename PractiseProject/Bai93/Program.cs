Console.WriteLine("Nhap so a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so b: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so c: ");
int c =Convert.ToInt32(Console.ReadLine());
int min = 0;
if(a<=b&&a<=c)
{
    min = a;
}
else if(b<=a&&b<=c)
{
    min = b;
}
if(c<=a&&c<=b)
{
    min = c;
}
Console.WriteLine("Gia tri nho nhat trong 3 so la :" + min);
Console.ReadLine();
