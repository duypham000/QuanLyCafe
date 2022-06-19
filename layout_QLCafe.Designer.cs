namespace QuanLyCafe
{
    partial class layout_QLCafe
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
            this.pnl_body = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_qlq = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qltk = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlh = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 24);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1292, 657);
            this.pnl_body.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_qlq,
            this.mn_qltk,
            this.mn_qlh,
            this.mn_dt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_qlq
            // 
            this.mn_qlq.Name = "mn_qlq";
            this.mn_qlq.Size = new System.Drawing.Size(90, 20);
            this.mn_qlq.Text = "Quản lý quán";
            this.mn_qlq.Click += new System.EventHandler(this.mn_qlq_Click);
            // 
            // mn_qltk
            // 
            this.mn_qltk.Name = "mn_qltk";
            this.mn_qltk.Size = new System.Drawing.Size(112, 20);
            this.mn_qltk.Text = "Quản lý tài khoản";
            this.mn_qltk.Click += new System.EventHandler(this.mn_qltk_Click);
            // 
            // mn_qlh
            // 
            this.mn_qlh.Name = "mn_qlh";
            this.mn_qlh.Size = new System.Drawing.Size(90, 20);
            this.mn_qlh.Text = "Quản lý hàng";
            this.mn_qlh.Click += new System.EventHandler(this.mn_qlh_Click);
            // 
            // mn_dt
            // 
            this.mn_dt.Name = "mn_dt";
            this.mn_dt.Size = new System.Drawing.Size(75, 20);
            this.mn_dt.Text = "Doanh thu";
            this.mn_dt.Click += new System.EventHandler(this.mn_dt_Click);
            // 
            // layout_QLCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 681);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "layout_QLCafe";
            this.Text = "Quản lý cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_qlq;
        private System.Windows.Forms.ToolStripMenuItem mn_qltk;
        private System.Windows.Forms.ToolStripMenuItem mn_qlh;
        private System.Windows.Forms.ToolStripMenuItem mn_dt;
    }
}