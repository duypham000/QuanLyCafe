namespace QuanLyCafe.qlcfFrm
{
    partial class frm_QLTK
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgv_dstk = new System.Windows.Forms.DataGridView();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCFDataSet = new QuanLyCafe.QLCFDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_rm = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inpt_mk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpt_nd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.taiKhoanTableAdapter = new QuanLyCafe.QLCFDataSetTableAdapters.TaiKhoanTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dstk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 657);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgv_dstk);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1292, 352);
            this.panel4.TabIndex = 2;
            // 
            // dtgv_dstk
            // 
            this.dtgv_dstk.AllowUserToAddRows = false;
            this.dtgv_dstk.AllowUserToDeleteRows = false;
            this.dtgv_dstk.AutoGenerateColumns = false;
            this.dtgv_dstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dstk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nguoiDungDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dtgv_dstk.DataSource = this.taiKhoanBindingSource;
            this.dtgv_dstk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_dstk.Location = new System.Drawing.Point(0, 0);
            this.dtgv_dstk.MultiSelect = false;
            this.dtgv_dstk.Name = "dtgv_dstk";
            this.dtgv_dstk.ReadOnly = true;
            this.dtgv_dstk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_dstk.Size = new System.Drawing.Size(1292, 352);
            this.dtgv_dstk.TabIndex = 0;
            this.dtgv_dstk.Click += new System.EventHandler(this.dtgv_dstk_Click);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qLCFDataSet;
            // 
            // qLCFDataSet
            // 
            this.qLCFDataSet.DataSetName = "QLCFDataSet";
            this.qLCFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.btn_rm);
            this.panel3.Controls.Add(this.btn_change);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.inpt_mk);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.inpt_nd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 241);
            this.panel3.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_add.FlatAppearance.BorderSize = 5;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(549, 170);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 52);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Thêm tài khoản";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_rm
            // 
            this.btn_rm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rm.BackColor = System.Drawing.Color.White;
            this.btn_rm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btn_rm.FlatAppearance.BorderSize = 5;
            this.btn_rm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rm.ForeColor = System.Drawing.Color.Black;
            this.btn_rm.Location = new System.Drawing.Point(716, 170);
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.Size = new System.Drawing.Size(151, 52);
            this.btn_rm.TabIndex = 16;
            this.btn_rm.Text = "Xóa tài khoản";
            this.btn_rm.UseVisualStyleBackColor = false;
            this.btn_rm.Click += new System.EventHandler(this.btn_rm_Click);
            // 
            // btn_change
            // 
            this.btn_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_change.BackColor = System.Drawing.Color.White;
            this.btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn_change.FlatAppearance.BorderSize = 5;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.Black;
            this.btn_change.Location = new System.Drawing.Point(406, 170);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(127, 52);
            this.btn_change.TabIndex = 15;
            this.btn_change.Text = "Đổi thông tin";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpt_mk
            // 
            this.inpt_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpt_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_mk.Location = new System.Drawing.Point(539, 123);
            this.inpt_mk.Name = "inpt_mk";
            this.inpt_mk.Size = new System.Drawing.Size(324, 32);
            this.inpt_mk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpt_nd
            // 
            this.inpt_nd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpt_nd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_nd.Location = new System.Drawing.Point(539, 64);
            this.inpt_nd.Name = "inpt_nd";
            this.inpt_nd.Size = new System.Drawing.Size(324, 32);
            this.inpt_nd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Người dùng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 64);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1292, 64);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quản lý tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nguoiDungDataGridViewTextBoxColumn
            // 
            this.nguoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nguoiDungDataGridViewTextBoxColumn.DataPropertyName = "NguoiDung";
            this.nguoiDungDataGridViewTextBoxColumn.HeaderText = "Người dùng";
            this.nguoiDungDataGridViewTextBoxColumn.Name = "nguoiDungDataGridViewTextBoxColumn";
            this.nguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 657);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QLTK";
            this.Text = "frm_QLCF";
            this.Load += new System.EventHandler(this.frm_QLTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dstk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgv_dstk;
        private System.Windows.Forms.TextBox inpt_nd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpt_mk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rm;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_add;
        private QLCFDataSet qLCFDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QLCFDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
    }
}