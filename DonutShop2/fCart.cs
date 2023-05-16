using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DonutShop2
{
    public partial class fCart : Form
    {
        BLLcart bll = new BLL.BLLcart();
        private Panel panel;
        List<Cart> carts;

        public fCart()
        {
            InitializeComponent();
            carts = bll.getlistcart(fHome.id);
            load();
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void load()
        {
            foreach (Cart cart in carts)
            {
                Panel pl = new Panel() { Height = 30, Width = 100 };
                Label label = new Label() { Text = cart.Donutname + " " + cart.Number + " " + cart.Status+" "+cart.Price };
                pl.Controls.Add(label);
                pl.BackColor = Color.FromArgb(64, 142, 145);
                pl.BorderStyle = BorderStyle.FixedSingle;
                flgvCart.Controls.Add(pl);
                pl.Click += clickadd;
            }
        }
        private void clickadd(object sender, EventArgs e)
        {
            panel = sender as Panel;
            if (panel.BackColor != Color.FromArgb(64, 142, 145))
            {
                return;
            }
            foreach (Control ctr in panel.Controls)
            {
                if (ctr is Label)
                {
                    string[] a = ctr.Text.Split(' ');
                    txtidname.Text = a[0] + " " + a[1];
                    txtnumber.Text = a[3];
                    txtprice.Text = a[2];
                    lbprice.Text = a[4];
                    break;
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidname.Text == "" || txtprice.Text == "")
            {
                MessageBox.Show("Do not buy!", "report", MessageBoxButtons.OK);
                return;
            }
            if (bll.CheckBuy(txtidname.Text, int.Parse(txtprice.Text), fHome.id))
                MessageBox.Show("Buy Complete", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Do not buy!", "report", MessageBoxButtons.OK);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtidname.Text == "")
            {
                MessageBox.Show("Error!", "report", MessageBoxButtons.OK);
                return;
            }
            Cart cart = new Cart(fHome.id.ToString(), txtidname.Text,"complete",int.Parse(txtprice.Text),int.Parse(lbprice.Text));
            Bill bill = new Bill(fHome.username + "-" + DateTime.Now.DayOfYear, fHome.username, DateTime.Now);
            if (bll.CheckComplete(cart,bill))
                MessageBox.Show("Complete !", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Error !", "report", MessageBoxButtons.OK);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtidname.Text == "")
            {
                MessageBox.Show("Error!", "report", MessageBoxButtons.OK);
                return;
            }
            Cart cart = new Cart(fHome.id.ToString(), txtidname.Text,"cart", int.Parse(txtprice.Text), int.Parse(lbprice.Text));
            if (bll.CheckDelete(cart))
                MessageBox.Show("Delete Complete !", "report", MessageBoxButtons.OK);
        }

        private void txtprice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
