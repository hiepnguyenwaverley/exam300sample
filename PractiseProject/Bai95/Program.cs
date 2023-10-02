Console.Write("Nhap so nguyen n: ");
int n = int.Parse(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[] soluong = new int[n];
float tong = 0;
for (int i = 0; i < n; i++)
{
    soluong[i] = int.Parse(stringArray[i]);
}
for (int i = 0; i < soluong.Length; i++)
{
    tong = tong + soluong[i];
}
float tbc = tong / soluong.Length;
Console.WriteLine("trung binh cong cac so trong mang : "+Math. Round(tbc,1));
Console.ReadLine();