using System.Text;
Console.OutputEncoding = Encoding.UTF8;
float pt1 = 0;
float pt2 = 0;
float pt3 = 0;
Console.Write("Nhập số a: ");
float a = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhập số b: ");
float b = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhập số c: ");
float c = Convert.ToInt32(Console.ReadLine());
pt1 = a + b + c;
pt2 = a/b + c;
pt3=a/(b+c);

Console.WriteLine("\t--Kết quả--:");

Console.WriteLine("\t{0} + {1} + {2} = {3}",a,b,c,pt1);
Console.WriteLine("\t{0} / {1} + {2} = {3}", a, b, c, Math.Round(pt2, 2));
Console.WriteLine("\t{0} / ({1} + {2}) = {3}", a, b, c, Math.Round(pt3, 3));
Console.ReadLine();

