using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALuser
    {
        Connect connect = new Connect();
        public DataTable getTableUser()
        {
            string sql = "Select userid,username,userpass,userper from userdonut";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertUser(string name,string pass,int per)
        {
            string sql = "Insert into UserDonut(username,userpass,userper) values('"+name+"','"+pass+"','"+per.ToString()+"')";
            connect.useQuery(sql);
        }

        public void getDeleteUser(string id)
        {
            string sql = "Delete Userdonut where userid='"+id+"'";
            connect.useQuery(sql);
        }

        public void getUpdateUser(int id, int per)
        {
            string sql = "update userdonut set userper='"+per.ToString()+"' where userid='"+id.ToString()+"'";
            connect.useQuery(sql);
        }

        public int login(string name, string pass)
        {
            connect.openConnection();
            //kiemtra
            connect.Command = new SqlCommand();
            connect.Command.CommandType = CommandType.StoredProcedure;
            connect.Command.CommandText = "SP_AuthoLogin";
            connect.Command.Parameters.AddWithValue("@UserName", name);
            connect.Command.Parameters.AddWithValue("@Password", pass);
            connect.Command.Connection = connect.Connection;
            object kq = connect.Command.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            return code;
        }

        public int getIdUser(string name)
        {
            string sql = "Select userid from userdonut where username='"+name+"'";
            return connect.useQuery2(sql);
        }

        public int getCheck(string name)
        {
            string sql = "select count(*) from userdonut where userid='" + name + "'";
            return connect.useQuery2(sql);
        }
    }
}
