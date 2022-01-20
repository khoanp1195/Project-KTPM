
namespace ProjectKTPM
{
    partial class KhachHang1
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
            this.txt_quyen = new System.Windows.Forms.ComboBox();
            this.txt_trangthai = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_KHID = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblChiTietQuocTich = new System.Windows.Forms.Label();
            this.lblChiTietTenKhach = new System.Windows.Forms.Label();
            this.lblChiTietSoPhong = new System.Windows.Forms.Label();
            this.lblChiTietGiaPhong = new System.Windows.Forms.Label();
            this.lblChiTietNgayVao = new System.Windows.Forms.Label();
            this.lblChiTietSoKhach = new System.Windows.Forms.Label();
            this.lblChiTietTenBooking = new System.Windows.Forms.Label();
            this.lblChiTietLoaiPhong = new System.Windows.Forms.Label();
            this.lblChiTietPP = new System.Windows.Forms.Label();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.sad = new System.Windows.Forms.Label();
            this.gv_khachhang = new System.Windows.Forms.DataGridView();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_khachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_quyen
            // 
            this.txt_quyen.FormattingEnabled = true;
            this.txt_quyen.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.txt_quyen.Location = new System.Drawing.Point(592, 48);
            this.txt_quyen.Name = "txt_quyen";
            this.txt_quyen.Size = new System.Drawing.Size(168, 21);
            this.txt_quyen.TabIndex = 128;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.FormattingEnabled = true;
            this.txt_trangthai.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Ngưng hoạt động"});
            this.txt_trangthai.Location = new System.Drawing.Point(592, 148);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(165, 21);
            this.txt_trangthai.TabIndex = 124;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(592, 208);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(149, 20);
            this.txt_SDT.TabIndex = 123;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(206, 162);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(149, 20);
            this.txt_ten.TabIndex = 122;
            // 
            // txt_KHID
            // 
            this.txt_KHID.Location = new System.Drawing.Point(206, 51);
            this.txt_KHID.Name = "txt_KHID";
            this.txt_KHID.Size = new System.Drawing.Size(149, 20);
            this.txt_KHID.TabIndex = 115;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(592, 99);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(168, 20);
            this.txt_address.TabIndex = 114;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(443, 258);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(106, 25);
            this.lblDichVu.TabIndex = 113;
            this.lblDichVu.Text = "Danh Sách";
            // 
            // lblChiTietQuocTich
            // 
            this.lblChiTietQuocTich.AutoSize = true;
            this.lblChiTietQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietQuocTich.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietQuocTich.Location = new System.Drawing.Point(491, 153);
            this.lblChiTietQuocTich.Name = "lblChiTietQuocTich";
            this.lblChiTietQuocTich.Size = new System.Drawing.Size(64, 16);
            this.lblChiTietQuocTich.TabIndex = 109;
            this.lblChiTietQuocTich.Text = "Trạng Thái";
            // 
            // lblChiTietTenKhach
            // 
            this.lblChiTietTenKhach.AutoSize = true;
            this.lblChiTietTenKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenKhach.Location = new System.Drawing.Point(491, 105);
            this.lblChiTietTenKhach.Name = "lblChiTietTenKhach";
            this.lblChiTietTenKhach.Size = new System.Drawing.Size(43, 16);
            this.lblChiTietTenKhach.TabIndex = 108;
            this.lblChiTietTenKhach.Text = "Địa chỉ";
            // 
            // lblChiTietSoPhong
            // 
            this.lblChiTietSoPhong.AutoSize = true;
            this.lblChiTietSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoPhong.Location = new System.Drawing.Point(491, 54);
            this.lblChiTietSoPhong.Name = "lblChiTietSoPhong";
            this.lblChiTietSoPhong.Size = new System.Drawing.Size(40, 16);
            this.lblChiTietSoPhong.TabIndex = 107;
            this.lblChiTietSoPhong.Text = "Quyền";
            // 
            // lblChiTietGiaPhong
            // 
            this.lblChiTietGiaPhong.AutoSize = true;
            this.lblChiTietGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietGiaPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietGiaPhong.Location = new System.Drawing.Point(491, 210);
            this.lblChiTietGiaPhong.Name = "lblChiTietGiaPhong";
            this.lblChiTietGiaPhong.Size = new System.Drawing.Size(73, 16);
            this.lblChiTietGiaPhong.TabIndex = 106;
            this.lblChiTietGiaPhong.Text = "Số điện thoại";
            // 
            // lblChiTietNgayVao
            // 
            this.lblChiTietNgayVao.AutoSize = true;
            this.lblChiTietNgayVao.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayVao.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayVao.Location = new System.Drawing.Point(91, 208);
            this.lblChiTietNgayVao.Name = "lblChiTietNgayVao";
            this.lblChiTietNgayVao.Size = new System.Drawing.Size(59, 16);
            this.lblChiTietNgayVao.TabIndex = 105;
            this.lblChiTietNgayVao.Text = "Ngày Sinh";
            // 
            // lblChiTietSoKhach
            // 
            this.lblChiTietSoKhach.AutoSize = true;
            this.lblChiTietSoKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoKhach.Location = new System.Drawing.Point(91, 165);
            this.lblChiTietSoKhach.Name = "lblChiTietSoKhach";
            this.lblChiTietSoKhach.Size = new System.Drawing.Size(27, 16);
            this.lblChiTietSoKhach.TabIndex = 104;
            this.lblChiTietSoKhach.Text = "Tên";
            // 
            // lblChiTietTenBooking
            // 
            this.lblChiTietTenBooking.AutoSize = true;
            this.lblChiTietTenBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenBooking.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenBooking.Location = new System.Drawing.Point(91, 111);
            this.lblChiTietTenBooking.Name = "lblChiTietTenBooking";
            this.lblChiTietTenBooking.Size = new System.Drawing.Size(56, 16);
            this.lblChiTietTenBooking.TabIndex = 103;
            this.lblChiTietTenBooking.Text = "Password";
            // 
            // lblChiTietLoaiPhong
            // 
            this.lblChiTietLoaiPhong.AutoSize = true;
            this.lblChiTietLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietLoaiPhong.Location = new System.Drawing.Point(91, 63);
            this.lblChiTietLoaiPhong.Name = "lblChiTietLoaiPhong";
            this.lblChiTietLoaiPhong.Size = new System.Drawing.Size(44, 16);
            this.lblChiTietLoaiPhong.TabIndex = 102;
            this.lblChiTietLoaiPhong.Text = "KH_ID";
            this.lblChiTietLoaiPhong.Click += new System.EventHandler(this.lblChiTietLoaiPhong_Click);
            // 
            // lblChiTietPP
            // 
            this.lblChiTietPP.AutoSize = true;
            this.lblChiTietPP.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPP.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPP.Location = new System.Drawing.Point(353, 9);
            this.lblChiTietPP.Name = "lblChiTietPP";
            this.lblChiTietPP.Size = new System.Drawing.Size(337, 29);
            this.lblChiTietPP.TabIndex = 130;
            this.lblChiTietPP.Text = "Cập Nhật Thông Tin Khách Hàng";
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.txt_search.HintForeColor = System.Drawing.Color.Empty;
            this.txt_search.HintText = "";
            this.txt_search.isPassword = false;
            this.txt_search.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_search.LineThickness = 4;
            this.txt_search.Location = new System.Drawing.Point(39, 260);
            this.txt_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(293, 32);
            this.txt_search.TabIndex = 136;
            this.txt_search.Text = "Search";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Location = new System.Drawing.Point(206, 102);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(149, 20);
            this.txt_pass.TabIndex = 138;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(617, 258);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(238, 20);
            this.txt_Email.TabIndex = 140;
            // 
            // sad
            // 
            this.sad.AutoSize = true;
            this.sad.BackColor = System.Drawing.Color.Transparent;
            this.sad.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sad.Location = new System.Drawing.Point(575, 260);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(36, 16);
            this.sad.TabIndex = 139;
            this.sad.Text = "Email";
            // 
            // gv_khachhang
            // 
            this.gv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_khachhang.Location = new System.Drawing.Point(25, 302);
            this.gv_khachhang.Name = "gv_khachhang";
            this.gv_khachhang.Size = new System.Drawing.Size(852, 263);
            this.gv_khachhang.TabIndex = 144;
            this.gv_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_khachhang_CellContentClick);
            this.gv_khachhang.SelectionChanged += new System.EventHandler(this.gv_khachhang_SelectionChanged_1);
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(206, 210);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(149, 20);
            this.txt_dob.TabIndex = 145;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "Delete";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::ProjectKTPM.Properties.Resources.delete;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(913, 428);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(162, 56);
            this.bunifuFlatButton3.TabIndex = 143;
            this.bunifuFlatButton3.Text = "Delete";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Update";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::ProjectKTPM.Properties.Resources.Update;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(913, 339);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(162, 56);
            this.bunifuFlatButton2.TabIndex = 142;
            this.bunifuFlatButton2.Text = "Update";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.SlateBlue;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 7;
            this.btnAdd.ButtonText = "ADD";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::ProjectKTPM.Properties.Resources.add__2_;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(70, 619);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(162, 56);
            this.btnAdd.TabIndex = 141;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuImageButton1.Image = global::ProjectKTPM.Properties.Resources.search_icon;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(340, 260);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 137;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectKTPM.Properties.Resources.customer2;
            this.pictureBox1.Location = new System.Drawing.Point(913, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectKTPM.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 146;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // KhachHang1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 630);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.gv_khachhang);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.sad);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblChiTietPP);
            this.Controls.Add(this.txt_quyen);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_KHID);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblChiTietQuocTich);
            this.Controls.Add(this.lblChiTietTenKhach);
            this.Controls.Add(this.lblChiTietSoPhong);
            this.Controls.Add(this.lblChiTietGiaPhong);
            this.Controls.Add(this.lblChiTietNgayVao);
            this.Controls.Add(this.lblChiTietSoKhach);
            this.Controls.Add(this.lblChiTietTenBooking);
            this.Controls.Add(this.lblChiTietLoaiPhong);
            this.Name = "KhachHang1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_khachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txt_quyen;
        private System.Windows.Forms.ComboBox txt_trangthai;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_KHID;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblChiTietQuocTich;
        private System.Windows.Forms.Label lblChiTietTenKhach;
        private System.Windows.Forms.Label lblChiTietSoPhong;
        private System.Windows.Forms.Label lblChiTietGiaPhong;
        private System.Windows.Forms.Label lblChiTietNgayVao;
        private System.Windows.Forms.Label lblChiTietSoKhach;
        private System.Windows.Forms.Label lblChiTietTenBooking;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.Label lblChiTietPP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label sad;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.DataGridView gv_khachhang;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
