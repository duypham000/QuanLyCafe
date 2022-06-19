using QuanLyCafe.qlcfFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class layout_QLCafe : Form
    {
        public layout_QLCafe()
        {
            InitializeComponent();
            mn_qlq_Click(null, null);
        }

        private Form activeForm = null;
        public void openChildForm(Form form)
        {
            if (activeForm != null)
            {
                this.pnl_body.Controls.Clear();
            }

            this.activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnl_body.Controls.Add(form);
            this.pnl_body.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void mn_qlq_Click(object sender, EventArgs e)
        {
            frm_QLQ frm_QLQ = new frm_QLQ();
            openChildForm(frm_QLQ);
        }

        private void mn_qltk_Click(object sender, EventArgs e)
        {
            frm_QLTK frm_QLTK = new frm_QLTK();
            openChildForm(frm_QLTK);
        }

        private void mn_qlh_Click(object sender, EventArgs e)
        {
            frm_QLH frm_QLH = new frm_QLH();
            openChildForm(frm_QLH);
        }

        private void mn_dt_Click(object sender, EventArgs e)
        {
            frm_DT frm_DT = new frm_DT();
            openChildForm(frm_DT);
        }
    }
}
