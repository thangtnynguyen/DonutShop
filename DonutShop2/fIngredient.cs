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
    public partial class fIngredient : Form
    {
        BLLIngredient bll = new BLLIngredient();
        public fIngredient()
        {
            InitializeComponent();
            DataTable donuttable= bll.tableDonut();
            ccbdonut.DataSource = donuttable;
            ccbdonut.DisplayMember = "donutname";
            ccbdonut.ValueMember = "donutname";
            cbbsupllies.DataSource = bll.tableSupllies();
            cbbsupllies.DisplayMember = "vattuten";
            cbbsupllies.ValueMember = "vattuten";
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            if (ccbdonut.Text == "")
            {
                return;
            }
            dgvingredient.DataSource= bll.getTable(ccbdonut.Text);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cbbsupllies.Text == "" || ccbdonut.Text == "" || txtnumber.Text == "")
                return;
            Supllies supllies = new Supllies(cbbsupllies.Text, 0);
            Ingredient ingredient = new Ingredient(ccbdonut.Text, cbbsupllies.Text, float.Parse(txtnumber.Text));
            if (bll.checkInsert(ingredient))
            {
                MessageBox.Show("complete", "report", MessageBoxButtons.OK);
                dgvingredient.DataSource = bll.getTable(ccbdonut.Text);
            }
            else
            {
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (cbbsupllies.Text == "" || ccbdonut.Text == "" || txtnumber.Text == "")
                return;
            Ingredient ingredient = new Ingredient(ccbdonut.Text, cbbsupllies.Text, float.Parse(txtnumber.Text));
            if (bll.checkDelete(ingredient))
            {
                MessageBox.Show("complete", "report", MessageBoxButtons.OK);
                dgvingredient.DataSource = bll.getTable(ccbdonut.Text);
            }
            else
            {
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
            }
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvingredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x < 0)
                return;
            ccbdonut.SelectedItem = dgvingredient["vattuid",x].Value.ToString();
            txtnumber.Text = dgvingredient["sl", x].Value.ToString();
        }
    }
}
