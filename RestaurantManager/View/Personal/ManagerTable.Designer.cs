namespace RestaurantManager.View.Personal
{
    partial class ManagerTable
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
            this._grGenus = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._grViand = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._grProperty = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._grDetail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._lvGenus = new System.Windows.Forms.ListView();
            this._txtGenusId = new System.Windows.Forms.TextBox();
            this._lvViand = new System.Windows.Forms.ListView();
            this._grGenus.SuspendLayout();
            this._grViand.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grGenus
            // 
            this._grGenus.CanvasColor = System.Drawing.SystemColors.Control;
            this._grGenus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grGenus.Controls.Add(this._lvGenus);
            this._grGenus.Location = new System.Drawing.Point(1, 12);
            this._grGenus.Name = "_grGenus";
            this._grGenus.Size = new System.Drawing.Size(192, 503);
            // 
            // 
            // 
            this._grGenus.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grGenus.Style.BackColorGradientAngle = 90;
            this._grGenus.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grGenus.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderBottomWidth = 1;
            this._grGenus.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grGenus.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderLeftWidth = 1;
            this._grGenus.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderRightWidth = 1;
            this._grGenus.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grGenus.Style.BorderTopWidth = 1;
            this._grGenus.Style.CornerDiameter = 4;
            this._grGenus.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grGenus.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grGenus.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grGenus.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grGenus.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grGenus.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grGenus.TabIndex = 3;
            this._grGenus.Text = "Loại Món";
            // 
            // _grViand
            // 
            this._grViand.CanvasColor = System.Drawing.SystemColors.Control;
            this._grViand.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grViand.Controls.Add(this._lvViand);
            this._grViand.Location = new System.Drawing.Point(199, 12);
            this._grViand.Name = "_grViand";
            this._grViand.Size = new System.Drawing.Size(334, 503);
            // 
            // 
            // 
            this._grViand.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grViand.Style.BackColorGradientAngle = 90;
            this._grViand.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grViand.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderBottomWidth = 1;
            this._grViand.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grViand.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderLeftWidth = 1;
            this._grViand.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderRightWidth = 1;
            this._grViand.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grViand.Style.BorderTopWidth = 1;
            this._grViand.Style.CornerDiameter = 4;
            this._grViand.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grViand.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grViand.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grViand.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grViand.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grViand.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grViand.TabIndex = 4;
            this._grViand.Text = "Món";
            // 
            // _grProperty
            // 
            this._grProperty.CanvasColor = System.Drawing.SystemColors.Control;
            this._grProperty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grProperty.Location = new System.Drawing.Point(539, 12);
            this._grProperty.Name = "_grProperty";
            this._grProperty.Size = new System.Drawing.Size(331, 503);
            // 
            // 
            // 
            this._grProperty.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grProperty.Style.BackColorGradientAngle = 90;
            this._grProperty.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grProperty.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderBottomWidth = 1;
            this._grProperty.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grProperty.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderLeftWidth = 1;
            this._grProperty.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderRightWidth = 1;
            this._grProperty.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grProperty.Style.BorderTopWidth = 1;
            this._grProperty.Style.CornerDiameter = 4;
            this._grProperty.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grProperty.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grProperty.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grProperty.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grProperty.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grProperty.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grProperty.TabIndex = 5;
            this._grProperty.Text = "Tùy Chọn";
            // 
            // _grDetail
            // 
            this._grDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this._grDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this._grDetail.Location = new System.Drawing.Point(876, 12);
            this._grDetail.Name = "_grDetail";
            this._grDetail.Size = new System.Drawing.Size(446, 503);
            // 
            // 
            // 
            this._grDetail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._grDetail.Style.BackColorGradientAngle = 90;
            this._grDetail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._grDetail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderBottomWidth = 1;
            this._grDetail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._grDetail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderLeftWidth = 1;
            this._grDetail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderRightWidth = 1;
            this._grDetail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._grDetail.Style.BorderTopWidth = 1;
            this._grDetail.Style.CornerDiameter = 4;
            this._grDetail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this._grDetail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this._grDetail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._grDetail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this._grDetail.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._grDetail.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._grDetail.TabIndex = 6;
            this._grDetail.Text = "Chi Tiết Gọi Món";
            // 
            // _lvGenus
            // 
            this._lvGenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvGenus.Location = new System.Drawing.Point(0, 0);
            this._lvGenus.MultiSelect = false;
            this._lvGenus.Name = "_lvGenus";
            this._lvGenus.Size = new System.Drawing.Size(186, 482);
            this._lvGenus.TabIndex = 0;
            this._lvGenus.UseCompatibleStateImageBehavior = false;
            this._lvGenus.SelectedIndexChanged += new System.EventHandler(this._lvGenus_SelectedIndexChanged);
            // 
            // _txtGenusId
            // 
            this._txtGenusId.Location = new System.Drawing.Point(4, 557);
            this._txtGenusId.Name = "_txtGenusId";
            this._txtGenusId.Size = new System.Drawing.Size(53, 20);
            this._txtGenusId.TabIndex = 7;
            this._txtGenusId.TextChanged += new System.EventHandler(this._txtGenusId_TextChanged);
            // 
            // _lvViand
            // 
            this._lvViand.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvViand.Location = new System.Drawing.Point(0, 0);
            this._lvViand.MultiSelect = false;
            this._lvViand.Name = "_lvViand";
            this._lvViand.Size = new System.Drawing.Size(328, 482);
            this._lvViand.TabIndex = 1;
            this._lvViand.UseCompatibleStateImageBehavior = false;
            // 
            // ManagerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 618);
            this.Controls.Add(this._txtGenusId);
            this.Controls.Add(this._grDetail);
            this.Controls.Add(this._grProperty);
            this.Controls.Add(this._grViand);
            this.Controls.Add(this._grGenus);
            this.Name = "ManagerTable";
            this.Text = "ManagerTable";
            this.Resize += new System.EventHandler(this.ManagerTable_Resize);
            this._grGenus.ResumeLayout(false);
            this._grViand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel _grGenus;
        private DevComponents.DotNetBar.Controls.GroupPanel _grViand;
        private DevComponents.DotNetBar.Controls.GroupPanel _grProperty;
        private DevComponents.DotNetBar.Controls.GroupPanel _grDetail;
        private System.Windows.Forms.ListView _lvGenus;
        private System.Windows.Forms.TextBox _txtGenusId;
        private System.Windows.Forms.ListView _lvViand;
    }
}