namespace Mission1.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVisitCount = new System.Windows.Forms.Label();
            this.lblPointHistory = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastVisitDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numUsePoint = new System.Windows.Forms.NumericUpDown();
            this.numEarnPoint = new System.Windows.Forms.NumericUpDown();
            this.btnUse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEarn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerAdd = new System.Windows.Forms.LinkLabel();
            this.lblCustomerList = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUsePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEarnPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Pelanggan";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(165, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhoneNo.Location = new System.Drawing.Point(74, 20);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(86, 21);
            this.txtPhoneNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor HP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblVisitCount);
            this.groupBox2.Controls.Add(this.lblPointHistory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblLastVisitDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Pelanggan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "poin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "kali";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Azure;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBalance.Location = new System.Drawing.Point(74, 144);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 27);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Poin yang Tersisa";
            // 
            // lblVisitCount
            // 
            this.lblVisitCount.BackColor = System.Drawing.Color.Azure;
            this.lblVisitCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisitCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVisitCount.Location = new System.Drawing.Point(74, 102);
            this.lblVisitCount.Name = "lblVisitCount";
            this.lblVisitCount.Size = new System.Drawing.Size(65, 27);
            this.lblVisitCount.TabIndex = 6;
            this.lblVisitCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointHistory
            // 
            this.lblPointHistory.AutoSize = true;
            this.lblPointHistory.Location = new System.Drawing.Point(191, 151);
            this.lblPointHistory.Name = "lblPointHistory";
            this.lblPointHistory.Size = new System.Drawing.Size(69, 13);
            this.lblPointHistory.TabIndex = 5;
            this.lblPointHistory.TabStop = true;
            this.lblPointHistory.Text = "Riwayat Poin";
            this.lblPointHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPointHistory_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Jumlah Kunjungan";
            // 
            // lblLastVisitDate
            // 
            this.lblLastVisitDate.BackColor = System.Drawing.Color.Azure;
            this.lblLastVisitDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastVisitDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastVisitDate.Location = new System.Drawing.Point(74, 63);
            this.lblLastVisitDate.Name = "lblLastVisitDate";
            this.lblLastVisitDate.Size = new System.Drawing.Size(102, 27);
            this.lblLastVisitDate.TabIndex = 4;
            this.lblLastVisitDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Kunjungan Terakhir";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Azure;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(74, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 27);
            this.lblName.TabIndex = 2;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numUsePoint);
            this.groupBox3.Controls.Add(this.numEarnPoint);
            this.groupBox3.Controls.Add(this.btnUse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnEarn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(10, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menambahkan Poin";
            // 
            // numUsePoint
            // 
            this.numUsePoint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numUsePoint.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUsePoint.Location = new System.Drawing.Point(201, 20);
            this.numUsePoint.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUsePoint.Name = "numUsePoint";
            this.numUsePoint.Size = new System.Drawing.Size(49, 22);
            this.numUsePoint.TabIndex = 7;
            this.numUsePoint.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numEarnPoint
            // 
            this.numEarnPoint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numEarnPoint.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEarnPoint.Location = new System.Drawing.Point(74, 20);
            this.numEarnPoint.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEarnPoint.Name = "numEarnPoint";
            this.numEarnPoint.Size = new System.Drawing.Size(49, 22);
            this.numEarnPoint.TabIndex = 6;
            this.numEarnPoint.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnUse
            // 
            this.btnUse.Image = ((System.Drawing.Image)(resources.GetObject("btnUse.Image")));
            this.btnUse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUse.Location = new System.Drawing.Point(157, 53);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(74, 49);
            this.btnUse.TabIndex = 1;
            this.btnUse.Text = "Penggunaan";
            this.btnUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Poin yang Digunakan";
            // 
            // btnEarn
            // 
            this.btnEarn.Image = ((System.Drawing.Image)(resources.GetObject("btnEarn.Image")));
            this.btnEarn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEarn.Location = new System.Drawing.Point(34, 53);
            this.btnEarn.Name = "btnEarn";
            this.btnEarn.Size = new System.Drawing.Size(74, 49);
            this.btnEarn.TabIndex = 0;
            this.btnEarn.Text = "Penambahan";
            this.btnEarn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEarn.UseVisualStyleBackColor = true;
            this.btnEarn.Click += new System.EventHandler(this.btnEarn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Poin yang Ditambahkan";
            // 
            // lblCustomerAdd
            // 
            this.lblCustomerAdd.AutoSize = true;
            this.lblCustomerAdd.Location = new System.Drawing.Point(285, 32);
            this.lblCustomerAdd.Name = "lblCustomerAdd";
            this.lblCustomerAdd.Size = new System.Drawing.Size(100, 13);
            this.lblCustomerAdd.TabIndex = 4;
            this.lblCustomerAdd.TabStop = true;
            this.lblCustomerAdd.Text = "Tambah Pelanggan";
            this.lblCustomerAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomerAdd_LinkClicked);
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Location = new System.Drawing.Point(285, 62);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerList.TabIndex = 6;
            this.lblCustomerList.TabStop = true;
            this.lblCustomerList.Text = "List Pelanggan";
            this.lblCustomerList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomerList_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(1, 402);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(347, 27);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 428);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.lblCustomerAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah/Gunakan Poin";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUsePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEarnPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVisitCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastVisitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numUsePoint;
        private System.Windows.Forms.NumericUpDown numEarnPoint;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEarn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblCustomerAdd;
        private System.Windows.Forms.LinkLabel lblPointHistory;
        private System.Windows.Forms.LinkLabel lblCustomerList;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}