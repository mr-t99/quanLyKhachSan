using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKhachSan.module
{
    class ModelPhong
    {
        string t_phong, t_thietBi, t_thaiTb;
        int id_phong, id_tang, id_tthaiPhong, id_thietBi, gia;

        public string T_phong { get => t_phong; set => t_phong = value; }
        public string T_thietBi { get => t_thietBi; set => t_thietBi = value; }
        public string T_thaiTb { get => t_thaiTb; set => t_thaiTb = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public int Id_tang { get => id_tang; set => id_tang = value; }
        public int Id_tthaiPhong { get => id_tthaiPhong; set => id_tthaiPhong = value; }
        public int Id_thietBi { get => id_thietBi; set => id_thietBi = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
