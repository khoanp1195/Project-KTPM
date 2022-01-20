
namespace ProjectKTPM
{
    partial class FormADD
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADD));
            this.telerikMetroTouchTheme2 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.office2019GrayTheme1 = new Telerik.WinControls.Themes.Office2019GrayTheme();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gvSP_HD = new Telerik.WinControls.UI.RadGridView();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMASP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMAHD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_HD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProjectKTPM.Properties.Resources.image;
            this.pictureBox6.Location = new System.Drawing.Point(798, 318);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 83;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjectKTPM.Properties.Resources.descripe;
            this.pictureBox5.Location = new System.Drawing.Point(798, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // gvSP_HD
            // 
            this.gvSP_HD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvSP_HD.Location = new System.Drawing.Point(29, 104);
            // 
            // 
            // 
            this.gvSP_HD.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gvSP_HD.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvSP_HD.Name = "gvSP_HD";
            this.gvSP_HD.Size = new System.Drawing.Size(722, 373);
            this.gvSP_HD.TabIndex = 76;
            this.gvSP_HD.ThemeName = "TelerikMetroTouch";
            this.gvSP_HD.SelectionChanged += new System.EventHandler(this.gvSP_HD_SelectionChanged);
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
            this.txt_search.Location = new System.Drawing.Point(32, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(293, 49);
            this.txt_search.TabIndex = 71;
            this.txt_search.Text = "Search";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectKTPM.Properties.Resources.NameProduct;
            this.pictureBox2.Location = new System.Drawing.Point(796, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectKTPM.Properties.Resources.Masp;
            this.pictureBox1.Location = new System.Drawing.Point(796, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // txtMASP
            // 
            this.txtMASP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMASP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASP.ForeColor = System.Drawing.Color.Bisque;
            this.txtMASP.HintForeColor = System.Drawing.Color.Empty;
            this.txtMASP.HintText = "";
            this.txtMASP.isPassword = false;
            this.txtMASP.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtMASP.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtMASP.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtMASP.LineThickness = 4;
            this.txtMASP.Location = new System.Drawing.Point(847, 114);
            this.txtMASP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.Size = new System.Drawing.Size(284, 33);
            this.txtMASP.TabIndex = 79;
            this.txtMASP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Bisque;
            this.txtSoLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.HintText = "";
            this.txtSoLuong.isPassword = false;
            this.txtSoLuong.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtSoLuong.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtSoLuong.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtSoLuong.LineThickness = 4;
            this.txtSoLuong.Location = new System.Drawing.Point(849, 239);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(284, 33);
            this.txtSoLuong.TabIndex = 78;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGia
            // 
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.Bisque;
            this.txtGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtGia.HintText = "";
            this.txtGia.isPassword = false;
            this.txtGia.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtGia.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtGia.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtGia.LineThickness = 4;
            this.txtGia.Location = new System.Drawing.Point(849, 318);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(284, 33);
            this.txtGia.TabIndex = 77;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuImageButton1.Image = global::ProjectKTPM.Properties.Resources.search_icon;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(333, 35);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 72;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 2;
            this.btnDelete.IdleCornerRadius = 35;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Teal;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btnDelete.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btnDelete.Location = new System.Drawing.Point(933, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 50);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 2;
            this.btnUpdate.IdleCornerRadius = 35;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.Teal;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btnUpdate.Location = new System.Drawing.Point(743, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 50);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnADD
            // 
            this.btnADD.ActiveBorderThickness = 1;
            this.btnADD.ActiveCornerRadius = 20;
            this.btnADD.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnADD.ActiveForecolor = System.Drawing.Color.White;
            this.btnADD.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.ButtonText = "Add";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnADD.IdleBorderThickness = 2;
            this.btnADD.IdleCornerRadius = 35;
            this.btnADD.IdleFillColor = System.Drawing.Color.Teal;
            this.btnADD.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btnADD.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btnADD.Location = new System.Drawing.Point(562, 17);
            this.btnADD.Margin = new System.Windows.Forms.Padding(5);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(159, 50);
            this.btnADD.TabIndex = 89;
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtMAHD
            // 
            this.txtMAHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMAHD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAHD.ForeColor = System.Drawing.Color.Bisque;
            this.txtMAHD.HintForeColor = System.Drawing.Color.Empty;
            this.txtMAHD.HintText = "";
            this.txtMAHD.isPassword = false;
            this.txtMAHD.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtMAHD.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtMAHD.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtMAHD.LineThickness = 4;
            this.txtMAHD.Location = new System.Drawing.Point(847, 178);
            this.txtMAHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(284, 33);
            this.txtMAHD.TabIndex = 92;
            this.txtMAHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 530);
            this.Controls.Add(this.txtMAHD);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gvSP_HD);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMASP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "FormADD";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FormADD";
            this.Load += new System.EventHandler(this.FormADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_HD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme2;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.Themes.Office2019GrayTheme office2019GrayTheme1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Telerik.WinControls.UI.RadGridView gvSP_HD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMASP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGia;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnADD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMAHD;
    }
}
