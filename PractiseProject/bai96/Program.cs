int dem = 0;
float sum = 0;
Console.Write("Nhap so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(stringArray[i]);
}
Console.Write("Cac so chan : ");
for (int i = 0; i < n; i++)
{
    if (a[i] % 2 == 0)
    {
        Console.Write(" " + a[i]);
        sum = sum + a[i];
        dem++;
    }
}
float tbc = sum / dem;

Console.WriteLine("\nTrung binh cong cua cac so trong mang:" + Math.Round(tbc, 2)); // lam tron 2 so thap phan 
Console.ReadLine();

//int tbc = 0;
//Console.WriteLine("Nhap so nguyen duong n : ");
//int n = Convert.ToInt32(Console.ReadLine());   
//List<int> list = new List<int>();
//for (int i = 1; i < n; i++)
//{
//    if(i%2==0)
//    {
//        list.Add(i);
//    }
//}
//list.ForEach(i => Console.Write(i+" "));
//int sum = 0;
//for (int i = 0; i < list.Count; i++)
//{
//    sum = sum + list[i];
//}
//    tbc=sum/list.Count;
//Console.WriteLine("\ntong cua cac so chan : " + sum);
//Console.WriteLine("trung binh cong : "+tbc);
//Console.ReadLine();
//10
//16 28 7 21 4 6 5 8 9 14
