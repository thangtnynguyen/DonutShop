using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALdonut
    {
        Connect connect = new Connect();
        public List<Donut> getListDonut()
        {
            List<Donut> listDonut = new List<Donut>();
            string sql = "Select donutname,donutimg,donutprice from Donut";
            connect.Table = connect.useTable(sql);
            foreach (DataRow row in connect.Table.Rows)
            {
                Donut donut = new Donut(row);
                listDonut.Add(donut);
            }
            return listDonut;
        }

        public void getUpdateStatus(string name, int x)
        {
            string sql = "Update StatusDonut set donutnumber=donutnumber +'" + x.ToString() + "' where statusid=N'" + name + "'";
            connect.useQuery(sql);
        }

        public void getInsert(Donut donut)
        {
            string sql = "Insert into Donut values(@donutname,@donutimage,@donutprice)";
            connect.useQuery(sql, donut);
            sql = "Insert into StatusDonut values(N'" + donut.Donutname + "','0')";
            connect.useQuery(sql);
        }

        public void getDelete(Donut donut)
        {
            string sql = "Delete Donut where donutname=N'" + donut.Donutname + "'";
            connect.useQuery(sql);
            sql = "Delete StatusDonut where statusid=N'" + donut.Donutname + "'";
            connect.useQuery(sql);
        }

        public void getUpdate(Donut donut)
        {
            string sql = "Update Donut set donutimg=@donutimage, donutprice=@donutprice where donutname=@donutname";
            connect.useQuery(sql, donut);
        }

        public DataTable getTable()
        {
            string sql = "Select donutname from Donut";
            return connect.useTable(sql);
        }

        public bool getCheck(string name)
        {
            string sql = "Select count(*) from Donut where donutname='" + name + "'";
            if (connect.useQuery2(sql) > 0)
                return false;
            return true;
        }

        public bool updateSupplies(int x)
        {
            string sql = "Set xact_abort on " +
                        "begin tran " +

                        "declare @ten nvarchar(20) " +
                        "declare @sl int " +
                        "declare tro cursor " +
                        "for (select vattuid, sl from TPdonut where tpdonutid = N'Apple donut') " +
                        "                open tro " +
                        "fetch next from tro into @ten,@sl " +
                        "while @@FETCH_STATUS = 0 " +
                        "begin " +
                        "    update vattu set soluong = soluong - @sl*'"+x+"' where vattuten = @ten " +

                        "    fetch next from tro into @ten,@sl " +
                        "end " +
                        "close tro " +
                        "deallocate tro " +

                        "commit";
            try { connect.useQuery(sql);
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
