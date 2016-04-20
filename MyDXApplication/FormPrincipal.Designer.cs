namespace MyDXApplication
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.monitorGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.basculasGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.agregarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.salvarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.eliminarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.cancelarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.reportesGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.salirGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.configuracionBtn = new DevExpress.XtraEditors.SimpleButton();
            this.myTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.monitorTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonitor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.basculasTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.DsBasculas = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dataColumn29 = new System.Data.DataColumn();
            this.GridViewMaestroBasculas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSipBecamo_BasculasId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccionIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Procede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Bloque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlt_Calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMarca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.reportesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.exportarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cargarReporteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.bodegaCmb = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.basculaCmb = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hastaDtp = new DevExpress.XtraEditors.DateEdit();
            this.desdeDtp = new DevExpress.XtraEditors.DateEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDESCRIPCION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_BODEGA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_PERIODO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_NUMERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_BRUTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_TARA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLT_NETO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabControl)).BeginInit();
            this.myTabControl.SuspendLayout();
            this.monitorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonitor)).BeginInit();
            this.basculasTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBasculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMaestroBasculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).BeginInit();
            this.reportesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basculaCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDtp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeDtp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeDtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.configuracionBtn);
            this.splitContainerControl.Panel2.Controls.Add(this.myTabControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1100, 700);
            this.splitContainerControl.SplitterPosition = 165;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.monitorGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.monitorGroup,
            this.basculasGroup,
            this.reportesGroup,
            this.salirGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.agregarItem,
            this.salvarItem,
            this.eliminarItem,
            this.cancelarItem,
            this.navBarItem1});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(165, 688);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            this.navBarControl.Click += new System.EventHandler(this.navBarControl_Click);
            // 
            // monitorGroup
            // 
            this.monitorGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorGroup.Appearance.Options.UseFont = true;
            this.monitorGroup.Caption = "Monitor";
            this.monitorGroup.Expanded = true;
            this.monitorGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("monitorGroup.LargeImage")));
            this.monitorGroup.Name = "monitorGroup";
            // 
            // basculasGroup
            // 
            this.basculasGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basculasGroup.Appearance.Options.UseFont = true;
            this.basculasGroup.Caption = "Basculas";
            this.basculasGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.agregarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.salvarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.eliminarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.cancelarItem)});
            this.basculasGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("basculasGroup.LargeImage")));
            this.basculasGroup.LargeImageIndex = 1;
            this.basculasGroup.Name = "basculasGroup";
            // 
            // agregarItem
            // 
            this.agregarItem.Caption = "Agregar";
            this.agregarItem.Name = "agregarItem";
            this.agregarItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("agregarItem.SmallImage")));
            this.agregarItem.SmallImageIndex = 4;
            this.agregarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.agregarItem_LinkClicked);
            // 
            // salvarItem
            // 
            this.salvarItem.Caption = "Salvar";
            this.salvarItem.Name = "salvarItem";
            this.salvarItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("salvarItem.SmallImage")));
            this.salvarItem.SmallImageIndex = 5;
            this.salvarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.salvarItem_LinkClicked);
            // 
            // eliminarItem
            // 
            this.eliminarItem.Caption = "Eliminar";
            this.eliminarItem.Name = "eliminarItem";
            this.eliminarItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("eliminarItem.SmallImage")));
            this.eliminarItem.SmallImageIndex = 3;
            this.eliminarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.eliminarItem_LinkClicked);
            // 
            // cancelarItem
            // 
            this.cancelarItem.Caption = "Cancelar";
            this.cancelarItem.Name = "cancelarItem";
            this.cancelarItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("cancelarItem.SmallImage")));
            this.cancelarItem.SmallImageIndex = 1;
            this.cancelarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.cancelarItem_LinkClicked);
            // 
            // reportesGroup
            // 
            this.reportesGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesGroup.Appearance.Options.UseFont = true;
            this.reportesGroup.Caption = "Reportes";
            this.reportesGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("reportesGroup.LargeImage")));
            this.reportesGroup.Name = "reportesGroup";
            // 
            // salirGroup
            // 
            this.salirGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirGroup.Appearance.Options.UseFont = true;
            this.salirGroup.Caption = "Salir";
            this.salirGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("salirGroup.LargeImage")));
            this.salirGroup.Name = "salirGroup";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // configuracionBtn
            // 
            this.configuracionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configuracionBtn.Image = ((System.Drawing.Image)(resources.GetObject("configuracionBtn.Image")));
            this.configuracionBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.configuracionBtn.Location = new System.Drawing.Point(876, 1);
            this.configuracionBtn.Name = "configuracionBtn";
            this.configuracionBtn.Size = new System.Drawing.Size(39, 38);
            this.configuracionBtn.TabIndex = 3;
            this.configuracionBtn.Click += new System.EventHandler(this.configuracionBtn_Click);
            // 
            // myTabControl
            // 
            this.myTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTabControl.Location = new System.Drawing.Point(0, 0);
            this.myTabControl.Name = "myTabControl";
            this.myTabControl.SelectedTabPage = this.monitorTabPage;
            this.myTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.myTabControl.Size = new System.Drawing.Size(870, 694);
            this.myTabControl.TabIndex = 1;
            this.myTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.monitorTabPage,
            this.basculasTabPage,
            this.reportesTabPage});
            // 
            // monitorTabPage
            // 
            this.monitorTabPage.Controls.Add(this.gridControl1);
            this.monitorTabPage.Name = "monitorTabPage";
            this.monitorTabPage.Size = new System.Drawing.Size(864, 688);
            this.monitorTabPage.Text = "Monitor";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewMonitor;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(864, 688);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonitor});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridViewMonitor
            // 
            this.gridViewMonitor.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridViewMonitor.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMonitor.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMonitor.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMonitor.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMonitor.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMonitor.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewMonitor.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMonitor.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewMonitor.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMonitor.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMonitor.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewMonitor.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMonitor.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewMonitor.GridControl = this.gridControl1;
            this.gridViewMonitor.GroupPanelText = "MONITOR";
            this.gridViewMonitor.Name = "gridViewMonitor";
            // 
            // basculasTabPage
            // 
            this.basculasTabPage.Controls.Add(this.gridControl);
            this.basculasTabPage.Name = "basculasTabPage";
            this.basculasTabPage.Size = new System.Drawing.Size(864, 688);
            this.basculasTabPage.Text = "Basculas";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.DataMember = "TblBasculas";
            this.gridControl.DataSource = this.DsBasculas;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.GridViewMaestroBasculas;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbMarca});
            this.gridControl.Size = new System.Drawing.Size(864, 688);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMaestroBasculas});
            // 
            // DsBasculas
            // 
            this.DsBasculas.DataSetName = "NewDataSet";
            this.DsBasculas.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn30});
            this.dataTable1.TableName = "TblBasculas";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "SipBecamo_BasculasId";
            this.dataColumn1.DataType = typeof(decimal);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Descripcion";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DireccionIp";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Ubicacion";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Blt_Proceso";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Blt_Periodo";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Blt_Bodega";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Blt_Orden";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Blt_Procede";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Blt_Bloque";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Blt_Calidad";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Blt_Calidad_Interna";
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "Marca";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20});
            this.dataTable2.TableName = "TblMonitor";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "BASCULA";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "DIRECCION_IP";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "FECHA";
            this.dataColumn15.DataType = typeof(System.DateTime);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "NUMERO_BOLETA";
            this.dataColumn16.DataType = typeof(int);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "SERIE_BOLETA";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "BRUTO";
            this.dataColumn18.DataType = typeof(decimal);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "TARA";
            this.dataColumn19.DataType = typeof(decimal);
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "NETO";
            this.dataColumn20.DataType = typeof(decimal);
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25,
            this.dataColumn26,
            this.dataColumn27,
            this.dataColumn28,
            this.dataColumn29});
            this.dataTable3.TableName = "TblReporte";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "DESCRIPCION";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "BLT_BODEGA";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "BLT_SERIE";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "BLT_PERIODO";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "BLT_NUMERO";
            this.dataColumn25.DataType = typeof(decimal);
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "BLT_FECHA";
            this.dataColumn26.DataType = typeof(System.DateTime);
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "BLT_BRUTO";
            this.dataColumn27.DataType = typeof(decimal);
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "BLT_TARA";
            this.dataColumn28.DataType = typeof(decimal);
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "BLT_NETO";
            this.dataColumn29.DataType = typeof(decimal);
            // 
            // GridViewMaestroBasculas
            // 
            this.GridViewMaestroBasculas.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Black;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridViewMaestroBasculas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.Options.UseFont = true;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewMaestroBasculas.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridViewMaestroBasculas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridViewMaestroBasculas.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewMaestroBasculas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GridViewMaestroBasculas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewMaestroBasculas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridViewMaestroBasculas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GridViewMaestroBasculas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSipBecamo_BasculasId,
            this.colDescripcion,
            this.colDireccionIp,
            this.colUbicacion,
            this.colBlt_Proceso,
            this.colBlt_Periodo,
            this.colBlt_Bodega,
            this.colBlt_Orden,
            this.colBlt_Procede,
            this.colBlt_Bloque,
            this.colBlt_Calidad,
            this.colMarca});
            this.GridViewMaestroBasculas.GridControl = this.gridControl;
            this.GridViewMaestroBasculas.GroupPanelText = "MAESTRO BASCULAS";
            this.GridViewMaestroBasculas.Name = "GridViewMaestroBasculas";
            this.GridViewMaestroBasculas.OptionsView.ColumnAutoWidth = false;
            // 
            // colSipBecamo_BasculasId
            // 
            this.colSipBecamo_BasculasId.Caption = "MARCA";
            this.colSipBecamo_BasculasId.FieldName = "SipBecamo_BasculasId";
            this.colSipBecamo_BasculasId.Name = "colSipBecamo_BasculasId";
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "DESCRIPCION";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 150;
            // 
            // colDireccionIp
            // 
            this.colDireccionIp.Caption = "DIRECCION IP";
            this.colDireccionIp.FieldName = "DireccionIp";
            this.colDireccionIp.Name = "colDireccionIp";
            this.colDireccionIp.Visible = true;
            this.colDireccionIp.VisibleIndex = 1;
            this.colDireccionIp.Width = 89;
            // 
            // colUbicacion
            // 
            this.colUbicacion.Caption = "UBICACION";
            this.colUbicacion.FieldName = "Ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.Visible = true;
            this.colUbicacion.VisibleIndex = 2;
            this.colUbicacion.Width = 76;
            // 
            // colBlt_Proceso
            // 
            this.colBlt_Proceso.Caption = "PROCESO";
            this.colBlt_Proceso.FieldName = "Blt_Proceso";
            this.colBlt_Proceso.Name = "colBlt_Proceso";
            this.colBlt_Proceso.Visible = true;
            this.colBlt_Proceso.VisibleIndex = 3;
            // 
            // colBlt_Periodo
            // 
            this.colBlt_Periodo.Caption = "PERIODO";
            this.colBlt_Periodo.FieldName = "Blt_Periodo";
            this.colBlt_Periodo.Name = "colBlt_Periodo";
            this.colBlt_Periodo.Visible = true;
            this.colBlt_Periodo.VisibleIndex = 4;
            // 
            // colBlt_Bodega
            // 
            this.colBlt_Bodega.Caption = "BODEGA";
            this.colBlt_Bodega.FieldName = "Blt_Bodega";
            this.colBlt_Bodega.Name = "colBlt_Bodega";
            this.colBlt_Bodega.Visible = true;
            this.colBlt_Bodega.VisibleIndex = 5;
            // 
            // colBlt_Orden
            // 
            this.colBlt_Orden.Caption = "ORDEN";
            this.colBlt_Orden.FieldName = "Blt_Orden";
            this.colBlt_Orden.Name = "colBlt_Orden";
            this.colBlt_Orden.Visible = true;
            this.colBlt_Orden.VisibleIndex = 7;
            // 
            // colBlt_Procede
            // 
            this.colBlt_Procede.Caption = "PROCEDE";
            this.colBlt_Procede.FieldName = "Blt_Procede";
            this.colBlt_Procede.Name = "colBlt_Procede";
            this.colBlt_Procede.Visible = true;
            this.colBlt_Procede.VisibleIndex = 8;
            // 
            // colBlt_Bloque
            // 
            this.colBlt_Bloque.Caption = "BLOQUE";
            this.colBlt_Bloque.FieldName = "Blt_Bloque";
            this.colBlt_Bloque.Name = "colBlt_Bloque";
            this.colBlt_Bloque.Visible = true;
            this.colBlt_Bloque.VisibleIndex = 9;
            // 
            // colBlt_Calidad
            // 
            this.colBlt_Calidad.Caption = "CALIDAD";
            this.colBlt_Calidad.FieldName = "Blt_Calidad";
            this.colBlt_Calidad.Name = "colBlt_Calidad";
            this.colBlt_Calidad.Visible = true;
            this.colBlt_Calidad.VisibleIndex = 10;
            this.colBlt_Calidad.Width = 82;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "MARCA";
            this.colMarca.ColumnEdit = this.cmbMarca;
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 6;
            this.colMarca.Width = 135;
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoHeight = false;
            this.cmbMarca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.NullText = "Seleccione una marca...";
            this.cmbMarca.ShowHeader = false;
            // 
            // reportesTabPage
            // 
            this.reportesTabPage.Controls.Add(this.exportarBtn);
            this.reportesTabPage.Controls.Add(this.cargarReporteBtn);
            this.reportesTabPage.Controls.Add(this.groupControl3);
            this.reportesTabPage.Controls.Add(this.groupControl2);
            this.reportesTabPage.Controls.Add(this.groupControl1);
            this.reportesTabPage.Controls.Add(this.gridControl2);
            this.reportesTabPage.Name = "reportesTabPage";
            this.reportesTabPage.Size = new System.Drawing.Size(864, 688);
            this.reportesTabPage.Text = "Reportes";
            // 
            // exportarBtn
            // 
            this.exportarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportarBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportarBtn.Image")));
            this.exportarBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.exportarBtn.Location = new System.Drawing.Point(811, 5);
            this.exportarBtn.Name = "exportarBtn";
            this.exportarBtn.Size = new System.Drawing.Size(50, 55);
            this.exportarBtn.TabIndex = 5;
            this.exportarBtn.Click += new System.EventHandler(this.exportarBtn_Click);
            // 
            // cargarReporteBtn
            // 
            this.cargarReporteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargarReporteBtn.Image = ((System.Drawing.Image)(resources.GetObject("cargarReporteBtn.Image")));
            this.cargarReporteBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cargarReporteBtn.Location = new System.Drawing.Point(755, 5);
            this.cargarReporteBtn.Name = "cargarReporteBtn";
            this.cargarReporteBtn.Size = new System.Drawing.Size(50, 55);
            this.cargarReporteBtn.TabIndex = 4;
            this.cargarReporteBtn.Click += new System.EventHandler(this.cargarReporteBtn_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.Appearance.Options.UseForeColor = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.bodegaCmb);
            this.groupControl3.Location = new System.Drawing.Point(568, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(181, 55);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Bodega:";
            // 
            // bodegaCmb
            // 
            this.bodegaCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodegaCmb.Location = new System.Drawing.Point(12, 28);
            this.bodegaCmb.Name = "bodegaCmb";
            this.bodegaCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bodegaCmb.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BLT_BODEGA", "BLT_BODEGA")});
            this.bodegaCmb.Properties.NullText = "Seleccione una bodega...";
            this.bodegaCmb.Properties.ShowHeader = false;
            this.bodegaCmb.Size = new System.Drawing.Size(159, 20);
            this.bodegaCmb.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.basculaCmb);
            this.groupControl2.Location = new System.Drawing.Point(381, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(181, 55);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Bascula:";
            // 
            // basculaCmb
            // 
            this.basculaCmb.Location = new System.Drawing.Point(10, 28);
            this.basculaCmb.Name = "basculaCmb";
            this.basculaCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basculaCmb.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BLT_BODEGA", "BLT_BODEGA", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION")});
            this.basculaCmb.Properties.NullText = "Seleccione una bascula...";
            this.basculaCmb.Properties.ShowHeader = false;
            this.basculaCmb.Size = new System.Drawing.Size(159, 20);
            this.basculaCmb.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.hastaDtp);
            this.groupControl1.Controls.Add(this.desdeDtp);
            this.groupControl1.Location = new System.Drawing.Point(3, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 55);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Filtro Fecha:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(194, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Desde:";
            // 
            // hastaDtp
            // 
            this.hastaDtp.EditValue = null;
            this.hastaDtp.Location = new System.Drawing.Point(236, 28);
            this.hastaDtp.Name = "hastaDtp";
            this.hastaDtp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hastaDtp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hastaDtp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.hastaDtp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.hastaDtp.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.hastaDtp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.hastaDtp.Size = new System.Drawing.Size(122, 20);
            this.hastaDtp.TabIndex = 1;
            // 
            // desdeDtp
            // 
            this.desdeDtp.EditValue = null;
            this.desdeDtp.Location = new System.Drawing.Point(60, 28);
            this.desdeDtp.Name = "desdeDtp";
            this.desdeDtp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.desdeDtp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.desdeDtp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.desdeDtp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.desdeDtp.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.desdeDtp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.desdeDtp.Size = new System.Drawing.Size(122, 20);
            this.desdeDtp.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "TblReporte";
            this.gridControl2.DataSource = this.DsBasculas;
            this.gridControl2.Location = new System.Drawing.Point(0, 66);
            this.gridControl2.MainView = this.gridViewReporte;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(865, 622);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReporte});
            // 
            // gridViewReporte
            // 
            this.gridViewReporte.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewReporte.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewReporte.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewReporte.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewReporte.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewReporte.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewReporte.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDESCRIPCION1,
            this.colBLT_BODEGA1,
            this.colBLT_SERIE,
            this.colBLT_PERIODO1,
            this.colBLT_NUMERO,
            this.colBLT_FECHA,
            this.colBLT_BRUTO,
            this.colBLT_TARA,
            this.colBLT_NETO});
            this.gridViewReporte.GridControl = this.gridControl2;
            this.gridViewReporte.GroupPanelText = "REPORTE BOLETAS";
            this.gridViewReporte.Name = "gridViewReporte";
            // 
            // colDESCRIPCION1
            // 
            this.colDESCRIPCION1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDESCRIPCION1.AppearanceHeader.Options.UseFont = true;
            this.colDESCRIPCION1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDESCRIPCION1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDESCRIPCION1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDESCRIPCION1.Caption = "BASCULA";
            this.colDESCRIPCION1.FieldName = "DESCRIPCION";
            this.colDESCRIPCION1.Name = "colDESCRIPCION1";
            this.colDESCRIPCION1.OptionsColumn.ReadOnly = true;
            this.colDESCRIPCION1.Visible = true;
            this.colDESCRIPCION1.VisibleIndex = 0;
            this.colDESCRIPCION1.Width = 128;
            // 
            // colBLT_BODEGA1
            // 
            this.colBLT_BODEGA1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_BODEGA1.AppearanceHeader.Options.UseFont = true;
            this.colBLT_BODEGA1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_BODEGA1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_BODEGA1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_BODEGA1.Caption = "BODEGA";
            this.colBLT_BODEGA1.FieldName = "BLT_BODEGA";
            this.colBLT_BODEGA1.Name = "colBLT_BODEGA1";
            this.colBLT_BODEGA1.OptionsColumn.ReadOnly = true;
            this.colBLT_BODEGA1.Visible = true;
            this.colBLT_BODEGA1.VisibleIndex = 1;
            this.colBLT_BODEGA1.Width = 128;
            // 
            // colBLT_SERIE
            // 
            this.colBLT_SERIE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_SERIE.AppearanceHeader.Options.UseFont = true;
            this.colBLT_SERIE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_SERIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_SERIE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_SERIE.Caption = "ID";
            this.colBLT_SERIE.FieldName = "BLT_SERIE";
            this.colBLT_SERIE.Name = "colBLT_SERIE";
            this.colBLT_SERIE.OptionsColumn.ReadOnly = true;
            this.colBLT_SERIE.Visible = true;
            this.colBLT_SERIE.VisibleIndex = 2;
            this.colBLT_SERIE.Width = 128;
            // 
            // colBLT_PERIODO1
            // 
            this.colBLT_PERIODO1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_PERIODO1.AppearanceHeader.Options.UseFont = true;
            this.colBLT_PERIODO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_PERIODO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_PERIODO1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_PERIODO1.Caption = "PERIODO";
            this.colBLT_PERIODO1.FieldName = "BLT_PERIODO";
            this.colBLT_PERIODO1.Name = "colBLT_PERIODO1";
            this.colBLT_PERIODO1.OptionsColumn.ReadOnly = true;
            this.colBLT_PERIODO1.Visible = true;
            this.colBLT_PERIODO1.VisibleIndex = 3;
            this.colBLT_PERIODO1.Width = 128;
            // 
            // colBLT_NUMERO
            // 
            this.colBLT_NUMERO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_NUMERO.AppearanceHeader.Options.UseFont = true;
            this.colBLT_NUMERO.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_NUMERO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_NUMERO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_NUMERO.Caption = "BOLETA NO";
            this.colBLT_NUMERO.FieldName = "BLT_NUMERO";
            this.colBLT_NUMERO.Name = "colBLT_NUMERO";
            this.colBLT_NUMERO.OptionsColumn.ReadOnly = true;
            this.colBLT_NUMERO.Visible = true;
            this.colBLT_NUMERO.VisibleIndex = 4;
            this.colBLT_NUMERO.Width = 128;
            // 
            // colBLT_FECHA
            // 
            this.colBLT_FECHA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_FECHA.AppearanceHeader.Options.UseFont = true;
            this.colBLT_FECHA.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_FECHA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_FECHA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_FECHA.Caption = "FECHA";
            this.colBLT_FECHA.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colBLT_FECHA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBLT_FECHA.FieldName = "BLT_FECHA";
            this.colBLT_FECHA.GroupFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colBLT_FECHA.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBLT_FECHA.Name = "colBLT_FECHA";
            this.colBLT_FECHA.OptionsColumn.ReadOnly = true;
            this.colBLT_FECHA.Visible = true;
            this.colBLT_FECHA.VisibleIndex = 5;
            this.colBLT_FECHA.Width = 165;
            // 
            // colBLT_BRUTO
            // 
            this.colBLT_BRUTO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_BRUTO.AppearanceHeader.Options.UseFont = true;
            this.colBLT_BRUTO.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_BRUTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_BRUTO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_BRUTO.Caption = "BRUTO";
            this.colBLT_BRUTO.DisplayFormat.FormatString = "n2";
            this.colBLT_BRUTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_BRUTO.FieldName = "BLT_BRUTO";
            this.colBLT_BRUTO.GroupFormat.FormatString = "n2";
            this.colBLT_BRUTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_BRUTO.Name = "colBLT_BRUTO";
            this.colBLT_BRUTO.OptionsColumn.ReadOnly = true;
            this.colBLT_BRUTO.Visible = true;
            this.colBLT_BRUTO.VisibleIndex = 6;
            this.colBLT_BRUTO.Width = 115;
            // 
            // colBLT_TARA
            // 
            this.colBLT_TARA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_TARA.AppearanceHeader.Options.UseFont = true;
            this.colBLT_TARA.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_TARA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_TARA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_TARA.Caption = "TARA";
            this.colBLT_TARA.DisplayFormat.FormatString = "n2";
            this.colBLT_TARA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_TARA.FieldName = "BLT_TARA";
            this.colBLT_TARA.GroupFormat.FormatString = "n2";
            this.colBLT_TARA.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_TARA.Name = "colBLT_TARA";
            this.colBLT_TARA.OptionsColumn.ReadOnly = true;
            this.colBLT_TARA.Visible = true;
            this.colBLT_TARA.VisibleIndex = 7;
            this.colBLT_TARA.Width = 115;
            // 
            // colBLT_NETO
            // 
            this.colBLT_NETO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBLT_NETO.AppearanceHeader.Options.UseFont = true;
            this.colBLT_NETO.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLT_NETO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLT_NETO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBLT_NETO.Caption = "NETO";
            this.colBLT_NETO.DisplayFormat.FormatString = "n2";
            this.colBLT_NETO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_NETO.FieldName = "BLT_NETO";
            this.colBLT_NETO.GroupFormat.FormatString = "n2";
            this.colBLT_NETO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLT_NETO.Name = "colBLT_NETO";
            this.colBLT_NETO.OptionsColumn.ReadOnly = true;
            this.colBLT_NETO.Visible = true;
            this.colBLT_NETO.VisibleIndex = 8;
            this.colBLT_NETO.Width = 117;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainerControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RMS Revuelta App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabControl)).EndInit();
            this.myTabControl.ResumeLayout(false);
            this.monitorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonitor)).EndInit();
            this.basculasTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBasculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMaestroBasculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).EndInit();
            this.reportesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basculaCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDtp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeDtp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeDtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup basculasGroup;
        private DevExpress.XtraNavBar.NavBarItem agregarItem;
        private DevExpress.XtraNavBar.NavBarItem salvarItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarItem eliminarItem;
        private DevExpress.XtraNavBar.NavBarItem cancelarItem;
        private DevExpress.XtraTab.XtraTabControl myTabControl;
        private DevExpress.XtraTab.XtraTabPage monitorTabPage;
        private DevExpress.XtraNavBar.NavBarGroup salirGroup;
        private DevExpress.XtraTab.XtraTabPage basculasTabPage;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewMaestroBasculas;
        private DevExpress.XtraEditors.SimpleButton configuracionBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonitor;
        private System.Data.DataSet DsBasculas;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colSipBecamo_BasculasId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccionIp;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Proceso;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Periodo;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Procede;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Bloque;
        private DevExpress.XtraGrid.Columns.GridColumn colBlt_Calidad;
        private System.Data.DataTable dataTable2;
        private DevExpress.XtraNavBar.NavBarGroup monitorGroup;
        private DevExpress.XtraNavBar.NavBarGroup reportesGroup;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraTab.XtraTabPage reportesTabPage;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit hastaDtp;
        private DevExpress.XtraEditors.DateEdit desdeDtp;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataColumn dataColumn29;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReporte;
        private DevExpress.XtraEditors.SimpleButton exportarBtn;
        private DevExpress.XtraEditors.SimpleButton cargarReporteBtn;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit bodegaCmb;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit basculaCmb;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPCION1;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_BODEGA1;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_PERIODO1;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_NUMERO;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_BRUTO;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_TARA;
        private DevExpress.XtraGrid.Columns.GridColumn colBLT_NETO;
        private System.Data.DataColumn dataColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMarca;

    }
}
