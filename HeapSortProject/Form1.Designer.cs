namespace HeapSortProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnHeapSort = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnCreateBinaryTree = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreateMaxHeap = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreateMinHeap = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ResetButton = new DevComponents.DotNetBar.ButtonX();
            this.RandomPTbuttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.TuNhapPTbuttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SoPhanTutextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnHelp = new DevComponents.DotNetBar.ButtonX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.randomValuebtn = new DevComponents.DotNetBar.ButtonItem();
            this.Inputbtn = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2,
            this.ribbonTabItem3});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1052, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "Chương trình mô phỏng thuật toán heap sort";
            this.ribbonControl1.TitleText = "<font color=\"#ED1C24\"><b>Chương trình mô phỏng thuật toán Heap sort</b></font>\r\n";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Controls.Add(this.ribbonBar1);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1052, 98);
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeapSort});
            this.ribbonBar2.Location = new System.Drawing.Point(345, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(168, 95);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Heap sort";
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeapSort.FixedSize = new System.Drawing.Size(160, 70);
            this.btnHeapSort.FontBold = true;
            this.btnHeapSort.Image = ((System.Drawing.Image)(resources.GetObject("btnHeapSort.Image")));
            this.btnHeapSort.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnHeapSort.ImagePaddingHorizontal = 8;
            this.btnHeapSort.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Stretch = true;
            this.btnHeapSort.Text = "Mô tả thuật toán Heap sort";
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCreateBinaryTree,
            this.btnCreateMaxHeap,
            this.btnCreateMinHeap});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(342, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Cây nhị phân";
            // 
            // btnCreateBinaryTree
            // 
            this.btnCreateBinaryTree.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCreateBinaryTree.FontBold = true;
            this.btnCreateBinaryTree.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBinaryTree.Image")));
            this.btnCreateBinaryTree.ImagePaddingHorizontal = 8;
            this.btnCreateBinaryTree.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreateBinaryTree.Name = "btnCreateBinaryTree";
            this.btnCreateBinaryTree.Stretch = true;
            this.btnCreateBinaryTree.Text = "Tạo cây nhị phân";
            this.btnCreateBinaryTree.Click += new System.EventHandler(this.btnCreateBinaryTree_Click);
            // 
            // btnCreateMaxHeap
            // 
            this.btnCreateMaxHeap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCreateMaxHeap.FixedSize = new System.Drawing.Size(120, 70);
            this.btnCreateMaxHeap.FontBold = true;
            this.btnCreateMaxHeap.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMaxHeap.Image")));
            this.btnCreateMaxHeap.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnCreateMaxHeap.ImagePaddingHorizontal = 8;
            this.btnCreateMaxHeap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreateMaxHeap.Name = "btnCreateMaxHeap";
            this.btnCreateMaxHeap.Text = "Max Heap Tree";
            this.btnCreateMaxHeap.Click += new System.EventHandler(this.btnCreateMaxHeap_Click);
            // 
            // btnCreateMinHeap
            // 
            this.btnCreateMinHeap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCreateMinHeap.FixedSize = new System.Drawing.Size(120, 70);
            this.btnCreateMinHeap.FontBold = true;
            this.btnCreateMinHeap.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMinHeap.Image")));
            this.btnCreateMinHeap.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnCreateMinHeap.ImagePaddingHorizontal = 8;
            this.btnCreateMinHeap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreateMinHeap.Name = "btnCreateMinHeap";
            this.btnCreateMinHeap.Text = "Min Heap Tree";
            this.btnCreateMinHeap.Click += new System.EventHandler(this.btnCreateMinHeap_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ResetButton);
            this.ribbonPanel1.Controls.Add(this.RandomPTbuttonX1);
            this.ribbonPanel1.Controls.Add(this.TuNhapPTbuttonX2);
            this.ribbonPanel1.Controls.Add(this.SoPhanTutextBoxX1);
            this.ribbonPanel1.Controls.Add(this.label2);
            this.ribbonPanel1.Controls.Add(this.label1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1052, 98);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.ResetButton.Location = new System.Drawing.Point(815, 23);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(154, 51);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RandomPTbuttonX1
            // 
            this.RandomPTbuttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.RandomPTbuttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomPTbuttonX1.Image = ((System.Drawing.Image)(resources.GetObject("RandomPTbuttonX1.Image")));
            this.RandomPTbuttonX1.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.RandomPTbuttonX1.Location = new System.Drawing.Point(394, 23);
            this.RandomPTbuttonX1.Name = "RandomPTbuttonX1";
            this.RandomPTbuttonX1.Size = new System.Drawing.Size(157, 51);
            this.RandomPTbuttonX1.TabIndex = 7;
            this.RandomPTbuttonX1.Text = "Tạo tự động";
            this.RandomPTbuttonX1.Click += new System.EventHandler(this.RandomPTbuttonX1_Click);
            // 
            // TuNhapPTbuttonX2
            // 
            this.TuNhapPTbuttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TuNhapPTbuttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuNhapPTbuttonX2.Image = ((System.Drawing.Image)(resources.GetObject("TuNhapPTbuttonX2.Image")));
            this.TuNhapPTbuttonX2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.TuNhapPTbuttonX2.Location = new System.Drawing.Point(607, 23);
            this.TuNhapPTbuttonX2.Name = "TuNhapPTbuttonX2";
            this.TuNhapPTbuttonX2.Size = new System.Drawing.Size(154, 51);
            this.TuNhapPTbuttonX2.TabIndex = 6;
            this.TuNhapPTbuttonX2.Text = "Tự nhập liệu";
            this.TuNhapPTbuttonX2.Click += new System.EventHandler(this.TuNhapPTbuttonX2_Click);
            // 
            // SoPhanTutextBoxX1
            // 
            // 
            // 
            // 
            this.SoPhanTutextBoxX1.Border.Class = "TextBoxBorder";
            this.SoPhanTutextBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoPhanTutextBoxX1.Location = new System.Drawing.Point(179, 23);
            this.SoPhanTutextBoxX1.Name = "SoPhanTutextBoxX1";
            this.SoPhanTutextBoxX1.Size = new System.Drawing.Size(62, 40);
            this.SoPhanTutextBoxX1.TabIndex = 5;
            this.SoPhanTutextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "phần tử";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tạo mảng có";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Controls.Add(this.btnHelp);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 54);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1052, 98);
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnHelp.Location = new System.Drawing.Point(41, 23);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 44);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Hướng dẫn người dùng";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Khởi tạo mảng";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Tạo và sắp xếp Heap";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.ImagePaddingHorizontal = 8;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "Hướng dẫn";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.randomValuebtn,
            this.Inputbtn});
            this.buttonItem1.Text = "Chọn lại giá trị mảng";
            // 
            // randomValuebtn
            // 
            this.randomValuebtn.ImagePaddingHorizontal = 8;
            this.randomValuebtn.Name = "randomValuebtn";
            this.randomValuebtn.Text = "Chọn ngẫu nhiên";
            this.randomValuebtn.Click += new System.EventHandler(this.randomValuebtn_Click);
            // 
            // Inputbtn
            // 
            this.Inputbtn.ImagePaddingHorizontal = 8;
            this.Inputbtn.Name = "Inputbtn";
            this.Inputbtn.Text = "Tự nhập liệu";
            this.Inputbtn.Click += new System.EventHandler(this.Inputbtn_Click);
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 776);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.ButtonX ResetButton;
        private DevComponents.DotNetBar.ButtonX RandomPTbuttonX1;
        private DevComponents.DotNetBar.ButtonX TuNhapPTbuttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX SoPhanTutextBoxX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnHeapSort;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnCreateBinaryTree;
        private DevComponents.DotNetBar.ButtonItem btnCreateMaxHeap;
        private DevComponents.DotNetBar.ButtonItem btnCreateMinHeap;
        private DevComponents.DotNetBar.ButtonItem randomValuebtn;
        private DevComponents.DotNetBar.ButtonItem Inputbtn;
        private DevComponents.DotNetBar.ButtonX btnHelp;
    }
}

