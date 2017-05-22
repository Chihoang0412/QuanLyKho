using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho.DAL
{
    class SQL_PhieuNhap
    {
        KetNoiDB db = null;
        public SQL_PhieuNhap()
        {
            db = new KetNoiDB();
        }

        public DataTable GetList()
        {
            DataTable dt = new DataTable();
            string query = @"select pn.ma as mapn
	                        , pn.ten as tenpn
	                        , ncc.ten as tenncc
	                        , pn.ghichu
	                        , pn.ngaynhap
	                        , tk.ma as matk
                        from phieunhap pn
                        inner join taikhoan tk on pn.taikhoanma = tk.ma
                        inner join nhacungcap ncc on pn.nhacungcapma = ncc.ma";
            dt = db.GetDataTable(query);
            return dt;
        }

        public DataTable GetNcc()
        {
            string query = @"select ma, ten from nhacungcap";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(query);
            return dt;
        }

        public int Them(string ten, int ncc, string ghichu)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["user"].ToString();
            string query = @"insert into phieunhap(ten, nhacungcapma, taikhoanma, ghichu)
                            select N'" + ten + "', '" + ncc + "', ma , N'" + ghichu + "' from taikhoan where username = '" + id + "'";

            try
            {
                db.ExcuteNonQuery(query);
            }
            catch
            {
                return 0;
            }
            return 1;
        }

        public int Sua(string ten, int ncc, string ghichu, int ma)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["user"].ToString();
            string query = @"update phieunhap
                            set ten = N'" + ten + "', nhacungcapma = '" + ncc + "', taikhoanma = (select ma from taikhoan where username = '" + id + "'), ghichu = N'" + ghichu + "' where ma = '" + ma + "'";

            try
            {
                db.ExcuteNonQuery(query);
            }
            catch
            {
                return 0;
            }
            return 1;
        }

        public int Xoa(int ma)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["user"].ToString();
            string query = @"delete from PhieuNhap where ma ='" + ma + "'";

            try
            {
                db.ExcuteNonQuery(query);
            }
            catch
            {
                return 0;
            }
            return 1;
        }
    }
}
