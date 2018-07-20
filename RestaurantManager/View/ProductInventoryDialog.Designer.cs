namespace RestaurantManager.View
{
    partial class ProductInventoryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInventoryDialog));
            this.label1 = new System.Windows.Forms.Label();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this._txtGroupId = new System.Windows.Forms.TextBox();
            this._dgProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtSumCount = new System.Windows.Forms.TextBox();
            this._txtSumPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Nhóm Sản Phẩm:";
            // 
            // _cbbGroup
            // 
            this._cbbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(203, 5);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(186, 26);
            this._cbbGroup.TabIndex = 2;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // _txtGroupId
            // 
            this._txtGroupId.Location = new System.Drawing.Point(374, 5);
            this._txtGroupId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtGroupId.Name = "_txtGroupId";
            this._txtGroupId.ReadOnly = true;
            this._txtGroupId.Size = new System.Drawing.Size(43, 20);
            this._txtGroupId.TabIndex = 3;
            this._txtGroupId.Visible = false;
            // 
            // _dgProduct
            // 
            this._dgProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this._dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgProduct.Location = new System.Drawing.Point(13, 40);
            this._dgProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._dgProduct.Name = "_dgProduct";
            this._dgProduct.Size = new System.Drawing.Size(428, 656);
            this._dgProduct.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 752);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng Giá Trị Tồn:";
            // 
            // _txtSumCount
            // 
            this._txtSumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSumCount.Location = new System.Drawing.Point(229, 716);
            this._txtSumCount.Name = "_txtSumCount";
            this._txtSumCount.Size = new System.Drawing.Size(133, 26);
            this._txtSumCount.TabIndex = 8;
            // 
            // _txtSumPrice
            // 
            this._txtSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSumPrice.Location = new System.Drawing.Point(229, 749);
            this._txtSumPrice.Name = "_txtSumPrice";
            this._txtSumPrice.Size = new System.Drawing.Size(133, 26);
            this._txtSumPrice.TabIndex = 9;
            // 
            // ProductInventoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(454, 789);
            this.Controls.Add(this._txtSumPrice);
            this.Controls.Add(this._txtSumCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dgProduct);
            this.Controls.Add(this._txtGroupId);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductInventoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống Kê Kho";
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.TextBox _txtGroupId;
        private System.Windows.Forms.DataGridView _dgProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtSumCount;
        private System.Windows.Forms.TextBox _txtSumPrice;
    }
}