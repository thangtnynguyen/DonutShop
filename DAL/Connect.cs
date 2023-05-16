using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        string kn = @"Data Source=DESKTOP-EJFHH2L\SQLEXPRESS;Initial Catalog=Donut;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        SqlDataReader reader;
        string stringconnection;

        public Connect()
        {
            this.connection = new SqlConnection(kn);
        }

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataTable Table { get => table; set => table = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public string Stringconnection { get => stringconnection; set => stringconnection = value; }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public void useQuery(string sql)
        {
            openConnection();
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void useQuery(string sql,Donut donut)
        {
            openConnection();
            command = new SqlCommand(sql, connection);
            //command.CommandText = sql;
            command.Parameters.Add("@donutname", donut.Donutname);
            command.Parameters.Add("@donutimage", donut.Donutimage);
            command.Parameters.Add("@donutprice", donut.Donutprice);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public DataTable useTable(string sql)
        {
            openConnection();
            table = new DataTable();
            adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(table);
            closeConnection();
            return table;
        }

        public DataTable useTableGet(string sql)
        {
            openConnection();
            table = new DataTable();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            table.Load(reader);
            closeConnection();
            return table;
        }

        public int useQuery2(string sql)
        {
            openConnection();
            command = new SqlCommand(sql, connection);
            int x = (int)command.ExecuteScalar();
            closeConnection();
            return x;
        }
    }
}
