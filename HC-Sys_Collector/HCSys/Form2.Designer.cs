namespace HCSys
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.d = new System.Windows.Forms.Label();
            this.cxDate = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.cxterminale = new System.Windows.Forms.Label();
            this.cxTypeTitre = new System.Windows.Forms.Label();
            this.cxType = new System.Windows.Forms.Label();
            this.cxreqTitle = new System.Windows.Forms.Label();
            this.cxreq = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cxCheckGrinMarks = new MaterialSkin.Controls.MaterialCheckBox();
            this.cxSatelite = new MaterialSkin.Controls.MaterialRadioButton();
            this.cxmap = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 99);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1001, 461);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Queries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(666, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 429);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gMapControl2);
            this.tabPage5.Controls.Add(this.flowLayoutPanel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(30);
            this.tabPage5.Size = new System.Drawing.Size(316, 403);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Query Details";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemmory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(30, 232);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 100;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.Padding = new System.Windows.Forms.Padding(20);
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(256, 141);
            this.gMapControl2.TabIndex = 7;
            this.gMapControl2.Zoom = 10D;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.d);
            this.flowLayoutPanel2.Controls.Add(this.cxDate);
            this.flowLayoutPanel2.Controls.Add(this.t);
            this.flowLayoutPanel2.Controls.Add(this.cxterminale);
            this.flowLayoutPanel2.Controls.Add(this.cxTypeTitre);
            this.flowLayoutPanel2.Controls.Add(this.cxType);
            this.flowLayoutPanel2.Controls.Add(this.cxreqTitle);
            this.flowLayoutPanel2.Controls.Add(this.cxreq);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(256, 202);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.d.Location = new System.Drawing.Point(3, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(81, 18);
            this.d.TabIndex = 0;
            this.d.Text = "Date Time:";
            // 
            // cxDate
            // 
            this.cxDate.AutoSize = true;
            this.cxDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.cxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxDate.Location = new System.Drawing.Point(3, 18);
            this.cxDate.Name = "cxDate";
            this.cxDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cxDate.Size = new System.Drawing.Size(0, 28);
            this.cxDate.TabIndex = 4;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.t.Location = new System.Drawing.Point(3, 46);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(83, 18);
            this.t.TabIndex = 1;
            this.t.Text = "Terminale :";
            // 
            // cxterminale
            // 
            this.cxterminale.AutoSize = true;
            this.cxterminale.Font = new System.Drawing.Font("Roboto", 11F);
            this.cxterminale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxterminale.Location = new System.Drawing.Point(3, 64);
            this.cxterminale.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.cxterminale.Name = "cxterminale";
            this.cxterminale.Size = new System.Drawing.Size(0, 18);
            this.cxterminale.TabIndex = 5;
            // 
            // cxTypeTitre
            // 
            this.cxTypeTitre.AutoSize = true;
            this.cxTypeTitre.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.cxTypeTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxTypeTitre.Location = new System.Drawing.Point(3, 92);
            this.cxTypeTitre.Name = "cxTypeTitre";
            this.cxTypeTitre.Size = new System.Drawing.Size(49, 18);
            this.cxTypeTitre.TabIndex = 2;
            this.cxTypeTitre.Text = "Type :";
            // 
            // cxType
            // 
            this.cxType.AutoSize = true;
            this.cxType.Font = new System.Drawing.Font("Roboto", 11F);
            this.cxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxType.Location = new System.Drawing.Point(3, 110);
            this.cxType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.cxType.Name = "cxType";
            this.cxType.Size = new System.Drawing.Size(0, 18);
            this.cxType.TabIndex = 6;
            // 
            // cxreqTitle
            // 
            this.cxreqTitle.AutoSize = true;
            this.cxreqTitle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.cxreqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxreqTitle.Location = new System.Drawing.Point(3, 138);
            this.cxreqTitle.Name = "cxreqTitle";
            this.cxreqTitle.Size = new System.Drawing.Size(60, 18);
            this.cxreqTitle.TabIndex = 3;
            this.cxreqTitle.Text = "Querie :";
            // 
            // cxreq
            // 
            this.cxreq.AutoSize = true;
            this.cxreq.Font = new System.Drawing.Font("Roboto", 11F);
            this.cxreq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cxreq.Location = new System.Drawing.Point(3, 156);
            this.cxreq.Name = "cxreq";
            this.cxreq.Size = new System.Drawing.Size(0, 18);
            this.cxreq.TabIndex = 7;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(160, 3);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(506, 429);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Terminal";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 117;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Time";
            this.columnHeader7.Width = 196;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialFlatButton1);
            this.flowLayoutPanel1.Controls.Add(this.materialFlatButton3);
            this.flowLayoutPanel1.Controls.Add(this.materialFlatButton4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(150, 0);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "All";
            this.materialFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.materialFlatButton1.UseCompatibleTextRendering = true;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(4, 54);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MinimumSize = new System.Drawing.Size(150, 0);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "Queries";
            this.materialFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton3.UseCompatibleTextRendering = true;
            this.materialFlatButton3.UseVisualStyleBackColor = false;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(4, 102);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MinimumSize = new System.Drawing.Size(150, 0);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(150, 36);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "Terminals";
            this.materialFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialFlatButton4.UseCompatibleTextRendering = true;
            this.materialFlatButton4.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel4);
            this.tabPage2.Controls.Add(this.flowLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(30);
            this.tabPage2.Size = new System.Drawing.Size(993, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(243, 74);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 100;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(720, 331);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 15D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.materialRaisedButton1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(243, 30);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(720, 44);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(590, 3);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(127, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Reset Position";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cxCheckGrinMarks);
            this.flowLayoutPanel3.Controls.Add(this.cxSatelite);
            this.flowLayoutPanel3.Controls.Add(this.cxmap);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(30, 30);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(20, 44, 20, 20);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(213, 375);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // cxCheckGrinMarks
            // 
            this.cxCheckGrinMarks.Depth = 0;
            this.cxCheckGrinMarks.Font = new System.Drawing.Font("Roboto", 10F);
            this.cxCheckGrinMarks.Location = new System.Drawing.Point(20, 44);
            this.cxCheckGrinMarks.Margin = new System.Windows.Forms.Padding(0);
            this.cxCheckGrinMarks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cxCheckGrinMarks.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxCheckGrinMarks.Name = "cxCheckGrinMarks";
            this.cxCheckGrinMarks.Ripple = true;
            this.cxCheckGrinMarks.Size = new System.Drawing.Size(168, 37);
            this.cxCheckGrinMarks.TabIndex = 4;
            this.cxCheckGrinMarks.Text = "Hide Green terminals";
            this.cxCheckGrinMarks.UseVisualStyleBackColor = true;
            this.cxCheckGrinMarks.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // cxSatelite
            // 
            this.cxSatelite.Depth = 0;
            this.cxSatelite.Font = new System.Drawing.Font("Roboto", 10F);
            this.cxSatelite.Location = new System.Drawing.Point(20, 81);
            this.cxSatelite.Margin = new System.Windows.Forms.Padding(0);
            this.cxSatelite.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cxSatelite.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxSatelite.Name = "cxSatelite";
            this.cxSatelite.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.cxSatelite.Ripple = true;
            this.cxSatelite.Size = new System.Drawing.Size(168, 30);
            this.cxSatelite.TabIndex = 0;
            this.cxSatelite.Text = "Satelite ";
            this.cxSatelite.UseVisualStyleBackColor = true;
            this.cxSatelite.CheckedChanged += new System.EventHandler(this.cxSatelite_CheckedChanged);
            // 
            // cxmap
            // 
            this.cxmap.Checked = true;
            this.cxmap.Depth = 0;
            this.cxmap.Font = new System.Drawing.Font("Roboto", 10F);
            this.cxmap.Location = new System.Drawing.Point(20, 111);
            this.cxmap.Margin = new System.Windows.Forms.Padding(0);
            this.cxmap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cxmap.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxmap.Name = "cxmap";
            this.cxmap.Padding = new System.Windows.Forms.Padding(10);
            this.cxmap.Ripple = true;
            this.cxmap.Size = new System.Drawing.Size(168, 30);
            this.cxmap.TabIndex = 1;
            this.cxmap.TabStop = true;
            this.cxmap.Text = "Map";
            this.cxmap.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 60);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1001, 39);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 560);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label cxTypeTitre;
        private System.Windows.Forms.Label cxreqTitle;
        protected System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialRadioButton cxSatelite;
        private MaterialSkin.Controls.MaterialRadioButton cxmap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialCheckBox cxCheckGrinMarks;
        private System.Windows.Forms.Label cxDate;
        private System.Windows.Forms.Label cxterminale;
        private System.Windows.Forms.Label cxType;
        private System.Windows.Forms.Label cxreq;
    }
}