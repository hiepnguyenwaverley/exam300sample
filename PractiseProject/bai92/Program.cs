
double phuongtrinh1(int a,int b,int c)
{
    return a + b + c;
}
double phuongtrinh2(int a,int b,int c)
{
    return a/b + c;
}
double phuongtrinh3(int a,int b,int c)
{
    return a/(b+c);
}

Console.Write("Nhap so a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap so c: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("pt1:"+phuongtrinh1(a,b,c));
Console.WriteLine("pt2:" + Math.Round(phuongtrinh2(a,b,c), 2));
Console.WriteLine("pt3:" + Math.Round(phuongtrinh3(a,b,c), 3));
Console.ReadLine();

