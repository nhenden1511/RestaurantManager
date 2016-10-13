namespace RestaurantManager.View.Manager
{
    partial class AreaDialog
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
            this._dgArea = new System.Windows.Forms.DataGridView();
            this._lbArea = new System.Windows.Forms.Label();
            this._lbAreaName = new System.Windows.Forms.Label();
            this._txtArea = new System.Windows.Forms.TextBox();
            this._btnAddArea = new System.Windows.Forms.Button();
            this._txtId = new System.Windows.Forms.TextBox();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._grUpdate = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this._dgArea)).BeginInit();
            this._grUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgArea
            // 
            this._dgArea.AllowUserToResizeRows = false;
            this._dgArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgArea.Location = new System.Drawing.Point(5, 46);
            this._dgArea.MultiSelect = false;
            this._dgArea.Name = "_dgArea";
            this._dgArea.Size = new System.Drawing.Size(248, 358);
            this._dgArea.TabIndex = 0;
            this._dgArea.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgArea_RowEnter);
            // 
            // _lbArea
            // 
            this._lbArea.AutoSize = true;
            this._lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbArea.Location = new System.Drawing.Point(95, 9);
            this._lbArea.Name = "_lbArea";
            this._lbArea.Size = new System.Drawing.Size(69, 20);
            this._lbArea.TabIndex = 1;
            this._lbArea.Text = "Khu Vực";
            // 
            // _lbAreaName
            // 
            this._lbAreaName.AutoSize = true;
            this._lbAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbAreaName.Location = new System.Drawing.Point(12, 22);
            this._lbAreaName.Name = "_lbAreaName";
            this._lbAreaName.Size = new System.Drawing.Size(100, 20);
            this._lbAreaName.TabIndex = 2;
            this._lbAreaName.Text = "Tên Khu Vực";
            // 
            // _txtArea
            // 
            this._txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtArea.Location = new System.Drawing.Point(136, 19);
            this._txtArea.Name = "_txtArea";
            this._txtArea.Size = new System.Drawing.Size(242, 26);
            this._txtArea.TabIndex = 3;
            // 
            // _btnAddArea
            // 
            this._btnAddArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddArea.Location = new System.Drawing.Point(351, 46);
            this._btnAddArea.Name = "_btnAddArea";
            this._btnAddArea.Size = new System.Drawing.Size(237, 56);
            this._btnAddArea.TabIndex = 4;
            this._btnAddArea.Text = "Thêm Mới Khu Vực";
            this._btnAddArea.UseVisualStyleBackColor = true;
            this._btnAddArea.Click += new System.EventHandler(this._btnAddArea_Click);
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(578, 9);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(51, 20);
            this._txtId.TabIndex = 5;
            this._txtId.Visible = false;
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpdate.Location = new System.Drawing.Point(163, 82);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(88, 42);
            this._btnUpdate.TabIndex = 6;
            this._btnUpdate.Text = "Lưu";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(294, 334);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(100, 42);
            this._btnDelete.TabIndex = 7;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnExit
            // 
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.Location = new System.Drawing.Point(529, 334);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(100, 42);
            this._btnExit.TabIndex = 8;
            this._btnExit.Text = "Thoát";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _grUpdate
            // 
            this._grUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._grUpdate.CanvasColor = System.Drawing.SystemColors.Control;
            this._grUpdate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grUpdate.Controls.Add(this._btnUpdate);
            this._grUpdate.Controls.Add(this._txtArea);
            this._grUpdate.Controls.Add(this._lbAreaName);
            this._grUpdate.Location = new System.Drawing.Point(259, 137);
            this._grUpdate.Name = "_grUpdate";
            this._grUpdate.Size = new System.Drawing.Size(402, 160);
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
            this._grUpdate.TabIndex = 1;
            this._grUpdate.Text = "Sửa Tên Khu Vực";
            // 
            // AreaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(672, 407);
            this.Controls.Add(this._grUpdate);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._btnAddArea);
            this.Controls.Add(this._lbArea);
            this.Controls.Add(this._dgArea);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AreaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KHU VỰC";
            this.Load += new System.EventHandler(this.AreaDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgArea)).EndInit();
            this._grUpdate.ResumeLayout(false);
            this._grUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgArea;
        private System.Windows.Forms.Label _lbArea;
        private System.Windows.Forms.Label _lbAreaName;
        private System.Windows.Forms.TextBox _txtArea;
        private System.Windows.Forms.Button _btnAddArea;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnExit;
        private DevComponents.DotNetBar.Controls.GroupPanel _grUpdate;
    }
}