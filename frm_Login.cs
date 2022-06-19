using System;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frm_Login : Form
    {
        private QLCFDataSet.TaiKhoanDataTable taiKhoans = null;
        private QLCFDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanAdapter = null;

        public frm_Login()
        {
            InitializeComponent();
            taiKhoanAdapter = new QLCFDataSetTableAdapters.TaiKhoanTableAdapter();
            taiKhoans = new QLCFDataSet.TaiKhoanDataTable();
            taiKhoanAdapter.Fill(taiKhoans);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String nd = this.inpt_nd.Text;
            String mk = this.inpt_mk.Text;
            bool thanhCong = false;
            foreach (var tk in taiKhoans)
            {
                if (tk.NguoiDung.Equals(nd) && tk.MatKhau.Equals(mk))
                {
                    thanhCong = true;
                }
            }

            if (thanhCong)
            {
                layout_QLCafe layout_QLCafe = new layout_QLCafe();
                this.Hide();
                layout_QLCafe.ShowDialog();
                taiKhoanAdapter.Fill(taiKhoans);
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, kiểm tra lại thông tin!");
            }
        }
    }
}