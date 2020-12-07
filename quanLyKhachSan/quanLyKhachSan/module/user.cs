using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKhachSan.module
{
    class User
    {
        private int id, user_type, id_nvien, gioi_tinh;
        private string t_khoan, m_khau, h_ten, q_quan, ngay_lam;

        public int Id { get => id; set => id = value; }
        public int User_type { get => user_type; set => user_type = value; }
        public int Id_nvien { get => id_nvien; set => id_nvien = value; }
        public string T_khoan { get => t_khoan; set => t_khoan = value; }
        public string Khau { get => m_khau; set => m_khau = value; }
        public string H_ten { get => h_ten; set => h_ten = value; }
        public string Q_quan { get => q_quan; set => q_quan = value; }
        public string Ngay_lam { get => ngay_lam; set => ngay_lam = value; }
        public int Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
    }
}
