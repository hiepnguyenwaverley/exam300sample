

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
            if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))   // nam nhuan
                songay = 29;
            else
                songay = 28;
            break;
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            songay = 31; break;
        case 4:
        case 6:
        case 9: 
        case 11: 
            songay = 30; break;
    }

    Console.Write(" \nThang " + th + "/" + nm + " co " + songay + " Ngay");
}
Console.ReadLine();