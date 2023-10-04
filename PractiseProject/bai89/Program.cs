
class Program
{
    public static long GT(int a)
    {
        int kq = 1;
        for (int i = 1; i <= a; i++)
        {
            kq = kq * i;
        }
        return kq;
    }
    public static long Tohop(int n, int k)
    {
        return GT(n) / (GT(k) * GT(n - k));

    }
    public static void Main()
    {
        Console.Write("Nhap so n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so k : ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Giai Thua cua n va k :"+GT(n)+","+GT(k));
        Console.Write("Ket qua :{0} / {1} * {2} = {3}",GT(n),GT(k),GT(n-k),Tohop(n, k));
        Console.ReadKey();
    }
}
