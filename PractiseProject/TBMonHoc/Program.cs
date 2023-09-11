Console.WriteLine("Nhap so luong mon:");
int n=int.Parse(Console.ReadLine());
int[] soluong=new int[n];
int tong = 0;
double tbc = 0;
for (int i = 0;i<soluong.Length;i++)
{
    Console.WriteLine("Nhap diem mon thu {0}:",i+1);
    soluong[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < soluong.Length; i++)
{

    tong += soluong[i];
}   
tbc=tong/soluong.Length;
Console.WriteLine("Diem trung binh cua cac mon:{0}",tbc);
Console.ReadLine();