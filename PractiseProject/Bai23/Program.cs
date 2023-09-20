
Console.Write("Nhap 1 so nguyen duong :");
int n=Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0)
    {
        list.Add(i);
    }
}
Console.Write("Cac so chia het cho 3 la: ");
list.ForEach(x => Console.Write(x + " "));

Console.ReadKey(); ;
