namespace TEST_FINGER
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btncancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grMayVanTay = new DevExpress.XtraGrid.GridControl();
            this.fP_DanhMucMayQuetVanTayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMayVanTay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTaViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVaoRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKVanTay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMayVanTay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fP_DanhMucMayQuetVanTayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayVanTay)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnsave,
            this.btncancel,
            this.btndelete});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnsave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btndelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncancel)});
            this.bar2.Text = "Tools";
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Save";
            this.btnsave.Id = 0;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Delete";
            this.btndelete.Id = 2;
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.LargeImage")));
            this.btndelete.Name = "btndelete";
            this.btndelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btncancel
            // 
            this.btncancel.Caption = "Cancel";
            this.btncancel.Id = 1;
            this.btncancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.ImageOptions.Image")));
            this.btncancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btncancel.ImageOptions.LargeImage")));
            this.btncancel.Name = "btncancel";
            this.btncancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btncancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncancel_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(926, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 447);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(926, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(926, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // grMayVanTay
            // 
            this.grMayVanTay.DataSource = this.fP_DanhMucMayQuetVanTayBindingSource;
            this.grMayVanTay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grMayVanTay.Location = new System.Drawing.Point(0, 24);
            this.grMayVanTay.MainView = this.gvMayVanTay;
            this.grMayVanTay.Name = "grMayVanTay";
            this.grMayVanTay.Size = new System.Drawing.Size(926, 423);
            this.grMayVanTay.TabIndex = 4;
            this.grMayVanTay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMayVanTay});
            // 
            // fP_DanhMucMayQuetVanTayBindingSource
            // 
            this.fP_DanhMucMayQuetVanTayBindingSource.DataSource = typeof(TEST_FINGER.FP_DanhMucMayQuetVanTay);
            // 
            // gvMayVanTay
            // 
            this.gvMayVanTay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTenMay,
            this.colMoTaViTri,
            this.colVaoRa,
            this.colIP,
            this.colPort,
            this.colTinhTrangSuDung,
            this.colDKVanTay});
            this.gvMayVanTay.GridControl = this.grMayVanTay;
            this.gvMayVanTay.Name = "gvMayVanTay";
            this.gvMayVanTay.NewItemRowText = "Nhấn vào đây để thêm mới máy vân tay";
            this.gvMayVanTay.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvMayVanTay.OptionsNavigation.AutoFocusNewRow = true;
            this.gvMayVanTay.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colTenMay
            // 
            this.colTenMay.FieldName = "TenMay";
            this.colTenMay.Name = "colTenMay";
            this.colTenMay.Visible = true;
            this.colTenMay.VisibleIndex = 0;
            // 
            // colMoTaViTri
            // 
            this.colMoTaViTri.FieldName = "MoTaViTri";
            this.colMoTaViTri.Name = "colMoTaViTri";
            this.colMoTaViTri.Visible = true;
            this.colMoTaViTri.VisibleIndex = 1;
            // 
            // colVaoRa
            // 
            this.colVaoRa.FieldName = "VaoRa";
            this.colVaoRa.Name = "colVaoRa";
            this.colVaoRa.Visible = true;
            this.colVaoRa.VisibleIndex = 2;
            // 
            // colIP
            // 
            this.colIP.FieldName = "IP";
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 3;
            // 
            // colPort
            // 
            this.colPort.FieldName = "Port";
            this.colPort.Name = "colPort";
            this.colPort.Visible = true;
            this.colPort.VisibleIndex = 4;
            // 
            // colTinhTrangSuDung
            // 
            this.colTinhTrangSuDung.FieldName = "TinhTrangSuDung";
            this.colTinhTrangSuDung.Name = "colTinhTrangSuDung";
            this.colTinhTrangSuDung.Visible = true;
            this.colTinhTrangSuDung.VisibleIndex = 5;
            // 
            // colDKVanTay
            // 
            this.colDKVanTay.FieldName = "DKVanTay";
            this.colDKVanTay.Name = "colDKVanTay";
            this.colDKVanTay.Visible = true;
            this.colDKVanTay.VisibleIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 467);
            this.Controls.Add(this.grMayVanTay);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMayVanTay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fP_DanhMucMayQuetVanTayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayVanTay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grMayVanTay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMayVanTay;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private DevExpress.XtraBars.BarButtonItem btncancel;
        private System.Windows.Forms.BindingSource fP_DanhMucMayQuetVanTayBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTaViTri;
        private DevExpress.XtraGrid.Columns.GridColumn colVaoRa;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private DevExpress.XtraGrid.Columns.GridColumn colPort;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colDKVanTay;
        private DevExpress.XtraBars.BarButtonItem btndelete;
    }
}