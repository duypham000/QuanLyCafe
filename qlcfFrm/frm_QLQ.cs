using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace QuanLyCafe.qlcfFrm
{
    public partial class frm_QLQ : Form
    {
        public frm_QLQ()
        {
            InitializeComponent();
        }

        private void frm_QLQ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCFDataSet3.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qLCFDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'qLCFDataSet3.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.qLCFDataSet.MatHang);
            // TODO: This line of code loads data into the 'qLCFDataSet3.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.qLCFDataSet.DonHang);
            // TODO: This line of code loads data into the 'qLCFDataSet3.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.qLCFDataSet.DanhMuc);
            // TODO: This line of code loads data into the 'qLCFDataSet3.Ban' table. You can move, or remove it, as needed.
            this.banTableAdapter.Fill(this.qLCFDataSet.Ban);
            // TODO: This line of code loads data into the 'qLCFDataSet.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.qLCFDataSet.MatHang);
            // TODO: This line of code loads data into the 'qLCFDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.qLCFDataSet.DanhMuc);
            // TODO: This line of code loads data into the 'qLCFDataSet.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.qLCFDataSet.DonHang);
            // TODO: This line of code loads data into the 'qLCFDataSet.ChiTietDonHang' table. You can move, or remove it, as needed.
            this.chiTietDonHangTableAdapter.Fill(this.qLCFDataSet.ChiTietDonHang);
            // TODO: This line of code loads data into the 'qLCFDataSet.Ban' table. You can move, or remove it, as needed.
            this.banTableAdapter.Fill(this.qLCFDataSet.Ban);
            hienThiDM();
            dtgv_ban_Click(null, null);
            dtgv_dm_Click(null, null);
            dtgv_hoaDon_Click(null, null);
            dtgv_sp_Click(null, null);
        }

        private void hienThiDM()
        {
            this.dtgv_dm.Rows.Add(0, "Tất cả");
            foreach (var dm in this.qLCFDataSet.DanhMuc)
            {
                this.dtgv_dm.Rows.Add(dm.ID, "--" + dm.TenDM);
            }
        }

        private void btn_themBan_Click(object sender, EventArgs e)
        {
            String tenBan = Interaction.InputBox("Đặt tên bàn:", "Thêm bàn", "");

            if (tenBan != "")
            {
                foreach (var ban in this.qLCFDataSet.Ban)
                {
                    if (ban.TenBan.Equals(tenBan))
                    {
                        MessageBox.Show("Bàn đã tồn tại");
                        return;
                    }
                }
                this.banTableAdapter.Insert(tenBan, null, false);
                this.banTableAdapter.Fill(this.qLCFDataSet.Ban);
            }
        }

        private void capNhatGiaoDien()
        {
            if (this.qLCFDataSet.Ban.FindByID(idBan).DaDatBan)
            {
                this.btn_datban.Enabled = false;
                this.btn_huyBan.Enabled = true;

                this.btn_themMon.Enabled = true;
                this.btn_botMon.Enabled = true;
                this.btn_xoaMon.Enabled = true;
            }
            else
            {
                this.btn_datban.Enabled = true;
                this.btn_huyBan.Enabled = false;

                this.btn_themMon.Enabled = false;
                this.btn_botMon.Enabled = false;
                this.btn_xoaMon.Enabled = false;
            }
        }

        private int idBan = 1;

        private void dtgv_ban_Click(object sender, EventArgs e)
        {
            if (this.dtgv_ban.Rows.Count > 0)
            {
                this.idBan = int.Parse(this.dtgv_ban.SelectedRows[0].Cells[0].Value.ToString());
                if (this.dtgv_ban.SelectedRows[0].Cells[2].Value.ToString() != "" && this.qLCFDataSet.Ban.FindByID(idBan).DaDatBan)
                {
                    this.idDon = int.Parse(this.dtgv_ban.SelectedRows[0].Cells[2].Value.ToString());
                    this.inpt_tenKH.Text = this.qLCFDataSet.DonHang.FindByID(this.idDon).TenKH;
                    hienThiHoaDon();
                }
                else
                {
                    this.dtgv_hoaDon.Rows.Clear();
                    this.idDon = 0;
                    this.inpt_tenKH.Text = "";

                    this.nm_tong.Value = 0;
                    this.nm_tienGiam.Value = 0;
                    this.nm_thanhTien.Value = 0;
                    this.nm_giam.Value = 0;
                }
                capNhatGiaoDien();
            }
        }

        private void hienThiHoaDon()
        {
            this.dtgv_hoaDon.Rows.Clear();

            foreach (var ctDon in this.qLCFDataSet.ChiTietDonHang)
            {
                if (ctDon.IdDonHang == this.idDon)
                {
                    var hang = this.qLCFDataSet.MatHang.FindByID(ctDon.IdHang);
                    this.dtgv_hoaDon.Rows.Add(ctDon.ID, hang.TenMH, hang.DonVi, ctDon.SoLuong, ctDon.SoLuong * hang.Gia);
                }
            }

            decimal tong = this.qLCFDataSet.DonHang.FindByID(this.idDon).TongTien;
            this.nm_tong.Value = tong;
            this.nm_tienGiam.Value = 0;
            this.nm_thanhTien.Value = tong;
            this.nm_giam.Value = 0;
        }

        private void btn_botBan_Click(object sender, EventArgs e)
        {
            if (idBan > 0)
            {
                try
                {
                    var ban = this.qLCFDataSet.Ban.FindByID(idBan);
                    this.banTableAdapter.Delete(ban.ID, ban.TenBan, ban.IdDonHang, ban.DaDatBan);
                    this.banTableAdapter.Fill(this.qLCFDataSet.Ban);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa bàn vì có hóa đơn liên quan");
                }
            }
        }

        private int idDon = 0;

        private void btn_datban_Click(object sender, EventArgs e)
        {
            String tenKH = this.inpt_tenKH.Text;
            if (tenKH == "")
            {
                MessageBox.Show("Điền tên khách");
            }
            else if (idBan > 0)
            {
                this.qLCFDataSet.Ban.FindByID(idBan).DaDatBan = true;
                this.banTableAdapter.Update(this.qLCFDataSet.Ban);
                capNhatGiaoDien();

                this.idDon = this.donHangTableAdapter.Insert(0, tenKH, DateTime.Now, idBan);
                this.donHangTableAdapter.Fill(this.qLCFDataSet.DonHang);

                this.qLCFDataSet.Ban.FindByID(idBan).IdDonHang = this.idDon;
                this.banTableAdapter.Update(this.qLCFDataSet.Ban);
            }
        }

        private void btn_huyBan_Click(object sender, EventArgs e)
        {
            if (idBan > 0)
            {
                this.qLCFDataSet.Ban.FindByID(idBan).DaDatBan = false;

                this.banTableAdapter.Update(this.qLCFDataSet.Ban);
                capNhatGiaoDien();
                this.dtgv_hoaDon.Rows.Clear();
                var hoaDon = this.qLCFDataSet.DonHang.FindByID(this.idDon);
                foreach (var ct in this.qLCFDataSet.ChiTietDonHang)
                {
                    if (ct.IdDonHang == hoaDon.ID)
                    {
                        this.chiTietDonHangTableAdapter.Delete(ct.ID, ct.IdDonHang, ct.IdHang, ct.SoLuong);
                    }
                }
                this.chiTietDonHangTableAdapter.Fill(this.qLCFDataSet.ChiTietDonHang);
                this.donHangTableAdapter.Delete(hoaDon.ID, hoaDon.TongTien, hoaDon.TenKH, hoaDon.NgayDat, hoaDon.IdBan);
                this.donHangTableAdapter.Fill(this.qLCFDataSet.DonHang);

                this.nm_tong.Value = 0;
                this.nm_tienGiam.Value = 0;
                this.nm_thanhTien.Value = 0;
                this.nm_giam.Value = 0;
            }
        }

        private int idDm = 0;

        private void dtgv_dm_Click(object sender, EventArgs e)
        {
            this.dtgv_sp.Rows.Clear();
            this.idDm = int.Parse(this.dtgv_dm.SelectedRows[0].Cells[0].Value.ToString());
            if (idDm == 0)
            {
                foreach (var mh in this.qLCFDataSet.MatHang)
                {
                    this.dtgv_sp.Rows.Add(mh.ID, mh.TenMH, mh.DonVi, mh.Gia);
                }
            }
            else
            {
                foreach (var mh in this.qLCFDataSet.MatHang)
                {
                    if (mh.IdDanhMuc == idDm)
                    {
                        this.dtgv_sp.Rows.Add(mh.ID, mh.TenMH, mh.DonVi, mh.Gia);
                    }
                }
            }
        }

        private int idSp = 0;

        private void dtgv_sp_Click(object sender, EventArgs e)
        {
            if (this.dtgv_sp.Rows.Count > 0)
                this.idSp = int.Parse(this.dtgv_sp.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btn_themMon_Click(object sender, EventArgs e)
        {
            int sl = (int)this.nm_sl.Value;
            bool chuaCo = true;

            foreach (var ctDon in this.qLCFDataSet.ChiTietDonHang)
            {
                if (ctDon.IdDonHang == this.idDon && ctDon.IdHang == this.idSp)
                {
                    chuaCo = false;
                    ctDon.SoLuong += sl;
                }
            }

            if (chuaCo)
            {
                this.chiTietDonHangTableAdapter.Insert(this.idDon, this.idSp, sl);
                this.chiTietDonHangTableAdapter.Fill(this.qLCFDataSet.ChiTietDonHang);
            }

            this.nm_sl.Value = 0;
            hienThiHoaDon();
            tinhTien();
        }

        private void dtgv_dm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void btn_botMon_Click(object sender, EventArgs e)
        {
            dtgv_hoaDon_Click(null, null);
            int sl = (int)this.nm_sl.Value;

            var ctDon = this.qLCFDataSet.ChiTietDonHang.FindByID(this.id_ctHoaDon);
            if (ctDon.SoLuong > sl)
            {
                ctDon.SoLuong -= sl;
                this.chiTietDonHangTableAdapter.Update(this.qLCFDataSet.ChiTietDonHang);
                this.nm_sl.Value = 0;
            }
            else
            {
                MessageBox.Show("Số lượng bớt phải nhỏ hơn số lượng đang có");
            }
            hienThiHoaDon();
            tinhTien();
        }

        private int id_ctHoaDon = 0;

        private void dtgv_hoaDon_Click(object sender, EventArgs e)
        {
            if (this.dtgv_hoaDon.Rows.Count > 0)
            {
                this.id_ctHoaDon = int.Parse(this.dtgv_hoaDon.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_xoaMon_Click(object sender, EventArgs e)
        {
            var ctDon = this.qLCFDataSet.ChiTietDonHang.FindByID(this.id_ctHoaDon);
            this.chiTietDonHangTableAdapter.Delete(ctDon.ID, ctDon.IdDonHang, ctDon.IdHang, ctDon.SoLuong);
            this.chiTietDonHangTableAdapter.Fill(this.qLCFDataSet.ChiTietDonHang);
            hienThiHoaDon();
            tinhTien();
        }

        private void tinhTien()
        {
            decimal tongTien = 0;
            foreach (var ct in this.qLCFDataSet.ChiTietDonHang)
            {
                if (ct.IdDonHang == this.idDon)
                {
                    var hang = this.qLCFDataSet.MatHang.FindByID(ct.IdHang);
                    tongTien += ct.SoLuong * hang.Gia;
                }
            }
            this.nm_tong.Value = tongTien;
            this.nm_tienGiam.Value = tongTien * this.nm_giam.Value * (decimal)0.01;
            this.nm_thanhTien.Value = tongTien - this.nm_tienGiam.Value;

            this.qLCFDataSet.DonHang.FindByID(this.idDon).TongTien = this.nm_thanhTien.Value;
            this.donHangTableAdapter.Update(this.qLCFDataSet.DonHang);
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (idBan > 0)
            {
                this.qLCFDataSet.Ban.FindByID(idBan).DaDatBan = false;

                this.banTableAdapter.Update(this.qLCFDataSet.Ban);
                capNhatGiaoDien();
                this.dtgv_hoaDon.Rows.Clear();

                this.nm_tong.Value = 0;
                this.nm_tienGiam.Value = 0;
                this.nm_thanhTien.Value = 0;
                this.nm_giam.Value = 0;
            }
        }

        private void nm_giam_ValueChanged(object sender, EventArgs e)
        {
            tinhTien();
        }
    }
}