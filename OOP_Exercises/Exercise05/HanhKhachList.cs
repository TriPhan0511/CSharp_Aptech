using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class HanhKhachList
    {
        // Nhap vao danh sach cach HanhKhach objects
        public static List<HanhKhach> NhapDanhSachHanhKhach()
        {
            int soLuong = Utils.ReadInt("Nhap vao so luong cac hanh khach: ");
            List<HanhKhach> list = new List<HanhKhach>();
            for (int i = 0; i < soLuong; i++)
            {
                HanhKhach h = Utils2.NhapHanhKhach();
                list.Add(h);
            }
            return list;
        }

        // Hien thi noi dung mot danh sach cac KhachHang obects
        public static void XuatDanhSachHanhKhach(List<HanhKhach> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Danh sach hanh khach rong. Vui long nhap vao danh sach cac hanh khach.");
            }
            else
            {
                foreach (var item in list)
                {
                    Utils2.XuatHanhKhach(item);
                }
            }
            Console.WriteLine();
        }

        // Sap xep mot danh sach cac KhachHang objects theo chieu giam dan cua tong tien
        public static void SapXepDanhSachHanhKhachTheoTongTienGiamDan(List<HanhKhach> list)
        {
            list.Sort();
            list.Reverse();
        }
    }
}
