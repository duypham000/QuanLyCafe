using System;
using System.Windows.Forms;

namespace QuanLyCafe.qlcfFrm
{
    public partial class frm_DT : Form
    {
        private QLCFDataSetTableAdapters.DonHangTableAdapter donHangTableAdapter = null;
        private QLCFDataSetTableAdapters.ChiTietDonHangTableAdapter ChiTietDonHangTableAdapter = null;
        private QLCFDataSetTableAdapters.BanTableAdapter BanTableAdapter = null;
        private QLCFDataSetTableAdapters.MatHangTableAdapter MatHangTableAdapter = null;

        private QLCFDataSet.DonHangDataTable donHangs = null;
        private QLCFDataSet.ChiTietDonHangDataTable chiTietDons = null;
        private QLCFDataSet.BanDataTable bans = null;
        private QLCFDataSet.MatHangDataTable matHangs = null;

        public frm_DT()
        {
            InitializeComponent();

            donHangs = new QLCFDataSet.DonHangDataTable();
            chiTietDons = new QLCFDataSet.ChiTietDonHangDataTable();
            bans = new QLCFDataSet.BanDataTable();
            matHangs = new QLCFDataSet.MatHangDataTable();

            donHangTableAdapter = new QLCFDataSetTableAdapters.DonHangTableAdapter();
            ChiTietDonHangTableAdapter = new QLCFDataSetTableAdapters.ChiTietDonHangTableAdapter();
            BanTableAdapter = new QLCFDataSetTableAdapters.BanTableAdapter();
            MatHangTableAdapter = new QLCFDataSetTableAdapters.MatHangTableAdapter();

            donHangTableAdapter.Fill(donHangs);
            ChiTietDonHangTableAdapter.Fill(chiTietDons);
            BanTableAdapter.Fill(bans);
            MatHangTableAdapter.Fill(matHangs);

            hienThi(null, null);
        }

        private void hienThi(object sender, EventArgs e)
        {
            decimal tongTienThu = 0;
            int soKhanh = 0, soHang = 0;

            DateTime tu = this.dtp_start.Value;
            DateTime den = this.dtp_end.Value;

            foreach (var don in donHangs)
            {
                if (don.NgayDat.CompareTo(tu) > 0 && don.NgayDat.CompareTo(den) < 0)
                {
                    soKhanh++;
                    tongTienThu += don.TongTien;

                    String chiTietHoaDon = "";
                    foreach (var ctDon in chiTietDons)
                    {
                        if (ctDon.IdDonHang == don.ID)
                        {
                            soHang++;
                            chiTietHoaDon += matHangs.FindByID(ctDon.IdHang).TenMH + " X" + ctDon.SoLuong + ", ";
                        }
                    }

                    String ban = this.bans.FindByID(don.IdBan).TenBan;
                    String ngay = don.NgayDat.ToString("HH:mm dd/MM/yyyy");

                    this.dtgv_chiTiet.Rows.Add(don.ID, ngay, don.TenKH, ban, chiTietHoaDon, don.TongTien);
                }
            }

            this.s_hang.Text = soHang.ToString();
            this.s_khach.Text = soKhanh.ToString();
            this.s_tien.Text = tongTienThu.ToString();
        }
    }
}