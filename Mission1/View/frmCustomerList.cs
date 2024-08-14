using Mission1.Business;
using System;
using System.Windows.Forms;

namespace Mission1.View
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void rdoLatestVisitOrder_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void rdoVisitCountOrder_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            RefreshGrid();
        }


        private void RefreshGrid()
        {
            if (rdoLatestVisitOrder.Checked)
                dgvCustomer.DataSource = PointWorkBiz.GetInstance().GetCustomersSortedByLastVisitDate();
            else
                dgvCustomer.DataSource = PointWorkBiz.GetInstance().GetCustomersSortedByVisitCount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
