
static bool IsTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}


Console.WriteLine("Nhập ba giá trị a, b, c:");

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

Console.Write("c = ");
int c = int.Parse(Console.ReadLine());

if (IsTriangle(a, b, c))
{
    Console.WriteLine("Ba giá trị này có thể là ba cạnh của một tam giác.");
}
else
{
    Console.WriteLine("Ba giá trị này không thể là ba cạnh của một tam giác.");
}

