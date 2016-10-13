namespace RestaurantManager.View.Manager
{
    partial class ViandDialog
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
            this._btnExit = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._grUpdate = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._lbPrice = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._lbViandName = new System.Windows.Forms.Label();
            this._txtViand = new System.Windows.Forms.TextBox();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._txtGenusName = new System.Windows.Forms.TextBox();
            this._btnAddViand = new System.Windows.Forms.Button();
            this._txtViandId = new System.Windows.Forms.TextBox();
            this._txtGenusId = new System.Windows.Forms.TextBox();
            this._lbViand = new System.Windows.Forms.Label();
            this._lbGenus = new System.Windows.Forms.Label();
            this._dgViand = new System.Windows.Forms.DataGridView();
            this._dgGenus = new System.Windows.Forms.DataGridView();
            this._grUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgViand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgGenus)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnExit
            // 
            this._btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExit.Location = new System.Drawing.Point(833, 514);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(111, 55);
            this._btnExit.TabIndex = 24;
            this._btnExit.Text = "Thoát";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(551, 514);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(113, 55);
            this._btnDelete.TabIndex = 23;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _grUpdate
            // 
            this._grUpdate.CanvasColor = System.Drawing.SystemColors.Control;
            this._grUpdate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grUpdate.Controls.Add(this._lbPrice);
            this._grUpdate.Controls.Add(this._txtPrice);
            this._grUpdate.Controls.Add(this._lbViandName);
            this._grUpdate.Controls.Add(this._txtViand);
            this._grUpdate.Controls.Add(this._btnUpdate);
            this._grUpdate.Location = new System.Drawing.Point(495, 189);
            this._grUpdate.Name = "_grUpdate";
            this._grUpdate.Size = new System.Drawing.Size(495, 212);
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
            this._grUpdate.TabIndex = 22;
            this._grUpdate.Text = "Sửa Tên Món";
            // 
            // _lbPrice
            // 
            this._lbPrice.AutoSize = true;
            this._lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbPrice.Location = new System.Drawing.Point(14, 71);
            this._lbPrice.Name = "_lbPrice";
            this._lbPrice.Size = new System.Drawing.Size(34, 20);
            this._lbPrice.TabIndex = 13;
            this._lbPrice.Text = "Giá";
            // 
            // _txtPrice
            // 
            this._txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrice.Location = new System.Drawing.Point(131, 68);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.ReadOnly = true;
            this._txtPrice.Size = new System.Drawing.Size(277, 26);
            this._txtPrice.TabIndex = 12;
            this._txtPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this._txtPrice_MouseClick);
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            // 
            // _lbViandName
            // 
            this._lbViandName.AutoSize = true;
            this._lbViandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbViandName.Location = new System.Drawing.Point(14, 14);
            this._lbViandName.Name = "_lbViandName";
            this._lbViandName.Size = new System.Drawing.Size(71, 20);
            this._lbViandName.TabIndex = 8;
            this._lbViandName.Text = "Tên Món";
            // 
            // _txtViand
            // 
            this._txtViand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtViand.Location = new System.Drawing.Point(131, 11);
            this._txtViand.Name = "_txtViand";
            this._txtViand.ReadOnly = true;
            this._txtViand.Size = new System.Drawing.Size(277, 26);
            this._txtViand.TabIndex = 7;
            this._txtViand.MouseClick += new System.Windows.Forms.MouseEventHandler(this._txtViand_MouseClick);
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpdate.Location = new System.Drawing.Point(187, 126);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(124, 43);
            this._btnUpdate.TabIndex = 11;
            this._btnUpdate.Text = "Lưu";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _txtGenusName
            // 
            this._txtGenusName.Location = new System.Drawing.Point(495, 407);
            this._txtGenusName.Name = "_txtGenusName";
            this._txtGenusName.Size = new System.Drawing.Size(30, 20);
            this._txtGenusName.TabIndex = 21;
            this._txtGenusName.Visible = false;
            // 
            // _btnAddViand
            // 
            this._btnAddViand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddViand.Location = new System.Drawing.Point(598, 35);
            this._btnAddViand.Name = "_btnAddViand";
            this._btnAddViand.Size = new System.Drawing.Size(317, 63);
            this._btnAddViand.TabIndex = 20;
            this._btnAddViand.Text = "Thêm Món Mới";
            this._btnAddViand.UseVisualStyleBackColor = true;
            this._btnAddViand.Click += new System.EventHandler(this._btnAddViand_Click);
            // 
            // _txtViandId
            // 
            this._txtViandId.Location = new System.Drawing.Point(495, 459);
            this._txtViandId.Name = "_txtViandId";
            this._txtViandId.Size = new System.Drawing.Size(30, 20);
            this._txtViandId.TabIndex = 19;
            this._txtViandId.Visible = false;
            // 
            // _txtGenusId
            // 
            this._txtGenusId.Location = new System.Drawing.Point(495, 433);
            this._txtGenusId.Name = "_txtGenusId";
            this._txtGenusId.Size = new System.Drawing.Size(30, 20);
            this._txtGenusId.TabIndex = 18;
            this._txtGenusId.Visible = false;
            // 
            // _lbViand
            // 
            this._lbViand.AutoSize = true;
            this._lbViand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbViand.Location = new System.Drawing.Point(307, 6);
            this._lbViand.Name = "_lbViand";
            this._lbViand.Size = new System.Drawing.Size(40, 20);
            this._lbViand.TabIndex = 17;
            this._lbViand.Text = "Món";
            // 
            // _lbGenus
            // 
            this._lbGenus.AutoSize = true;
            this._lbGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbGenus.Location = new System.Drawing.Point(55, 6);
            this._lbGenus.Name = "_lbGenus";
            this._lbGenus.Size = new System.Drawing.Size(74, 20);
            this._lbGenus.TabIndex = 16;
            this._lbGenus.Text = "Loại Món";
            // 
            // _dgViand
            // 
            this._dgViand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgViand.Location = new System.Drawing.Point(192, 35);
            this._dgViand.MultiSelect = false;
            this._dgViand.Name = "_dgViand";
            this._dgViand.ReadOnly = true;
            this._dgViand.Size = new System.Drawing.Size(287, 540);
            this._dgViand.TabIndex = 15;
            this._dgViand.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgViand_RowEnter);
            // 
            // _dgGenus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgGenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgGenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgGenus.Location = new System.Drawing.Point(12, 35);
            this._dgGenus.MultiSelect = false;
            this._dgGenus.Name = "_dgGenus";
            this._dgGenus.ReadOnly = true;
            this._dgGenus.RowTemplate.Height = 33;
            this._dgGenus.Size = new System.Drawing.Size(162, 540);
            this._dgGenus.TabIndex = 14;
            this._dgGenus.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgGenus_RowEnter);
            // 
            // ViandDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 581);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._grUpdate);
            this.Controls.Add(this._txtGenusName);
            this.Controls.Add(this._btnAddViand);
            this.Controls.Add(this._txtViandId);
            this.Controls.Add(this._txtGenusId);
            this.Controls.Add(this._lbViand);
            this.Controls.Add(this._lbGenus);
            this.Controls.Add(this._dgViand);
            this.Controls.Add(this._dgGenus);
            this.Name = "ViandDialog";
            this.Text = "ViandDialog";
            this.Load += new System.EventHandler(this.ViandDialog_Load);
            this._grUpdate.ResumeLayout(false);
            this._grUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgViand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgGenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnDelete;
        private DevComponents.DotNetBar.Controls.GroupPanel _grUpdate;
        private System.Windows.Forms.Label _lbViandName;
        private System.Windows.Forms.TextBox _txtViand;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.TextBox _txtGenusName;
        private System.Windows.Forms.Button _btnAddViand;
        private System.Windows.Forms.TextBox _txtViandId;
        private System.Windows.Forms.TextBox _txtGenusId;
        private System.Windows.Forms.Label _lbViand;
        private System.Windows.Forms.Label _lbGenus;
        private System.Windows.Forms.DataGridView _dgViand;
        private System.Windows.Forms.DataGridView _dgGenus;
        private System.Windows.Forms.Label _lbPrice;
        private System.Windows.Forms.TextBox _txtPrice;
    }
}