namespace RestaurantManager.View.Manager
{
    partial class GenusDialog
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
            this._grUpdate = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._txtGenus = new System.Windows.Forms.TextBox();
            this._lbGenusName = new System.Windows.Forms.Label();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._txtId = new System.Windows.Forms.TextBox();
            this._btnAddGenus = new System.Windows.Forms.Button();
            this._lbGenus = new System.Windows.Forms.Label();
            this._dgGenus = new System.Windows.Forms.DataGridView();
            this._grUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgGenus)).BeginInit();
            this.SuspendLayout();
            // 
            // _grUpdate
            // 
            this._grUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._grUpdate.CanvasColor = System.Drawing.SystemColors.Control;
            this._grUpdate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grUpdate.Controls.Add(this._btnUpdate);
            this._grUpdate.Controls.Add(this._txtGenus);
            this._grUpdate.Controls.Add(this._lbGenusName);
            this._grUpdate.Location = new System.Drawing.Point(280, 202);
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
            this._grUpdate.TabIndex = 10;
            this._grUpdate.Text = "Sửa Tên Loại Món";
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
            // _txtGenus
            // 
            this._txtGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtGenus.Location = new System.Drawing.Point(136, 19);
            this._txtGenus.Name = "_txtGenus";
            this._txtGenus.Size = new System.Drawing.Size(242, 26);
            this._txtGenus.TabIndex = 3;
            // 
            // _lbGenusName
            // 
            this._lbGenusName.AutoSize = true;
            this._lbGenusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbGenusName.Location = new System.Drawing.Point(12, 22);
            this._lbGenusName.Name = "_lbGenusName";
            this._lbGenusName.Size = new System.Drawing.Size(105, 20);
            this._lbGenusName.TabIndex = 2;
            this._lbGenusName.Text = "Tên Loại Món";
            // 
            // _btnExit
            // 
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.Location = new System.Drawing.Point(557, 479);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(125, 53);
            this._btnExit.TabIndex = 15;
            this._btnExit.Text = "Thoát";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(299, 479);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(125, 53);
            this._btnDelete.TabIndex = 14;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(585, 11);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(51, 20);
            this._txtId.TabIndex = 13;
            this._txtId.Visible = false;
            // 
            // _btnAddGenus
            // 
            this._btnAddGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddGenus.Location = new System.Drawing.Point(358, 48);
            this._btnAddGenus.Name = "_btnAddGenus";
            this._btnAddGenus.Size = new System.Drawing.Size(237, 56);
            this._btnAddGenus.TabIndex = 12;
            this._btnAddGenus.Text = "Thêm Mới Loại Món";
            this._btnAddGenus.UseVisualStyleBackColor = true;
            this._btnAddGenus.Click += new System.EventHandler(this._btnAddGenus_Click);
            // 
            // _lbGenus
            // 
            this._lbGenus.AutoSize = true;
            this._lbGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbGenus.Location = new System.Drawing.Point(88, 11);
            this._lbGenus.Name = "_lbGenus";
            this._lbGenus.Size = new System.Drawing.Size(74, 20);
            this._lbGenus.TabIndex = 11;
            this._lbGenus.Text = "Loại Món";
            // 
            // _dgGenus
            // 
            this._dgGenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgGenus.Location = new System.Drawing.Point(3, 48);
            this._dgGenus.Name = "_dgGenus";
            this._dgGenus.Size = new System.Drawing.Size(248, 494);
            this._dgGenus.TabIndex = 9;
            this._dgGenus.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgGenus_RowEnter);
            // 
            // GenusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 544);
            this.Controls.Add(this._grUpdate);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._btnAddGenus);
            this.Controls.Add(this._lbGenus);
            this.Controls.Add(this._dgGenus);
            this.Name = "GenusDialog";
            this.Text = "GenusDialog";
            this.Load += new System.EventHandler(this.GenusDialog_Load);
            this._grUpdate.ResumeLayout(false);
            this._grUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgGenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel _grUpdate;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.TextBox _txtGenus;
        private System.Windows.Forms.Label _lbGenusName;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.Button _btnAddGenus;
        private System.Windows.Forms.Label _lbGenus;
        private System.Windows.Forms.DataGridView _dgGenus;
    }
}