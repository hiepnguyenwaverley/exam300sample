//1h=3600s,1p=60s
Console.WriteLine("Nhap so nguyen : ");

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a + b;
int second = c % 60;
int hour = c / 3600;
int minute = c % 3600 / 60;
Console.Write("Tong so giay {0} doi thanh dinh dang gio :{1}:{2}:{3}", c, hour, minute, second);
Console.ReadKey();