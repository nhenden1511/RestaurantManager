namespace RestaurantManager.View.Manager
{
    partial class AddVianddialog
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
            this._txtGenusId = new System.Windows.Forms.TextBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this._txtViand = new System.Windows.Forms.TextBox();
            this._lbViandName = new System.Windows.Forms.Label();
            this._grGenus = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._txtArea = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._lbPrice = new System.Windows.Forms.Label();
            this._grGenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtGenusId
            // 
            this._txtGenusId.Location = new System.Drawing.Point(35, 124);
            this._txtGenusId.Name = "_txtGenusId";
            this._txtGenusId.Size = new System.Drawing.Size(10, 20);
            this._txtGenusId.TabIndex = 13;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(300, 169);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(116, 46);
            this._btnAdd.TabIndex = 12;
            this._btnAdd.Text = "Thêm Mới";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _txtViand
            // 
            this._txtViand.Location = new System.Drawing.Point(398, 32);
            this._txtViand.Name = "_txtViand";
            this._txtViand.Size = new System.Drawing.Size(279, 20);
            this._txtViand.TabIndex = 10;
            this._txtViand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtViand_KeyPress);
            // 
            // _lbViandName
            // 
            this._lbViandName.AutoSize = true;
            this._lbViandName.Location = new System.Drawing.Point(323, 35);
            this._lbViandName.Name = "_lbViandName";
            this._lbViandName.Size = new System.Drawing.Size(50, 13);
            this._lbViandName.TabIndex = 11;
            this._lbViandName.Text = "Tên Món";
            // 
            // _grGenus
            // 
            this._grGenus.CanvasColor = System.Drawing.SystemColors.Control;
            this._grGenus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grGenus.Controls.Add(this._txtArea);
            this._grGenus.Location = new System.Drawing.Point(12, 32);
            this._grGenus.Name = "_grGenus";
            this._grGenus.Size = new System.Drawing.Size(244, 95);
            // 
            // 
            // 
            this._grGenus.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grGenus.Style.BackColorGradientAngle = 90;
            this._grGenus.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grGenus.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderBottomWidth = 1;
            this._grGenus.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grGenus.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderLeftWidth = 1;
            this._grGenus.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderRightWidth = 1;
            this._grGenus.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderTopWidth = 1;
            this._grGenus.Style.CornerDiameter = 4;
            this._grGenus.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grGenus.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grGenus.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grGenus.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grGenus.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grGenus.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grGenus.TabIndex = 14;
            this._grGenus.Text = "Loại Món";
            // 
            // _txtArea
            // 
            this._txtArea.Location = new System.Drawing.Point(14, 16);
            this._txtArea.Name = "_txtArea";
            this._txtArea.ReadOnly = true;
            this._txtArea.Size = new System.Drawing.Size(197, 20);
            this._txtArea.TabIndex = 3;
            this._txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(398, 98);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(279, 20);
            this._txtPrice.TabIndex = 15;
            this._txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            // 
            // _lbPrice
            // 
            this._lbPrice.AutoSize = true;
            this._lbPrice.Location = new System.Drawing.Point(323, 101);
            this._lbPrice.Name = "_lbPrice";
            this._lbPrice.Size = new System.Drawing.Size(45, 13);
            this._lbPrice.TabIndex = 16;
            this._lbPrice.Text = "Giá Bán";
            // 
            // AddVianddialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 236);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._lbPrice);
            this.Controls.Add(this._txtGenusId);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtViand);
            this.Controls.Add(this._lbViandName);
            this.Controls.Add(this._grGenus);
            this.Name = "AddVianddialog";
            this.Text = "AddVianddialog";
            this._grGenus.ResumeLayout(false);
            this._grGenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtGenusId;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.TextBox _txtViand;
        private System.Windows.Forms.Label _lbViandName;
        private DevComponents.DotNetBar.Controls.GroupPanel _grGenus;
        private System.Windows.Forms.TextBox _txtArea;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.Label _lbPrice;
    }
}