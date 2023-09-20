int tien;
Console.WriteLine("Nhap so km da di : ");
int km = Convert.ToInt32(Console.ReadLine());   

if (km <= 1)
{
    tien = km * 12000;
}
else if(km > 1 && km <= 30 )
{
    tien = 1*12000+(km-1)*10000;

}
else
{
    tien = 1*12000 + 29 * 10000 + (km - 30) * 9000;
}
Console.WriteLine("So tien phai tra la : "+tien);
Console.ReadLine();
