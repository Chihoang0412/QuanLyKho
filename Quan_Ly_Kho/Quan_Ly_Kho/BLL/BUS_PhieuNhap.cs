using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Kho.DAL;
using System.Data;

namespace Quan_Ly_Kho.BLL
{
    class BUS_PhieuNhap
    {
        SQL_PhieuNhap sql = null;
        public BUS_PhieuNhap()
        {
            sql = new SQL_PhieuNhap();
        }

        public DataTable GetList()
        {
            return sql.GetList();
        }

        public DataTable getNcc()
        {
            return sql.GetNcc();
        }

        public int Them(string ten, int ncc, string ghichu)
        {
            return sql.Them(ten, ncc, ghichu);
        }
        public int Sua(string ten, int ncc, string ghichu, int ma)
        {
            return sql.Sua(ten, ncc, ghichu, ma);
        }

        public int Xoa (int ma)
        {
            return sql.Xoa( ma);
        }
    }
}
