using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class Program
    {
        private List<HanhKhach> list = new List<HanhKhach>();

        static void Main(string[] args)
        {
            (new Program()).DisplayOptions();
            //Console.ReadLine(); // Pause the program
        }

        private void DisplayOptions()
        {

            int choice;
            do
            {
                // Menu options
                Console.WriteLine("\n-----Chao mung den voi chuong trinh quan ly hanh khach!-----\n");
                Console.WriteLine("1. Nhap vao danh sach cac hanh khach.");
                Console.WriteLine("2. Hien thi danh sach cac hanh khach.");
                Console.WriteLine("3. Sap xep danh sach cac hanh khach theo chieu giam dan cua tong tien va hien thi.");
                Console.WriteLine("4. Thoat khoi chuong trinh.");
                choice = Utils.ReadInt("\nLua chon cua ban: ");
                switch (choice)
                {
                    case 1:
                        list = HanhKhachList.NhapDanhSachHanhKhach();
                        break;
                    case 2:
                        HanhKhachList.XuatDanhSachHanhKhach(list);
                        break;
                    case 3:
                        HanhKhachList.SapXepDanhSachHanhKhachTheoTongTienGiamDan(list);
                        HanhKhachList.XuatDanhSachHanhKhach(list);
                        break;
                    case 4:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        break;
                }
            } while (choice != 4);
        }
    }
}
