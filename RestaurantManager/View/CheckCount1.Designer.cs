namespace RestaurantManager.View
{
    partial class CheckCount1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCount1));
            this.label1 = new System.Windows.Forms.Label();
            this._dtpick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this._dgCheckCount = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtCountShop = new System.Windows.Forms.TextBox();
            this._txtSumShop = new System.Windows.Forms.TextBox();
            this._txtPriceShop = new System.Windows.Forms.TextBox();
            this._txtSumAllShop = new System.Windows.Forms.TextBox();
            this._txtPaymentId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtSumAllOnline = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtPriceOnline = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtSumOnline = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtCountOnline = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtSumAllMuti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._txtPriceMuti = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._txtSumMuti = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this._txtCountMuti = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgCheckCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Ngày";
            // 
            // _dtpick
            // 
            this._dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dtpick.Location = new System.Drawing.Point(231, 12);
            this._dtpick.Name = "_dtpick";
            this._dtpick.Size = new System.Drawing.Size(110, 23);
            this._dtpick.TabIndex = 1;
            this._dtpick.ValueChanged += new System.EventHandler(this._dtpick_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh Sách Hóa Đơn";
            // 
            // _dgCheckCount
            // 
            this._dgCheckCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgCheckCount.Location = new System.Drawing.Point(4, 71);
            this._dgCheckCount.Name = "_dgCheckCount";
            this._dgCheckCount.Size = new System.Drawing.Size(369, 417);
            this._dgCheckCount.TabIndex = 3;
            this._dgCheckCount.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgCheckCount_RowEnter);
            this._dgCheckCount.DoubleClick += new System.EventHandler(this._dgCheckCount_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Số Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng Tiền Bán Được";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền Vốn Mua Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiền Lời Sau Bán:";
            // 
            // _txtCountShop
            // 
            this._txtCountShop.Location = new System.Drawing.Point(189, 31);
            this._txtCountShop.Name = "_txtCountShop";
            this._txtCountShop.ReadOnly = true;
            this._txtCountShop.Size = new System.Drawing.Size(107, 23);
            this._txtCountShop.TabIndex = 8;
            // 
            // _txtSumShop
            // 
            this._txtSumShop.Location = new System.Drawing.Point(189, 69);
            this._txtSumShop.Name = "_txtSumShop";
            this._txtSumShop.ReadOnly = true;
            this._txtSumShop.Size = new System.Drawing.Size(107, 23);
            this._txtSumShop.TabIndex = 9;
            // 
            // _txtPriceShop
            // 
            this._txtPriceShop.Location = new System.Drawing.Point(189, 106);
            this._txtPriceShop.Name = "_txtPriceShop";
            this._txtPriceShop.ReadOnly = true;
            this._txtPriceShop.Size = new System.Drawing.Size(106, 23);
            this._txtPriceShop.TabIndex = 10;
            // 
            // _txtSumAllShop
            // 
            this._txtSumAllShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSumAllShop.Location = new System.Drawing.Point(169, 389);
            this._txtSumAllShop.Name = "_txtSumAllShop";
            this._txtSumAllShop.ReadOnly = true;
            this._txtSumAllShop.Size = new System.Drawing.Size(126, 29);
            this._txtSumAllShop.TabIndex = 11;
            // 
            // _txtPaymentId
            // 
            this._txtPaymentId.Location = new System.Drawing.Point(392, 14);
            this._txtPaymentId.Name = "_txtPaymentId";
            this._txtPaymentId.ReadOnly = true;
            this._txtPaymentId.Size = new System.Drawing.Size(77, 23);
            this._txtPaymentId.TabIndex = 12;
            this._txtPaymentId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtSumAllShop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtPriceShop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtSumShop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._txtCountShop);
            this.groupBox1.Location = new System.Drawing.Point(379, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 430);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê bán Shop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._txtSumAllOnline);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._txtPriceOnline);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this._txtSumOnline);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this._txtCountOnline);
            this.groupBox2.Location = new System.Drawing.Point(691, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 430);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê bán Online";
            // 
            // _txtSumAllOnline
            // 
            this._txtSumAllOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSumAllOnline.Location = new System.Drawing.Point(169, 389);
            this._txtSumAllOnline.Name = "_txtSumAllOnline";
            this._txtSumAllOnline.ReadOnly = true;
            this._txtSumAllOnline.Size = new System.Drawing.Size(126, 29);
            this._txtSumAllOnline.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng Số Hóa Đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng Tiền Bán Được";
            // 
            // _txtPriceOnline
            // 
            this._txtPriceOnline.Location = new System.Drawing.Point(189, 106);
            this._txtPriceOnline.Name = "_txtPriceOnline";
            this._txtPriceOnline.ReadOnly = true;
            this._txtPriceOnline.Size = new System.Drawing.Size(106, 23);
            this._txtPriceOnline.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tiền Vốn Mua Sản Phẩm";
            // 
            // _txtSumOnline
            // 
            this._txtSumOnline.Location = new System.Drawing.Point(189, 69);
            this._txtSumOnline.Name = "_txtSumOnline";
            this._txtSumOnline.ReadOnly = true;
            this._txtSumOnline.Size = new System.Drawing.Size(107, 23);
            this._txtSumOnline.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 392);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tiền Lời Sau Bán:";
            // 
            // _txtCountOnline
            // 
            this._txtCountOnline.Location = new System.Drawing.Point(189, 31);
            this._txtCountOnline.Name = "_txtCountOnline";
            this._txtCountOnline.ReadOnly = true;
            this._txtCountOnline.Size = new System.Drawing.Size(107, 23);
            this._txtCountOnline.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._txtSumAllMuti);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this._txtPriceMuti);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this._txtSumMuti);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this._txtCountMuti);
            this.groupBox3.Location = new System.Drawing.Point(1003, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 430);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê bán Sỉ";
            // 
            // _txtSumAllMuti
            // 
            this._txtSumAllMuti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSumAllMuti.Location = new System.Drawing.Point(169, 389);
            this._txtSumAllMuti.Name = "_txtSumAllMuti";
            this._txtSumAllMuti.ReadOnly = true;
            this._txtSumAllMuti.Size = new System.Drawing.Size(126, 29);
            this._txtSumAllMuti.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tổng Số Hóa Đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tổng Tiền Bán Được";
            // 
            // _txtPriceMuti
            // 
            this._txtPriceMuti.Location = new System.Drawing.Point(189, 106);
            this._txtPriceMuti.Name = "_txtPriceMuti";
            this._txtPriceMuti.ReadOnly = true;
            this._txtPriceMuti.Size = new System.Drawing.Size(106, 23);
            this._txtPriceMuti.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tiền Vốn Mua Sản Phẩm";
            // 
            // _txtSumMuti
            // 
            this._txtSumMuti.Location = new System.Drawing.Point(189, 69);
            this._txtSumMuti.Name = "_txtSumMuti";
            this._txtSumMuti.ReadOnly = true;
            this._txtSumMuti.Size = new System.Drawing.Size(107, 23);
            this._txtSumMuti.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 392);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 24);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tiền Lời Sau Bán:";
            // 
            // _txtCountMuti
            // 
            this._txtCountMuti.Location = new System.Drawing.Point(189, 31);
            this._txtCountMuti.Name = "_txtCountMuti";
            this._txtCountMuti.ReadOnly = true;
            this._txtCountMuti.Size = new System.Drawing.Size(107, 23);
            this._txtCountMuti.TabIndex = 8;
            // 
            // CheckCount1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1317, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._txtPaymentId);
            this.Controls.Add(this._dgCheckCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dtpick);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckCount1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống Kê Theo Ngày";
            ((System.ComponentModel.ISupportInitialize)(this._dgCheckCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _dtpick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _dgCheckCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtCountShop;
        private System.Windows.Forms.TextBox _txtSumShop;
        private System.Windows.Forms.TextBox _txtPriceShop;
        private System.Windows.Forms.TextBox _txtSumAllShop;
        private System.Windows.Forms.TextBox _txtPaymentId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _txtSumAllOnline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtPriceOnline;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtSumOnline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtCountOnline;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtSumAllMuti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _txtPriceMuti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _txtSumMuti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _txtCountMuti;
    }
}