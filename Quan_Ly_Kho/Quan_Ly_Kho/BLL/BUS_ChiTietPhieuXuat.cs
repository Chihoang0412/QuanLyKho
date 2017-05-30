using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Kho.DAL;
using System.Data;

namespace Quan_Ly_Kho.BLL
{
    public class BUS_ChiTietPhieuXuat
    {
        SQL_ChiTietPhieuXuat sql = null;
        public BUS_ChiTietPhieuXuat()
        {
            sql = new SQL_ChiTietPhieuXuat();
        }
        public DataTable getChiTiet()
        {
            return sql.getChiTiet();
        }

        public DataTable getHangHoa()
        {
            return sql.getHangHoa();
        }

        public bool Insert(int ma, int sl, int dongia)
        {
            return sql.Insert(ma, sl, dongia);
        }

        public bool Update(int ma, int sl, int dongia , int hh)
        {
            return sql.Update(ma, sl, dongia , hh);
        }

        public bool Delete(int ma)
        {
            return sql.Delete(ma);
        }
    }
}
