using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALbill
    {
        Connect connect = new Connect();
        public DataTable getTableBill()
        {
            string sql = "Select mahoadon,hduserid,ngay from hoadonnhap";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertBill(Bill bill)
        {
            string sql = "Insert into hoadonnhap values('"+bill.Idbill+"','"+bill.Userid+"','"+bill.Day.ToString("yyyy-MM-dd")+"')";
            connect.useQuery(sql);
        }

        public void getDeleteBill(Bill bill)
        {
            string sql = "delete hoadonnhap where mahoadon='"+bill.Idbill+"'";
            connect.useQuery(sql);
        }

        public DataTable getFilterBill(Bill bill)
        {
            string sql = "Select mahoadon,hduserid,ngay from hoadonnhap where mahoadon='"+bill.Idbill
                                                                    + "' or hduserid='" + bill.Userid 
                                                                    + "' or ngay='" + bill.Day + "'";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public int getCheck(string name)
        {
            string sql = "select count(*) from hoadonnhap where mahoadon='" + name + "'";
            return connect.useQuery2(sql);
        }
    }
}
