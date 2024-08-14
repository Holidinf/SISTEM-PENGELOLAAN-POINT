using Mission1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mission1.View
{
    public partial class frmPointHistory : Form
    {
        public Customer Customer;

        public frmPointHistory()
        {
            InitializeComponent();
        }

        private void frmPointHistory_Load(object sender, EventArgs e)
        {
            lblName.Text = Customer.PhoneNo; // Menggunakan PhoneNo karena tidak ada properti Name
            lblBalance.Text = Customer.Balance.ToString("#,0");

            dgvPointHistory.AutoGenerateColumns = false;
            dgvPointHistory.DataSource = Customer.PointRecords.Select(p => new
            {
                p.RecordDate,
                RecordType = (p.RecordType == PointRecordTypeEnum.Earn) ? "Tambahkan" : "Gunakan",
                p.Points // Pastikan menggunakan `Points`
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
