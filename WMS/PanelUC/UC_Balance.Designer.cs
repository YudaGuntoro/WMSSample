
namespace WMS.User_Control
{
    partial class UC_Balance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Balance));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.GridBalance = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RackLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DDownMaterialType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CBxFifo = new System.Windows.Forms.CheckBox();
            this.CBxLifo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBxLotNo = new System.Windows.Forms.CheckBox();
            this.CBxPartNo = new System.Windows.Forms.CheckBox();
            this.TBxPartNo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TBxLotNo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridBalance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBalance
            // 
            this.GridBalance.AllowUserToAddRows = false;
            this.GridBalance.AllowUserToDeleteRows = false;
            this.GridBalance.AllowUserToResizeColumns = false;
            this.GridBalance.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridBalance.ColumnHeadersHeight = 30;
            this.GridBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LotNo,
            this.partNo,
            this.partName,
            this.RackLocation,
            this.RemainsQuantity,
            this.InitialQuantity,
            this.StockIn});
            this.GridBalance.Location = new System.Drawing.Point(56, 178);
            this.GridBalance.Name = "GridBalance";
            this.GridBalance.RowHeadersVisible = false;
            this.GridBalance.Size = new System.Drawing.Size(876, 391);
            this.GridBalance.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // LotNo
            // 
            this.LotNo.DataPropertyName = "LotNo";
            this.LotNo.HeaderText = "Lot No";
            this.LotNo.Name = "LotNo";
            // 
            // partNo
            // 
            this.partNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partNo.DataPropertyName = "PartNo";
            this.partNo.HeaderText = "Part No";
            this.partNo.Name = "partNo";
            // 
            // partName
            // 
            this.partName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partName.DataPropertyName = "PartName";
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            // 
            // RackLocation
            // 
            this.RackLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RackLocation.DataPropertyName = "RackLocation";
            this.RackLocation.HeaderText = "Rack Location";
            this.RackLocation.Name = "RackLocation";
            // 
            // RemainsQuantity
            // 
            this.RemainsQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RemainsQuantity.DataPropertyName = "RemainsQuantity";
            this.RemainsQuantity.HeaderText = "Remains Qty";
            this.RemainsQuantity.Name = "RemainsQuantity";
            this.RemainsQuantity.Width = 120;
            // 
            // InitialQuantity
            // 
            this.InitialQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InitialQuantity.DataPropertyName = "InitialQuantity";
            this.InitialQuantity.HeaderText = "Initial Qty";
            this.InitialQuantity.Name = "InitialQuantity";
            this.InitialQuantity.Width = 96;
            // 
            // StockIn
            // 
            this.StockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StockIn.DataPropertyName = "StockInDate";
            this.StockIn.HeaderText = "StockIn";
            this.StockIn.Name = "StockIn";
            this.StockIn.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 30);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lot No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DDownMaterialType
            // 
            this.DDownMaterialType.BackColor = System.Drawing.Color.Transparent;
            this.DDownMaterialType.BackgroundColor = System.Drawing.Color.White;
            this.DDownMaterialType.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DDownMaterialType.BorderRadius = 10;
            this.DDownMaterialType.Color = System.Drawing.Color.DodgerBlue;
            this.DDownMaterialType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DDownMaterialType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DDownMaterialType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DDownMaterialType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DDownMaterialType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DDownMaterialType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DDownMaterialType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DDownMaterialType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DDownMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDownMaterialType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DDownMaterialType.FillDropDown = true;
            this.DDownMaterialType.FillIndicator = false;
            this.DDownMaterialType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DDownMaterialType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DDownMaterialType.ForeColor = System.Drawing.Color.Black;
            this.DDownMaterialType.FormattingEnabled = true;
            this.DDownMaterialType.Icon = null;
            this.DDownMaterialType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DDownMaterialType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.DDownMaterialType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DDownMaterialType.IndicatorThickness = 2;
            this.DDownMaterialType.IsDropdownOpened = false;
            this.DDownMaterialType.ItemBackColor = System.Drawing.Color.White;
            this.DDownMaterialType.ItemBorderColor = System.Drawing.Color.White;
            this.DDownMaterialType.ItemForeColor = System.Drawing.Color.Black;
            this.DDownMaterialType.ItemHeight = 26;
            this.DDownMaterialType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DDownMaterialType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DDownMaterialType.ItemTopMargin = 3;
            this.DDownMaterialType.Location = new System.Drawing.Point(169, 105);
            this.DDownMaterialType.Name = "DDownMaterialType";
            this.DDownMaterialType.Size = new System.Drawing.Size(194, 32);
            this.DDownMaterialType.TabIndex = 21;
            this.DDownMaterialType.Text = null;
            this.DDownMaterialType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DDownMaterialType.TextLeftMargin = 5;
            this.DDownMaterialType.SelectedIndexChanged += new System.EventHandler(this.DDownMaterialType_SelectedIndexChanged);
            this.DDownMaterialType.Click += new System.EventHandler(this.DDownMaterialType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 30);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBxFifo
            // 
            this.CBxFifo.AutoSize = true;
            this.CBxFifo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxFifo.Location = new System.Drawing.Point(41, 59);
            this.CBxFifo.Name = "CBxFifo";
            this.CBxFifo.Size = new System.Drawing.Size(57, 24);
            this.CBxFifo.TabIndex = 24;
            this.CBxFifo.Text = "FIFO";
            this.CBxFifo.UseVisualStyleBackColor = true;
            this.CBxFifo.CheckedChanged += new System.EventHandler(this.CBxFifo_CheckedChanged);
            // 
            // CBxLifo
            // 
            this.CBxLifo.AutoSize = true;
            this.CBxLifo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxLifo.Location = new System.Drawing.Point(41, 89);
            this.CBxLifo.Name = "CBxLifo";
            this.CBxLifo.Size = new System.Drawing.Size(56, 24);
            this.CBxLifo.TabIndex = 26;
            this.CBxLifo.Text = "LIFO";
            this.CBxLifo.UseVisualStyleBackColor = true;
            this.CBxLifo.CheckedChanged += new System.EventHandler(this.CBxLifo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBxLotNo);
            this.groupBox1.Controls.Add(this.CBxPartNo);
            this.groupBox1.Controls.Add(this.TBxPartNo);
            this.groupBox1.Controls.Add(this.DDownMaterialType);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.TBxLotNo);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 151);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // CBxLotNo
            // 
            this.CBxLotNo.AutoSize = true;
            this.CBxLotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxLotNo.Location = new System.Drawing.Point(38, 71);
            this.CBxLotNo.Name = "CBxLotNo";
            this.CBxLotNo.Size = new System.Drawing.Size(15, 14);
            this.CBxLotNo.TabIndex = 30;
            this.CBxLotNo.UseVisualStyleBackColor = true;
            this.CBxLotNo.CheckedChanged += new System.EventHandler(this.CBxLotNo_CheckedChanged);
            // 
            // CBxPartNo
            // 
            this.CBxPartNo.AutoSize = true;
            this.CBxPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxPartNo.Location = new System.Drawing.Point(38, 30);
            this.CBxPartNo.Name = "CBxPartNo";
            this.CBxPartNo.Size = new System.Drawing.Size(15, 14);
            this.CBxPartNo.TabIndex = 29;
            this.CBxPartNo.UseVisualStyleBackColor = true;
            this.CBxPartNo.CheckedChanged += new System.EventHandler(this.CBxPartNo_CheckedChanged);
            // 
            // TBxPartNo
            // 
            this.TBxPartNo.AcceptsReturn = false;
            this.TBxPartNo.AcceptsTab = false;
            this.TBxPartNo.AnimationSpeed = 200;
            this.TBxPartNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TBxPartNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TBxPartNo.AutoSizeHeight = true;
            this.TBxPartNo.BackColor = System.Drawing.Color.Transparent;
            this.TBxPartNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBxPartNo.BackgroundImage")));
            this.TBxPartNo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TBxPartNo.BorderColorDisabled = System.Drawing.Color.DimGray;
            this.TBxPartNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TBxPartNo.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.TBxPartNo.BorderRadius = 20;
            this.TBxPartNo.BorderThickness = 1;
            this.TBxPartNo.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.TBxPartNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBxPartNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxPartNo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TBxPartNo.DefaultText = "";
            this.TBxPartNo.FillColor = System.Drawing.Color.White;
            this.TBxPartNo.HideSelection = true;
            this.TBxPartNo.IconLeft = null;
            this.TBxPartNo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxPartNo.IconPadding = 10;
            this.TBxPartNo.IconRight = global::WMS.Properties.Resources.search;
            this.TBxPartNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxPartNo.Lines = new string[0];
            this.TBxPartNo.Location = new System.Drawing.Point(169, 16);
            this.TBxPartNo.MaxLength = 32767;
            this.TBxPartNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.TBxPartNo.Modified = false;
            this.TBxPartNo.Multiline = false;
            this.TBxPartNo.Name = "TBxPartNo";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxPartNo.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.DimGray;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TBxPartNo.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxPartNo.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxPartNo.OnIdleState = stateProperties12;
            this.TBxPartNo.Padding = new System.Windows.Forms.Padding(3);
            this.TBxPartNo.PasswordChar = '\0';
            this.TBxPartNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBxPartNo.PlaceholderText = "";
            this.TBxPartNo.ReadOnly = false;
            this.TBxPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBxPartNo.SelectedText = "";
            this.TBxPartNo.SelectionLength = 0;
            this.TBxPartNo.SelectionStart = 0;
            this.TBxPartNo.ShortcutsEnabled = true;
            this.TBxPartNo.Size = new System.Drawing.Size(194, 37);
            this.TBxPartNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TBxPartNo.TabIndex = 23;
            this.TBxPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBxPartNo.TextMarginBottom = 0;
            this.TBxPartNo.TextMarginLeft = 3;
            this.TBxPartNo.TextMarginTop = 0;
            this.TBxPartNo.TextPlaceholder = "";
            this.TBxPartNo.UseSystemPasswordChar = false;
            this.TBxPartNo.WordWrap = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(59, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 30);
            this.panel3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "PartNo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBxLotNo
            // 
            this.TBxLotNo.AcceptsReturn = false;
            this.TBxLotNo.AcceptsTab = false;
            this.TBxLotNo.AnimationSpeed = 200;
            this.TBxLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TBxLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TBxLotNo.AutoSizeHeight = true;
            this.TBxLotNo.BackColor = System.Drawing.Color.Transparent;
            this.TBxLotNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBxLotNo.BackgroundImage")));
            this.TBxLotNo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TBxLotNo.BorderColorDisabled = System.Drawing.Color.DimGray;
            this.TBxLotNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TBxLotNo.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.TBxLotNo.BorderRadius = 20;
            this.TBxLotNo.BorderThickness = 1;
            this.TBxLotNo.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.TBxLotNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBxLotNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxLotNo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TBxLotNo.DefaultText = "";
            this.TBxLotNo.FillColor = System.Drawing.Color.White;
            this.TBxLotNo.HideSelection = true;
            this.TBxLotNo.IconLeft = null;
            this.TBxLotNo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxLotNo.IconPadding = 10;
            this.TBxLotNo.IconRight = global::WMS.Properties.Resources.search;
            this.TBxLotNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxLotNo.Lines = new string[0];
            this.TBxLotNo.Location = new System.Drawing.Point(169, 59);
            this.TBxLotNo.MaxLength = 32767;
            this.TBxLotNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.TBxLotNo.Modified = false;
            this.TBxLotNo.Multiline = false;
            this.TBxLotNo.Name = "TBxLotNo";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.DimGray;
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TBxLotNo.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnIdleState = stateProperties16;
            this.TBxLotNo.Padding = new System.Windows.Forms.Padding(3);
            this.TBxLotNo.PasswordChar = '\0';
            this.TBxLotNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TBxLotNo.PlaceholderText = "";
            this.TBxLotNo.ReadOnly = false;
            this.TBxLotNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBxLotNo.SelectedText = "";
            this.TBxLotNo.SelectionLength = 0;
            this.TBxLotNo.SelectionStart = 0;
            this.TBxLotNo.ShortcutsEnabled = true;
            this.TBxLotNo.Size = new System.Drawing.Size(194, 37);
            this.TBxLotNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TBxLotNo.TabIndex = 19;
            this.TBxLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBxLotNo.TextMarginBottom = 0;
            this.TBxLotNo.TextMarginLeft = 3;
            this.TBxLotNo.TextMarginTop = 0;
            this.TBxLotNo.TextPlaceholder = "";
            this.TBxLotNo.UseSystemPasswordChar = false;
            this.TBxLotNo.WordWrap = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBxLifo);
            this.groupBox2.Controls.Add(this.CBxFifo);
            this.groupBox2.Location = new System.Drawing.Point(489, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 151);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AllowAnimations = true;
            this.BtnSubmit.AllowMouseEffects = true;
            this.BtnSubmit.AllowToggling = false;
            this.BtnSubmit.AnimationSpeed = 200;
            this.BtnSubmit.AutoGenerateColors = false;
            this.BtnSubmit.AutoRoundBorders = false;
            this.BtnSubmit.AutoSizeLeftIcon = true;
            this.BtnSubmit.AutoSizeRightIcon = true;
            this.BtnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.BtnSubmit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSubmit.BackgroundImage")));
            this.BtnSubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.ButtonText = "Submit";
            this.BtnSubmit.ButtonTextMarginLeft = 0;
            this.BtnSubmit.ColorContrastOnClick = 45;
            this.BtnSubmit.ColorContrastOnHover = 45;
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnSubmit.CustomizableEdges = borderEdges2;
            this.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSubmit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSubmit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.IconLeft = null;
            this.BtnSubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSubmit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnSubmit.IconMarginLeft = 11;
            this.BtnSubmit.IconPadding = 10;
            this.BtnSubmit.IconRight = null;
            this.BtnSubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnSubmit.IconSize = 25;
            this.BtnSubmit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.IdleBorderRadius = 30;
            this.BtnSubmit.IdleBorderThickness = 1;
            this.BtnSubmit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.IdleIconLeftImage = null;
            this.BtnSubmit.IdleIconRightImage = null;
            this.BtnSubmit.IndicateFocus = false;
            this.BtnSubmit.Location = new System.Drawing.Point(796, 111);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSubmit.OnDisabledState.BorderRadius = 10;
            this.BtnSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnDisabledState.BorderThickness = 1;
            this.BtnSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSubmit.OnDisabledState.IconLeftImage = null;
            this.BtnSubmit.OnDisabledState.IconRightImage = null;
            this.BtnSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnSubmit.onHoverState.BorderRadius = 10;
            this.BtnSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.onHoverState.BorderThickness = 1;
            this.BtnSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.onHoverState.IconLeftImage = null;
            this.BtnSubmit.onHoverState.IconRightImage = null;
            this.BtnSubmit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.OnIdleState.BorderRadius = 10;
            this.BtnSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnIdleState.BorderThickness = 1;
            this.BtnSubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.OnIdleState.IconLeftImage = null;
            this.BtnSubmit.OnIdleState.IconRightImage = null;
            this.BtnSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnSubmit.OnPressedState.BorderRadius = 10;
            this.BtnSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnPressedState.BorderThickness = 1;
            this.BtnSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.OnPressedState.IconLeftImage = null;
            this.BtnSubmit.OnPressedState.IconRightImage = null;
            this.BtnSubmit.Size = new System.Drawing.Size(136, 40);
            this.BtnSubmit.TabIndex = 23;
            this.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSubmit.TextMarginLeft = 0;
            this.BtnSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnSubmit.UseDefaultRadiusAndThickness = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // UC_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.GridBalance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_Balance";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GridBalance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridBalance;
        private Bunifu.UI.WinForms.BunifuTextBox TBxLotNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown DDownMaterialType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSubmit;
        private System.Windows.Forms.CheckBox CBxFifo;
        private System.Windows.Forms.CheckBox CBxLifo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RackLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockIn;
        private Bunifu.UI.WinForms.BunifuTextBox TBxPartNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBxLotNo;
        private System.Windows.Forms.CheckBox CBxPartNo;
    }
}
