//Ước số của một số tự nhiên a là b,khi a chia hết cho b.
int sum = 0;
Console.WriteLine("Nhap so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    if(n%i == 0)
    {
        Console.Write(" "+i);
        sum = sum + 1;
    }
}
Console.WriteLine("\nCo " +sum+" so uoc cua n");
Console.ReadLine();