Console.Write("Nhap so nguyen km da di: ");
int km=Convert.ToInt32(Console.ReadLine());
if (km <= 1) 
{
    km = km * 12000;
}
else if (km <= 30)
{
    km = 1 * 12000 +(km - 1) * 10000; 
}
else
{
    km = 1 * 12000 + 30 * 10000 + (km -1- 30) * 9000;
}
Console.WriteLine("So tien can tra cho taxi la :" + km +" dong");
Console.ReadLine();
