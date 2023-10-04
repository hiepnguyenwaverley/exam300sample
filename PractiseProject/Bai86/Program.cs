

double chuvi(int a,int b,int c)
{
    return a+b+c;
}

double dientich(int a,int b,int c)
{
    double P = chuvi(a,b,c) / 2;
    Console.WriteLine("Nua Chu Vi cua tam giac :" +P);
    return Math.Sqrt(P*(P-a)*(P-b)*(P-c)); 
}

Console.Write("Nhap canh a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap canh b: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap canh c: ");
int c=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------");
Console.WriteLine("Chu Vi cua tam giac : " + Math.Round(chuvi(a, b, c), 1));
Console.WriteLine("Dien Tich cua tam giac : "+Math.Round(dientich(a,b,c),3));
Console.ReadLine();