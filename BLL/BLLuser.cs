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
    public class BLLuser
    {
        DALuser dal = new DALuser();
        public int login(string name,string pass)
        {
            int x = dal.login(name, pass);
            if (x != 1 && x != 2 && x != 3)
                return -1;
            return x;
        }
        public bool signup(string name,string pass)
        {
            if (dal.getCheck(name)>0)
            {
                return false;
            }
            dal.getInsertUser(name, pass, 3);
            return true;
        }
        public bool update(string name, int id,int per)
        {
            if (dal.getCheck(name) == 0)
            {
                return false;
            }
            dal.getUpdateUser(id, per);
            return true;
        }
        public bool delete(string name)
        {
            if (dal.getCheck(name) == 0)
            {
                return false;
            }
            dal.getDeleteUser(name);
            return true;
        }
        public int iduser(string name)
        {
            return dal.getIdUser(name);
        }
        public DataTable tableUser()
        {
            return dal.getTableUser();
        }
    }
}
