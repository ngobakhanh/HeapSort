using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using System.Drawing.Drawing2D;
using System.Threading;

namespace HeapSortProject
{
    public partial class Form1 : Form
    {
        TextBox[] value;
        int[] array;
        CircleNode[] c;//Khai báo node
        int num_elements;//số phần tử mảng
        Label[] index; //chỉ số của các phần tử
        int padding;//canh lề cho mảng
        int size; // kích thước của phần tử
        int font_size; //kích thước chữ
        int[] a;//Lưu tọa độ left của cái node 
        int[] b;//Lưu tọa độ top của các node
        Label[] lb;

        public Form1()
        {
            InitializeComponent();
        }

        private void RandomPTbuttonX1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            try
            {
                num_elements = Convert.ToInt32(SoPhanTutextBoxX1.Text);
            }
            catch
            {
                MessageBox.Show("Số phần tử không hợp lệ..");
                return;
            }
            if ((num_elements < 1) || (num_elements > 20))
            {
                MessageBox.Show("Số phần tử của mảng vượt quá mức cho phép !!! .. vui lòng nhập lại [1,20]");
                return;
            }
            SoPhanTutextBoxX1.Enabled = false;
            RandomPTbuttonX1.Enabled = false;
            TuNhapPTbuttonX2.Enabled = false;
            buttonItem1.Visible = true;
            ribbonControl1.Refresh();

            switch (num_elements)
            {
                case 20:
                case 19:
                    size = 47;
                    font_size = 12;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 18:
                case 17:
                case 16:
                    size = 50;
                    font_size = 13;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    size = 60;
                    font_size = 16;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    size = 50;
                    font_size = 16;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
            }

            //Khởi tạo kích thước mảng
            index = new Label[num_elements];
            array = new int[num_elements];
            value = new TextBox[num_elements];
            lb = new Label[num_elements];

            for (int i = 0; i < num_elements; i++)
            {
                //Tạo mảng (gán mỗi textbox tương ứng với 1 phần tử)
                array[i] = r.Next(100);
                value[i] = new TextBox();
                value[i].TextAlign = HorizontalAlignment.Center;
                value[i].Text = array[i].ToString();
                value[i].Width = value[i].Height = size;
                value[i].Location = new Point(padding + size * i, 220);
                value[i].BackColor = SystemColors.Highlight;
                value[i].ForeColor = SystemColors.ButtonFace;
                //value[i].Font = new Font(this.Font, FontStyle.Bold);
                value[i].Font = new System.Drawing.Font("Arial", font_size, FontStyle.Regular);

                // Add các giá trị mảng vào form
                this.Controls.Add(value[i]);

                //Tạo chỉ số cho các phần tử mảng
                index[i] = new Label();
                index[i].TextAlign = ContentAlignment.MiddleCenter;
                index[i].Text = (i + 1).ToString();
                index[i].Width = size;
                index[i].Location = new Point(padding + size * i, 180);
                //index[i].Font = new Font(this.Font, FontStyle.Bold);
                index[i].Font = new System.Drawing.Font("Arial", font_size, FontStyle.Regular);

                //Add các chỉ số vào form
                this.Controls.Add(index[i]);
            }

            ResetButton.Enabled = true;
        }

