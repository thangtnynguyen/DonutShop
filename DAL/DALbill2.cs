using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALbill2
    {
        Connect connect = new Connect();
        public DataTable getTableBill()
        {
            string sql = "Select mahoadon,hduserid,ngay from hoadonban";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertBill(Bill bill)
        {
            string sql = "Insert into hoadonban values('" + bill.Idbill + "','" + bill.Userid + "','" + bill.Day.ToString("yyyy-MM-dd") + "')";
            connect.useQuery(sql);
        }

        public void getDeleteBill(Bill bill)
        {
            string sql = "delete hoadonban where mahoadon='" + bill.Idbill + "'";
            connect.useQuery(sql);
        }

        public int getCheck(string name)
        {
            string sql = "select count(*) from hoadonban where mahoadon='" + name + "'";
            return connect.useQuery2(sql);
        }
    }
}
