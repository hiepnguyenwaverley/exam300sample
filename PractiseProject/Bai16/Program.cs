//TBCN=(TBHKI+TBHKII*2)/3
Console.WriteLine("----Nhap Diem Trung Binh Cua Ca 2 Hoc Ki--");

Console.Write("\nNhap Diem Trung Binh Hoc Ki I:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap Diem Trung Binh Hoc Ki II:");
int b = Convert.ToInt32(Console.ReadLine());
int c = (a + b * 2) / 3;
Console.WriteLine("Diem Trung Binh Ca Nam :{0} ",c);
if (c == 8)
{
    Console.WriteLine("Hoc Luc Gioi");
}
else if (c >= 6.5||c <= 8)
{
    Console.WriteLine("Hoc Luc Kha");
}
else if(c >= 5||c < 6.5)
{
    Console.WriteLine("Hoc Luc Trung Binh");
}
else if(c >= 3.5||c < 5)
{
    Console.WriteLine("Hoc Luc Yeu");
}
else
{
    Console.WriteLine("Hoc Luc Kem");
}
Console.ReadKey();