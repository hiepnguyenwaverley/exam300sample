
Console.WriteLine("nhap so nguyen duong n :");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i < n; i++) // vong lap for , chay tu 1 den so n 
{
    if(i%3==0)
    {
        Console.WriteLine("Cac so chia het cho 3 :"+i);
    }
}
Console.WriteLine("-");//khong co thi in dau - 
Console.ReadKey();
