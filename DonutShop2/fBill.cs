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
    public partial class fBill : Form
    {
        BLLbill bll = new BLL.BLLbill();
        string matam="";
        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            dgvbill.DataSource = bll.tableBill();
        }

        private void btnaddbill_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || mtbdate.Text.Replace("/","").Split().Length == 0)
            {
                return;
            }
            Bill bill = new Bill(txtid.Text, fHome.username, DateTime.Now);
            if (bll.checkInsertBill(bill))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvbill.DataSource = bll.tableBill();
            }
            else
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
        }

        private void btndeletebill_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || mtbdate.Text.Replace("/", "").Length == 0)
            {
                return;
            }
            Bill bill = new Bill(txtid.Text, fHome.username, DateTime.Now);
            if (bll.checkDeleteBill(bill))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvbill.DataSource = bll.tableBill();
            }
            else
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
        }

        private void btnadddetails_Click(object sender, EventArgs e)
        {
            if (txtSupllies.Text == "" || txtprice.Text==""||txtid.Text=="" ||matam=="")
            {
                return;
            }
            detailsbill details = new detailsbill(txtid.Text,matam, int.Parse(txtnumber.Text), int.Parse(txtprice.Text));
            if (bll.checkInsertDetails(details))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvdetailsbill.DataSource = bll.tableDetails(txtid.Text);
            }
            else
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
        }

        private void btndeletedetails_Click(object sender, EventArgs e)
        {
            if (txtSupllies.Text == "" || txtprice.Text == "" || txtid.Text == "")
            {
                return;
            }
            detailsbill details = new detailsbill(txtSupllies.Text, matam, int.Parse(txtnumber.Text), int.Parse(txtprice.Text));
            if (bll.checkDeleteDetails(details))
            {
                MessageBox.Show("Complete", "report", MessageBoxButtons.OK);
                dgvdetailsbill.DataSource = bll.tableDetails(txtid.Text);
            }
            else
                MessageBox.Show("error", "report", MessageBoxButtons.OK);
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x < 0)
                return;
            txtid.Text = dgvbill["mahoadon", x].Value.ToString();
            matam = txtid.Text;
            mtbdate.Text = dgvbill["ngay", x].Value.ToString();
            dgvdetailsbill.DataSource = bll.tableDetails(txtid.Text);
        }

        private void dgvdetailsbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x < 0)
                return;
            txtSupllies.Text = dgvdetailsbill["idvattu", x].Value.ToString();
            txtnumber.Text = dgvdetailsbill["soluong", x].Value.ToString();
            txtprice.Text = dgvdetailsbill["soluong", x].Value.ToString();
        }
    }
}
