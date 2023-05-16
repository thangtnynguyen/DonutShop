using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLstatiscal
    {
        DALstatiscal dal = new DALstatiscal();
        public DataTable getMonthban()
        {
            return dal.getMonthban();
        }

        public DataTable getMonthnhap()
        {
            return dal.getMonthnhap();
        }

        public DataTable getDaynhap(int x)
        {
            return dal.getDayban(x);
        }

        public DataTable getDayban(int x)
        {
            return dal.getDaynhap(x);
        }
    }
}
