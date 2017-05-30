using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Kho.DAL;
using System.Data;

namespace Quan_Ly_Kho.BLL
{
    public class BUS_PhieuXuat
    {
        public SQL_PhieuXuat sql = null;
        public BUS_PhieuXuat()
        {
            sql = new SQL_PhieuXuat();
        }

        public DataTable getList()
        {
            return sql.getList();
        }

        public DataTable getKhachHang()
        {
            return sql.getKhachHang();
        }

        public bool Insert(string ten,  string lydo, int kh, string ghichu)
        {
            return sql.Insert(ten, lydo, kh, ghichu);
        }

        public bool Update(string ten, string lydo, int kh, string ghichu, int ma)
        {
            return sql.Update(ten, lydo, kh, ghichu, ma);
        }

        public bool Delete(int ma)
        {
            return sql.Delete(ma);
        }

        
    }
}
