int count = 0;
Console.Write("Nhap 1 so nguyen duong n: ");
int n =Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    if(i % 3 == 0)
    {
        Console.Write(" "+i);
        count=count+1;
    }

}
Console.WriteLine("\nSo luong so chia het cho 3 la : "+count);
Console.ReadLine();