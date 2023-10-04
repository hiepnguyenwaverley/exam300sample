int count = 0;
Console.WriteLine("Nhap so nguyen duong n: ");
int n=Convert.ToInt32(Console.ReadLine());
bool snt = true;
if(n<2)
{
    snt = false;
    Console.WriteLine("No");
}

for (int i = 2; i < n; i++)
{
    if (n % i == 0)
    {
        snt = false;
        break;
    }
}
if (snt )
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Console.ReadKey();
