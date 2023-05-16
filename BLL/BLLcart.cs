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
    public class BLLcart
    {
        DALcart listcart = new DALcart();

        public List<Cart> getlistcart(int x)
        {
            return listcart.getListCart(x);
        }

        public bool CheckBuy(string name, int x, int per)
        {
            int y = listcart.getCheck(name);
            if (x < y)
            {
                listcart.getOrderCart(per);
                DALdonut a = new DALdonut();
                a.getUpdateStatus(name, y - x);
                return true;
            }
            else
                return false;
        }

        public bool CheckAdd(Cart cart)
        {
            listcart.getInsertCart(cart);
            return true;
        }

        public bool CheckDelete(Cart cart)
        {
            listcart.getDeleteCart(cart);
            return true;
        }

        public bool CheckComplete(Cart cart,Bill bill)
        {
            DALbill2 dALbill2 = new DALbill2();
            DALdetails2 dALdetails2 = new DALdetails2();
            if (dALbill2.getCheck(bill.Idbill) != 1)
                dALbill2.getInsertBill(bill);
            detailsbill d = new detailsbill(cart.Donutname, bill.Idbill, cart.Number,cart.Price);
            dALdetails2.getInsertDetails(d);
            listcart.getUpdateCart(cart);
            return true;
        }
    }
}
