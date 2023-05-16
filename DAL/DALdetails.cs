using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALdetails
    {
        Connect connect = new Connect();
        public DataTable getTableDetails(string name)
        {
            string sql = "select idvattu,mahoadon,soluong,gia from cthoadonnhap where mahoadon='"+name+"'";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertDetails(detailsbill details)
        {
            string sql = "Insert into cthoadonnhap values(N'"+details.Idsupllies+"','"+details.Idbill+"','"
                                                            +details.Number.ToString()+"','"+details.Price.ToString()+"')";
            connect.useQuery(sql);
        }

        public void getDeleteDetails(detailsbill details)
        {
            string sql = "delete cthoadonnhap where mahoadon='"+details.Idbill+"' and idvattu='"+details.Idsupllies+"'";
            connect.useQuery(sql);
        }
    }
}
