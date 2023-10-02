//Số nguyên tố là tập hợp những số tự nhiên chỉ chia hết cho 1 và cho chính nó.
static Boolean songuyento(int n)
{
    bool snt = true;
    for(int i = 2; i < n; i++)
    {
        if(n%i==0)
        {
            return false;
        }
    }
    if(snt)
        return true;
    else
        return false;
}
int count = 0;
int dem = 0;
Console.Write("Nhap so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[]a= new int[n];
for(int i = 0; i < n;i++)
{
    a[i] = int.Parse(stringArray[i]);
}
Console.Write("\n=>Cac so nguyen to : ");
for (int i = 0; i < n;i++)
{
    if (songuyento(a[i]))
    {
        count=count+1;
        dem++;
        Console.Write(" " + a[i]);   
    }
}
Console.WriteLine("\nTrong mang co {0} so nguyen to", count);
Console.ReadLine();
//14
//3 4 4 6 7 8 9 10 11 12 13 14 15 16 17