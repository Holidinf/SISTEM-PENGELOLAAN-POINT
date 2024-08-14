using System;
using System.Windows.Forms;
using Mission1.Business;
using Mission1.Model;

namespace Mission1.View
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Tutup form tanpa menyimpan perubahan
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(txtPhoneNo.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nomor HP dan Nama harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat objek Customer dengan nama dan nomor telepon
            var newCustomer = new Customer(txtPhoneNo.Text, txtName.Text);

            // Dapatkan instance PointWorkBiz dan tambahkan customer
            var pointWorkBiz = PointWorkBiz.GetInstance();
            pointWorkBiz.AddCustomer(newCustomer);

            MessageBox.Show("Pelanggan berhasil ditambahkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tutup form setelah menambahkan customer
            DialogResult = DialogResult.OK;
        }
    }
}
