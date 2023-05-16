using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutShop2
{
    public partial class fHome : Form
    {
        public static int per = 0;
        public static int id = 0;
        public static string username;

        Form activeForm;
        Color colorc = Color.FromArgb(179, 229, 190);
        bool flag = false;
        Point start;
        Panel anclick;
        Button btnnow;

        public fHome()
        {
            InitializeComponent();
            openChildForm(new fDonut());
            ActiveButton(btnDonut, colorc);
            anclick = new Panel();
            plmenu.Controls.Add(anclick);
        }

        private void ActiveButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                destroybtn();
                btnnow = (Button)senderbtn;
                btnnow.BackColor = Color.FromArgb(0, 50, 130);
                btnnow.ForeColor = color;
                btnnow.TextAlign = ContentAlignment.MiddleCenter;

                anclick.BackColor = color;
                anclick.Location = new Point(0, btnnow.Location.Y);
                anclick.Visible = true;
                anclick.BringToFront();
            }
        }

        private void destroybtn()
        {
            if (btnnow != null)
            {
                btnnow.BackColor = Color.FromArgb(128,128,255);
                btnnow.ForeColor = Color.WhiteSmoke;
                btnnow.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openChildForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            plactive.Controls.Add(activeForm);
            plactive.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void plcontrol_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            start = new Point(e.X, e.Y);
        }

        private void plcontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }

        private void plcontrol_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            destroybtn();
            ActiveButton(sender, colorc);
            activeForm.Close();
        }

        private void btnDonut_Click(object sender, EventArgs e)
        {
            destroybtn();
            ActiveButton(sender, colorc);
            openChildForm(new fDonut());
        }

        private void btnvattu_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 1 && fHome.per != 2)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fSupplies());
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 1 && fHome.per != 2)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fBill());
        }

        private void btngiohang_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 3)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fCart());
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 1)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fDetails());
        }

        private void btnstatistical_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 1)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fStatistical());
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            destroybtn();
            if (fHome.per != 1 && fHome.per != 2)
            {
                return;
            }
            ActiveButton(sender, colorc);
            openChildForm(new fIngredient());
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            destroybtn();
            ActiveButton(sender, colorc);
            Form form = new fAccount();
            openChildForm(form);
        }

        public void Loadformhome()
        {
            if (fHome.per == 0)
            {
                btngiohang.Visible = false;
                btnHoadon.Visible = false;
                btndetail.Visible = false;
                btnvattu.Visible = false;
                btnstatistical.Visible = false;
                btnIngredient.Visible = false;
            }
            else if (fHome.per == 1)
            {
                btngiohang.Visible = false;
                btnHoadon.Visible = true;
                btndetail.Visible = true;
                btnvattu.Visible = true;
                btnstatistical.Visible = true;
                btnIngredient.Visible = true;
            }
            else if (fHome.per == 2)
            {
                btngiohang.Visible = false;
                btnHoadon.Visible = true;
                btndetail.Visible = false;
                btnvattu.Visible = true;
                btnstatistical.Visible = false;
                btnIngredient.Visible = true;
            }
            else
            {
                btngiohang.Visible = true;
                btnHoadon.Visible = false;
                btndetail.Visible = false;
                btnvattu.Visible = false;
                btnstatistical.Visible = false;
                btnIngredient.Visible = false;
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Loadformhome();
            ActiveButton(btnaccount, colorc);
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            Loadformhome();
        }
    }
}
