namespace RestaurantManager
{
    partial class LoginActivitive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginActivitive));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtUserName = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this._txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this._lbPassConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // _txtUserName
            // 
            this._txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtUserName.Location = new System.Drawing.Point(171, 28);
            this._txtUserName.Name = "_txtUserName";
            this._txtUserName.Size = new System.Drawing.Size(207, 26);
            this._txtUserName.TabIndex = 1;
            // 
            // _txtPassword
            // 
            this._txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.Location = new System.Drawing.Point(171, 68);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(207, 26);
            this._txtPassword.TabIndex = 2;
            this._txtPassword.UseSystemPasswordChar = true;
            this._txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPassword_KeyPress);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Image = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this.btLogin.Location = new System.Drawing.Point(160, 143);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(116, 51);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // _txtPasswordConfirm
            // 
            this._txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPasswordConfirm.Location = new System.Drawing.Point(171, 109);
            this._txtPasswordConfirm.Name = "_txtPasswordConfirm";
            this._txtPasswordConfirm.Size = new System.Drawing.Size(207, 26);
            this._txtPasswordConfirm.TabIndex = 3;
            this._txtPasswordConfirm.UseSystemPasswordChar = true;
            this._txtPasswordConfirm.Visible = false;
            this._txtPasswordConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPasswordConfirm_KeyPress);
            // 
            // _lbPassConfirm
            // 
            this._lbPassConfirm.AutoSize = true;
            this._lbPassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbPassConfirm.Location = new System.Drawing.Point(28, 112);
            this._lbPassConfirm.Name = "_lbPassConfirm";
            this._lbPassConfirm.Size = new System.Drawing.Size(137, 20);
            this._lbPassConfirm.TabIndex = 5;
            this._lbPassConfirm.Text = "Password Confirm";
            this._lbPassConfirm.Visible = false;
            // 
            // LoginActivitive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(417, 201);
            this.Controls.Add(this._txtPasswordConfirm);
            this.Controls.Add(this._lbPassConfirm);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginActivitive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Antivitive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtUserName;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox _txtPasswordConfirm;
        private System.Windows.Forms.Label _lbPassConfirm;
    }
}

