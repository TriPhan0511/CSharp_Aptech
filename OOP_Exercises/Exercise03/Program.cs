using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Program
    {
        // Khai bao mot delegate
        public delegate PhanSo TinhToanTrenHaiPhanSo(PhanSo p1, PhanSo phanSo);

        // Khai bao hai fields
        private PhanSo p1;
        private PhanSo p2;

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
                Console.WriteLine("\n====== Exercise 03 =====");
                Console.WriteLine("1. Nhap vao hai phan so.");
                Console.WriteLine("2. Xuat ra man hinh hai phan so vua nhap.");
                Console.WriteLine("3. Cong hai phan so vua nhap.");
                Console.WriteLine("4. Tru hai phan so vua nhap.");
                Console.WriteLine("5. Nhan hai phan so vua nhap.");
                Console.WriteLine("6. Chia hai phan so vua nhap.");
                Console.WriteLine("7. Thoat ra khoi chuong trinh.");
                choice = Utils.ReadInt("\nLua chon cua ban: ");
                switch (choice)
                {
                    case 1:
                        NhapHaiPhanSo();
                        break;
                    case 2:
                        HienThi(p1, p2);
                        break;
                    case 3:
                        ThucHienPhepTinhTrenHaiPhanSo(Cong, p1, p2);
                        break;
                    case 4:
                        ThucHienPhepTinhTrenHaiPhanSo(Tru, p1, p2);
                        break;
                    case 5:
                        ThucHienPhepTinhTrenHaiPhanSo(Nhan, p1, p2);
                        break;
                    case 6:
                        ThucHienPhepTinhTrenHaiPhanSo(Chia, p1, p2);
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        break;
                }
            } while (choice != 7);
        }

        private void ThucHienPhepTinhTrenHaiPhanSo(TinhToanTrenHaiPhanSo tinhToanDelegate, PhanSo p1, PhanSo p2)
        {
            if (p1 == null || p2 == null)
            {
                Console.WriteLine("Vui long nhap vao gia tri cua hai phan so truoc khi thuc hien phep tinh tren hai phan so.");
            }
            else
            {
                var methodName = tinhToanDelegate.Method.Name;
                PhanSo ketQua = tinhToanDelegate(p1, p2);
                if (ketQua.MauSo == 1)
                {
                    Console.WriteLine($"Ket Qua Cua Phep {methodName} Giua {p1} Va {p2} La {ketQua.TuSo}");
                }
                else
                {
                    Console.WriteLine($"Ket Qua Cua Phep {methodName} Giua {p1} Va {p2} La {ketQua}");
                }
            }
            
        }

        // Lay du lieu tu console sau do gan du lieu do cho hai PhanSo p1 va p2
        private void NhapHaiPhanSo()
        {
            Console.WriteLine("Nhap vao tu so va mau so cho phan so thu nhat.");
            p1 = Nhap();
            Console.WriteLine("Nhap vao tu so va mau so cho phan so thu hai.");
            p2 = Nhap();
        }

        // Hien thi hai PhanSo instances (p1 va p2)
        private void HienThi(PhanSo p1, PhanSo p2)
        {
            if (p1 == null || p2 == null)
            {
                Console.WriteLine("Vui long nhap vao gia tri cua hai phan so truoc khi hien thi.");
            }
            else
            {
                Console.WriteLine("Phan so thu nhat:");
                Xuat(p1);
                Console.WriteLine("Phan so thu hai:");
                Xuat(p2);
            }
        }

        // Lay du lieu nhap vao tu console, sau do tra ve mot PhanSo instance.
        private PhanSo Nhap()
        {
            int tuSo = Utils.ReadInt("Tu so: ");
            int mauSo;
            while (true)
            {
                mauSo = Utils.ReadInt("Mau so: ");
                if (mauSo == 0)
                {
                    Console.WriteLine("Mau so phai khac 0. Moi ban nhap lai mau so.");
                }
                else
                {
                    break;
                }
            }
            return new PhanSo() { TuSo = tuSo, MauSo = mauSo };
        }

        // Hien thi mot PhanSo instance
        private void Xuat(PhanSo phanSo)
        {
            Console.WriteLine($"{phanSo.TuSo}/{phanSo.MauSo}");
        }

        // Cong hai PhanSo instances va tra ve ket qua la mot PhanSo instance.
        private PhanSo Cong(PhanSo p1, PhanSo p2)
        {
            int tuSo = p1.TuSo * p2.MauSo + p2.TuSo * p1.MauSo;
            int mauSo = p1.MauSo * p2.MauSo;
            int remainder = tuSo % mauSo;
            if (remainder == 0)
            {
                tuSo = tuSo / mauSo;
                mauSo = 1;
            }
            return new PhanSo() { TuSo = tuSo, MauSo = mauSo };
        }

        // Tru hai PhanSo instances va tra ve ket qua la mot PhanSo instance.
        private PhanSo Tru(PhanSo p1, PhanSo p2)
        {
            int tuSo = p1.TuSo * p2.MauSo - p2.TuSo * p1.MauSo;
            int mauSo = p1.MauSo * p2.MauSo;
            int remainder = tuSo % mauSo;
            if (remainder == 0)
            {
                tuSo = tuSo / mauSo;
                mauSo = 1;
            }
            return new PhanSo() { TuSo = tuSo, MauSo = mauSo };
        }

        // Chi hai PhanSo instances va tra ve ket qua la mot PhanSo instance.
        private PhanSo Nhan(PhanSo p1, PhanSo p2)
        {
            int tuSo = p1.TuSo * p2.TuSo;
            int mauSo = p1.MauSo * p2.MauSo;
            int remainder = tuSo % mauSo;
            if (remainder == 0)
            {
                tuSo = tuSo / mauSo;
                mauSo = 1;
            }
            return new PhanSo() { TuSo = tuSo, MauSo = mauSo };
        }

        // Nhan hai PhanSo instances va tra ve ket qua la mot PhanSo instance.
        private PhanSo Chia(PhanSo p1, PhanSo p2)
        {
            int tuSo = p1.TuSo * p2.MauSo;
            int mauSo = p1.MauSo * p2.TuSo;
            int remainder = tuSo % mauSo;
            if (remainder == 0)
            {
                tuSo = tuSo / mauSo;
                mauSo = 1;
            }
            return new PhanSo() { TuSo = tuSo, MauSo = mauSo };
        }
    }
}
