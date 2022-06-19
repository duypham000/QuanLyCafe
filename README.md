# QuanLyCafe
đổi phần cài đặt trong Insert donHangTableAdapter
''' c#
        public virtual int Insert(global::System.Nullable<decimal> TongTien, string TenKH, global::System.Nullable<global::System.DateTime> NgayDat, global::System.Nullable<int> IdBan) {
            ...
            try {
                int returnValue = (int)this.Adapter.InsertCommand.ExecuteScalar();
                return returnValue;
            }
            ...
  }
'''
