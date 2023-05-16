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
    public partial class fDetails : Form
    {
        BLLbillall bll = new BLLbillall();
        public fDetails()
        {
            InitializeComponent();
            ccbbillid.DataSource = bll.getidbill();
            ccbbillid.DisplayMember = "mahoadon";
            ccbbillid.ValueMember = "mahoadon";
            ccbuserid.DataSource = bll.getiduser();
            ccbuserid.DisplayMember = "username";
            ccbuserid.ValueMember = "username";
        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2023, 12, 12);
            if (mtbDate.Text.Replace("/", " ").Trim().Length != 0)
                d = DateTime.Parse(mtbDate.Text);
            dgvbill.DataSource = bll.getfilterbill(ccbuserid.Text, ccbbillid.Text, d);
        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x < 0)
                return;
            dgvdetailsbill.DataSource = bll.getdetails(dgvbill["mahoadon", x].Value.ToString());
        }
    }
}
