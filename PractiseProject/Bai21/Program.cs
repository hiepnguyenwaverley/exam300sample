int tien;
Console.WriteLine("Nhap so km da di : ");
int km = Convert.ToInt32(Console.ReadLine());   
if (km <= 1)//1km = 12000d
{
    tien = km * 12000;
}
else if( km > 2 && km <= 30 )// km > 2 && km <= 30km = 10000d
{
    tien = 1*12000+(km-1)*10000;
    
}else
{
    tien = 1*12000 + 29 * 10000 + (km - 30) * 9000;
}
Console.WriteLine("So tien phai tra la :"+tien+"d");
Console.ReadLine();
