//int sum = 0;
//Console.WriteLine("Nhap so phan tu ");
//int n = Convert.ToInt32(Console.ReadLine());
//List<int> list = new List<int>();
//for(int i = 1; i <= n; i++)
//{
//    if(i%5==0)
//    {
//        list.Add(i);
//    }
//}
//Console.Write("Cac so chia het cho 5 la: ");
//list.ForEach(x => Console.Write(x + " "));
//for (int i = 0; i < list.Count; i++)
//{
//    sum = sum + list[i];
//}

//Console.WriteLine($"\nTong cua cac so chia het cho 5: "+sum);
//Console.ReadLine();
//mang 
int sum = 0;
Console.WriteLine("Nhap so nguyen duong n :");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write(" ", i);
    a[i] = int.Parse(Console.ReadLine());
}
Console.Write("Cac so chia het cho 5 :");
for (int i = 0; i < n; i++)
{
    if (a[i] % 5 == 0)
    {
        Console.Write(a[i] + " ");
    }

}
for (int i = 0; i < n; i++)
{
    sum = sum + a[i];
}
Console.WriteLine("\nTong so chia het cho 5 la " + sum);

Console.ReadLine();