namespace RestaurantManager
{
    partial class HomeActivitive
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeActivitive));
            this._lvProductGroup = new System.Windows.Forms.ListView();
            this._image = new System.Windows.Forms.ImageList(this.components);
            this._btnProductGroup = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._btnProduct = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._btnCheck1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtGroupId = new System.Windows.Forms.TextBox();
            this._btnPay = new System.Windows.Forms.Button();
            this._lvOrder = new System.Windows.Forms.ListView();
            this.col_GroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtPayment = new System.Windows.Forms.TextBox();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnExit = new System.Windows.Forms.Button();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._txtNumber = new System.Windows.Forms.TextBox();
            this._txtProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtShip = new System.Windows.Forms.TextBox();
            this._txtSale = new System.Windows.Forms.TextBox();
            this._txtOrderId = new System.Windows.Forms.TextBox();
            this._txtBonus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtCustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_table = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lvProductGroup
            // 
            this._lvProductGroup.LargeImageList = this._image;
            this._lvProductGroup.Location = new System.Drawing.Point(12, 91);
            this._lvProductGroup.Name = "_lvProductGroup";
            this._lvProductGroup.Size = new System.Drawing.Size(641, 538);
            this._lvProductGroup.SmallImageList = this._image;
            this._lvProductGroup.TabIndex = 0;
            this._lvProductGroup.UseCompatibleStateImageBehavior = false;
            this._lvProductGroup.SelectedIndexChanged += new System.EventHandler(this._lvProductGroup_SelectedIndexChanged);
            this._lvProductGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lvProductGroup_MouseDoubleClick);
            // 
            // _image
            // 
            this._image.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._image.ImageSize = new System.Drawing.Size(160, 160);
            this._image.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _btnProductGroup
            // 
            this._btnProductGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnProductGroup.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnProductGroup.Location = new System.Drawing.Point(170, 3);
            this._btnProductGroup.Name = "_btnProductGroup";
            this._btnProductGroup.Size = new System.Drawing.Size(129, 43);
            this._btnProductGroup.TabIndex = 1;
            this._btnProductGroup.Text = "Nhóm Sản Phẩm";
            this._btnProductGroup.UseVisualStyleBackColor = true;
            this._btnProductGroup.Click += new System.EventHandler(this._btnProductGroup_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 77);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(633, 48);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trang Chủ";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.button4.Location = new System.Drawing.Point(365, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.button2.Location = new System.Drawing.Point(139, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Máy Tính";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.btn_table);
            this.tabPage1.Controls.Add(this._btnProduct);
            this.tabPage1.Controls.Add(this._btnProductGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý";
            // 
            // _btnProduct
            // 
            this._btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnProduct.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnProduct.Location = new System.Drawing.Point(327, 3);
            this._btnProduct.Name = "_btnProduct";
            this._btnProduct.Size = new System.Drawing.Size(113, 42);
            this._btnProduct.TabIndex = 2;
            this._btnProduct.Text = "Sản Phẩm";
            this._btnProduct.UseVisualStyleBackColor = true;
            this._btnProduct.Click += new System.EventHandler(this._btnProduct_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this._btnCheck1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 48);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.button5.Location = new System.Drawing.Point(318, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thống Kê Kho";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.button3.Location = new System.Drawing.Point(161, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thống Kê Chung";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _btnCheck1
            // 
            this._btnCheck1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnCheck1.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnCheck1.Location = new System.Drawing.Point(4, 3);
            this._btnCheck1.Name = "_btnCheck1";
            this._btnCheck1.Size = new System.Drawing.Size(151, 42);
            this._btnCheck1.TabIndex = 4;
            this._btnCheck1.Text = "Thống Kê Theo Ngày";
            this._btnCheck1.UseVisualStyleBackColor = true;
            this._btnCheck1.Click += new System.EventHandler(this._btnCheck1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(816, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Hóa Đơn";
            // 
            // _txtGroupId
            // 
            this._txtGroupId.Location = new System.Drawing.Point(491, 8);
            this._txtGroupId.Name = "_txtGroupId";
            this._txtGroupId.ReadOnly = true;
            this._txtGroupId.Size = new System.Drawing.Size(100, 20);
            this._txtGroupId.TabIndex = 5;
            this._txtGroupId.Visible = false;
            // 
            // _btnPay
            // 
            this._btnPay.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnPay.Location = new System.Drawing.Point(39, 103);
            this._btnPay.Name = "_btnPay";
            this._btnPay.Size = new System.Drawing.Size(152, 60);
            this._btnPay.TabIndex = 6;
            this._btnPay.Text = "Thanh Toán";
            this._btnPay.UseVisualStyleBackColor = true;
            this._btnPay.Click += new System.EventHandler(this._btnPay_Click);
            // 
            // _lvOrder
            // 
            this._lvOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_GroupName,
            this.col_Code,
            this.col_Product,
            this.col_num,
            this.col_price,
            this.col_total,
            this.col_Id,
            this.col_productId});
            this._lvOrder.Location = new System.Drawing.Point(672, 44);
            this._lvOrder.Name = "_lvOrder";
            this._lvOrder.Size = new System.Drawing.Size(457, 331);
            this._lvOrder.TabIndex = 7;
            this._lvOrder.UseCompatibleStateImageBehavior = false;
            this._lvOrder.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this._lvOrder_DrawColumnHeader);
            this._lvOrder.SelectedIndexChanged += new System.EventHandler(this._lvOrder_SelectedIndexChanged);
            // 
            // col_GroupName
            // 
            this.col_GroupName.Text = "Loại Hàng";
            this.col_GroupName.Width = 80;
            // 
            // col_Code
            // 
            this.col_Code.Text = "MH";
            this.col_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Code.Width = 50;
            // 
            // col_Product
            // 
            this.col_Product.Text = "Sản Phẩm";
            this.col_Product.Width = 110;
            // 
            // col_num
            // 
            this.col_num.Text = "SL";
            this.col_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_num.Width = 40;
            // 
            // col_price
            // 
            this.col_price.Text = "Giá Bán";
            this.col_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_price.Width = 80;
            // 
            // col_total
            // 
            this.col_total.Text = "Thành Tiền";
            this.col_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_total.Width = 90;
            // 
            // col_Id
            // 
            this.col_Id.Width = 0;
            // 
            // col_productId
            // 
            this.col_productId.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtPayment);
            this.groupBox1.Controls.Add(this._txtTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._btnPay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(907, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 169);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // _txtPayment
            // 
            this._txtPayment.Location = new System.Drawing.Point(97, 56);
            this._txtPayment.Name = "_txtPayment";
            this._txtPayment.ReadOnly = true;
            this._txtPayment.Size = new System.Drawing.Size(119, 23);
            this._txtPayment.TabIndex = 14;
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(97, 25);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.ReadOnly = true;
            this._txtTotal.Size = new System.Drawing.Size(119, 23);
            this._txtTotal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thanh Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng Tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnExit);
            this.groupBox2.Controls.Add(this._txtPrice);
            this.groupBox2.Controls.Add(this._txtNumber);
            this.groupBox2.Controls.Add(this._txtProductName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(672, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 169);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(9, 127);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(62, 36);
            this._btnExit.TabIndex = 13;
            this._btnExit.Text = "Hủy";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Visible = false;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(94, 92);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.ReadOnly = true;
            this._txtPrice.Size = new System.Drawing.Size(119, 23);
            this._txtPrice.TabIndex = 12;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPrice_KeyPress);
            this._txtPrice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._txtPrice_MouseDoubleClick);
            // 
            // _txtNumber
            // 
            this._txtNumber.Location = new System.Drawing.Point(94, 56);
            this._txtNumber.Name = "_txtNumber";
            this._txtNumber.ReadOnly = true;
            this._txtNumber.Size = new System.Drawing.Size(119, 23);
            this._txtNumber.TabIndex = 11;
            this._txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtNumber_KeyPress);
            this._txtNumber.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._txtNumber_MouseDoubleClick);
            // 
            // _txtProductName
            // 
            this._txtProductName.Location = new System.Drawing.Point(94, 22);
            this._txtProductName.Name = "_txtProductName";
            this._txtProductName.ReadOnly = true;
            this._txtProductName.Size = new System.Drawing.Size(119, 23);
            this._txtProductName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sản Phẩm";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(102, 127);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(111, 36);
            this._btnSave.TabIndex = 6;
            this._btnSave.Text = "Lưu Thay Đổi";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Visible = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiền Ship:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(930, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giảm Giá:";
            // 
            // _txtShip
            // 
            this._txtShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtShip.Location = new System.Drawing.Point(766, 394);
            this._txtShip.Name = "_txtShip";
            this._txtShip.Size = new System.Drawing.Size(119, 23);
            this._txtShip.TabIndex = 13;
            this._txtShip.TextChanged += new System.EventHandler(this._txtShip_TextChanged);
            this._txtShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtShip_KeyPress);
            // 
            // _txtSale
            // 
            this._txtSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSale.Location = new System.Drawing.Point(1004, 394);
            this._txtSale.Name = "_txtSale";
            this._txtSale.Size = new System.Drawing.Size(119, 23);
            this._txtSale.TabIndex = 14;
            this._txtSale.TextChanged += new System.EventHandler(this._txtSale_TextChanged);
            this._txtSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSale_KeyPress);
            // 
            // _txtOrderId
            // 
            this._txtOrderId.Location = new System.Drawing.Point(622, 8);
            this._txtOrderId.Name = "_txtOrderId";
            this._txtOrderId.ReadOnly = true;
            this._txtOrderId.Size = new System.Drawing.Size(100, 20);
            this._txtOrderId.TabIndex = 15;
            this._txtOrderId.Visible = false;
            // 
            // _txtBonus
            // 
            this._txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBonus.Location = new System.Drawing.Point(1004, 423);
            this._txtBonus.Name = "_txtBonus";
            this._txtBonus.Size = new System.Drawing.Size(119, 23);
            this._txtBonus.TabIndex = 17;
            this._txtBonus.TextChanged += new System.EventHandler(this._txtBonus_TextChanged);
            this._txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtBonus_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(932, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Phụ Thu:";
            // 
            // _txtCustomer
            // 
            this._txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCustomer.Location = new System.Drawing.Point(766, 423);
            this._txtCustomer.Name = "_txtCustomer";
            this._txtCustomer.Size = new System.Drawing.Size(119, 23);
            this._txtCustomer.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(682, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Khách Hàng:";
            // 
            // btn_table
            // 
            this.btn_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_table.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.btn_table.Location = new System.Drawing.Point(6, 3);
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(129, 43);
            this.btn_table.TabIndex = 3;
            this.btn_table.Text = "Bàn ăn";
            this.btn_table.UseVisualStyleBackColor = true;
            // 
            // HomeActivitive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1135, 634);
            this.Controls.Add(this._txtCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._txtBonus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._txtOrderId);
            this.Controls.Add(this._txtSale);
            this.Controls.Add(this._txtShip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lvOrder);
            this.Controls.Add(this._txtGroupId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._lvProductGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeActivitive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Quản Lý";
            this.Load += new System.EventHandler(this.HomeActivitive_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _lvProductGroup;
        private System.Windows.Forms.Button _btnProductGroup;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button _btnProduct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList _image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtGroupId;
        private System.Windows.Forms.Button _btnPay;
        private System.Windows.Forms.ListView _lvOrder;
        private System.Windows.Forms.ColumnHeader col_GroupName;
        private System.Windows.Forms.ColumnHeader col_Code;
        private System.Windows.Forms.ColumnHeader col_Product;
        private System.Windows.Forms.ColumnHeader col_num;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_total;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_productId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtPayment;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.TextBox _txtNumber;
        private System.Windows.Forms.TextBox _txtProductName;
        private System.Windows.Forms.TextBox _txtShip;
        private System.Windows.Forms.TextBox _txtSale;
        private System.Windows.Forms.TextBox _txtOrderId;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnCheck1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox _txtBonus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox _txtCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_table;
    }
}