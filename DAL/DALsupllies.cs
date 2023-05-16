using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALsupllies
    {
        Connect connect = new Connect();
        public DataTable getTableSupllies()
        {
            string sql = "Select vattuten,soluong from Vattu";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertSupllies(Supllies supllies)
        {
            string sql = "Insert into Vattu values (N'" + supllies.Name + "','"+supllies.Soluong+"')";
            connect.useQuery(sql);
        }

        public void getDeleteSupllies(Supllies supllies)
        {
            string sql = "Delete Vattu where vattuten= N'" + supllies.Name + "'";
            connect.useQuery(sql);
        }

        public DataTable getFilterSupllies(Supllies supllies)
        {
            string sql = "Select vattuten,soluong from Vattu where vattuten='"+supllies.Name+"'";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public bool getCheck(Supllies supllies)
        {
            string sql = "Select count(*) from vattu where vattuten='"+supllies.Name+"'";
            if(connect.useQuery2(sql)>0)
                return false;
            return true;
        }
    }
}
