using Mission1.Business;
using Mission1.Model;
using System;
using System.Windows.Forms;

namespace Mission1.View
{
    public partial class frmMain : Form
    {
        private Rule rule;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rule = FileDB.LoadRule();
            ClearCustomerInfo();
        }

        private void lblCustomerAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmCustomerAdd();
            form.ShowDialog();
        }

        private void lblPointHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmPointHistory();
            form.Customer = PointWorkBiz.GetInstance().GetCustomer(txtPhoneNo.Text);
            form.ShowDialog();
        }

        private void lblCustomerList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmCustomerList();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayCustomerInfo();
        }

        private void DisplayCustomerInfo()
        {
            ClearCustomerInfo();

            var pointWorkBiz = PointWorkBiz.GetInstance();
            var customer = pointWorkBiz.GetCustomer(txtPhoneNo.Text);

            if (customer == null)
            {
                lblMessage.Text = $"{txtPhoneNo.Text} Tidak ada pelanggan untuk nomor HP ini.";
                return;
            }

            lblName.Text = customer.Name;
            lblLastVisitDate.Text = customer.LastVisitDate.ToString("yyyy-MM-dd");
            lblBalance.Text = customer.Balance.ToString("#,0");
            lblVisitCount.Text = customer.VisitCount.ToString("#,0");

            btnEarn.Enabled = true;
            btnUse.Enabled = true;
            lblPointHistory.Enabled = true;

        }

        private void ClearCustomerInfo()
        {
            lblName.Text = "";
            lblLastVisitDate.Text = "";
            lblVisitCount.Text = "";
            lblBalance.Text = "";

            lblMessage.Text = "";
            numUsePoint.Minimum = rule.MinimumUsablePoint;
            numUsePoint.Value = rule.MinimumUsablePoint;


            lblPointHistory.Enabled = false;
            btnEarn.Enabled = false;
            btnUse.Enabled = false;
        }

        private void btnEarn_Click(object sender, EventArgs e)
        {
            var pointWorkBiz = PointWorkBiz.GetInstance();
            var customer = pointWorkBiz.GetCustomer(txtPhoneNo.Text);
            customer.EarnPoint((int)numEarnPoint.Value);
            DisplayCustomerInfo();

            lblMessage.Text = $"poin {numEarnPoint.Value:#,0}poin sudah ditambahkan.";
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            var pointWorkBiz = PointWorkBiz.GetInstance();
            var customer = pointWorkBiz.GetCustomer(txtPhoneNo.Text);
            if (customer.UsePoint((int)numUsePoint.Value))
            {
                DisplayCustomerInfo();
                lblMessage.Text = $"poin {numUsePoint.Value:#,0}poin sudah digunakan.";
            }
            else
                lblMessage.Text = "Saldo poin yang tersedia tidak mencukupi.";
        }
    }
}
