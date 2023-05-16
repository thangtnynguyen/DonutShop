using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALstatiscal
    {
        Connect connect = new Connect();
        public DataTable getMonthban()
        {
            string sql = "select Month(ngay) as thang,sum(soluong*gia) as tong from hoadonban inner join cthoadonban on hoadonban.mahoadon=cthoadonban.mahoadon group by Month(ngay)";
            return connect.useTable(sql);
        }

        public DataTable getMonthnhap()
        {
            string sql = "select Month(ngay) as thang,sum(soluong*gia) as tong from hoadonnhap inner join cthoadonnhap on hoadonnhap.mahoadon=cthoadonnhap.mahoadon group by Month(ngay)";
            return connect.useTable(sql);
        }

        public DataTable getDaynhap(int x)
        {
            string sql = "select Day(ngay) as ngay,sum(soluong*gia) as tong from hoadonban inner join cthoadonban on hoadonban.mahoadon=cthoadonban.mahoadon" +
                            " where Month(ngay)= '"+x.ToString()+"'" +
                            "group by Day(ngay)";
            return connect.useTable(sql);
        }

        public DataTable getDayban(int x)
        {
            string sql = "select Day(ngay) as ngay,sum(soluong*gia) as tong from hoadonnhap inner join cthoadonnhap on hoadonnhap.mahoadon=cthoadonnhap.mahoadon" +
                            " where Month(ngay)= '" + x.ToString() + "'" +
                            "group by Day(ngay)";
            return connect.useTable(sql);
        }
    }
}
