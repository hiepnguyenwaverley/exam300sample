Console.Write("Nhap so x: ");
double x=Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so n : ");
double n=Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so k: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so a : ");
int a = Convert.ToInt32(Console.ReadLine());

double F = 0;
for(int i=0; i<k; i++)
{
   F=F+a*Math.Pow(x,n);
}
Console.WriteLine("ket qua:"+F);
Console.ReadLine();