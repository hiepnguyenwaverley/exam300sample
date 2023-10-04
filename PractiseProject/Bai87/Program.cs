Console.Write("Nhap so nguyen n : ");
int n=Convert.ToInt32(Console.ReadLine());
if(n<=0)
{
    Console.WriteLine("Moi ban nhap so nguyen");
}
else if(n%5==0)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
Console.ReadLine();