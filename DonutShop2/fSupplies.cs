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
    public partial class fSupplies : Form
    {
        BLLsupllies bll = new BLLsupllies();
        Supllies supllies;
        public fSupplies()
        {
            InitializeComponent();
            dtgvSuplise.DataSource = bll.getTable();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            supllies = new Supllies(txtname.Text, int.Parse(txtsl.Text));
            dtgvSuplise.DataSource = bll.getFilter(supllies);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtsl.Text == "") {
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
                return;
            }
            supllies = new Supllies(txtname.Text, int.Parse(txtsl.Text));
            if (bll.checkDelete(supllies))
            {
                MessageBox.Show("complete", "report", MessageBoxButtons.OK);
                dtgvSuplise.DataSource = bll.getTable();
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtsl.Text == "")
            {
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
                return;
            }
            supllies = new Supllies(txtname.Text, int.Parse(txtsl.Text));
            if (bll.checkInsert(supllies))
            {
                MessageBox.Show("complete", "report", MessageBoxButtons.OK);
                dtgvSuplise.DataSource = bll.getTable();
            }
            else
                MessageBox.Show("Error", "report", MessageBoxButtons.OK);
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgvSuplise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x < 0)
                return;
            txtname.Text = dtgvSuplise["vattuten", x].Value.ToString();
            txtsl.Text = dtgvSuplise["soluong", x].Value.ToString();
        }
    }
}
