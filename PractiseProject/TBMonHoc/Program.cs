Console.WriteLine("Nhap so luong mon:");
int n=int.Parse(Console.ReadLine());
int[] a=new int[n];
int tong = 0;
double tbc = 0;
for (int i = 0;i<n;i++)
{
    Console.WriteLine("Nhap diem mon thu {0}:",i+1);
    a[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{

    tong =tong+a[i];
}   
tbc=tong/a.Length;
Console.WriteLine("Diem trung binh cua cac mon:{0}",tbc);
Console.ReadLine();