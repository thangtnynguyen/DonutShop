using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLbill
    {
        DALbill bill = new DALbill();
        DALdetails details = new DALdetails();
        public DataTable tableBill()
        {
            return bill.getTableBill();
        }
        public DataTable tableDetails(string name)
        {
            return details.getTableDetails(name);
        }
        public bool checkInsertBill(Bill bills)
        {
            if (bill.getCheck(bills.Idbill) > 0)
            {
                return false;
            }
            bill.getInsertBill(bills);
            return true;
        }
        public bool checkDeleteBill(Bill bills)
        {
            if (bill.getCheck(bills.Idbill) == 0)
            {
                return false;
            }
            bill.getDeleteBill(bills);
            return true;
        }
        public bool checkInsertDetails(detailsbill detail)
        {
            if (bill.getCheck(detail.Idbill) <= 0)
            {
                return false;
            }
            details.getInsertDetails(detail);
            return true;
        }
        public bool checkDeleteDetails(detailsbill detail)
        {
            if (bill.getCheck(detail.Idbill) <= 0)
            {
                return false;
            }
            details.getDeleteDetails(detail);
            return true;
        }
    }
}
