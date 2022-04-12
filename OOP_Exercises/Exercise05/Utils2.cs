using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class Utils2
    {
        // Lay thong tin tu user, tu thong tin do khoi tao nen mot VeMayBay object
        public static VeMayBay NhapVeMayBay()
        {
            string tenChuyen = Utils.ReadString("Ten chuyen may bay: ");
            DateTime ngayGioBay = Utils.ReadDateTime("Ngay gio bay");
            decimal giaVe = Utils.ReadDecimal("Gia ve: ");
            return new VeMayBay() { TenChuyen=tenChuyen, NgayGioBay=ngayGioBay, GiaVe=giaVe};
        }

        // Xuat thong tin cua mot VeMayBay object
        public static void XuatVeMayBay(VeMayBay v)
        {
            Console.WriteLine($"Ten Chuyen: {v.TenChuyen} - Ngay gio bay: {v.NgayGioBay} - Gia ve: {v.GiaVe:C2}");
        }

        // Lay thong tin tu user, tu thong tin do khoi tao nen mot Nguoi object
        public static Nguoi NhapNguoi()
        {
            string hoTen = Utils.ReadString("Ten: ");
            GioiTinh gioiTinh = Utils.ReadGioiTinh("Gioi tinh: ");
            int tuoi = Utils.ReadInt("Tuoi:");
            return new Nguoi() { HoTen=hoTen, GioiTinh=gioiTinh, Tuoi=tuoi};
        }

        // Xuat thong tin cua mot Nguoi object
        public static void XuatNguoi(Nguoi n)
        {
            string gioiTinhString = n.GioiTinh == GioiTinh.Nam ? "Nam" : "Nu";
            Console.WriteLine($"Ho Ten: {n.HoTen} - Gioi tinh: {gioiTinhString} - Tuoi: {n.Tuoi}");
        }

        // Lay thong tin tu user, tu thong tin do khoi tao nen mot HanhKhach object
        public static HanhKhach NhapHanhKhach()
        {
            string hoTen = Utils.ReadString("Ten: ");
            GioiTinh gioiTinh = Utils.ReadGioiTinh("Gioi tinh: ");
            int tuoi = Utils.ReadInt("Tuoi:");
            VeMayBay veMayBay = NhapVeMayBay();
            int soLuongVeMayBay = Utils.ReadInt("So luong ve may bay: ");
            return new HanhKhach() { HoTen=hoTen, GioiTinh = gioiTinh, Tuoi = tuoi, VeMayBay =veMayBay, SoLuongVeMayBay=soLuongVeMayBay};
        }

        // Xuat thong tin cua mot HanhKhach object
        public static void XuatHanhKhach(HanhKhach h)
        {
            Console.WriteLine(h);

            //string gioiTinhString = h.GioiTinh == GioiTinh.Nam ? "Nam" : "Nu";
            //VeMayBay v = h.VeMayBay;
            //Console.WriteLine($"Ho Ten: {h.HoTen} - Gioi tinh: {gioiTinhString} - Tuoi: {h.Tuoi}\n" +
            //    "Thong tin ve ve may bay:\n" +
            //    $"Ten Chuyen: {v.TenChuyen} - Ngay gio bay: {v.NgayGioBay} - Gia ve: {v.GiaVe:C2}\n" +
            //    $"So luong ve may bay: {h.SoLuongVeMayBay} - Tong tien: {h.TinhTongTien()}");
        }
    }
}
