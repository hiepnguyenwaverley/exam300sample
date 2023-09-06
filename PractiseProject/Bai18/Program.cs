

Console.WriteLine("----Nhap Thang Nam--");

Console.Write("\nNhap Thang:");
string thang = Console.ReadLine();

Console.Write("Nhap Nam :");
string nam = Console.ReadLine();
int th = int.Parse(thang);
int nm = int.Parse(nam);
int songay = 0;
if (th >= 1 && th <= 12)
{
    switch (th)
    {
        case 1: songay = 31; break;
        case 2:
            if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
                songay = 29;
            else
                songay = 28;
            break;
        case 3: songay = 31; break;
        case 4: songay = 30; break;
        case 5: songay = 31; break;
        case 6: songay = 30; break;
        case 7: songay = 31; break;
        case 8: songay = 31; break;
        case 9: songay = 30; break;
        case 10: songay = 31; break;
        case 11: songay = 30; break;
        case 12: songay = 31; break;


    }

    Console.Write(" \nThang " + th + "/" + nm + " co " + songay + " Ngay");
}
Console.ReadLine();