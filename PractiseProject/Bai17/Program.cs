

Console.WriteLine("----Nhap Thang--");

Console.Write("\nNhap Thang:");
string thang = Console.ReadLine();

int th = int.Parse(thang);
string mua = "";
if (th >= 1 && th <= 12)
{
    switch (th)
    {
        case 1: mua = "Winter"; break;
        case 2: mua = "Spring";break;
        case 3: mua = "Spring"; break;
        case 4: mua = "Spring"; break;
        case 5: mua = "Summer"; break;
        case 6: mua = "Summer"; break;
        case 7: mua = "Summer"; break;
        case 8: mua = "Fall"; break;
        case 9: mua = "Fall"; break;
        case 10: mua = "Fall"; break;
        case 11: mua = "Winter"; break;
        case 12: mua = "Winter"; break;


    }

    Console.Write(" \nSeason "+mua+ " on the Month " + th+" ");
}
Console.ReadLine();