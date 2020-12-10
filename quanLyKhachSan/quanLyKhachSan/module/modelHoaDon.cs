using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKhachSan.module
{
    class modelHoaDon
    {
        private int id, id_tkhoan, id_dichvu, id_phong, t_tien, id_tang;
        private DateTime gio_vao, gio_ra;
        private string ten_dv, t_nvien, t_khang;

        public int Id { get => id; set => id = value; }
        public int Id_tkhoan { get => id_tkhoan; set => id_tkhoan = value; }
        public int Id_dichvu { get => id_dichvu; set => id_dichvu = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public int T_tien { get => t_tien; set => t_tien = value; }
        public string Ten_dv { get => ten_dv; set => ten_dv = value; }
        public string T_nvien { get => t_nvien; set => t_nvien = value; }
        public string T_khang { get => t_khang; set => t_khang = value; }
        public DateTime Gio_vao { get => gio_vao; set => gio_vao = value; }
        public DateTime Gio_ra { get => gio_ra; set => gio_ra = value; }
        public int Id_tang { get => id_tang; set => id_tang = value; }
    }
}
