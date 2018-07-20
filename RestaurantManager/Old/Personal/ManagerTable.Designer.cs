namespace RestaurantManager.View.Personal
{
    partial class ManagerTable
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
            this._grGenus = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._lvGenus = new System.Windows.Forms.ListView();
            this._grViand = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._lvViand = new System.Windows.Forms.ListView();
            this._grProperty = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._btnAdd = new System.Windows.Forms.Button();
            this._txtTolal = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._txtNumber = new System.Windows.Forms.NumericUpDown();
            this._txtViandId = new System.Windows.Forms.TextBox();
            this._txtViandName = new System.Windows.Forms.TextBox();
            this._txtTableName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lbTotal = new System.Windows.Forms.Label();
            this._lbPrice = new System.Windows.Forms.Label();
            this._lbNumber = new System.Windows.Forms.Label();
            this._lbViandName = new System.Windows.Forms.Label();
            this._lbTableName = new System.Windows.Forms.Label();
            this._grDetail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._dgOrderDetail = new System.Windows.Forms.DataGridView();
            this._txtGenusId = new System.Windows.Forms.TextBox();
            this._btnPayment = new System.Windows.Forms.Button();
            this._grGenus.SuspendLayout();
            this._grViand.SuspendLayout();
            this._grProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNumber)).BeginInit();
            this._grDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // _grGenus
            // 
            this._grGenus.CanvasColor = System.Drawing.SystemColors.Control;
            this._grGenus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grGenus.Controls.Add(this._lvGenus);
            this._grGenus.Location = new System.Drawing.Point(1, 12);
            this._grGenus.Name = "_grGenus";
            this._grGenus.Size = new System.Drawing.Size(192, 503);
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
            this._grGenus.TabIndex = 3;
            this._grGenus.Text = "Loại Món";
            // 
            // _lvGenus
            // 
            this._lvGenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvGenus.Location = new System.Drawing.Point(0, 0);
            this._lvGenus.MultiSelect = false;
            this._lvGenus.Name = "_lvGenus";
            this._lvGenus.Size = new System.Drawing.Size(186, 482);
            this._lvGenus.TabIndex = 0;
            this._lvGenus.UseCompatibleStateImageBehavior = false;
            this._lvGenus.SelectedIndexChanged += new System.EventHandler(this._lvGenus_SelectedIndexChanged);
            // 
            // _grViand
            // 
            this._grViand.CanvasColor = System.Drawing.SystemColors.Control;
            this._grViand.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grViand.Controls.Add(this._lvViand);
            this._grViand.Location = new System.Drawing.Point(199, 12);
            this._grViand.Name = "_grViand";
            this._grViand.Size = new System.Drawing.Size(334, 503);
            // 
            // 
            // 
            this._grViand.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grViand.Style.BackColorGradientAngle = 90;
            this._grViand.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grViand.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderBottomWidth = 1;
            this._grViand.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grViand.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderLeftWidth = 1;
            this._grViand.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderRightWidth = 1;
            this._grViand.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderTopWidth = 1;
            this._grViand.Style.CornerDiameter = 4;
            this._grViand.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grViand.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grViand.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grViand.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grViand.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grViand.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grViand.TabIndex = 4;
            this._grViand.Text = "Món";
            // 
            // _lvViand
            // 
            this._lvViand.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvViand.Location = new System.Drawing.Point(0, 0);
            this._lvViand.MultiSelect = false;
            this._lvViand.Name = "_lvViand";
            this._lvViand.Size = new System.Drawing.Size(328, 482);
            this._lvViand.TabIndex = 1;
            this._lvViand.UseCompatibleStateImageBehavior = false;
            this._lvViand.SelectedIndexChanged += new System.EventHandler(this._lvViand_SelectedIndexChanged);
            // 
            // _grProperty
            // 
            this._grProperty.CanvasColor = System.Drawing.SystemColors.Control;
            this._grProperty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grProperty.Controls.Add(this._btnAdd);
            this._grProperty.Controls.Add(this._txtTolal);
            this._grProperty.Controls.Add(this._txtPrice);
            this._grProperty.Controls.Add(this._txtNumber);
            this._grProperty.Controls.Add(this._txtViandId);
            this._grProperty.Controls.Add(this._txtViandName);
            this._grProperty.Controls.Add(this._txtTableName);
            this._grProperty.Controls.Add(this.label10);
            this._grProperty.Controls.Add(this.label9);
            this._grProperty.Controls.Add(this.label8);
            this._grProperty.Controls.Add(this.label7);
            this._grProperty.Controls.Add(this.label6);
            this._grProperty.Controls.Add(this._lbTotal);
            this._grProperty.Controls.Add(this._lbPrice);
            this._grProperty.Controls.Add(this._lbNumber);
            this._grProperty.Controls.Add(this._lbViandName);
            this._grProperty.Controls.Add(this._lbTableName);
            this._grProperty.Location = new System.Drawing.Point(539, 12);
            this._grProperty.Name = "_grProperty";
            this._grProperty.Size = new System.Drawing.Size(331, 503);
            // 
            // 
            // 
            this._grProperty.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grProperty.Style.BackColorGradientAngle = 90;
            this._grProperty.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grProperty.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderBottomWidth = 1;
            this._grProperty.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grProperty.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderLeftWidth = 1;
            this._grProperty.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderRightWidth = 1;
            this._grProperty.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderTopWidth = 1;
            this._grProperty.Style.CornerDiameter = 4;
            this._grProperty.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grProperty.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grProperty.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grProperty.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grProperty.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grProperty.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grProperty.TabIndex = 5;
            this._grProperty.Text = "Tùy Chọn";
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.Location = new System.Drawing.Point(89, 277);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(151, 43);
            this._btnAdd.TabIndex = 16;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _txtTolal
            // 
            this._txtTolal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTolal.Location = new System.Drawing.Point(143, 227);
            this._txtTolal.Name = "_txtTolal";
            this._txtTolal.ReadOnly = true;
            this._txtTolal.Size = new System.Drawing.Size(179, 26);
            this._txtTolal.TabIndex = 15;
            // 
            // _txtPrice
            // 
            this._txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrice.Location = new System.Drawing.Point(107, 132);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.ReadOnly = true;
            this._txtPrice.Size = new System.Drawing.Size(215, 26);
            this._txtPrice.TabIndex = 14;
            // 
            // _txtNumber
            // 
            this._txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNumber.Location = new System.Drawing.Point(107, 181);
            this._txtNumber.Name = "_txtNumber";
            this._txtNumber.Size = new System.Drawing.Size(120, 26);
            this._txtNumber.TabIndex = 13;
            this._txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtNumber.ValueChanged += new System.EventHandler(this._txtNumber_ValueChanged);
            this._txtNumber.TabIndexChanged += new System.EventHandler(this.numericUpDown1_TabIndexChanged);
            // 
            // _txtViandId
            // 
            this._txtViandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtViandId.Location = new System.Drawing.Point(7, 49);
            this._txtViandId.Name = "_txtViandId";
            this._txtViandId.ReadOnly = true;
            this._txtViandId.Size = new System.Drawing.Size(39, 26);
            this._txtViandId.TabIndex = 12;
            // 
            // _txtViandName
            // 
            this._txtViandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtViandName.Location = new System.Drawing.Point(107, 84);
            this._txtViandName.Name = "_txtViandName";
            this._txtViandName.ReadOnly = true;
            this._txtViandName.Size = new System.Drawing.Size(215, 26);
            this._txtViandName.TabIndex = 11;
            // 
            // _txtTableName
            // 
            this._txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTableName.Location = new System.Drawing.Point(107, 13);
            this._txtTableName.Name = "_txtTableName";
            this._txtTableName.ReadOnly = true;
            this._txtTableName.Size = new System.Drawing.Size(215, 26);
            this._txtTableName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // _lbTotal
            // 
            this._lbTotal.AutoSize = true;
            this._lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTotal.Location = new System.Drawing.Point(3, 230);
            this._lbTotal.Name = "_lbTotal";
            this._lbTotal.Size = new System.Drawing.Size(92, 20);
            this._lbTotal.TabIndex = 4;
            this._lbTotal.Text = "Thành Tiền:";
            // 
            // _lbPrice
            // 
            this._lbPrice.AutoSize = true;
            this._lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbPrice.Location = new System.Drawing.Point(3, 135);
            this._lbPrice.Name = "_lbPrice";
            this._lbPrice.Size = new System.Drawing.Size(72, 20);
            this._lbPrice.TabIndex = 3;
            this._lbPrice.Text = "Đơn Giá:";
            // 
            // _lbNumber
            // 
            this._lbNumber.AutoSize = true;
            this._lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbNumber.Location = new System.Drawing.Point(3, 183);
            this._lbNumber.Name = "_lbNumber";
            this._lbNumber.Size = new System.Drawing.Size(78, 20);
            this._lbNumber.TabIndex = 2;
            this._lbNumber.Text = "Số Lượng";
            // 
            // _lbViandName
            // 
            this._lbViandName.AutoSize = true;
            this._lbViandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbViandName.Location = new System.Drawing.Point(3, 87);
            this._lbViandName.Name = "_lbViandName";
            this._lbViandName.Size = new System.Drawing.Size(75, 20);
            this._lbViandName.TabIndex = 1;
            this._lbViandName.Text = "Tên Món:";
            // 
            // _lbTableName
            // 
            this._lbTableName.AutoSize = true;
            this._lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTableName.Location = new System.Drawing.Point(3, 16);
            this._lbTableName.Name = "_lbTableName";
            this._lbTableName.Size = new System.Drawing.Size(73, 20);
            this._lbTableName.TabIndex = 0;
            this._lbTableName.Text = "Tên Bàn:";
            // 
            // _grDetail
            // 
            this._grDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this._grDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grDetail.Controls.Add(this._dgOrderDetail);
            this._grDetail.Location = new System.Drawing.Point(876, 12);
            this._grDetail.Name = "_grDetail";
            this._grDetail.Size = new System.Drawing.Size(446, 503);
            // 
            // 
            // 
            this._grDetail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grDetail.Style.BackColorGradientAngle = 90;
            this._grDetail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grDetail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderBottomWidth = 1;
            this._grDetail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grDetail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderLeftWidth = 1;
            this._grDetail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderRightWidth = 1;
            this._grDetail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderTopWidth = 1;
            this._grDetail.Style.CornerDiameter = 4;
            this._grDetail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grDetail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grDetail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grDetail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grDetail.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grDetail.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grDetail.TabIndex = 6;
            this._grDetail.Text = "Chi Tiết Gọi Món";
            // 
            // _dgOrderDetail
            // 
            this._dgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgOrderDetail.Location = new System.Drawing.Point(0, 0);
            this._dgOrderDetail.Name = "_dgOrderDetail";
            this._dgOrderDetail.Size = new System.Drawing.Size(440, 482);
            this._dgOrderDetail.TabIndex = 0;
            // 
            // _txtGenusId
            // 
            this._txtGenusId.Location = new System.Drawing.Point(4, 557);
            this._txtGenusId.Name = "_txtGenusId";
            this._txtGenusId.Size = new System.Drawing.Size(53, 20);
            this._txtGenusId.TabIndex = 7;
            this._txtGenusId.TextChanged += new System.EventHandler(this._txtGenusId_TextChanged);
            // 
            // _btnPayment
            // 
            this._btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPayment.Location = new System.Drawing.Point(437, 536);
            this._btnPayment.Name = "_btnPayment";
            this._btnPayment.Size = new System.Drawing.Size(151, 43);
            this._btnPayment.TabIndex = 17;
            this._btnPayment.Text = "Thanh Toán";
            this._btnPayment.UseVisualStyleBackColor = true;
            this._btnPayment.Click += new System.EventHandler(this._btnPayment_Click);
            // 
            // ManagerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this._btnPayment);
            this.Controls.Add(this._txtGenusId);
            this.Controls.Add(this._grDetail);
            this.Controls.Add(this._grProperty);
            this.Controls.Add(this._grViand);
            this.Controls.Add(this._grGenus);
            this.Name = "ManagerTable";
            this.Text = "ManagerTable";
            this.Resize += new System.EventHandler(this.ManagerTable_Resize);
            this._grGenus.ResumeLayout(false);
            this._grViand.ResumeLayout(false);
            this._grProperty.ResumeLayout(false);
            this._grProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNumber)).EndInit();
            this._grDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel _grGenus;
        private DevComponents.DotNetBar.Controls.GroupPanel _grViand;
        private DevComponents.DotNetBar.Controls.GroupPanel _grProperty;
        private DevComponents.DotNetBar.Controls.GroupPanel _grDetail;
        private System.Windows.Forms.ListView _lvGenus;
        private System.Windows.Forms.TextBox _txtGenusId;
        private System.Windows.Forms.ListView _lvViand;
        private System.Windows.Forms.DataGridView _dgOrderDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lbTotal;
        private System.Windows.Forms.Label _lbPrice;
        private System.Windows.Forms.Label _lbNumber;
        private System.Windows.Forms.Label _lbViandName;
        private System.Windows.Forms.Label _lbTableName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtTableName;
        private System.Windows.Forms.TextBox _txtViandName;
        private System.Windows.Forms.TextBox _txtViandId;
        private System.Windows.Forms.NumericUpDown _txtNumber;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.TextBox _txtTolal;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnPayment;
    }
}