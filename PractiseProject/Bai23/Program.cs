Console.Write("Nhap so nguyen duong n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Cac so chia het cho 3 tu 1 den n :");
for (int i = 1; i < n; i++)
{
    if (i % 3 == 0)
    {
        Console.Write(" " + i);
    }
}
//CACH 2 
//List<int> list = new List<int>();
//for(int i = 1; i < n; i++)
//{
//    if(i%3==0)
//    {
//        list.Add(i);
//    }
//}
//list.ForEach(x => Console.Write(x+" "));
Console.ReadLine();
