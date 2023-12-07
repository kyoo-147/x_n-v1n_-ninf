using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     * 1. PhuongTienGiaoGiao: 
     *    1.1. Phuong thuc khoi tao: Khoi tao gia tri ban dau cho thuoc tinh
     *    1.2. Phuong thuc nhap: Nhap thong tin cho lop PhuongTienGiaoGiao
     *    1.3. Phuong thuc xuat: Xuat thong tin cho lop PhuongTienGiaoGiao
     * 2. Oto: ...
     * 3. XeMay: ...
     * 4. XeTai: ...
     * 5. Them phuong tien giao thong: them 1 phuong tien moi (ôtt, xe tai hoac xe may) vao danh sach can quan ly
     * 6. Xoa phuong tien: Nhap ID (ma phuong tien can xoa) tu ban phim, tim va xoa phuong tien giong voi ID vua nhap khoi danh sach
     * 7. Tim theo hang san xuat: Nhap thong tin hang san xuat, in danh sach cac phuong tien co hang san xuat giong voi hang sx vua nhap
     * 8. Tim theo mau sac: Nhap mau sac muon tim, in danh sach cac phuong tien co mau sac giong voi mau sac vua nhap
     * 9. Thoat chuong trinh
     * */
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyDSPhuongTienGT QLDanhSach = new QuanLyDSPhuongTienGT();
            int ChonChucnang = 0;
            do
            {
                Console.WriteLine("1. Them phuong tien moi");
                Console.WriteLine("2. Xoa phuong tien ");
                Console.WriteLine("3. Tim kiem theo mau sac");
                Console.WriteLine("4. Tim kiem theo hang san xuat");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                ChonChucnang = int.Parse(Console.ReadLine());
                if (ChonChucnang == 1)
                {
                    int ChonPhuongTien = 0;
                    Console.WriteLine("1. Xe may");
                    Console.WriteLine("2. Oto ");
                    Console.WriteLine("3. Xe tai");
                    Console.Write("Chon loai phuong tien:");
                    ChonPhuongTien = int.Parse(Console.ReadLine());
                    if(ChonPhuongTien==1)
                    {
                        XeMay xm = new XeMay();
                        xm.Nhap();
                        QLDanhSach.ThemPhuongTienGiaoThong(xm);
                    }
                    if (ChonPhuongTien == 2)
                    {
                        OTO xm = new OTO();
                        xm.Nhap();
                        QLDanhSach.ThemPhuongTienGiaoThong(xm);
                    }
                    if (ChonPhuongTien == 3)
                    {
                        XeTai xm = new XeTai();
                        xm.Nhap();
                        QLDanhSach.ThemPhuongTienGiaoThong(xm);
                    }
                }
                if (ChonChucnang == 2)
                {
                    int IDmuonxoa = 0;
                    Console.Write("Chon ma phuong tien muon xoa:");
                    IDmuonxoa = int.Parse(Console.ReadLine());
                    QLDanhSach.XoaphuongtienGiaoThong(IDmuonxoa);
                }
                if (ChonChucnang == 3)
                {
                    string mausacmuontim = "";
                    Console.Write("Chon mau sac muon tim:");
                    mausacmuontim = Console.ReadLine();
                    QLDanhSach.TimKiemTheoMauSac(mausacmuontim);
                }
                if (ChonChucnang == 4)
                {
                    string hangsxmuontim = "";
                    Console.Write("Chon hang sx muon tim:");
                    hangsxmuontim = Console.ReadLine();
                    QLDanhSach.TimKiemTheoHangXuat(hangsxmuontim);
                }
                if (ChonChucnang == 5)
                {
                    return;
                }
            } while (true);
        }
    }
}
