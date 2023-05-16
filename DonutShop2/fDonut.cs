using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DonutShop2
{
    public partial class fDonut : Form
    {
        BLLdonut checkDonut = new BLLdonut();
        List<Donut> donuts;
        Panel panel;

        public fDonut()
        {
            InitializeComponent();
            donuts = checkDonut.Lists;
            load();
            if(fHome.per==1||fHome.per==2)
            {
                plBuy.Visible = false;
                plmanage.Visible = true;
            }
            else if (fHome.per == 3)
            {
                plBuy.Visible = true;
                plmanage.Visible = false;
            }
            else
            {
                plBuy.Visible = false;
                plmanage.Visible = false;
            }
        }

        private void load()
        {
            foreach (Donut donut in donuts)
            {
                Panel pl = new Panel() { Height = 90, Width = 90 };
                PictureBox pB = new PictureBox()
                {
                    Height = 64,
                    Width = 64,
                    Location = new Point(15, 5),
                    Image = bytetoimage(donut.Donutimage)
                };
                Label label = new Label() { Text = donut.Donutname + " " + donut.Donutprice, Location = new Point(5, 70) };
                pl.Controls.Add(pB);
                pl.Controls.Add(label);
                pl.BackColor = Color.FromArgb(64, 142, 145);
                pl.BorderStyle = BorderStyle.FixedSingle;
                flpDonutview.Controls.Add(pl);
                pl.Click += clickadd;
            }
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openimage = new OpenFileDialog();
                openimage.Filter = "PNG files(*.png)|*.png";
                if (openimage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbview.Image = Image.FromFile(openimage.FileName);
                    //txtnamead.Text =imagetobyte(pbview.Image).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] imagetobyte(System.Drawing.Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private Image bytetoimage(Byte[] bytein)
        {
            using (MemoryStream ms = new MemoryStream(bytein))
            {
                Image image = Image.FromStream(ms);
                return image;
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
                    int x = a.Length;
                    txtname.Text = a[0] + " " + a[1];
                    txtnamead.Text = a[0] + " " + a[1];
                    txtprice.Text = a[x - 1];
                    lbprice.Text= a[x - 1];
                }
                if (ctr is PictureBox)
                {
                    PictureBox a = (PictureBox)ctr;
                    pbview.Image = a.Image;
                }
            }
        }

        private void btnaddcart_Click(object sender, EventArgs e)
        {
            BLLcart checkCart = new BLLcart();
            if (txtnumber.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("Error !", "report", MessageBoxButtons.OK);
                return;
            }
            Cart cart = new Cart(fHome.id.ToString(), txtname.Text, "Cart", int.Parse(txtnumber.Text),int.Parse(lbprice.Text));
            if (checkCart.CheckAdd(cart))
                MessageBox.Show("Complete !", "report", MessageBoxButtons.OK);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnamead.Text=="" ||txtprice.Text==""|| pbview.Image==null)
            {
                return;
            }
            byte[] a = imagetobyte(pbview.Image);
            Donut donutz = new Donut(txtnamead.Text, a, int.Parse(txtprice.Text));
            if (checkDonut.CheckAdd(donutz))
                MessageBox.Show("Add Complete!", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Add Error!", "report", MessageBoxButtons.OK);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtnamead.Text == "" || txtprice.Text == "" || pbview.Image == null)
            {
                return;
            }
            byte[] a = imagetobyte(pbview.Image);
            Donut donutz = new Donut(txtnamead.Text, a, int.Parse(txtprice.Text));
            if (checkDonut.CheckUpdate(donutz))
                MessageBox.Show("Update Complete!", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Update Error!", "report", MessageBoxButtons.OK);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtnamead.Text == "" || txtprice.Text == "" || pbview.Image == null)
            {
                MessageBox.Show("Error!", "report", MessageBoxButtons.OK);
                return;
            }
            byte[] a = null;
            Donut donutz = new Donut(txtnamead.Text, a, int.Parse(txtprice.Text));
            if (checkDonut.CheckDelete(donutz))
                MessageBox.Show("Delete Complete!", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Delete Error!", "report", MessageBoxButtons.OK);
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            flpDonutview.Controls.Clear();
            if (txtprice.Text == "")
                txtprice.Text = "0";
            foreach (Donut donut in donuts)
            {
                if (donut.Donutname == txtnamead.Text || donut.Donutprice == int.Parse(txtprice.Text))
                {
                    Panel pl = new Panel() { Height = 90, Width = 90 };
                    PictureBox pB = new PictureBox() { Height = 64, Width = 64, Location = new Point(15, 5) };
                    Label label = new Label() { Text = donut.Donutname + " " + donut.Donutprice };
                    pl.Controls.Add(pB);
                    pl.Controls.Add(label);
                    pl.BackColor = Color.AliceBlue;
                    flpDonutview.Controls.Add(pl);
                    pl.Click += clickadd;
                }
            }
        }

        private void btnupnumber_Click(object sender, EventArgs e)
        {
            if (txtnamead.Text == "" || txtnumberad.Text == "")
            {
                return;
            }
            byte[] a = null;
            Donut donutz = new Donut(txtnamead.Text, a, int.Parse(txtnumberad.Text));
            if (checkDonut.CheckUpdateDonut(donutz,int.Parse(txtnumberad.Text)))
                MessageBox.Show("Add Complete!", "report", MessageBoxButtons.OK);
            else
                MessageBox.Show("Add Error!", "report", MessageBoxButtons.OK);
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
