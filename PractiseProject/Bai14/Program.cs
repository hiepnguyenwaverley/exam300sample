Console.WriteLine("Moi ban Nhap tuoi cua mot nguoi");
int tuoi=Convert.ToInt32(Console.ReadLine());
if (tuoi <= 0 && tuoi >150 )
{
    Console.WriteLine("Moi ban nhap lai tuoi");
}
else if (tuoi > 0 && tuoi <= 11)
{
    Console.WriteLine("Thieu Nhi");
}
else if (tuoi > 11 && tuoi <= 25)
{
    Console.WriteLine("Thieu Nien");
}
else if (tuoi > 25 && tuoi <= 50)
{
    Console.WriteLine("Trung Nien");
}
else 
{
    Console.WriteLine("Lao Nien");
}
Console.ReadLine();