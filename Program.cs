
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThuVien thuVien = new ThuVien();
            thuVien.ThemSach("S001", "Anh", "Dung");
            thuVien.ThemSach("S002", "Toan", "Tuan");
            thuVien.ThemSach("S003", "Van", "Tu");

            Console.WriteLine("Danh sach trong thu vien: ");
            thuVien.HienThiThongTinSach();

            string maSachCanXoa = "S002";
            string ketQuaXoa = thuVien.XoaSach(maSachCanXoa);
            Console.WriteLine(ketQuaXoa);

            Console.WriteLine("Danh sach sau khi xoa:");
            thuVien.HienThiThongTinSach();
            Console.ReadKey();

            
        }
        
    }
}
