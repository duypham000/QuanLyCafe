using System;
using System.Windows.Forms;

namespace QuanLyCafe.qlcfFrm
{
    public partial class frm_QLTK : Form
    {
        public frm_QLTK()
        {
            InitializeComponent();
        }

        private void frm_QLTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCFDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qLCFDataSet.TaiKhoan);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String nd = this.inpt_nd.Text;
            String mk = this.inpt_mk.Text;
            if (nd != "" && mk != "")
            {
                foreach (var tk in this.qLCFDataSet.TaiKhoan)
                {
                    if (tk.NguoiDung.Equals(nd))
                    {
                        MessageBox.Show("Người dùng đã tồn tại!");
                        return;
                    }
                }

                taiKhoanTableAdapter.Insert(nd, mk);
                this.taiKhoanTableAdapter.Fill(this.qLCFDataSet.TaiKhoan);
            }
        }

        private int curId = 1;

        private void dtgv_dstk_Click(object sender, EventArgs e)
        {
            this.curId = int.Parse(this.dtgv_dstk.SelectedRows[0].Cells[0].Value.ToString());
            this.inpt_nd.Text = this.qLCFDataSet.TaiKhoan.FindByID(curId).NguoiDung;
            this.inpt_mk.Text = this.qLCFDataSet.TaiKhoan.FindByID(curId).MatKhau;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nd = this.inpt_nd.Text;
            String mk = this.inpt_mk.Text;

            var tkCu = this.qLCFDataSet.TaiKhoan.FindByID(curId);

            if (nd != "" && mk != "")
            {
                foreach (var tk in this.qLCFDataSet.TaiKhoan)
                {
                    if (tk.NguoiDung.Equals(nd) && tkCu.NguoiDung != nd)
                    {
                        MessageBox.Show("Người dùng đã tồn tại!");
                        return;
                    }
                }

                tkCu.NguoiDung = nd;
                tkCu.MatKhau = mk;
                this.taiKhoanTableAdapter.Update(this.qLCFDataSet.TaiKhoan);
            }
        }

        private void btn_rm_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = this.qLCFDataSet.TaiKhoan.FindByID(curId);
                this.taiKhoanTableAdapter.Delete(tk.ID, tk.NguoiDung, tk.MatKhau);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}