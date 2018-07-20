namespace RestaurantManager.View.Manager
{
    partial class AddTableDialog
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtTable = new System.Windows.Forms.TextBox();
            this._btnAddTable = new System.Windows.Forms.Button();
            this._txtAreaId = new System.Windows.Forms.TextBox();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this._txtArea);
            this.groupPanel1.Location = new System.Drawing.Point(12, 24);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(244, 86);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "Khu Vực";
            // 
            // _txtArea
            // 
            this._txtArea.Location = new System.Drawing.Point(14, 16);
            this._txtArea.Name = "_txtArea";
            this._txtArea.ReadOnly = true;
            this._txtArea.Size = new System.Drawing.Size(197, 26);
            this._txtArea.TabIndex = 3;
            this._txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Bàn";
            // 
            // _txtTable
            // 
            this._txtTable.Location = new System.Drawing.Point(392, 61);
            this._txtTable.Name = "_txtTable";
            this._txtTable.Size = new System.Drawing.Size(279, 26);
            this._txtTable.TabIndex = 1;
            this._txtTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTable_KeyPress);
            // 
            // _btnAddTable
            // 
            this._btnAddTable.Location = new System.Drawing.Point(298, 141);
            this._btnAddTable.Name = "_btnAddTable";
            this._btnAddTable.Size = new System.Drawing.Size(116, 46);
            this._btnAddTable.TabIndex = 5;
            this._btnAddTable.Text = "Thêm Mới";
            this._btnAddTable.UseVisualStyleBackColor = true;
            this._btnAddTable.Click += new System.EventHandler(this._btnAddTable_Click);
            // 
            // _txtAreaId
            // 
            this._txtAreaId.Location = new System.Drawing.Point(29, 116);
            this._txtAreaId.Name = "_txtAreaId";
            this._txtAreaId.Size = new System.Drawing.Size(10, 26);
            this._txtAreaId.TabIndex = 6;
            // 
            // AddTableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 229);
            this.Controls.Add(this._txtAreaId);
            this.Controls.Add(this._btnAddTable);
            this.Controls.Add(this._txtTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTableDialog";
            this.Text = "Thêm Bàn Mới";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TextBox _txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtTable;
        private System.Windows.Forms.Button _btnAddTable;
        private System.Windows.Forms.TextBox _txtAreaId;
    }
}