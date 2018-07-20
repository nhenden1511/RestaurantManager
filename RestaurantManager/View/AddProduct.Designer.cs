namespace RestaurantManager.View
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtGroupId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._picShow = new System.Windows.Forms.PictureBox();
            this._btnImage = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._txtCode = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._txtPrices = new System.Windows.Forms.TextBox();
            this._openImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cbbGroup
            // 
            this._cbbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(20, 29);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(4);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(250, 26);
            this._cbbGroup.TabIndex = 0;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Nhóm Sản Phẩm";
            // 
            // _txtGroupId
            // 
            this._txtGroupId.Location = new System.Drawing.Point(314, 7);
            this._txtGroupId.Margin = new System.Windows.Forms.Padding(4);
            this._txtGroupId.Name = "_txtGroupId";
            this._txtGroupId.ReadOnly = true;
            this._txtGroupId.Size = new System.Drawing.Size(148, 24);
            this._txtGroupId.TabIndex = 2;
            this._txtGroupId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this._picShow);
            this.groupBox1.Location = new System.Drawing.Point(489, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(260, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // _picShow
            // 
            this._picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picShow.Location = new System.Drawing.Point(4, 21);
            this._picShow.Margin = new System.Windows.Forms.Padding(4);
            this._picShow.Name = "_picShow";
            this._picShow.Size = new System.Drawing.Size(252, 203);
            this._picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picShow.TabIndex = 5;
            this._picShow.TabStop = false;
            // 
            // _btnImage
            // 
            this._btnImage.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnImage.Location = new System.Drawing.Point(489, 49);
            this._btnImage.Margin = new System.Windows.Forms.Padding(4);
            this._btnImage.Name = "_btnImage";
            this._btnImage.Size = new System.Drawing.Size(112, 32);
            this._btnImage.TabIndex = 7;
            this._btnImage.Text = "Tải Hình";
            this._btnImage.UseVisualStyleBackColor = true;
            this._btnImage.Click += new System.EventHandler(this._btnImage_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnAdd.Location = new System.Drawing.Point(245, 375);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(225, 51);
            this._btnAdd.TabIndex = 8;
            this._btnAdd.Text = "Lưu";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _txtCode
            // 
            this._txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCode.Location = new System.Drawing.Point(156, 66);
            this._txtCode.Margin = new System.Windows.Forms.Padding(4);
            this._txtCode.Name = "_txtCode";
            this._txtCode.Size = new System.Drawing.Size(265, 26);
            this._txtCode.TabIndex = 2;
            // 
            // _txtName
            // 
            this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtName.Location = new System.Drawing.Point(156, 33);
            this._txtName.Margin = new System.Windows.Forms.Padding(4);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(265, 26);
            this._txtName.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._txtCost);
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
            this.groupBox2.Location = new System.Drawing.Point(18, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(452, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá Nhập";
            // 
            // _txtCost
            // 
            this._txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCost.Location = new System.Drawing.Point(156, 104);
            this._txtCost.Margin = new System.Windows.Forms.Padding(4);
            this._txtCost.Name = "_txtCost";
            this._txtCost.Size = new System.Drawing.Size(265, 26);
            this._txtCost.TabIndex = 3;
            this._txtCost.TextChanged += new System.EventHandler(this._txtCost_TextChanged);
            this._txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtCost_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số Lượng";
            // 
            // _txtTotal
            // 
            this._txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTotal.Location = new System.Drawing.Point(156, 140);
            this._txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(265, 26);
            this._txtTotal.TabIndex = 4;
            this._txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá Bán Lẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá bán Sỉ";
            // 
            // _txtPrice
            // 
            this._txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrice.Location = new System.Drawing.Point(156, 176);
            this._txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(265, 26);
            this._txtPrice.TabIndex = 5;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            // 
            // _txtPrices
            // 
            this._txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrices.Location = new System.Drawing.Point(156, 210);
            this._txtPrices.Margin = new System.Windows.Forms.Padding(4);
            this._txtPrices.Name = "_txtPrices";
            this._txtPrices.Size = new System.Drawing.Size(265, 26);
            this._txtPrices.TabIndex = 6;
            this._txtPrices.TextChanged += new System.EventHandler(this._txtPrices_TextChanged);
            this._txtPrices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrices_KeyPress);
            // 
            // _openImage
            // 
            this._openImage.FileName = "openFileDialog1";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(766, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnImage);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtGroupId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbbGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Sản Phẩm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtGroupId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox _picShow;
        private System.Windows.Forms.Button _btnImage;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.TextBox _txtCode;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.TextBox _txtPrices;
        private System.Windows.Forms.OpenFileDialog _openImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtCost;
    }
}