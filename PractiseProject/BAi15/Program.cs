int c;
int c1, c2, c3,chuvi;
Console.WriteLine("Nhap canh 1):");
c1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap canh 2:");
c2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap canh 3 :");
c3 = Convert.ToInt32(Console.ReadLine());
if (c1 == 1 || c2 == 1 || c3 == 1)
{
    Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");

}
else
{
    
    Console.WriteLine("Day la 3 canh cua mot tam giac");
    chuvi = (c1 + c2 + c3) / 2;
    Console.WriteLine("chu vi tam giac :" + chuvi);
}
Console.ReadKey();