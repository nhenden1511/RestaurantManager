namespace RestaurantManager.View
{
    partial class ProductDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDialog));
            this.label1 = new System.Windows.Forms.Label();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this._txtGroupId = new System.Windows.Forms.TextBox();
            this._txtProductId = new System.Windows.Forms.TextBox();
            this._dgProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._txtPrices = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._openImage = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this._txtBasePrice = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnChange = new System.Windows.Forms.Button();
            this._picShow = new System.Windows.Forms.PictureBox();
            this._btnImage = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Nhóm Sản Phẩm";
            // 
            // _cbbGroup
            // 
            this._cbbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(13, 28);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(4);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(224, 26);
            this._cbbGroup.TabIndex = 1;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // _txtGroupId
            // 
            this._txtGroupId.Location = new System.Drawing.Point(272, 3);
            this._txtGroupId.Margin = new System.Windows.Forms.Padding(4);
            this._txtGroupId.Name = "_txtGroupId";
            this._txtGroupId.ReadOnly = true;
            this._txtGroupId.Size = new System.Drawing.Size(43, 24);
            this._txtGroupId.TabIndex = 2;
            this._txtGroupId.Visible = false;
            // 
            // _txtProductId
            // 
            this._txtProductId.Location = new System.Drawing.Point(566, 3);
            this._txtProductId.Margin = new System.Windows.Forms.Padding(4);
            this._txtProductId.Name = "_txtProductId";
            this._txtProductId.ReadOnly = true;
            this._txtProductId.Size = new System.Drawing.Size(73, 24);
            this._txtProductId.TabIndex = 3;
            this._txtProductId.Visible = false;
            // 
            // _dgProduct
            // 
            this._dgProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this._dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgProduct.Location = new System.Drawing.Point(2, 68);
            this._dgProduct.Margin = new System.Windows.Forms.Padding(4);
            this._dgProduct.Name = "_dgProduct";
            this._dgProduct.Size = new System.Drawing.Size(346, 456);
            this._dgProduct.TabIndex = 4;
            this._dgProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgProduct_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._txtBasePrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._txtPrice);
            this.groupBox2.Controls.Add(this._txtPrices);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._txtName);
            this.groupBox2.Controls.Add(this._txtCode);
            this.groupBox2.Location = new System.Drawing.Point(356, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(394, 240);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số Lượng";
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(162, 202);
            this._txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(211, 24);
            this._txtTotal.TabIndex = 18;
            this._txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá Bán Lẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá bán Sỉ";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(162, 134);
            this._txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(211, 24);
            this._txtPrice.TabIndex = 15;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            // 
            // _txtPrices
            // 
            this._txtPrices.Location = new System.Drawing.Point(162, 167);
            this._txtPrices.Margin = new System.Windows.Forms.Padding(4);
            this._txtPrices.Name = "_txtPrices";
            this._txtPrices.Size = new System.Drawing.Size(211, 24);
            this._txtPrices.TabIndex = 16;
            this._txtPrices.TextChanged += new System.EventHandler(this._txtPrices_TextChanged);
            this._txtPrices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrices_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Mặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Mặt Hàng";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(162, 34);
            this._txtName.Margin = new System.Windows.Forms.Padding(4);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(211, 24);
            this._txtName.TabIndex = 11;
            // 
            // _txtCode
            // 
            this._txtCode.Location = new System.Drawing.Point(162, 67);
            this._txtCode.Margin = new System.Windows.Forms.Padding(4);
            this._txtCode.Name = "_txtCode";
            this._txtCode.Size = new System.Drawing.Size(211, 24);
            this._txtCode.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this._picShow);
            this.groupBox1.Location = new System.Drawing.Point(758, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(225, 212);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // _openImage
            // 
            this._openImage.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá Nhập";
            // 
            // _txtBasePrice
            // 
            this._txtBasePrice.Location = new System.Drawing.Point(162, 101);
            this._txtBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this._txtBasePrice.Name = "_txtBasePrice";
            this._txtBasePrice.ReadOnly = true;
            this._txtBasePrice.Size = new System.Drawing.Size(211, 24);
            this._txtBasePrice.TabIndex = 20;
            this._txtBasePrice.TextChanged += new System.EventHandler(this._txtBasePrice_TextChanged);
            // 
            // _btnSave
            // 
            this._btnSave.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Location = new System.Drawing.Point(585, 339);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(153, 48);
            this._btnSave.TabIndex = 19;
            this._btnSave.Text = "Lưu Thay Đổi";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Visible = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnChange
            // 
            this._btnChange.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChange.Location = new System.Drawing.Point(368, 339);
            this._btnChange.Margin = new System.Windows.Forms.Padding(4);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(145, 48);
            this._btnChange.TabIndex = 18;
            this._btnChange.Text = "Sửa";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // _picShow
            // 
            this._picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picShow.Location = new System.Drawing.Point(4, 21);
            this._picShow.Margin = new System.Windows.Forms.Padding(4);
            this._picShow.Name = "_picShow";
            this._picShow.Size = new System.Drawing.Size(217, 187);
            this._picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picShow.TabIndex = 5;
            this._picShow.TabStop = false;
            // 
            // _btnImage
            // 
            this._btnImage.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnImage.Location = new System.Drawing.Point(768, 28);
            this._btnImage.Margin = new System.Windows.Forms.Padding(4);
            this._btnImage.Name = "_btnImage";
            this._btnImage.Size = new System.Drawing.Size(112, 32);
            this._btnImage.TabIndex = 17;
            this._btnImage.Text = "Tải Hình";
            this._btnImage.UseVisualStyleBackColor = true;
            this._btnImage.Click += new System.EventHandler(this._btnImage_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.Location = new System.Drawing.Point(566, 450);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(261, 74);
            this._btnAdd.TabIndex = 5;
            this._btnAdd.Text = "Thêm Sản Phẩm";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(800, 339);
            this._btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(153, 48);
            this._btnDelete.TabIndex = 20;
            this._btnDelete.Text = "Xóa Sản Phẩm";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Visible = false;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // ProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._dgProduct);
            this.Controls.Add(this._txtProductId);
            this.Controls.Add(this._txtGroupId);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.TextBox _txtGroupId;
        private System.Windows.Forms.TextBox _txtProductId;
        private System.Windows.Forms.DataGridView _dgProduct;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.TextBox _txtPrices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox _picShow;
        private System.Windows.Forms.Button _btnImage;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.OpenFileDialog _openImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtBasePrice;
        private System.Windows.Forms.Button _btnDelete;
    }
}