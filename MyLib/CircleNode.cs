using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyLib
{
    public partial class CircleNode : Control
    {
        Color backgroundcolor;
        public Color Backgroundcolor
        {
            get
            {
                return backgroundcolor;
            }
            set
            {
                backgroundcolor = value;
            }
        }
        public CircleNode()
        {
            InitializeComponent();
            Backgroundcolor = Color.LightGray;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.Draw(new SolidBrush(Backgroundcolor), Brushes.Black);
        }

        private void Draw(Brush bg, Brush fg)
        {
            //Ngung cap nhat
            this.SuspendLayout();
            this.Width = this.Height = this.Width;
            Graphics g = this.CreateGraphics();

            //Ve hinh tron bot lom chom
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Canh giua cho text
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //Ve hinh tron
            g.FillEllipse(bg, new Rectangle(0, 0, this.Width, this.Height));

            //Ve text
            g.DrawString(this.Text, this.Font, fg, this.ClientRectangle, sf);

            //Cap nhat lai
            this.ResumeLayout();
        }
    }
}
