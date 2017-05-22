using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Kho.DAL;
using System.Data;

namespace Quan_Ly_Kho.BLL
{
    class BUS_ChiThietPhieuNhap
    {
        SQL_ChiTietPhieuNhap sql = null;

        public BUS_ChiThietPhieuNhap()
        {
            sql = new SQL_ChiTietPhieuNhap();
        }

        public DataTable getList()
        {
            return sql.getList();
        }

        public DataTable getHangHoa()
        {
            return sql.getHangHoa();
        }
        public int Them(string ma, string sl, string gia)
        {
            return sql.Them(ma, sl, gia);
        }

        public int Sua(string mahh, string sl, string gia, string ma)
        {
            return sql.Sua(mahh, sl, gia, ma);
        }
        public int Xoa(string ma)
        {
            return sql.Xoa(ma);
        }
    }
}
