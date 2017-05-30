using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Kho.DAL
{
    public class SQL_PhieuXuat
    {
        KetNoiDB db = null;
        public SQL_PhieuXuat()
        {
            db = new KetNoiDB();
        }

        public DataTable getList()
        {
            var query = @"select  px.ma
		            , px.ten tenPx
		            , px.ngayxuat
		            , px.lydoxuat
		            , kh.ten tenKh
		            , px.ghichu
            from phieuxuat px
            inner join khachhang kh on px.khachhangma = kh.ma";
            return db.GetDataTable(query);
        }

        public DataTable getKhachHang()
        {
            var query = @"select ma, ten from khachhang";
            return db.GetDataTable(query);
        }

        public bool Insert(string ten, string lydo, int kh, string ghichu)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["user"].ToString();
            var query = @"insert into phieuxuat(ten, lydoxuat, khachhangma, taikhoanma, ghichu)
                            values (N'"+ten+"',  N'"+lydo+"', '"+kh+"', (select ma from taikhoan where username = '"+id+"'), N'"+ghichu+"')";
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

        public bool Update(string ten, string lydo, int kh, string ghichu, int ma)
        {
            var query = @"update phieuxuat
                            set ten = N'"+ten+"', lydoxuat = N'"+lydo+"', khachhangma = '"+kh+"', ghichu = N'"+ghichu+"' where ma = '"+ma+"'";
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
            var query1 = @"delete from chitietphieuxuat where phieuxuatma = '"+ma+"'";
            var query2 = @"delete from phieuxuat where ma = '"+ma+"'";
            try
            {
                db.ExcuteNonQuery(query1);
                db.ExcuteNonQuery(query2);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        //public DataTable getHangHoa()
        //{
        //    string 
        //}
    }
}
