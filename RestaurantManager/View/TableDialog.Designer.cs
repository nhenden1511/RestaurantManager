namespace RestaurantManager.View
{
    partial class TableDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this._dgProduct = new System.Windows.Forms.DataGridView();
            this._btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn ăn";
            // 
            // _dgProduct
            // 
            this._dgProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this._dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgProduct.Location = new System.Drawing.Point(4, 31);
            this._dgProduct.Margin = new System.Windows.Forms.Padding(4);
            this._dgProduct.Name = "_dgProduct";
            this._dgProduct.Size = new System.Drawing.Size(210, 414);
            this._dgProduct.TabIndex = 5;
            // 
            // _btnChange
            // 
            this._btnChange.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._btnChange.Location = new System.Drawing.Point(440, 72);
            this._btnChange.Margin = new System.Windows.Forms.Padding(4);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(99, 49);
            this._btnChange.TabIndex = 19;
            this._btnChange.Text = "Sửa";
            this._btnChange.UseVisualStyleBackColor = true;
            // 
            // TableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this._dgProduct);
            this.Controls.Add(this.label1);
            this.Name = "TableDialog";
            this.Text = "TableDialog";
            ((System.ComponentModel.ISupportInitialize)(this._dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dgProduct;
        private System.Windows.Forms.Button _btnChange;
    }
}