        private void TuNhapPTbuttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                num_elements = Convert.ToInt32(SoPhanTutextBoxX1.Text);
            }
            catch
            {

                MessageBox.Show("Số phần tử không hợp lệ..");
                return;
            }
            if ((num_elements < 1) || (num_elements > 20))
            {
                MessageBox.Show("Số phần tử của mảng vượt quá kích thước cho phép !!! .. vui lòng nhập lại [1,20]");
                return;
            }

            SoPhanTutextBoxX1.Enabled = false;
            RandomPTbuttonX1.Enabled = false;
            TuNhapPTbuttonX2.Enabled = false;
            buttonItem1.Visible = true;
            ribbonControl1.Refresh();

            switch (num_elements)
            {
                case 20:
                case 19:
                    size = 47;
                    font_size = 12;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 18:
                case 17:
                case 16:
                    size = 50;
                    font_size = 13;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    size = 60;
                    font_size = 16;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                    size = 50;
                    font_size = 16;
                    padding = (this.ClientSize.Width - size * num_elements) / 2;
                    break;
            }

            //Khởi tạo kích thước 
            index = new Label[num_elements];
            array = new int[num_elements];
            value = new TextBox[num_elements];
            lb = new Label[num_elements];

            for (int i = 0; i < num_elements; i++)
            {

                while (true)
                {
                    try
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập phần tử thứ " + (i + 1), "Nhập liệu");
                        array[i] = Convert.ToInt32(input);
                    }
                    catch
                    {
                        continue;
                    }

                    break;
                }

                //Tạo mảng (gán mỗi textbox tương ứng với 1 phần tử)
                value[i] = new TextBox();
                value[i].TextAlign = HorizontalAlignment.Center;
                value[i].Text = array[i].ToString();
                value[i].Width = value[i].Height = size;
                value[i].Location = new Point(padding + size * i, 220);
                value[i].BackColor = SystemColors.Highlight;
                value[i].ForeColor = SystemColors.ButtonFace;
                value[i].Font = new Font(this.Font, FontStyle.Bold);
                value[i].Font = new System.Drawing.Font("Arial", font_size, FontStyle.Regular);

                // Add các giá trị mảng vào form
                this.Controls.Add(value[i]);

                //Tạo chỉ số cho các phần tử mảng
                index[i] = new Label();
                index[i].TextAlign = ContentAlignment.MiddleCenter;
                index[i].Text = (i + 1).ToString();
                index[i].Width = index[i].Height = size;
                index[i].Location = new Point(padding + size * i, 180);
                index[i].Font = new Font(this.Font, FontStyle.Bold);
                index[i].Font = new System.Drawing.Font("Arial", font_size, FontStyle.Regular);

                //Add các chỉ số vào form
                this.Controls.Add(index[i]);
            }
            ResetButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                num_elements = int.Parse(SoPhanTutextBoxX1.Text);
                ResetButton.Enabled = false;
                for (int i = 0; i < num_elements; i++)
                {
                    this.Controls.Remove(value[i]);
                    this.Controls.Remove(index[i]);
                    this.Controls.Remove(lb[i]);
                }
                if (c != null)
                {
                    for (int i = 1; i <= num_elements; i++)
                    {
                        if (i == 1)
                            DrawLine(a[1] + 20, b[1] + 37, a[i + 1] + 20, b[i + 1], Color.WhiteSmoke);
                        else
                            DrawLine(a[i / 2] + 20, b[i / 2] + 37, a[i] + 20, b[i], Color.WhiteSmoke);
                        this.Controls.Remove(c[i]);
                    }
                }
            }
            catch{}
            c = null;
            value = null;
            array = null;
            lb = null;
            SoPhanTutextBoxX1.Enabled = true;
            RandomPTbuttonX1.Enabled = true;
            TuNhapPTbuttonX2.Enabled = true;
        }
        //Vẽ đường đường thẳng nối các node
        private void DrawLine(int x, int y, int m, int n, Color cl)//x,y tọa độ điểm đầu, m,n tọa độ điểm cuối 
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(cl, 1);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(pen, x, y, m, n);//left,top,left,top
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }
        //Swap 2 node
        private void swap(int a, int b)
        {
            string temp = c[a].Text;
            c[a].Text = c[b].Text;
            c[b].Text = temp;
        }

        //vẽ cây
        private void CreateHeapTree()
        {
            num_elements = int.Parse(SoPhanTutextBoxX1.Text) + 1;
            int x = this.ClientSize.Width / 2 - 20;//Tọa độ left của node đầu tiên
            int y = 280;//tọa độ top của node đầu tiên
            c = new CircleNode[num_elements];
            a = new int[num_elements];
            b = new int[num_elements];
            for (int i = 1; i < num_elements; i++)
            {
                c[i] = new CircleNode();
                c[i].Parent = this;
                c[i].Bounds = new Rectangle(x, y, 40, 40);
                c[i].Text = value[i - 1].Text;
                a[i] = c[i].Location.X;
                b[i] = c[i].Location.Y;
                lb[i] = new Label();
                lb[i].Font = new Font(this.Font, FontStyle.Regular);
                lb[i].Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
                lb[i].Location = new Point(a[i] - 30, b[i] + 17);
                if (i == 1 || i == 2)
                {
                    if (i % 2 == 0)
                    {
                        if (i < num_elements - 1)
                            DrawLine(a[1] + 20, b[1] + 37, a[1] + 200 + 20, b[1] + 100, Color.Black);

                        x += 400;
                    }
                    else
                    {
                        if (i < num_elements - 1)
                            DrawLine(a[1] + 20, b[1] + 37, a[1] - 200 + 20, b[1] + 100, Color.Black);

                        //Xét tọa độ cho node kế tiếp
                        x -= 200;
                        y += 100;
                    }
                }
                // >= node 3
                else
                {
                    if (i % 2 == 0)
                    {
                        if (i < 7)
                        {
                            x = a[i] + 240;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] + 120 + 20, b[(i + 1) / 2] + 80, Color.Black);
                          

                        }

                        else if (i >= 7 && i < 15)
                        {
                            x = a[i] + 120;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] + 60 + 20, b[(i + 1) / 2] + 70, Color.Black);
                          
                        }
                        else
                        {
                            x = a[i] + 80;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] + 40 + 20, b[(i + 1) / 2] + 70, Color.Black);
                        
                        }
                    }
                    else
                    {
                        if (i < 7)
                        {
                            x = a[(i + 1) / 2] - 120;
                            y = b[(i + 1) / 2] + 80;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] - 120 + 20, b[(i + 1) / 2] + 80, Color.Black);
                          

                        }
                        else if (i >= 7 && i < 15)
                        {
                            x = a[(i + 1) / 2] - 60;
                            y = b[(i + 1) / 2] + 70;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] - 60 + 20, b[(i + 1) / 2] + 70, Color.Black);
                          

                        }
                        else
                        {
                            x = a[(i + 1) / 2] - 40;
                            y = b[(i + 1) / 2] + 70;
                            if (i < num_elements - 1)
                                DrawLine(a[(i + 1) / 2] + 20, b[(i + 1) / 2] + 37, a[(i + 1) / 2] - 40 + 20, b[(i + 1) / 2] + 70, Color.Black);
                           
                        }
                    }

                }
            }
        }

        private void ChangeColor(CircleNode c1, CircleNode c2, Color cl)
        {
            if (c2 == null)
            {
                c1.Backgroundcolor = cl;
                c1.Refresh();
            }
            else
            {
                c1.Backgroundcolor = cl;
                c2.Backgroundcolor = cl;
                c1.Refresh();
                c2.Refresh();
            }
        }

        //Đổi màu cho phần tử mảng 
        private void ChangeColorArray(Control c1, Control c2, Color cl)
        {
            if (c2 == null)
            {
                c1.BackColor = cl;
                c1.Refresh();
            }
            else
            {
                c1.BackColor = cl;
                c2.BackColor = cl;
                c1.Refresh();
                c2.Refresh();
            }
        }
        //Swap 2 phần tử mảng
        private void swaparr(int a, int b)
        {
            string temp = value[a].Text;
            value[a].Text = value[b].Text;
            value[b].Text = temp;
        }

        int parent, leftchild, rightchild;
        bool isT = true;
        int pLastnode, leftnode, rightnode;
        int k = 0;
        int m = 1;

        //Convert Heap Tree --> Max Heap Tree
        public void MaxHeap()
        {
            num_elements = int.Parse(SoPhanTutextBoxX1.Text) + 1;
            pLastnode = (num_elements - 1) / 2;
            GetMax(pLastnode);
        }

        //Convert Heap Tree --> Min Heap Tree
        public void MinHeap()
        {
            num_elements = int.Parse(SoPhanTutextBoxX1.Text) + 1;
            //Parent cua pLastnode
            pLastnode = (num_elements - 1) / 2;
            for (int j = 0; j < m; j++)
            {
                for (int i = pLastnode; i > 0; i--)
                {
                    parent = int.Parse(c[i].Text);
                    //Xét con bên phải
                    if ((2 * i + 2) > num_elements)
                    {
                        leftnode = 2 * i;
                        leftchild = int.Parse(c[leftnode].Text);
                        isT = true;
                    }
                    else
                    {
                        leftnode = 2 * i;
                        rightnode = 2 * i + 1;
                        leftchild = int.Parse(c[leftnode].Text);
                        rightchild = int.Parse(c[rightnode].Text);
                        isT = false;
                    }
                    if (parent > leftchild || parent > rightchild)
                    {
                        if (leftchild > rightchild && isT == false)
                        {
                            ChangeColor(c[i], c[rightnode], Color.LightSalmon);
                            swap(i, rightnode);
                            Thread.Sleep(3000);
                            ChangeColor(c[i], c[rightnode], Color.LightGray);
                        }
                        else
                        {
                            //Xét trường hợp chỉ có con bên trái mà Parent lớn hơn thì đổi chỗ
                            if (parent > leftchild && isT)
                            {
                                ChangeColor(c[i], c[leftnode], Color.LightSalmon);
                                swap(i, leftnode);
                                Thread.Sleep(3000);
                                ChangeColor(c[i], c[leftnode], Color.LightGray);
                            }
                            //Nếu Parent nhỏ hơn thì không đổi chỗ 
                            else if (parent < leftchild) continue;
                            //Xét trường hợp có 2 con và con bên trái nhỏ hơn thì đổi chỗ cho parent
                            else
                            {
                                ChangeColor(c[i], c[leftnode], Color.LightSalmon);
                                swap(i, leftnode);
                                Thread.Sleep(3000);
                                ChangeColor(c[i], c[leftnode], Color.LightGray);
                            }
                        }
                        k++;
                    }
                }
                //Nếu k=0 không có lần swap nào--> cây min --> thoát vòng lặp
                if (k == 0) m--;
                else
                {
                    k = 0;
                    m++;
                }
            }
        }
        //Mô tả thuật toán Heap Sort
        public void HeapSort()
        {
            num_elements = int.Parse(SoPhanTutextBoxX1.Text) + 1;
            int r = array.Length - 1;
            while (num_elements > 1)
            {
                //Cha của node cuối cùng
                pLastnode = (num_elements - 1) / 2;
                int x = c[num_elements - 1].Location.X;
                int y = c[num_elements - 1].Location.Y;
                //Xét Node đầu tiên có phải là max không
                if (int.Parse(c[1].Text) != Getmaxnode(r))
                    GetMax(pLastnode);
                ChangeColor(c[1], c[num_elements - 1], Color.Orchid);
                for (int i = 0; i <= r; i++)
                {
                    if (int.Parse(c[1].Text) == int.Parse(value[i].Text))
                    {
                        ChangeColorArray(value[i], null, Color.Orchid);
                        swaparr(i, r);
                        Thread.Sleep(3000);
                        ChangeColorArray(value[i], null, SystemColors.Highlight);
                        ChangeColorArray(value[r], null, Color.LimeGreen);
                    }
                }
                swap(1, num_elements - 1);
                Thread.Sleep(1000);
                ChangeColor(c[1], null, Color.LightGray);
                this.Controls.Remove(c[num_elements - 1]);
                try
                {
                    DrawLine(c[pLastnode].Location.X + 20, c[pLastnode].Location.Y + 37, x + 20, y, Color.WhiteSmoke);
                }
                catch { }
                num_elements--;
                r--;
            }
        }
        //Lấy ra giá trị lớn nhất của mảng 
        private int Getmaxnode(int n)
        {
            int max = int.Parse(value[0].Text);
            int temp;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(value[i].Text);
                if (a > max)
                {
                    temp = a;
                    a = max;
                    max = temp;
                }
            }
            return max;
        }
        private void GetMax(int last_node)
        {
            for (int j = 0; j < m; j++)
            {
                for (int i = last_node; i > 0; i--)
                {
                    parent = int.Parse(c[i].Text);
                    //Xét con bên phải
                    if ((2 * i + 2) > num_elements)
                    {
                        leftnode = 2 * i;
                        leftchild = int.Parse(c[leftnode].Text);
                        isT = true;
                    }
                    else
                    {
                        leftnode = 2 * i;
                        rightnode = 2 * i + 1;
                        leftchild = int.Parse(c[leftnode].Text);
                        rightchild = int.Parse(c[rightnode].Text);
                        isT = false;
                    }
                    //Xét parent có nhỏ hơn leftchild or rightchild, nếu có thì swap
                    if (parent < leftchild || parent < rightchild)
                    {
                        if (leftchild < rightchild && isT == false)
                        {
                            ChangeColor(c[i], c[rightnode], Color.LightSalmon);
                            swap(i, rightnode);
                            Thread.Sleep(3000);
                            ChangeColor(c[i], c[rightnode], Color.LightGray);
                        }
                        else
                        {
                            //Xét trường hợp chỉ có con bên trái mà Parent lớn hơn thì đổi chỗ
                            if (parent < leftchild && isT)
                            {
                                ChangeColor(c[i], c[leftnode], Color.LightSalmon);
                                swap(i, leftnode);
                                Thread.Sleep(3000);
                                ChangeColor(c[i], c[leftnode], Color.LightGray);
                            }
                            //Nếu Parent nhỏ hơn thì không đổi chỗ 
                            else if (parent > leftchild || parent == leftchild) continue;
                            //Xét trường hợp có 2 con và con bên trái nhỏ hơn thì đổi chỗ cho parent
                            else
                            {
                                ChangeColor(c[i], c[leftnode], Color.LightSalmon);
                                swap(i, leftnode);
                                Thread.Sleep(3000);
                                ChangeColor(c[i], c[leftnode], Color.LightGray);
                            }
                        }
                        k++;
                    }
                }
                //Nếu k=0 không có lần swap nào--> cây min --> thoát vòng lặp
                if (k == 0) m--;
                else
                {
                    k = 0;
                    m++;
                }
            }
        }

        private void randomValuebtn_Click(object sender, EventArgs e)
        {
            //tao array ngau nhien
            int num_elements = array.Length;
            Random a = new Random();
            for (int i = 0; i < num_elements; i++)
            {
                value[i].Top = 220;
                array[i] = a.Next(100);
                value[i].Text = array[i].ToString();
            }
        }

        private void Inputbtn_Click(object sender, EventArgs e)
        {
            num_elements = array.Length;
            for (int i = 0; i < num_elements; i++)
            {
                while (true)
                {
                    try
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập phần tử thứ " + (i + 1), "Nhập liệu");
                        array[i] = Convert.ToInt32(input);
                    }
                    catch
                    {
                        continue;
                    }

                    break;
                }
                value[i].Text = array[i].ToString();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Instruction i = new Instruction();
            i.ShowDialog();
        }
        private void btnCreateBinaryTree_Click(object sender, EventArgs e)
        {
            try
            {
                CreateHeapTree();
            }
            catch {};
        }
        private void btnCreateMaxHeap_Click(object sender, EventArgs e)
        {
            try
            {
                MaxHeap();
            }
            catch{}
        }

        private void btnCreateMinHeap_Click(object sender, EventArgs e)
        {
            try
            {
                MinHeap();
            }
            catch {}
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            try
            {
                HeapSort();
                MessageBox.Show("Đã sắp xếp xong !");
            }
            catch { }
        }

    }
}
