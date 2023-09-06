
Console.WriteLine("Nhap so nguyen a");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so nguyen b");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so nguyen c");
int c = Convert.ToInt32(Console.ReadLine());   
if (a >= b && a >= c)
{
    Console.WriteLine("So a {0} la lon nhat",a);
}
else if (b >= c && b >= a)
{
    Console.WriteLine("So b {0} la lon nhat ",b);
}
else if((c >= b && c >= a))
{
    Console.WriteLine("So c {0} la lon nhat",c);
}
else
{
    Console.WriteLine("\n=");
}
Console.ReadLine();