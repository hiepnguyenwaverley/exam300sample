int money;
Console.WriteLine("Nhap so Kw/h dien da su dung ");
int kw = Convert.ToInt32(Console.ReadLine());
if (kw <= 50)//50kw=600d
{
    money = kw * 600;
}
else if (kw <= 100)//them 50kw 
{
    money = 50 * 600 + (kw - 50) * 800;
}
else if (kw <= 200)
{
    money = 50 * 600 + 50 * 800 + (kw - 50 - 50) * 1100;
}
else
{
    money = 50 * 600 + 50 * 800 + 100 * 1100 + (kw - 50 - 50 - 100) * 1500;
}
Console.WriteLine("So tien dien can tra :" + money);
Console.ReadKey();