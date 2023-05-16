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
    public partial class fStatistical : Form
    {
        BLLstatiscal bll = new BLLstatiscal();
        public fStatistical()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DataTable ban = bll.getMonthban();
            DataTable nhap = bll.getMonthnhap();
            cThang.Titles.Add("Statiscal");
            cThang.ChartAreas[0].AxisX.Title = "Month";
            cThang.ChartAreas[0].AxisY.Title = "Money";
            foreach (DataRow dt in nhap.Rows)
            {
                cThang.Series["In"].Points.AddXY(int.Parse(dt["thang"].ToString()), dt["tong"].ToString());
            }
            foreach (DataRow dt in ban.Rows)
            {
                cThang.Series["Out"].Points.AddXY(int.Parse(dt["thang"].ToString()), dt["tong"].ToString());
            }

            DataTable ban2 = bll.getDayban(DateTime.Now.Month);
            DataTable nhap2 = bll.getDaynhap(DateTime.Now.Month);
            cNgay.Titles.Add("Statiscal");
            cNgay.ChartAreas[0].AxisX.Title = "Day";
            cNgay.ChartAreas[0].AxisY.Title = "Money";
            foreach (DataRow dt in nhap2.Rows)
            {
                cNgay.Series["In"].Points.AddXY(int.Parse(dt["ngay"].ToString()), dt["tong"].ToString());
            }
            foreach (DataRow dt in ban2.Rows)
            {
                cNgay.Series["Out"].Points.AddXY(int.Parse(dt["ngay"].ToString()), dt["tong"].ToString());
            }
        }
    }
}
