int tbc;
int sum = 0;
Console.WriteLine("Nhap so n :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so m : ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    sum += i;
}
tbc = sum / (m - n + 1);
Console.WriteLine("Trung binh cong tu so n den so m :" + tbc);
Console.ReadLine();