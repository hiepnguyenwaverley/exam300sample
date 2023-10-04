
class Program
{
    static void Main(string[] args)
    {
        chuoiphanso c = new chuoiphanso();
        c.Nhap();
        c.Xuat();
        phanso tich = c.tinhtich();
        Console.Write("\nTich  la : ");
        tich.xuat();

        phanso tong = c.tinhtong();
        Console.Write("\nTong  la : ");
        tong.xuat();

        phanso hieu = c.tinhhieu();
        Console.Write("\nHieu  la : ");
        hieu.xuat();

        phanso thuong = c.tinhthuong();
        Console.Write("\nThuong  la : ");
        thuong.xuat();
        Console.ReadLine();
    }
}
class phanso
{
    private float tu, mau;
    public float TuSo
    {
        get { return tu; }
        set { tu = value; }
    }
    public float MauSo
    {
        get { return mau; }
        set
        {
            if (value != 0)
                mau = value;
        }
    }
    public void nhap()
    {
        Console.Write("+ Nhap tu so: ");
        tu = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.Write("+ Nhap tu mau: ");
            mau = Convert.ToInt32(Console.ReadLine());

        } while (mau == 0);

    }
    public static phanso operator +(phanso phanSo1, phanso phanSo2) // toán tử cộng 2 phân  số
    {
        phanso phansoKQ = new phanso();
        phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
        phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
        return phansoKQ;
    }
    public static phanso operator -(phanso phanSo1, phanso phanSo2) // toán tử tru 2 phân số
    {
        phanso phansoKQ = new phanso();
        phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo - phanSo2.TuSo * phanSo1.MauSo;
        phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
        return phansoKQ;
    }
    public static phanso operator *(phanso phanSo1, phanso phanSo2) // toán tử * 2 phân số
    {
        phanso phansoKQ = new phanso();
        phansoKQ.TuSo = phanSo1.TuSo * phanSo2.TuSo;
        phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
        return phansoKQ;
    }
    public static phanso operator /(phanso phanSo1, phanso phanSo2)// toán tử / 2 phân số
    {
        phanso phansoKQ = new phanso();
        phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo;
        phansoKQ.MauSo = phanSo1.MauSo * phanSo2.TuSo;
        return phansoKQ;
    }

    public void xuat()
    {
        Console.Write(" {0}/{1} ", tu, mau);
    }
}
class chuoiphanso
{
    phanso[] ps;
    int n;
    public void Nhap()
    {
        Console.Write("Nhap so luong phan so :");
        n = Convert.ToInt32(Console.ReadLine());
        ps = new phanso[n];
        for (int i = 0; i < n; i++)
        {
            ps[i] = new phanso();
            Console.WriteLine("Phan so thu {0}", i + 1);
            ps[i].nhap();
        }
    }
    public void Xuat()
    {
        for (int i = 0; i < n; i++)
        {
            ps[i].xuat();
            Console.Write(" , ");
        }
    }

    public phanso tinhtong()
    {
        phanso tong = ps[0];
        for (int i = 1; i < n; i++)
        {
            tong = tong + ps[i];
        }
        return tong;
    }
    public phanso tinhhieu()
    {
        phanso hieu = ps[0];
        for (int i = 1; i < n; i++)
        {
            hieu = hieu - ps[i];
        }
        return hieu;
    }
    public phanso tinhtich()
    {
        phanso tich = ps[0];
        for (int i = 1; i < n; i++)
        {
            tich = tich * ps[i];
        }
        return tich;
    }

    public phanso tinhthuong()
    {
        phanso thuong = ps[0];
        for (int i = 1; i < n; i++)
        {
            thuong = thuong / ps[i];
        }
        return thuong;
    }

}

