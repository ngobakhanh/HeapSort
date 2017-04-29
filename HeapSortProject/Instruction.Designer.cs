namespace HeapSortProject
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            this.huongdantxt = new System.Windows.Forms.RichTextBox();
            this.huongdan = new DevComponents.DotNetBar.ExpandablePanel();
            this.danhgia = new System.Windows.Forms.RichTextBox();
            this.danhgiagiaithuat = new DevComponents.DotNetBar.ExpandablePanel();
            this.code = new System.Windows.Forms.RichTextBox();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.huongdan.SuspendLayout();
            this.danhgiagiaithuat.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // huongdantxt
            // 
            this.huongdantxt.BackColor = System.Drawing.Color.AliceBlue;
            this.huongdantxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.huongdantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huongdantxt.ForeColor = System.Drawing.Color.Navy;
            this.huongdantxt.Location = new System.Drawing.Point(6, 24);
            this.huongdantxt.Name = "huongdantxt";
            this.huongdantxt.Size = new System.Drawing.Size(853, 263);
            this.huongdantxt.TabIndex = 1;
            this.huongdantxt.Text = resources.GetString("huongdantxt.Text");
            // 
            // huongdan
            // 
            this.huongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.huongdan.CanvasColor = System.Drawing.SystemColors.Control;
            this.huongdan.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black;
            this.huongdan.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.huongdan.Controls.Add(this.huongdantxt);
            this.huongdan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huongdan.Location = new System.Drawing.Point(24, 12);
            this.huongdan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.huongdan.Name = "huongdan";
            this.huongdan.Size = new System.Drawing.Size(875, 303);
            this.huongdan.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.huongdan.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.huongdan.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.huongdan.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.huongdan.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.huongdan.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.huongdan.Style.GradientAngle = 90;
            this.huongdan.TabIndex = 9;
            this.huongdan.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.huongdan.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.huongdan.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.huongdan.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.huongdan.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.huongdan.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.huongdan.TitleStyle.GradientAngle = 90;
            this.huongdan.TitleText = "Hướng dẫn sử dụng chương trình";
            // 
            // danhgia
            // 
            this.danhgia.BackColor = System.Drawing.Color.AliceBlue;
            this.danhgia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.danhgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhgia.ForeColor = System.Drawing.Color.Navy;
            this.danhgia.Location = new System.Drawing.Point(8, 33);
            this.danhgia.Name = "danhgia";
            this.danhgia.Size = new System.Drawing.Size(384, 202);
            this.danhgia.TabIndex = 2;
            this.danhgia.Text = "Ưu điểm:\n* Trường hợp tốt nhất: O(1).\n* Không dùng đệ quy.\nKhuyết điểm:\n* Trường " +
    "hợp tốt nhất: O(nlogn).";
            // 
            // danhgiagiaithuat
            // 
            this.danhgiagiaithuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.danhgiagiaithuat.CanvasColor = System.Drawing.SystemColors.Control;
            this.danhgiagiaithuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.danhgiagiaithuat.Controls.Add(this.danhgia);
            this.danhgiagiaithuat.Expanded = false;
            this.danhgiagiaithuat.ExpandedBounds = new System.Drawing.Rectangle(491, 339, 408, 242);
            this.danhgiagiaithuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhgiagiaithuat.Location = new System.Drawing.Point(491, 339);
            this.danhgiagiaithuat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.danhgiagiaithuat.Name = "danhgiagiaithuat";
            this.danhgiagiaithuat.Size = new System.Drawing.Size(408, 26);
            this.danhgiagiaithuat.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.danhgiagiaithuat.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.danhgiagiaithuat.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.danhgiagiaithuat.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.danhgiagiaithuat.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.danhgiagiaithuat.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.danhgiagiaithuat.Style.GradientAngle = 90;
            this.danhgiagiaithuat.TabIndex = 10;
            this.danhgiagiaithuat.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.danhgiagiaithuat.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.danhgiagiaithuat.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.danhgiagiaithuat.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.danhgiagiaithuat.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.danhgiagiaithuat.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.danhgiagiaithuat.TitleStyle.GradientAngle = 90;
            this.danhgiagiaithuat.TitleText = "Đánh giá giải thuật Heap sort";
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.AliceBlue;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.Navy;
            this.code.Location = new System.Drawing.Point(3, 28);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(432, 203);
            this.code.TabIndex = 11;
            this.code.Text = resources.GetString("code.Text");
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.code);
            this.expandablePanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.Location = new System.Drawing.Point(30, 339);
            this.expandablePanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(438, 242);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 12;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Ý tưởng";
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 604);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.huongdan);
            this.Controls.Add(this.danhgiagiaithuat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instruction";
            this.Text = "Hướng dẫn";
            this.huongdan.ResumeLayout(false);
            this.danhgiagiaithuat.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox huongdantxt;
        private DevComponents.DotNetBar.ExpandablePanel huongdan;
        private System.Windows.Forms.RichTextBox danhgia;
        private DevComponents.DotNetBar.ExpandablePanel danhgiagiaithuat;
        private System.Windows.Forms.RichTextBox code;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
    }
}