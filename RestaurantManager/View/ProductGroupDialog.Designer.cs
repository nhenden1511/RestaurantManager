namespace RestaurantManager
{
    partial class ProductGroupDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGroupDialog));
            this._dgListProductGroup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtCode = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._picShow = new System.Windows.Forms.PictureBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._openImage = new System.Windows.Forms.OpenFileDialog();
            this._btnChangPic = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgListProductGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgListProductGroup
            // 
            this._dgListProductGroup.AllowUserToAddRows = false;
            this._dgListProductGroup.AllowUserToDeleteRows = false;
            this._dgListProductGroup.AllowUserToResizeColumns = false;
            this._dgListProductGroup.AllowUserToResizeRows = false;
            this._dgListProductGroup.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._dgListProductGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgListProductGroup.Location = new System.Drawing.Point(12, 37);
            this._dgListProductGroup.Name = "_dgListProductGroup";
            this._dgListProductGroup.Size = new System.Drawing.Size(254, 486);
            this._dgListProductGroup.TabIndex = 0;
            this._dgListProductGroup.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgListProductGroup_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách";
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnAdd.Location = new System.Drawing.Point(505, 448);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(220, 75);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "Thêm Mới";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtCode);
            this.groupBox1.Controls.Add(this._txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(272, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // _txtCode
            // 
            this._txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCode.Location = new System.Drawing.Point(157, 33);
            this._txtCode.Name = "_txtCode";
            this._txtCode.Size = new System.Drawing.Size(198, 24);
            this._txtCode.TabIndex = 7;
            // 
            // _txtName
            // 
            this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtName.Location = new System.Drawing.Point(157, 65);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(198, 24);
            this._txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Nhóm Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Nhóm Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this._picShow);
            this.groupBox2.Location = new System.Drawing.Point(644, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 213);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // _picShow
            // 
            this._picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picShow.Location = new System.Drawing.Point(3, 16);
            this._picShow.Name = "_picShow";
            this._picShow.Size = new System.Drawing.Size(269, 194);
            this._picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picShow.TabIndex = 5;
            this._picShow.TabStop = false;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(819, 2);
            this._txtId.Name = "_txtId";
            this._txtId.ReadOnly = true;
            this._txtId.Size = new System.Drawing.Size(100, 20);
            this._txtId.TabIndex = 9;
            this._txtId.Visible = false;
            // 
            // _openImage
            // 
            this._openImage.FileName = "openFileDialog1";
            // 
            // _btnChangPic
            // 
            this._btnChangPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChangPic.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnChangPic.Location = new System.Drawing.Point(644, 4);
            this._btnChangPic.Name = "_btnChangPic";
            this._btnChangPic.Size = new System.Drawing.Size(107, 35);
            this._btnChangPic.TabIndex = 10;
            this._btnChangPic.Text = "Đổi Ảnh";
            this._btnChangPic.UseVisualStyleBackColor = true;
            this._btnChangPic.Click += new System.EventHandler(this._btnChangPic_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnSave.Location = new System.Drawing.Point(478, 201);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(144, 46);
            this._btnSave.TabIndex = 12;
            this._btnSave.Text = "Lưu Thay Đổi";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Visible = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnChange
            // 
            this._btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChange.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnChange.Location = new System.Drawing.Point(312, 201);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(121, 46);
            this._btnChange.TabIndex = 11;
            this._btnChange.Text = "Sửa";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductGroupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(928, 535);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this._btnChangPic);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dgListProductGroup);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductGroupDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhóm Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductGroupDialog_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductGroupDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._dgListProductGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgListProductGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtCode;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox _picShow;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.OpenFileDialog _openImage;
        private System.Windows.Forms.Button _btnChangPic;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.Button _btnSave;
    }
}