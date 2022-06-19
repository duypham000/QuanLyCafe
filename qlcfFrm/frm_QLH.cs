using System;
using System.Windows.Forms;

namespace QuanLyCafe.qlcfFrm
{
    public partial class frm_QLH : Form
    {
        public frm_QLH()
        {
            InitializeComponent();
        }

        private void frm_QLH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCFDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.qLCFDataSet.DanhMuc);
            // TODO: This line of code loads data into the 'qLCFDataSet.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.qLCFDataSet.MatHang);

            hienThiMatHang();
        }

        private int idDM = 0;

        private void dtgv_dm_Click(object sender, EventArgs e)
        {
            this.idDM = int.Parse(this.dtgv_dm.SelectedRows[0].Cells[0].Value.ToString());
            this.inpt_tenDm.Text = this.qLCFDataSet.DanhMuc.FindByID(idDM).TenDM;
        }

        private void btn_themDm_Click(object sender, EventArgs e)
        {
            String tenDM = this.inpt_tenDm.Text;
            foreach (var dm in this.qLCFDataSet.DanhMuc)
            {
                if (dm.TenDM.Equals(tenDM))
                {
                    MessageBox.Show("Danh mục đã tồn tại");
                    return;
                }
            }
            this.danhMucTableAdapter.Insert(tenDM);
            this.danhMucTableAdapter.Update(this.qLCFDataSet.DanhMuc);
        }

        private void btn_suaDM_Click(object sender, EventArgs e)
        {
            String tenDM = this.inpt_tenDm.Text;
            var dmht = this.qLCFDataSet.DanhMuc.FindByID(idDM);
            foreach (var dm in this.qLCFDataSet.DanhMuc)
            {
                if (dm.TenDM.Equals(tenDM) && !tenDM.Equals(dmht.TenDM))
                {
                    MessageBox.Show("Danh mục đã tồn tại");
                    return;
                }
            }
            this.qLCFDataSet.DanhMuc.FindByID(idDM).TenDM = tenDM;
            this.danhMucTableAdapter.Update(this.qLCFDataSet.DanhMuc);
        }

        private void btn_xoaDm_Click(object sender, EventArgs e)
        {
            try
            {
                var dm = this.qLCFDataSet.DanhMuc.FindByID(idDM);
                this.danhMucTableAdapter.Delete(dm.ID, dm.TenDM);
                this.danhMucTableAdapter.Fill(this.qLCFDataSet.DanhMuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa danh mục thất bại!");
            }
        }

        private int idMH = 0;

        private void dtgv_mh_Click(object sender, EventArgs e)
        {
            this.idMH = int.Parse(this.dtgv_mh.SelectedRows[0].Cells[0].Value.ToString());
            var mh = this.qLCFDataSet.MatHang.FindByID(idMH);

            this.inpt_tenMH.Text = mh.TenMH;
            this.cb_dm.SelectedValue = mh.IdDanhMuc;
            this.nm_gia.Value = mh.Gia;
            this.inpt_dv.Text = mh.DonVi;
        }

        private void btn_themHang_Click(object sender, EventArgs e)
        {
            String tenM = this.inpt_tenMH.Text;
            String donVi = this.inpt_dv.Text;
            int idDM = int.Parse(this.cb_dm.SelectedValue.ToString());
            decimal gia = this.nm_gia.Value;

            if (tenM != "" && idDM != 0 && gia != 0 && donVi != "")
            {
                foreach (var mh in this.qLCFDataSet.MatHang)
                {
                    if (mh.TenMH.Equals(tenM))
                    {
                        MessageBox.Show("Mặt hàng đã tồn tại");
                        return;
                    }
                }
                this.matHangTableAdapter.Insert(tenM, idDM, gia, donVi);
                this.matHangTableAdapter.Fill(this.qLCFDataSet.MatHang);
                hienThiMatHang();
            }
        }

        private void hienThiMatHang()
        {
            this.dtgv_mh.Rows.Clear();
            foreach (var mh in this.qLCFDataSet.MatHang)
            {
                String tenDM = this.qLCFDataSet.DanhMuc.FindByID(mh.IdDanhMuc).TenDM;
                this.dtgv_mh.Rows.Add(mh.ID, mh.TenMH, tenDM, mh.DonVi, mh.Gia);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tenM = this.inpt_tenMH.Text;
            String donVi = this.inpt_dv.Text;
            int idDm = int.Parse(this.cb_dm.SelectedValue.ToString());
            decimal gia = this.nm_gia.Value;

            var mhCu = this.qLCFDataSet.MatHang.FindByID(idMH);

            if (tenM != "" && idDm != 0 && gia != 0 && donVi != "")
            {
                foreach (var mh in this.qLCFDataSet.MatHang)
                {
                    if (mh.TenMH.Equals(tenM) && !mh.TenMH.Equals(mhCu.TenMH))
                    {
                        MessageBox.Show("Mặt hàng đã tồn tại");
                        return;
                    }
                }

                mhCu.TenMH = tenM;
                mhCu.DonVi = donVi;
                mhCu.IdDanhMuc = idDm;
                mhCu.Gia = gia;

                this.matHangTableAdapter.Update(this.qLCFDataSet.MatHang);
                hienThiMatHang();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mhCu = this.qLCFDataSet.MatHang.FindByID(idMH);
            this.matHangTableAdapter.Delete(mhCu.ID, mhCu.TenMH, mhCu.IdDanhMuc, mhCu.Gia, mhCu.DonVi);
            this.matHangTableAdapter.Update(this.qLCFDataSet.MatHang);
            hienThiMatHang();
        }
    }
}