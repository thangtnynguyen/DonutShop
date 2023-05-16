using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALbillall
    {
        Connect connect = new Connect();
        public DataTable getidbill()
        {
            string sql = "select mahoadon " +
                            "from (select mahoadon, hduserid, ngay from hoadonban union all select mahoadon, hduserid, ngay from hoadonnhap) " +
                            "as nhap";
            return connect.useTable(sql);
        }

        public DataTable getiduser()
        {
            string sql = "select userid,username from userdonut";
            return connect.useTable(sql);
        }

        public DataTable getfilterbill(string name,string id,DateTime d)
        {
            string sql = "select mahoadon,hduserid,ngay " +
                "from (select mahoadon, hduserid, ngay from hoadonban union all select mahoadon, hduserid, ngay from hoadonnhap) as nhap " +
                "where hduserid = '"+name+"' or mahoadon = '"+id+"' or ngay='"+d.ToString("yyyy-MM-dd")+"'";
            return connect.useTable(sql);
        }

        public DataTable getdetails(string name)
        {
            string sql = "select iddonut as id,mahoadon,soluong,gia " +
                "from (select iddonut, mahoadon, soluong, gia  from cthoadonban union all select idvattu, mahoadon, soluong, gia  from cthoadonnhap)" +
                " as nhap where mahoadon = '"+name+"'";
            return connect.useTable(sql);
        }
    }
}
