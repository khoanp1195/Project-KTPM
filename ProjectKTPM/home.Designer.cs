
namespace ProjectKTPM
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.applicaitonsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.movieLabTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.departmentLabTile = new Telerik.WinControls.UI.RadTileElement();
            this.FileExplorerTile = new Telerik.WinControls.UI.RadTileElement();
            this.radTilePhoto = new Telerik.WinControls.UI.RadLiveTileElement();
            this.radTileElement1 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement3 = new Telerik.WinControls.UI.RadTileElement();
            this.radLiveTileElement1 = new Telerik.WinControls.UI.RadLiveTileElement();
            this.radTileElement4 = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // radPanorama1
            // 
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.applicaitonsGroup});
            this.radPanorama1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radTileElement4});
            this.radPanorama1.Location = new System.Drawing.Point(8, 8);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.RowsCount = 7;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(956, 758);
            this.radPanorama1.TabIndex = 1;
            // 
            // applicaitonsGroup
            // 
            this.applicaitonsGroup.CellSize = new System.Drawing.Size(160, 150);
            this.applicaitonsGroup.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.applicaitonsGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.movieLabTile,
            this.departmentLabTile,
            this.FileExplorerTile,
            this.radTilePhoto,
            this.radTileElement1,
            this.radTileElement3,
            this.radLiveTileElement1});
            this.applicaitonsGroup.Name = "applicaitonsGroup";
            this.applicaitonsGroup.RowsCount = 6;
            this.applicaitonsGroup.Text = "Application";
            this.applicaitonsGroup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.applicaitonsGroup.UseCompatibleTextRendering = false;
            // 
            // movieLabTile
            // 
            this.movieLabTile.AutoSize = true;
            this.movieLabTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movieLabTile.ColSpan = 3;
            this.movieLabTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.movieLabTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(59)))), ((int)(((byte)(231)))));
            this.movieLabTile.Name = "movieLabTile";
            this.movieLabTile.RowSpan = 2;
            this.movieLabTile.Text = "Manage Plane";
            this.movieLabTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.movieLabTile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.movieLabTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.movieLabTile.UseCompatibleTextRendering = false;
            // 
            // departmentLabTile
            // 
            this.departmentLabTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.departmentLabTile.Name = "departmentLabTile";
            this.departmentLabTile.Row = 2;
            this.departmentLabTile.Text = "departmentLabTile";
            this.departmentLabTile.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.departmentLabTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.departmentLabTile.UseCompatibleTextRendering = false;
            // 
            // FileExplorerTile
            // 
            this.FileExplorerTile.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileExplorerTile.Column = 1;
            this.FileExplorerTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.FileExplorerTile.Name = "FileExplorerTile";
            this.FileExplorerTile.Row = 2;
            this.FileExplorerTile.Text = "";
            this.FileExplorerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.FileExplorerTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.FileExplorerTile.UseCompatibleTextRendering = false;
            // 
            // radTilePhoto
            // 
            this.radTilePhoto.Column = 2;
            this.radTilePhoto.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTilePhoto.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTilePhoto.Name = "radTilePhoto";
            this.radTilePhoto.Row = 2;
            this.radTilePhoto.Text = "";
            this.radTilePhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTilePhoto.UseCompatibleTextRendering = false;
            // 
            // radTileElement1
            // 
            this.radTileElement1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radTileElement1.ColSpan = 3;
            this.radTileElement1.Column = 3;
            this.radTileElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radTileElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTileElement1.Name = "radTileElement1";
            this.radTileElement1.Row = 2;
            this.radTileElement1.RowSpan = 2;
            this.radTileElement1.Text = "Manage Department";
            this.radTileElement1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement1.UseCompatibleTextRendering = false;
            // 
            // radTileElement3
            // 
            this.radTileElement3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radTileElement3.ColSpan = 3;
            this.radTileElement3.Column = 3;
            this.radTileElement3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(116)))), ((int)(((byte)(12)))));
            this.radTileElement3.Name = "radTileElement3";
            this.radTileElement3.RowSpan = 2;
            this.radTileElement3.Text = "Manage Employee";
            this.radTileElement3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileElement3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement3.UseCompatibleTextRendering = false;
            // 
            // radLiveTileElement1
            // 
            this.radLiveTileElement1.ColSpan = 3;
            this.radLiveTileElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radLiveTileElement1.Image = null;
            this.radLiveTileElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLiveTileElement1.Name = "radLiveTileElement1";
            this.radLiveTileElement1.Row = 3;
            this.radLiveTileElement1.Text = "";
            this.radLiveTileElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radLiveTileElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radLiveTileElement1.UseCompatibleTextRendering = false;
            // 
            // radTileElement4
            // 
            this.radTileElement4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement4.Name = "radTileElement4";
            this.radTileElement4.Text = "radTileElement4";
            this.radTileElement4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTileElement4.UseCompatibleTextRendering = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 644);
            this.Controls.Add(this.radPanorama1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "home";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.TileGroupElement applicaitonsGroup;
        private Telerik.WinControls.UI.RadLiveTileElement movieLabTile;
        private Telerik.WinControls.UI.RadTileElement departmentLabTile;
        private Telerik.WinControls.UI.RadTileElement FileExplorerTile;
        private Telerik.WinControls.UI.RadLiveTileElement radTilePhoto;
        private Telerik.WinControls.UI.RadTileElement radTileElement1;
        private Telerik.WinControls.UI.RadTileElement radTileElement3;
        private Telerik.WinControls.UI.RadLiveTileElement radLiveTileElement1;
        private Telerik.WinControls.UI.RadTileElement radTileElement4;
    }
}
