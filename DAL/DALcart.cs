using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALcart
    {
        Connect connect = new Connect();

        public List<Cart> getListCart(int x)
        {
            //userid,username,ghuserid,ghdonutid,ghstatus,sl,donutoutday
            List<Cart> listCart = new List<Cart>();
            string sql = "select ghuserid,ghdonutid,ghstatus,sl,donutprice from CtGioHang inner join donut on CtGioHang.ghdonutid=donut.donutname where ghuserid='"+x+"'";
            connect.Table = connect.useTable(sql);
            foreach (DataRow row in connect.Table.Rows)
            {
                Cart cart = new Cart(row);
                listCart.Add(cart);
            }
            return listCart;
        }

        public DataTable getCart(int id)
        {
            string sql = "select ghdonutid,ghstatus,sl from CtGioHang where ghuserid='"+id.ToString()+"'";
            connect.Table = connect.useTable(sql);
            return connect.Table;
        }

        public void getInsertCart(Cart cart)
        {
            string sql = "Insert into CtGioHang values('"+cart.Username+"','"+cart.Donutname+"','"+cart.Status+"','"+cart.Number.ToString()+"')";
            connect.useQuery(sql);
        }

        public void getDeleteCart(Cart cart)
        {
            string sql = "delete CtGioHang where ghdonutid='"+cart.Donutname+"' and ghuserid='"+cart.Username+"'";
            connect.useQuery(sql);
        }

        public void getUpdateCart(Cart cart)
        {
            string sql = "update CTgiohang set ghstatus ='complete' where userid='" + cart.Username + "' and ghdonutid='" + cart.Donutname + "'";
            connect.useQuery(sql);
        }

        public int getCheck(string name)
        {
            string sql = "select donutnumber from statusdonut where statusid='" + name + "'";
            return connect.useQuery2(sql);
        }

        public void getOrderCart(int x)
        {
            string sql = "Update CtGioHang set ghstatus='ordering' where ghuserid='" + x.ToString() + "'";
            connect.useQuery(sql);
        }
    }
}
