Console.WriteLine("Nhap so nguyen n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 0)
{
    Console.WriteLine("Moi ban nhap lai");
}
else if(n % 5 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}
Console.ReadLine();