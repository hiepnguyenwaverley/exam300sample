int count = 0;
Console.Write("Nhap vao mot so nguyen: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < number; i++)
{
    if (i % 3 == 0)
    {
        count += 1;
    }

}
Console.WriteLine("so luong so chia het cho 3 la : " + count);

Console.ReadLine();