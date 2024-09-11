
namespace WMS.PanelUC
{
    partial class UC_StockInLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StockInLog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TBxLotNo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.GridStockIn = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridStockIn)).BeginInit();
            this.SuspendLayout();
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnSubmit.CustomizableEdges = borderEdges1;
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
            this.BtnSubmit.Location = new System.Drawing.Point(346, 42);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSubmit.OnDisabledState.BorderRadius = 15;
            this.BtnSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnDisabledState.BorderThickness = 1;
            this.BtnSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSubmit.OnDisabledState.IconLeftImage = null;
            this.BtnSubmit.OnDisabledState.IconRightImage = null;
            this.BtnSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnSubmit.onHoverState.BorderRadius = 15;
            this.BtnSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.onHoverState.BorderThickness = 1;
            this.BtnSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.onHoverState.IconLeftImage = null;
            this.BtnSubmit.onHoverState.IconRightImage = null;
            this.BtnSubmit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.OnIdleState.BorderRadius = 15;
            this.BtnSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnIdleState.BorderThickness = 1;
            this.BtnSubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.OnIdleState.IconLeftImage = null;
            this.BtnSubmit.OnIdleState.IconRightImage = null;
            this.BtnSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnSubmit.OnPressedState.BorderRadius = 15;
            this.BtnSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmit.OnPressedState.BorderThickness = 1;
            this.BtnSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.OnPressedState.IconLeftImage = null;
            this.BtnSubmit.OnPressedState.IconRightImage = null;
            this.BtnSubmit.Size = new System.Drawing.Size(108, 46);
            this.BtnSubmit.TabIndex = 17;
            this.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSubmit.TextMarginLeft = 0;
            this.BtnSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnSubmit.UseDefaultRadiusAndThickness = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
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
            this.TBxLotNo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TBxLotNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TBxLotNo.BorderColorIdle = System.Drawing.Color.Silver;
            this.TBxLotNo.BorderRadius = 1;
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
            this.TBxLotNo.IconRight = null;
            this.TBxLotNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxLotNo.Lines = new string[0];
            this.TBxLotNo.Location = new System.Drawing.Point(31, 43);
            this.TBxLotNo.MaxLength = 32767;
            this.TBxLotNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.TBxLotNo.Modified = false;
            this.TBxLotNo.Multiline = false;
            this.TBxLotNo.Name = "TBxLotNo";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TBxLotNo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TBxLotNo.OnIdleState = stateProperties4;
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
            this.TBxLotNo.Size = new System.Drawing.Size(292, 46);
            this.TBxLotNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TBxLotNo.TabIndex = 16;
            this.TBxLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBxLotNo.TextMarginBottom = 0;
            this.TBxLotNo.TextMarginLeft = 3;
            this.TBxLotNo.TextMarginTop = 1;
            this.TBxLotNo.TextPlaceholder = "";
            this.TBxLotNo.UseSystemPasswordChar = false;
            this.TBxLotNo.WordWrap = true;
            // 
            // GridStockIn
            // 
            this.GridStockIn.AllowCustomTheming = false;
            this.GridStockIn.AllowUserToAddRows = false;
            this.GridStockIn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridStockIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridStockIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridStockIn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridStockIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridStockIn.ColumnHeadersHeight = 40;
            this.GridStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Shift,
            this.User,
            this.Date});
            this.GridStockIn.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridStockIn.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridStockIn.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridStockIn.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GridStockIn.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridStockIn.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.GridStockIn.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GridStockIn.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.GridStockIn.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridStockIn.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridStockIn.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.GridStockIn.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridStockIn.CurrentTheme.Name = null;
            this.GridStockIn.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridStockIn.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridStockIn.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridStockIn.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GridStockIn.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridStockIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridStockIn.EnableHeadersVisualStyles = false;
            this.GridStockIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GridStockIn.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.GridStockIn.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridStockIn.HeaderForeColor = System.Drawing.Color.White;
            this.GridStockIn.Location = new System.Drawing.Point(33, 118);
            this.GridStockIn.Name = "GridStockIn";
            this.GridStockIn.ReadOnly = true;
            this.GridStockIn.RowHeadersVisible = false;
            this.GridStockIn.RowTemplate.Height = 40;
            this.GridStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridStockIn.Size = new System.Drawing.Size(918, 421);
            this.GridStockIn.TabIndex = 15;
            this.GridStockIn.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Shift
            // 
            this.Shift.DataPropertyName = "StockInShift";
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "UserName";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "StockInDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // UC_StockInLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TBxLotNo);
            this.Controls.Add(this.GridStockIn);
            this.Name = "UC_StockInLog";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GridStockIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSubmit;
        private Bunifu.UI.WinForms.BunifuTextBox TBxLotNo;
        private Bunifu.UI.WinForms.BunifuDataGridView GridStockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
