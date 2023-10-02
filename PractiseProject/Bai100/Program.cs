Console.Write("Nhap so nguyen duong n : ");
int n=Convert.ToInt32(Console.ReadLine());
var stringArray = Console.ReadLine().Split(" ");
int[]a=new int[n];
for(int i=0;i<n;i++)
{
    a[i]= int.Parse(stringArray[i]);
    
}
int vt1 = 0;
int vt2 = 0;
int max = a[0];
int min = a[0];
for(int i = 0;i<n;i++)
{
    if (a[i]>max)
    {
        max=a[i];
        vt1=i;
    }
    if (a[i]<min)
    {
        min = a[i];
        vt2= i;

    }    
} 
Console.WriteLine("Max: " + max+" Vi tri " +vt1);
Console.WriteLine("Min: " + min + " Vi tri " + vt2);
Console.ReadLine();

