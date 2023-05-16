using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALingredient
    {
        Connect connect = new Connect();
        public DataTable getTableIngredient(string name)
        {
            string sql = "select TPdonutid,vattuid,sl from TPdonut where TPdonutid='"+name+"'";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertIngredient(Ingredient ingredient)
        {
            string sql = "Insert into TPdonut values('"+ingredient.Iddonut+"','"+ingredient.Idsupllies+"','"+ingredient.Number.ToString()+"')";
            connect.useQuery(sql);
        }

        public void getDeleteIngredient(Ingredient ingredient)
        {
            string sql = "delete TPdonut where tpdonutid='"+ingredient.Iddonut+"' and vattuid='"+ingredient.Idsupllies+"'";
            connect.useQuery(sql);
        }
    }
}
