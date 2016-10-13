namespace RestaurantManager.View.Manager
{
    partial class TableDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dgArea = new System.Windows.Forms.DataGridView();
            this._dgTable = new System.Windows.Forms.DataGridView();
            this._lbArea = new System.Windows.Forms.Label();
            this._lbTable = new System.Windows.Forms.Label();
            this._txtAreaId = new System.Windows.Forms.TextBox();
            this._txtTableId = new System.Windows.Forms.TextBox();
            this._btnAddTable = new System.Windows.Forms.Button();
            this._txtTable = new System.Windows.Forms.TextBox();
            this._lbTableName = new System.Windows.Forms.Label();
            this._txtAreaName = new System.Windows.Forms.TextBox();
            this._grUpdate = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgTable)).BeginInit();
            this._grUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgArea
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgArea.Location = new System.Drawing.Point(12, 38);
            this._dgArea.MultiSelect = false;
            this._dgArea.Name = "_dgArea";
            this._dgArea.ReadOnly = true;
            this._dgArea.RowTemplate.Height = 33;
            this._dgArea.Size = new System.Drawing.Size(144, 399);
            this._dgArea.TabIndex = 0;
            this._dgArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgArea_CellClick);
            // 
            // _dgTable
            // 
            this._dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgTable.Location = new System.Drawing.Point(174, 38);
            this._dgTable.MultiSelect = false;
            this._dgTable.Name = "_dgTable";
            this._dgTable.ReadOnly = true;
            this._dgTable.Size = new System.Drawing.Size(180, 399);
            this._dgTable.TabIndex = 1;
            this._dgTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgTable_CellClick);
            // 
            // _lbArea
            // 
            this._lbArea.AutoSize = true;
            this._lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbArea.Location = new System.Drawing.Point(39, 9);
            this._lbArea.Name = "_lbArea";
            this._lbArea.Size = new System.Drawing.Size(69, 20);
            this._lbArea.TabIndex = 2;
            this._lbArea.Text = "Khu Vực";
            // 
            // _lbTable
            // 
            this._lbTable.AutoSize = true;
            this._lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTable.Location = new System.Drawing.Point(236, 9);
            this._lbTable.Name = "_lbTable";
            this._lbTable.Size = new System.Drawing.Size(38, 20);
            this._lbTable.TabIndex = 3;
            this._lbTable.Text = "Bàn";
            // 
            // _txtAreaId
            // 
            this._txtAreaId.Location = new System.Drawing.Point(360, 391);
            this._txtAreaId.Name = "_txtAreaId";
            this._txtAreaId.Size = new System.Drawing.Size(30, 20);
            this._txtAreaId.TabIndex = 4;
            this._txtAreaId.Visible = false;
            // 
            // _txtTableId
            // 
            this._txtTableId.Location = new System.Drawing.Point(360, 417);
            this._txtTableId.Name = "_txtTableId";
            this._txtTableId.Size = new System.Drawing.Size(30, 20);
            this._txtTableId.TabIndex = 5;
            this._txtTableId.Visible = false;
            // 
            // _btnAddTable
            // 
            this._btnAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddTable.Location = new System.Drawing.Point(462, 38);
            this._btnAddTable.Name = "_btnAddTable";
            this._btnAddTable.Size = new System.Drawing.Size(317, 63);
            this._btnAddTable.TabIndex = 6;
            this._btnAddTable.Text = "Thêm Bàn Mới";
            this._btnAddTable.UseVisualStyleBackColor = true;
            this._btnAddTable.Click += new System.EventHandler(this._btnAddTable_Click);
            // 
            // _txtTable
            // 
            this._txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTable.Location = new System.Drawing.Point(131, 11);
            this._txtTable.Name = "_txtTable";
            this._txtTable.ReadOnly = true;
            this._txtTable.Size = new System.Drawing.Size(277, 26);
            this._txtTable.TabIndex = 7;
            this._txtTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this._txtTable_MouseClick);
            // 
            // _lbTableName
            // 
            this._lbTableName.AutoSize = true;
            this._lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTableName.Location = new System.Drawing.Point(14, 14);
            this._lbTableName.Name = "_lbTableName";
            this._lbTableName.Size = new System.Drawing.Size(69, 20);
            this._lbTableName.TabIndex = 8;
            this._lbTableName.Text = "Tên Bàn";
            // 
            // _txtAreaName
            // 
            this._txtAreaName.Location = new System.Drawing.Point(360, 365);
            this._txtAreaName.Name = "_txtAreaName";
            this._txtAreaName.Size = new System.Drawing.Size(30, 20);
            this._txtAreaName.TabIndex = 9;
            this._txtAreaName.Visible = false;
            // 
            // _grUpdate
            // 
            this._grUpdate.CanvasColor = System.Drawing.SystemColors.Control;
            this._grUpdate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grUpdate.Controls.Add(this._lbTableName);
            this._grUpdate.Controls.Add(this._txtTable);
            this._grUpdate.Controls.Add(this._btnUpdate);
            this._grUpdate.Location = new System.Drawing.Point(360, 147);
            this._grUpdate.Name = "_grUpdate";
            this._grUpdate.Size = new System.Drawing.Size(495, 145);
            // 
            // 
            // 
            this._grUpdate.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grUpdate.Style.BackColorGradientAngle = 90;
            this._grUpdate.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grUpdate.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grUpdate.Style.BorderBottomWidth = 1;
            this._grUpdate.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grUpdate.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grUpdate.Style.BorderLeftWidth = 1;
            this._grUpdate.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grUpdate.Style.BorderRightWidth = 1;
            this._grUpdate.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grUpdate.Style.BorderTopWidth = 1;
            this._grUpdate.Style.CornerDiameter = 4;
            this._grUpdate.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grUpdate.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grUpdate.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grUpdate.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grUpdate.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grUpdate.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grUpdate.TabIndex = 10;
            this._grUpdate.Text = "Sửa Tên Bàn";
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpdate.Location = new System.Drawing.Point(180, 59);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(124, 43);
            this._btnUpdate.TabIndex = 11;
            this._btnUpdate.Text = "Lưu";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnExit
            // 
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.Location = new System.Drawing.Point(698, 365);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(111, 55);
            this._btnExit.TabIndex = 13;
            this._btnExit.Text = "Thoát";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(411, 365);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(113, 55);
            this._btnDelete.TabIndex = 12;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // TableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 449);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._grUpdate);
            this.Controls.Add(this._txtAreaName);
            this.Controls.Add(this._btnAddTable);
            this.Controls.Add(this._txtTableId);
            this.Controls.Add(this._txtAreaId);
            this.Controls.Add(this._lbTable);
            this.Controls.Add(this._lbArea);
            this.Controls.Add(this._dgTable);
            this.Controls.Add(this._dgArea);
            this.Name = "TableDialog";
            this.Text = "Thêm Bàn";
            this.Load += new System.EventHandler(this.TableDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgTable)).EndInit();
            this._grUpdate.ResumeLayout(false);
            this._grUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgArea;
        private System.Windows.Forms.DataGridView _dgTable;
        private System.Windows.Forms.Label _lbArea;
        private System.Windows.Forms.Label _lbTable;
        private System.Windows.Forms.TextBox _txtAreaId;
        private System.Windows.Forms.TextBox _txtTableId;
        private System.Windows.Forms.Button _btnAddTable;
        private System.Windows.Forms.TextBox _txtTable;
        private System.Windows.Forms.Label _lbTableName;
        private System.Windows.Forms.TextBox _txtAreaName;
        private DevComponents.DotNetBar.Controls.GroupPanel _grUpdate;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnDelete;
    }
}