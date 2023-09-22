using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Sach
{
    public string MaSach { get; set; }
    public string TenSach { get; set; }
    public string TacGia { get; set; }

    public Sach(string maSach, string tenSach, string tacGia)
    {
        MaSach = maSach;
        TenSach = tenSach;
        TacGia = tacGia;
    }
}

    internal class ThuVien
{
    private List<Sach> sachList;

    public ThuVien()
    {
        sachList = new List<Sach>();
    }

    public void ThemSach(string maSach, string tenSach, string tacGia)
    {
        Sach sach = new Sach(maSach, tenSach, tacGia);
        sachList.Add(sach);
    }

    public string XoaSach(string maSach)
    {
        for (int i = 0; i < sachList.Count; i++)
        {
            if (sachList[i].MaSach == maSach)
            {
                sachList.RemoveAt(i);
                return $"Da xoa sach co ma {maSach}";
            }
        }
        return $"Khong tim thay sach co ma {maSach}";
    }

    public void HienThiThongTinSach()
    {
        if (sachList.Count == 0)
        {
            Console.WriteLine("Thu vien trong.");
            return;
        }

        Console.WriteLine("Danh sach trong thu vien:");
        foreach (Sach sach in sachList)
        {
            Console.WriteLine($"Ma sach: {sach.MaSach}, Ten sach: {sach.TenSach}, Tac gia: {sach.TacGia}");
        }
    }
}