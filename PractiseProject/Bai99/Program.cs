
static Boolean sochinhphuong(int n)
{
    bool scp = false;
    for (int i = 1; i < n ; i++)
    {
        if (i * i == n)
        {
            return true;
        }
    }
    if (scp)
    {
        return true;
    }
    else
        return false;
     
}
int dem = 0;
float tong = 0;
float tbc = 0;
Console.Write("Nhap 1 dong so nguyen n:");
int n=Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(stringArray[i]);
}

for (int i = 0; i < n; i++)
{
    if (sochinhphuong(a[i]))
    {
        Console.Write(" " + a[i]);
        tong =tong + a[i];
        dem++;
    }
}
tbc = tong / dem;
Console.WriteLine("\nTrung binh cong cua cac so chinh phuong: " +Math.Round(tbc,1));
Console.ReadLine();
