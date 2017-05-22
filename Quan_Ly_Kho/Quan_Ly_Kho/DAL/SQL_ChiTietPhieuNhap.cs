using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho.DAL
{
    class SQL_ChiTietPhieuNhap
    {
        KetNoiDB db = null;
        public SQL_ChiTietPhieuNhap()
        {
            db = new KetNoiDB();
        }

        public DataTable getList()
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapn"].ToString();
            DataTable dt = new DataTable();
            string query = @"select chitiet.ma as machitiet
		                    , chitiet.phieunhapma as mapn
		                    , hh.ten as tenhh
		                    , chitiet.soluong
		                    , chitiet.dongia
                    from chitietphieunhap chitiet
                    inner join hanghoa hh on chitiet.hanghoama = hh.ma
                    where chitiet.phieunhapma = '" + id + "'";
            dt = db.GetDataTable(query);
            return dt;
        }

        public DataTable getHangHoa()
        {
            DataTable dt = new DataTable();
            string query = @"select ma, ten from hanghoa";
            dt = db.GetDataTable(query);
            return dt;
        }

        public int Them(string ma, string sl, string gia)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapn"].ToString();
            string query = @"insert into chitietphieunhap(phieunhapma, hanghoama, soluong, dongia)
                            values('" + id + "', '" + ma + "', '" + sl + "' ,'" + gia + "')";
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

        public int Sua(string mahh, string sl, string gia, string ma)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapn"].ToString();
            string query = @"update chitietphieunhap
                            set hanghoama = '" + mahh + "', soluong = '" + sl + "', dongia = '" + gia + "' where ma = '" + ma + "'";
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

        public int Xoa(string ma)
        {
            string id = System.Configuration.ConfigurationManager.AppSettings["mapn"].ToString();
            string query = @"delete from chitietphieunhap where ma = '" + ma + "'";
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
