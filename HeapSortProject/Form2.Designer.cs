namespace HeapSortProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.circleNode1 = new MyLib.CircleNode();
            this.SuspendLayout();
            // 
            // circleNode1
            // 
            this.circleNode1.BackColor = System.Drawing.SystemColors.GrayText;
            this.circleNode1.Backgroundcolor = System.Drawing.Color.LightGray;
            this.circleNode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleNode1.Location = new System.Drawing.Point(390, 33);
            this.circleNode1.Name = "circleNode1";
            this.circleNode1.Size = new System.Drawing.Size(75, 75);
            this.circleNode1.TabIndex = 0;
            this.circleNode1.Text = "circleNode1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(579, 375);
            this.Controls.Add(this.circleNode1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private MyLib.CircleNode circleNode1;
    }
}