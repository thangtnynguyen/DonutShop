using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLIngredient
    {
        DALdonut donut = new DALdonut();
        DALsupllies supllies = new DALsupllies();
        DALingredient dal = new DALingredient();
        public DataTable tableDonut()
        {
            return donut.getTable();
        }
        public DataTable tableSupllies()
        {
            return supllies.getTableSupllies();
        }
        public DataTable getTable(string name)
        {
            return dal.getTableIngredient(name);
        }
        public bool checkInsert(Ingredient ingredient)
        {
            Supllies supllie = new Supllies(ingredient.Idsupllies, 0);
            if (!donut.getCheck(ingredient.Iddonut) && !supllies.getCheck(supllie))
            {
                dal.getInsertIngredient(ingredient);
                return true;
            }
            return false;
        }
        public bool checkDelete(Ingredient ingredient)
        {
            dal.getDeleteIngredient(ingredient);
            return true;
        }
    }
}
