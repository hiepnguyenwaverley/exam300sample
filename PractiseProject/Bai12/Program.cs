
Console.WriteLine("Nhap so nguyen n 3 chu so : ");
int n = Convert.ToInt32(Console.ReadLine());
if (n /10 >= 10 && n % 100 >= 10)
{ 
    Console.WriteLine("\n=>" + n / 10 + " " + n % 100); 
}
else
{
    Console.WriteLine("\n" + n / 10 + " " + "0" + n % 100);// chia cho /10 lay 2 chu so dau tien , chia cho %100 lay 2 so du ,
                                                           // neu 2 chu so co 0 phia truoc thi van in 
}

Console.ReadKey();
