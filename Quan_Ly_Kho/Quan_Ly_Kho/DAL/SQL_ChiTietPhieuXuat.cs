using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Kho.DAL
{
    public class SQL_ChiTietPhieuXuat
    {
        KetNoiDB db = null;
        public SQL_ChiTietPhieuXuat()
        {
            db = new KetNoiDB();
        }


        public DataTable getChiTiet()
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapx"].ToString();
            var query = @"select chitiet.ma
		                , hh.ten
		                , chitiet.soluong
		                , chitiet.dongia
                        , (chitiet.soluong * chitiet.dongia) as thanhtien
                from chitietphieuxuat chitiet
                inner join hanghoa hh on chitiet.hanghoama = hh.ma
                where chitiet.phieuxuatma = '" + id + "'";
            return db.GetDataTable(query);
        }

        public DataTable getHangHoa()
        {
            DataTable dt = new DataTable();
            string query = @"select ma, ten from hanghoa";
            dt = db.GetDataTable(query);
            return dt;
        }

        public bool Insert(int ma, int sl, int dongia)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapx"].ToString();
            var query = @"insert into chitietphieuxuat(phieuxuatma, hanghoama, soluong, dongia) values ('" + id + "', '" + ma + "', '" + sl + "', '" + dongia + "')";
            try
            {
                db.ExcuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int ma, int sl, int dongia, int hh)
        {
            var query = @"update chitietphieuxuat set hanghoama = '" + hh + "', soluong = '" + sl + "', dongia = '" + dongia + "' where ma = '" + ma + "'";
            try
            {
                db.ExcuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int ma)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapx"].ToString();
            var query = @"delete from chitietphieuxuat where ma = '" + ma + "'";
            try
            {
                db.ExcuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
