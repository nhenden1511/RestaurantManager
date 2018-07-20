namespace RestaurantManager.View
{
    partial class OrderDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDialog));
            this._txtGroupId = new System.Windows.Forms.TextBox();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtProductId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._picShow = new System.Windows.Forms.PictureBox();
            this._lvProduct = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col5_image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col6_SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._txtImage = new System.Windows.Forms.TextBox();
            this._btnSingle = new System.Windows.Forms.Button();
            this._btnMuti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnChange = new System.Windows.Forms.Button();
            this._txtNumber = new System.Windows.Forms.NumericUpDown();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this._btnSingleOnline = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtGroupId
            // 
            this._txtGroupId.Location = new System.Drawing.Point(180, 33);
            this._txtGroupId.Name = "_txtGroupId";
            this._txtGroupId.ReadOnly = true;
            this._txtGroupId.Size = new System.Drawing.Size(30, 20);
            this._txtGroupId.TabIndex = 7;
            this._txtGroupId.Visible = false;
            // 
            // _cbbGroup
            // 
            this._cbbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(12, 33);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(151, 28);
            this._cbbGroup.TabIndex = 6;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Nhóm Sản Phẩm";
            // 
            // _txtProductId
            // 
            this._txtProductId.Location = new System.Drawing.Point(456, 62);
            this._txtProductId.Name = "_txtProductId";
            this._txtProductId.ReadOnly = true;
            this._txtProductId.Size = new System.Drawing.Size(50, 20);
            this._txtProductId.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this._picShow);
            this.groupBox1.Location = new System.Drawing.Point(456, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 157);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // _picShow
            // 
            this._picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picShow.Location = new System.Drawing.Point(3, 16);
            this._picShow.Name = "_picShow";
            this._picShow.Size = new System.Drawing.Size(179, 138);
            this._picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picShow.TabIndex = 5;
            this._picShow.TabStop = false;
            // 
            // _lvProduct
            // 
            this._lvProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5_image,
            this.col6_SL});
            this._lvProduct.Location = new System.Drawing.Point(6, 88);
            this._lvProduct.Name = "_lvProduct";
            this._lvProduct.Size = new System.Drawing.Size(335, 421);
            this._lvProduct.TabIndex = 18;
            this._lvProduct.UseCompatibleStateImageBehavior = false;
            this._lvProduct.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this._lvProduct_DrawColumnHeader);
            this._lvProduct.SelectedIndexChanged += new System.EventHandler(this._lvProduct_SelectedIndexChanged);
            // 
            // col1
            // 
            this.col1.Text = "Mã SP";
            // 
            // col2
            // 
            this.col2.Text = "Tên Sản Phẩm";
            this.col2.Width = 150;
            // 
            // col3
            // 
            this.col3.Text = "Giá Bán";
            this.col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col3.Width = 80;
            // 
            // col4
            // 
            this.col4.Width = 0;
            // 
            // col5_image
            // 
            this.col5_image.Width = 0;
            // 
            // col6_SL
            // 
            this.col6_SL.Text = "Còn";
            this.col6_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col6_SL.Width = 40;
            // 
            // _txtImage
            // 
            this._txtImage.Location = new System.Drawing.Point(267, 24);
            this._txtImage.Name = "_txtImage";
            this._txtImage.Size = new System.Drawing.Size(126, 20);
            this._txtImage.TabIndex = 19;
            this._txtImage.Visible = false;
            // 
            // _btnSingle
            // 
            this._btnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSingle.Location = new System.Drawing.Point(347, 188);
            this._btnSingle.Name = "_btnSingle";
            this._btnSingle.Size = new System.Drawing.Size(129, 43);
            this._btnSingle.TabIndex = 20;
            this._btnSingle.Text = "Bán Lẻ Shop";
            this._btnSingle.UseVisualStyleBackColor = true;
            this._btnSingle.Click += new System.EventHandler(this._btnSingle_Click);
            // 
            // _btnMuti
            // 
            this._btnMuti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMuti.Location = new System.Drawing.Point(629, 188);
            this._btnMuti.Name = "_btnMuti";
            this._btnMuti.Size = new System.Drawing.Size(119, 43);
            this._btnMuti.TabIndex = 21;
            this._btnMuti.Text = "Bán Sỉ";
            this._btnMuti.UseVisualStyleBackColor = true;
            this._btnMuti.Click += new System.EventHandler(this._btnMuti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnChange);
            this.groupBox2.Controls.Add(this._txtNumber);
            this.groupBox2.Controls.Add(this._txtPrice);
            this.groupBox2.Controls.Add(this._txtName);
            this.groupBox2.Controls.Add(this._txtCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(347, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 191);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đặt Hàng";
            // 
            // _btnChange
            // 
            this._btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChange.Location = new System.Drawing.Point(300, 110);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(91, 26);
            this._btnChange.TabIndex = 26;
            this._btnChange.Text = "Thay đổi";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // _txtNumber
            // 
            this._txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNumber.Location = new System.Drawing.Point(126, 147);
            this._txtNumber.Name = "_txtNumber";
            this._txtNumber.Size = new System.Drawing.Size(168, 26);
            this._txtNumber.TabIndex = 30;
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(126, 110);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.ReadOnly = true;
            this._txtPrice.Size = new System.Drawing.Size(168, 26);
            this._txtPrice.TabIndex = 28;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(126, 71);
            this._txtName.Name = "_txtName";
            this._txtName.ReadOnly = true;
            this._txtName.Size = new System.Drawing.Size(168, 26);
            this._txtName.TabIndex = 27;
            // 
            // _txtCode
            // 
            this._txtCode.Location = new System.Drawing.Point(126, 32);
            this._txtCode.Name = "_txtCode";
            this._txtCode.ReadOnly = true;
            this._txtCode.Size = new System.Drawing.Size(168, 26);
            this._txtCode.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnAdd.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnAdd.Location = new System.Drawing.Point(473, 449);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(119, 46);
            this._btnAdd.TabIndex = 24;
            this._btnAdd.Text = "Đặt Hàng";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(708, 24);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.ReadOnly = true;
            this._txtTotal.Size = new System.Drawing.Size(30, 20);
            this._txtTotal.TabIndex = 25;
            this._txtTotal.Visible = false;
            // 
            // _btnSingleOnline
            // 
            this._btnSingleOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSingleOnline.Location = new System.Drawing.Point(488, 188);
            this._btnSingleOnline.Name = "_btnSingleOnline";
            this._btnSingleOnline.Size = new System.Drawing.Size(130, 43);
            this._btnSingleOnline.TabIndex = 26;
            this._btnSingleOnline.Text = "Bán Lẻ Online";
            this._btnSingleOnline.UseVisualStyleBackColor = true;
            this._btnSingleOnline.Click += new System.EventHandler(this._btnSingleOnline_Click);
            // 
            // OrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(752, 515);
            this.Controls.Add(this._btnSingleOnline);
            this.Controls.Add(this._txtTotal);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnMuti);
            this.Controls.Add(this._btnSingle);
            this.Controls.Add(this._txtImage);
            this.Controls.Add(this._lvProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._txtProductId);
            this.Controls.Add(this._txtGroupId);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt Hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtGroupId;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtProductId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox _picShow;
        private System.Windows.Forms.ListView _lvProduct;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5_image;
        private System.Windows.Forms.TextBox _txtImage;
        private System.Windows.Forms.Button _btnSingle;
        private System.Windows.Forms.Button _btnMuti;
        private System.Windows.Forms.ColumnHeader col6_SL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown _txtNumber;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.Button _btnSingleOnline;
    }
}