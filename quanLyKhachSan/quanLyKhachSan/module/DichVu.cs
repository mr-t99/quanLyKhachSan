using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKhachSan.module
{
    class DichVu
    {
        string t_dvu;
        int gia, s_luong, t_tien;

        public string T_dvu { get => t_dvu; set => t_dvu = value; }
        public int Gia { get => gia; set => gia = value; }
        public int S_luong { get => s_luong; set => s_luong = value; }
        public int T_tien { get => t_tien; set => t_tien = value; }
    }
}
