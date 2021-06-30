using System;
using System.Collections.Generic;
using System.Text;
using QuảnLýCửaHàng11;

namespace program
{
    internal class Program
    {
        private static List<SanPham>
            _sanPhams = new List<SanPham>();
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("------------Menu---------------");
                Console.WriteLine("1: Thêm hồ sơ sản phẩm :");
                Console.WriteLine("2: Hiể thị hồ sơ sản phẩm:  ");
                Console.WriteLine("3: Xóa sản phẩm theo Id: ");
                Console.WriteLine("4: Thoát: ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("vui long nhap lua chon 1 > 4");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TaoMoiSanPham();
                        break;
                    case 2:
                        HienThiDanhSachSanPham();
                        break;
                    case 3: XoaSanPham();
                        break;
                }

                if (choice == 4)
                {
                    break;
                }

                Console.ReadLine();
            }
        }
        public static void TaoMoiSanPham()
        {
            var sanPham = new SanPham();
            Console.WriteLine("vui long nhap Id: ");
            sanPham.Id = Console.ReadLine();
            Console.WriteLine("vui long nhap Name san pham: ");
            sanPham.Name = Console.ReadLine();
            Console.WriteLine("vui long nhap Price: ");
            sanPham.Price = double.Parse(Console.ReadLine());
            _sanPhams.Add(sanPham);
            
        }

        public static void HienThiDanhSachSanPham()
        {
            Console.WriteLine("Id       Name       Price");
            foreach (var thongtin in _sanPhams)
            {
                Console.WriteLine(thongtin.ToString());
            }
        }

        public static void XoaSanPham()
        {
            Console.WriteLine("vui long nhap id can xoa: ");
            var id = Console.ReadLine();
            for (int i = 0; i < _sanPhams.Count; i++)
            {
                var sanPham = _sanPhams[i];
                if (sanPham.Id.Equals(id))
                {
                    Console.WriteLine($"Tim thay sản pham co id {id} voi ten la : ");
                    Console.WriteLine("Bann co chac muon xoa (có/không)");
                    var luachon = Console.ReadLine();
                    if (luachon.ToLower().Equals("c"))  
                    {
                      _sanPhams.RemoveAt(i);
                      Console.WriteLine("xoa san pham thanh cong: ");
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay san pham!");
                    }
                    break;
                }
            }
        }
    }
}