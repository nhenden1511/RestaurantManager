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
            this._imageTable = new System.Windows.Forms.ImageList(this.components);
            this._txtTable = new System.Windows.Forms.TextBox();
            this._txtTableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _imageTable
            // 
            this._imageTable.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._imageTable.ImageSize = new System.Drawing.Size(100, 100);
            this._imageTable.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _txtTable
            // 
            this._txtTable.Location = new System.Drawing.Point(71, 492);
            this._txtTable.Name = "_txtTable";
            this._txtTable.Size = new System.Drawing.Size(100, 20);
            this._txtTable.TabIndex = 6;
            // 
            // _txtTableName
            // 
            this._txtTableName.Location = new System.Drawing.Point(71, 534);
            this._txtTableName.Name = "_txtTableName";
            this._txtTableName.Size = new System.Drawing.Size(100, 20);
            this._txtTableName.TabIndex = 7;
            // 
            // HomeActivitive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 566);
            this.Controls.Add(this._txtTableName);
            this.Controls.Add(this._txtTable);
            this.Name = "HomeActivitive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeActivitive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeActivitive_FormClosing);
            this.Load += new System.EventHandler(this.HomeActivitive_Load);
            //this.Resize += new System.EventHandler(this.HomeActivitive_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ImageList _imageTable;
        private System.Windows.Forms.TextBox _txtTable;
        private System.Windows.Forms.TextBox _txtTableName;
    }
}