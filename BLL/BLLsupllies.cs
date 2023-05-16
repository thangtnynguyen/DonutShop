using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLsupllies
    {
        DALsupllies dal = new DALsupllies();
        Connect connect = new Connect();
        public DataTable getTable()
        {
            return dal.getTableSupllies();
        }

        public bool checkInsert(Supllies supllies)
        {
            if (dal.getCheck(supllies))
            {
                dal.getInsertSupllies(supllies);
                return true;
            }
            return false;
        }

        public bool checkDelete(Supllies supllies)
        {
            if (!dal.getCheck(supllies))
            {
                dal.getDeleteSupllies(supllies);
                return true;
            }
            return false;
        }

        public DataTable getFilter(Supllies supllies)
        {
            return dal.getFilterSupllies(supllies);
        }
    }
}
