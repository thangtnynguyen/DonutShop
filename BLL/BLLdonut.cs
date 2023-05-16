using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLdonut
    {
        DALdonut listdonut = new DALdonut();
        List<Donut> lists;

        public List<Donut> Lists { get => lists; set => lists = value; }

        public BLLdonut()
        {
            this.Lists = listdonut.getListDonut();
        }

        public bool CheckDonuts(Donut donut)
        {
            if (!listdonut.getCheck(donut.Donutname))
                return true;
            return false;
        }

        public bool CheckAdd(Donut donut)
        {
            if (CheckDonuts(donut))
            {
                return false;
            }
            else
            {
                listdonut.getInsert(donut);
                return true;
            }
        }

        public bool CheckUpdate(Donut donut)
        {
            if (CheckDonuts(donut))
            {
                listdonut.getUpdate(donut);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckDelete(Donut donut)
        {
            if (CheckDonuts(donut))
            {
                listdonut.getDelete(donut);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUpdateDonut(Donut donut, int x)
        {
            if (CheckDonuts(donut) && x > 0 && CheckUpdateSupllies(x))
            {
                listdonut.getUpdateStatus(donut.Donutname, x);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUpdateSupllies(int x)
        {
            return listdonut.updateSupplies(x);
        }
    }
}
