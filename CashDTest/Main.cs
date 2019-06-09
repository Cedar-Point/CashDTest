using System;
using System.Windows.Forms;
using MicrosCashDrawer;

namespace CashDTest
{
    public partial class Main : Form
    {
        private CashDrawer CashDrawer = new CashDrawer();
        public Main()
        {
            InitializeComponent();
            UpdateStatus();
            CashDrawer.CashDrawerStatusChanged += CashDrawer_CashDrawerStatusChanged;
        }
        private void CashDrawer_CashDrawerStatusChanged(CashDrawerStatus cashDrawerStatus)
        {
            UpdateStatus();
        }
        private void BtnPop_Click(object sender, EventArgs e)
        {
            CashDrawer.OpenCashDrawer();
        }
        private void UpdateStatus()
        {
            if (CashDrawer.CashDrawerStatus == CashDrawerStatus.OPEN)
            {
                lblCDStatus.Text = "Open";
            }
            if (CashDrawer.CashDrawerStatus == CashDrawerStatus.CLOSED)
            {
                lblCDStatus.Text = "Closed";
            }
        }
    }
}
