namespace RestaurantManager
{
    partial class AddProductGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductGroup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtCode = new System.Windows.Forms.TextBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this._openImage = new System.Windows.Forms.OpenFileDialog();
            this._picShow = new System.Windows.Forms.PictureBox();
            this._btnImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhóm Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhóm Sản Phẩm";
            // 
            // _txtName
            // 
            this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtName.Location = new System.Drawing.Point(160, 49);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(198, 24);
            this._txtName.TabIndex = 1;
            // 
            // _txtCode
            // 
            this._txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCode.Location = new System.Drawing.Point(160, 95);
            this._txtCode.Name = "_txtCode";
            this._txtCode.Size = new System.Drawing.Size(198, 24);
            this._txtCode.TabIndex = 2;
            this._txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtCode_KeyPress);
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnAdd.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnAdd.Location = new System.Drawing.Point(131, 214);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(150, 45);
            this._btnAdd.TabIndex = 3;
            this._btnAdd.Text = "Lưu";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _openImage
            // 
            this._openImage.FileName = "_openImage";
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
            // _btnImage
            // 
            this._btnImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnImage.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnImage.Location = new System.Drawing.Point(406, 12);
            this._btnImage.Name = "_btnImage";
            this._btnImage.Size = new System.Drawing.Size(75, 31);
            this._btnImage.TabIndex = 4;
            this._btnImage.Text = "Tải Hình";
            this._btnImage.UseVisualStyleBackColor = true;
            this._btnImage.Click += new System.EventHandler(this._btnImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this._picShow);
            this.groupBox1.Location = new System.Drawing.Point(403, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 213);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // AddProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(712, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnImage);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtCode);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Mới Nhóm Sản Phẩm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductGroup_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this._picShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtCode;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.OpenFileDialog _openImage;
        private System.Windows.Forms.PictureBox _picShow;
        private System.Windows.Forms.Button _btnImage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}