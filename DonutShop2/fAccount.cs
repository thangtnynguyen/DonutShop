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

namespace DonutShop2
{
    public partial class fAccount : Form
    {
        BLLuser bll = new BLLuser();
        public fAccount()
        {
            InitializeComponent();
            load();
            if (fHome.per == 1)
                dgvaccount.DataSource = bll.tableUser();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtidname.Text == "" || txtpass.Text == "")
                return;
            int x = bll.login(txtidname.Text,txtpass.Text);
            if (x != -1)
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                fHome.per = x;
                fHome.username = txtidname.Text;
                fHome.id = bll.iduser(txtidname.Text);
                if (x == 1)
                    dgvaccount.DataSource = bll.tableUser();
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
            load();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtidname.Text == "" || txtpass.Text == "")
                return;
            if (bll.signup(txtidname.Text,txtpass.Text))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpasswork.Text == ""||txtper.Text=="")
                return;
            if (bll.update(txtidname.Text, int.Parse(txtid.Text),int.Parse(txtper.Text)))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvaccount.DataSource = bll.tableUser();
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                return;
            if (bll.delete(txtid.Text))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvaccount.DataSource = bll.tableUser();
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            fHome.per = 0;
            fHome.username = "";
            fHome.id = -1;
            load();
        }

        private void load()
        {
            if (fHome.per == 1)
            {
                dgvaccount.Visible = true;
                plform.Visible = false;
                plset.Visible = true;
                btnlogin.Visible = false;
                btnsignup.Visible = false;
                btnlogout.Visible = true;
            }
            else if (fHome.per > 1)
            {
                dgvaccount.Visible = false;
                plform.Visible = false;
                plset.Visible = false;
                btnlogin.Visible = false;
                btnsignup.Visible = false;
                btnlogout.Visible = true;
            }
            else
            {
                dgvaccount.Visible = false;
                plform.Visible = true;
                plset.Visible = false;
                btnlogin.Visible = true;
                btnsignup.Visible = true;
                btnlogout.Visible = false;
            }
        }

        private void dgvaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                return;
            txtname.Text = dgvaccount["username", index].Value.ToString();
            txtid.Text = dgvaccount["userid", index].Value.ToString();
            txtpasswork.Text = dgvaccount["userpass", index].Value.ToString();
            txtper.Text = dgvaccount["userper", index].Value.ToString();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
            btnSee.BringToFront();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '\0';
            btnHide.BringToFront();
        }

        private void txtper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
