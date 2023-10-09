
class phanso
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Nhap phan so 1-- ");
        phanso p1 = new phanso();
        p1.Nhap();
        Console.WriteLine("--Nhap phan so 2-- ");
        phanso p2 = new phanso();
        p2.Nhap();
        phanso kq = new phanso();

        Console.Write("\nTong cua 2 phan so: ");
        kq = kq.cong(p1, p2);
        kq = kq.Rutgon(p1, p2);
        kq.Xuat();

        Console.Write("\nHieu cua 2 phan so: ");
        kq = kq.hieu(p1, p2);
        kq = kq.Rutgon(p1, p2);
        kq.Xuat();

        Console.Write("\nTich cua 2 phan so: ");
        kq = kq.tich(p1, p2);
        kq = kq.Rutgon(p1, p2);
        kq.Xuat();

        Console.Write("\nThuong cua 2 phan so: ");
        kq = kq.thuong(p1, p2);
        kq = kq.Rutgon(p1, p2);
        kq.Xuat();
        Console.Read();



    }

    public int tuso { get; set; }
    public int mauso { get; set; }

    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        tuso = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        mauso = Convert.ToInt32(Console.ReadLine());

    }
    public void Xuat()
    {
        Console.Write("{0}/{1}", tuso, mauso);

    }
    public int UCLN(int a, int b)
    {
        a = tuso;
        b = mauso;
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    }
    public phanso cong(phanso p1, phanso p2)
    {
        phanso kq = new phanso();
        kq.tuso = p1.tuso * p2.mauso + p2.tuso * p1.mauso;
        kq.mauso = p1.mauso * p2.mauso;
        return kq;
    }
    public phanso hieu(phanso p1, phanso p2)
    {
        phanso kq = new phanso();
        kq.tuso = p1.tuso * p2.mauso - p2.tuso * p1.mauso;
        kq.mauso = p1.mauso * p2.mauso;
        return kq;
    }
    public phanso tich(phanso p1, phanso p2)
    {
        phanso kq = new phanso();
        kq.tuso = p1.tuso * p2.tuso;
        kq.mauso = p1.mauso * p2.mauso;
        return kq;
    }
    public phanso thuong(phanso p1, phanso p2)
    {
        phanso kq = new phanso();
        kq.tuso = p1.tuso * p2.mauso;
        kq.mauso = p1.mauso * p2.tuso;
        return kq;
    }
    public phanso Rutgon(phanso p1, phanso p2)
    {
        phanso rutgon = new phanso();
        int ucln = UCLN(tuso, mauso);
        if (ucln != 0)
        {
            rutgon.tuso = tuso / ucln;
            rutgon.mauso = mauso / ucln;
        }
        else
        {
            rutgon.tuso = tuso;
            rutgon.mauso = mauso;
        }

        return rutgon;
    }


}


