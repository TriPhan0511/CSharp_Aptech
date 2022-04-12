using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class HanhKhach : Nguoi, IEquatable<HanhKhach>, IComparable<HanhKhach>
    {
        int ID { get; set; }
        public VeMayBay VeMayBay { get; set; }
        public int SoLuongVeMayBay { get; set; }

        // Tinh tong tien mot khach hang phai tra
        public decimal TinhTongTien()
        {
            return SoLuongVeMayBay * VeMayBay.GiaVe;
        }

        // Implement interface member IEquatable.Equals(Part)
        public bool Equals(HanhKhach other)
        {
            if (other == null)
            {
                return false;
            }
            return this.ID.Equals(other.ID);
        }

        // Implement interface member IComparable.CompareTo(Part)
        // Default comparer for Part type
        public int CompareTo(HanhKhach other)
        {
            // A null value means that this object is greater
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.TinhTongTien().CompareTo(other.TinhTongTien());
            }
        }

        // Override the base class implementation of Equals(Object)
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            HanhKhach objAsHanhKhach = obj as HanhKhach;
            if (objAsHanhKhach == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsHanhKhach);
            }
        }

        // Override the base class implementation of GetHashCode() 
        public override int GetHashCode()
        {
            return ID;
        }

        // Override the ToString() method
        public override string ToString()
        {
            string gioiTinhString = GioiTinh == GioiTinh.Nam ? "Nam" : "Nu";
            VeMayBay v = VeMayBay;
            string s = $"Ho Ten: {HoTen} - Gioi tinh: {gioiTinhString} - Tuoi: {Tuoi}\n" +
                "Thong tin ve ve may bay:\n" +
                $"Ten Chuyen: {v.TenChuyen} - Ngay gio bay: {v.NgayGioBay} - Gia ve: {v.GiaVe:C2}\n" +
                $"So luong ve may bay: {SoLuongVeMayBay} - Tong tien: {TinhTongTien():C2}";
            return s;
        }
    }
}
