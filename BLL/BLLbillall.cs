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
    public class BLLbillall
    {
        DALbillall dal = new DALbillall();

        public DataTable getidbill()
        {
            return dal.getidbill();
        }

        public DataTable getiduser()
        {
            return dal.getiduser();
        }

        public DataTable getfilterbill(string name, string id, DateTime d)
        {
            return dal.getfilterbill(name, id, d);
        }

        public DataTable getdetails(string name)
        {
            return dal.getdetails(name);
        }
    }
}
