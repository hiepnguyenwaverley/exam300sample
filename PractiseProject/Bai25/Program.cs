//so chan la so chia het cho 2
int sum = 0;
Console.Write("Nhap so nguyen duong n: ");
int n= Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=n; i++)
{
    if(i%2==0)
    {
        Console.Write(" "+i);
        sum=sum+i;  
    }
}
Console.WriteLine("\nTong cac so chan tu 1 den n :" + sum);
Console.ReadLine();