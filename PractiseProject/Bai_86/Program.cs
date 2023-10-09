

double chuvi(int a,int b,int c)
{
    double P=a+b+c;
    return P;
}
double dientich(int a, int b, int c)   
{
    double P=chuvi(a,b,c)/2;
    double S = Math.Sqrt(P*(P - a) * (P - b) * (P - c));
    return S;
}
Console.WriteLine("Nhap canh a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap canh b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap canh c:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chu vi cua tam giac : " +Math.Round(chuvi(a,b,c),1));
Console.WriteLine("Dien tich cua tam giac : " + Math.Round(dientich(a,b,c),3));
Console.ReadLine();

