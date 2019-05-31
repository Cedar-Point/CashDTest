using System;
using System.Windows.Forms;

namespace CashDTest
{
    public partial class Main : Form
    {
        private CashDrawerAPI CashDrawer = new CashDrawerAPI();
        public Main()
        {
            InitializeComponent();
            CashDrawer.CashDrawerStatusChanged += CashDrawer_CashDrawerStatusChanged;
        }
        private void CashDrawer_CashDrawerStatusChanged(CashDrawerStatus cashDrawerStatus)
        {
            if(cashDrawerStatus == CashDrawerStatus.OPEN)
            {
                lblCDStatus.Text = "Open";
            }
            if (cashDrawerStatus == CashDrawerStatus.CLOSED)
            {
                lblCDStatus.Text = "Closed";
            }
        }
        private void BtnPop_Click(object sender, EventArgs e)
        {
            CashDrawer.OpenCashDrawer();
        }
    }
}
