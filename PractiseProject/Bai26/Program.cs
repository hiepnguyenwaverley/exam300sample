int sum = 0;
Console.WriteLine("Nhap so nguyen duong n : ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Cac so chia het cho 3 va 5 :");
for(int i=1;i<=n;i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.Write(" " + i);
        sum = sum + i;
    }
}
Console.WriteLine("\nTong cac so chia het cho ca 3 va 5 :" + sum);
Console.ReadLine();