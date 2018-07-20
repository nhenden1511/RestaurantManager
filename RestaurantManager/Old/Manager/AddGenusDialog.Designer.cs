namespace RestaurantManager.View.Manager
{
    partial class AddGenusDialog
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
            this._txtAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtAdd
            // 
            this._txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAdd.Location = new System.Drawing.Point(150, 21);
            this._txtAdd.Name = "_txtAdd";
            this._txtAdd.Size = new System.Drawing.Size(271, 26);
            this._txtAdd.TabIndex = 4;
            this._txtAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtAdd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Loại Món";
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAdd.Location = new System.Drawing.Point(175, 73);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(121, 41);
            this._btnAdd.TabIndex = 5;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // AddGenusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 126);
            this.Controls.Add(this._txtAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAdd);
            this.Name = "AddGenusDialog";
            this.Text = "AddGenusDialog";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddGenusDialog_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAdd;
    }
}