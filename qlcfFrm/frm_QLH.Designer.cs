namespace QuanLyCafe.qlcfFrm
{
    partial class frm_QLH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgv_mh = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.inpt_dv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_themHang = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_dm = new System.Windows.Forms.ComboBox();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCFDataSet = new QuanLyCafe.QLCFDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.nm_gia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inpt_tenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgv_dm = new System.Windows.Forms.DataGridView();
            this.danhMucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_themDm = new System.Windows.Forms.Button();
            this.btn_xoaDm = new System.Windows.Forms.Button();
            this.btn_suaDM = new System.Windows.Forms.Button();
            this.inpt_tenDm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new QuanLyCafe.QLCFDataSetTableAdapters.MatHangTableAdapter();
            this.danhMucTableAdapter = new QuanLyCafe.QLCFDataSetTableAdapters.DanhMucTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mh)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_gia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
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
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(412, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 575);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgv_mh);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 301);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(880, 274);
            this.panel8.TabIndex = 1;
            // 
            // dtgv_mh
            // 
            this.dtgv_mh.AllowUserToAddRows = false;
            this.dtgv_mh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_mh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_mh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_mh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.dm,
            this.dv,
            this.gia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_mh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_mh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_mh.Location = new System.Drawing.Point(0, 0);
            this.dtgv_mh.Name = "dtgv_mh";
            this.dtgv_mh.ReadOnly = true;
            this.dtgv_mh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_mh.Size = new System.Drawing.Size(880, 274);
            this.dtgv_mh.TabIndex = 0;
            this.dtgv_mh.Click += new System.EventHandler(this.dtgv_mh_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên mặt hàng";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // dm
            // 
            this.dm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dm.HeaderText = "Danh mục";
            this.dm.Name = "dm";
            this.dm.ReadOnly = true;
            // 
            // dv
            // 
            this.dv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv.HeaderText = "Đơn vị";
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.inpt_dv);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btn_themHang);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.cb_dm);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.nm_gia);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.inpt_tenMH);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(880, 301);
            this.panel7.TabIndex = 0;
            // 
            // inpt_dv
            // 
            this.inpt_dv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpt_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_dv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_dv.Location = new System.Drawing.Point(388, 193);
            this.inpt_dv.Name = "inpt_dv";
            this.inpt_dv.Size = new System.Drawing.Size(302, 32);
            this.inpt_dv.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(225, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Đơn vị tính";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_themHang
            // 
            this.btn_themHang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_themHang.BackColor = System.Drawing.Color.White;
            this.btn_themHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_themHang.FlatAppearance.BorderSize = 5;
            this.btn_themHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themHang.ForeColor = System.Drawing.Color.Black;
            this.btn_themHang.Location = new System.Drawing.Point(359, 253);
            this.btn_themHang.Name = "btn_themHang";
            this.btn_themHang.Size = new System.Drawing.Size(84, 42);
            this.btn_themHang.TabIndex = 19;
            this.btn_themHang.Text = "Thêm";
            this.btn_themHang.UseVisualStyleBackColor = false;
            this.btn_themHang.Click += new System.EventHandler(this.btn_themHang_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(539, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(449, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 42);
            this.button5.TabIndex = 17;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(880, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Món";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_dm
            // 
            this.cb_dm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_dm.DataSource = this.danhMucBindingSource;
            this.cb_dm.DisplayMember = "TenDM";
            this.cb_dm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dm.FormattingEnabled = true;
            this.cb_dm.Location = new System.Drawing.Point(388, 143);
            this.cb_dm.Name = "cb_dm";
            this.cb_dm.Size = new System.Drawing.Size(302, 33);
            this.cb_dm.TabIndex = 15;
            this.cb_dm.ValueMember = "ID";
            // 
            // danhMucBindingSource
            // 
            this.danhMucBindingSource.DataMember = "DanhMuc";
            this.danhMucBindingSource.DataSource = this.qLCFDataSetBindingSource;
            // 
            // qLCFDataSetBindingSource
            // 
            this.qLCFDataSetBindingSource.DataSource = this.qLCFDataSet;
            this.qLCFDataSetBindingSource.Position = 0;
            // 
            // qLCFDataSet
            // 
            this.qLCFDataSet.DataSetName = "QLCFDataSet";
            this.qLCFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Danh mục";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nm_gia
            // 
            this.nm_gia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nm_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_gia.Location = new System.Drawing.Point(388, 94);
            this.nm_gia.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.nm_gia.Name = "nm_gia";
            this.nm_gia.Size = new System.Drawing.Size(302, 32);
            this.nm_gia.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpt_tenMH
            // 
            this.inpt_tenMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpt_tenMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_tenMH.Location = new System.Drawing.Point(388, 44);
            this.inpt_tenMH.Name = "inpt_tenMH";
            this.inpt_tenMH.Size = new System.Drawing.Size(302, 32);
            this.inpt_tenMH.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên mặt hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 575);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgv_dm);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(412, 395);
            this.panel6.TabIndex = 1;
            // 
            // dtgv_dm
            // 
            this.dtgv_dm.AllowUserToAddRows = false;
            this.dtgv_dm.AllowUserToDeleteRows = false;
            this.dtgv_dm.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_dm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDMDataGridViewTextBoxColumn});
            this.dtgv_dm.DataSource = this.danhMucBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_dm.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_dm.Location = new System.Drawing.Point(0, 0);
            this.dtgv_dm.Name = "dtgv_dm";
            this.dtgv_dm.ReadOnly = true;
            this.dtgv_dm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_dm.Size = new System.Drawing.Size(412, 395);
            this.dtgv_dm.TabIndex = 0;
            this.dtgv_dm.Click += new System.EventHandler(this.dtgv_dm_Click);
            // 
            // danhMucBindingSource1
            // 
            this.danhMucBindingSource1.DataMember = "DanhMuc";
            this.danhMucBindingSource1.DataSource = this.qLCFDataSetBindingSource;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_themDm);
            this.panel5.Controls.Add(this.btn_xoaDm);
            this.panel5.Controls.Add(this.btn_suaDM);
            this.panel5.Controls.Add(this.inpt_tenDm);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 180);
            this.panel5.TabIndex = 0;
            // 
            // btn_themDm
            // 
            this.btn_themDm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_themDm.BackColor = System.Drawing.Color.White;
            this.btn_themDm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themDm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_themDm.FlatAppearance.BorderSize = 5;
            this.btn_themDm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themDm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themDm.ForeColor = System.Drawing.Color.Black;
            this.btn_themDm.Location = new System.Drawing.Point(322, 89);
            this.btn_themDm.Name = "btn_themDm";
            this.btn_themDm.Size = new System.Drawing.Size(84, 40);
            this.btn_themDm.TabIndex = 16;
            this.btn_themDm.Text = "Thêm";
            this.btn_themDm.UseVisualStyleBackColor = false;
            this.btn_themDm.Click += new System.EventHandler(this.btn_themDm_Click);
            // 
            // btn_xoaDm
            // 
            this.btn_xoaDm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoaDm.BackColor = System.Drawing.Color.White;
            this.btn_xoaDm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoaDm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btn_xoaDm.FlatAppearance.BorderSize = 5;
            this.btn_xoaDm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaDm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaDm.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaDm.Location = new System.Drawing.Point(320, 135);
            this.btn_xoaDm.Name = "btn_xoaDm";
            this.btn_xoaDm.Size = new System.Drawing.Size(86, 42);
            this.btn_xoaDm.TabIndex = 15;
            this.btn_xoaDm.Text = "Xóa";
            this.btn_xoaDm.UseVisualStyleBackColor = false;
            this.btn_xoaDm.Click += new System.EventHandler(this.btn_xoaDm_Click);
            // 
            // btn_suaDM
            // 
            this.btn_suaDM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_suaDM.BackColor = System.Drawing.Color.White;
            this.btn_suaDM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suaDM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn_suaDM.FlatAppearance.BorderSize = 5;
            this.btn_suaDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaDM.ForeColor = System.Drawing.Color.Black;
            this.btn_suaDM.Location = new System.Drawing.Point(322, 44);
            this.btn_suaDM.Name = "btn_suaDM";
            this.btn_suaDM.Size = new System.Drawing.Size(84, 40);
            this.btn_suaDM.TabIndex = 11;
            this.btn_suaDM.Text = "Sửa";
            this.btn_suaDM.UseVisualStyleBackColor = false;
            this.btn_suaDM.Click += new System.EventHandler(this.btn_suaDM_Click);
            // 
            // inpt_tenDm
            // 
            this.inpt_tenDm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_tenDm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_tenDm.Location = new System.Drawing.Point(14, 92);
            this.inpt_tenDm.Name = "inpt_tenDm";
            this.inpt_tenDm.Size = new System.Drawing.Size(302, 32);
            this.inpt_tenDm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên danh mục";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 82);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1292, 82);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quản lý hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.qLCFDataSetBindingSource;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // danhMucTableAdapter
            // 
            this.danhMucTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDMDataGridViewTextBoxColumn
            // 
            this.tenDMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDMDataGridViewTextBoxColumn.DataPropertyName = "TenDM";
            this.tenDMDataGridViewTextBoxColumn.HeaderText = "Tên danh mục";
            this.tenDMDataGridViewTextBoxColumn.Name = "tenDMDataGridViewTextBoxColumn";
            this.tenDMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_QLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 657);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QLH";
            this.Text = "frm_QLCF";
            this.Load += new System.EventHandler(this.frm_QLH_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mh)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_gia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgv_dm;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgv_mh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpt_tenDm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suaDM;
        private System.Windows.Forms.Button btn_xoaDm;
        private System.Windows.Forms.TextBox inpt_tenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_gia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_dm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_themDm;
        private System.Windows.Forms.Button btn_themHang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource qLCFDataSetBindingSource;
        private QLCFDataSet qLCFDataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QLCFDataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.BindingSource danhMucBindingSource;
        private QLCFDataSetTableAdapters.DanhMucTableAdapter danhMucTableAdapter;
        private System.Windows.Forms.BindingSource danhMucBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.TextBox inpt_dv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDMDataGridViewTextBoxColumn;
    }
}