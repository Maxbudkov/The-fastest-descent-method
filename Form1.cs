using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication4
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Kurs : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblTMin;
        private System.Windows.Forms.Label lblOtv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Anslabel;
        private System.Windows.Forms.Label Funlabel;
        private System.Windows.Forms.Label Ansylabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BegXtextBox;
        private System.Windows.Forms.TextBox BegYtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox Addtbx1;
        private System.Windows.Forms.TextBox Addtbx2;
        private System.Windows.Forms.TextBox Addtbx3;
        private System.Windows.Forms.TextBox Addtbx4;
        private System.Windows.Forms.TextBox Addtbx5;
        private System.Windows.Forms.TextBox Addtbx6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Doplabel1;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox SpuskWay;
        private System.Windows.Forms.TextBox X12;
        private System.Windows.Forms.TextBox X22;
        private System.Windows.Forms.TextBox X1X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.TextBox X2;
        private System.ComponentModel.IContainer components;

        public Kurs()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        const double kor = 2.236067977499789696409;
        double beg = -10.0, end = 10.0, eps = 0.01;
        double ResOtvet;
        double[] VectorWay = { 2.0, -1.0 };
        double[][] dopogr = new double[10][];

        int errorOGR = 0;
        int schogr = 0;

        Graphics g;
        Color grafic = Color.Silver, shtraf = Color.Red, black = Color.Black;

        double aa, bb, cc;
        double a, b, c, d, E, f;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kurs));
            this.label1 = new System.Windows.Forms.Label();
            this.X12 = new System.Windows.Forms.TextBox();
            this.X22 = new System.Windows.Forms.TextBox();
            this.X1X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.K = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblTMin = new System.Windows.Forms.Label();
            this.lblOtv = new System.Windows.Forms.Label();
            this.SpuskWay = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ansylabel = new System.Windows.Forms.Label();
            this.Funlabel = new System.Windows.Forms.Label();
            this.Anslabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BegXtextBox = new System.Windows.Forms.TextBox();
            this.BegYtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Addtbx1 = new System.Windows.Forms.TextBox();
            this.Addtbx2 = new System.Windows.Forms.TextBox();
            this.Addtbx3 = new System.Windows.Forms.TextBox();
            this.Addtbx4 = new System.Windows.Forms.TextBox();
            this.Addtbx5 = new System.Windows.Forms.TextBox();
            this.Addtbx6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Doplabel1 = new System.Windows.Forms.Label();
            this.Delbutton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpuskWay)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Минимизируемая функция:";
            // 
            // X12
            // 
            this.X12.Location = new System.Drawing.Point(61, 47);
            this.X12.Name = "X12";
            this.X12.Size = new System.Drawing.Size(29, 20);
            this.X12.TabIndex = 1;
            this.X12.Text = "3";
            // 
            // X22
            // 
            this.X22.Location = new System.Drawing.Point(213, 47);
            this.X22.Name = "X22";
            this.X22.Size = new System.Drawing.Size(29, 20);
            this.X22.TabIndex = 3;
            this.X22.Text = "1";
            // 
            // X1X2
            // 
            this.X1X2.Location = new System.Drawing.Point(135, 47);
            this.X1X2.Name = "X1X2";
            this.X1X2.Size = new System.Drawing.Size(30, 20);
            this.X1X2.TabIndex = 2;
            this.X1X2.Text = "-1";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(285, 47);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(29, 20);
            this.X1.TabIndex = 4;
            this.X1.Text = "-4";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(415, 47);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(29, 20);
            this.K.TabIndex = 6;
            this.K.Text = "0";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(350, 47);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(29, 20);
            this.X2.TabIndex = 5;
            this.X2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Старт";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(454, 45);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Очистить";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblTMin
            // 
            this.lblTMin.AutoSize = true;
            this.lblTMin.Location = new System.Drawing.Point(3, 32);
            this.lblTMin.Name = "lblTMin";
            this.lblTMin.Size = new System.Drawing.Size(96, 13);
            this.lblTMin.TabIndex = 13;
            this.lblTMin.Text = "Точка минимума:";
            // 
            // lblOtv
            // 
            this.lblOtv.AutoSize = true;
            this.lblOtv.Location = new System.Drawing.Point(3, 96);
            this.lblOtv.Name = "lblOtv";
            this.lblOtv.Size = new System.Drawing.Size(104, 13);
            this.lblOtv.TabIndex = 14;
            this.lblOtv.Text = "Значение функции:";
            // 
            // SpuskWay
            // 
            this.SpuskWay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpuskWay.Image = ((System.Drawing.Image)(resources.GetObject("SpuskWay.Image")));
            this.SpuskWay.Location = new System.Drawing.Point(15, 80);
            this.SpuskWay.Name = "SpuskWay";
            this.SpuskWay.Size = new System.Drawing.Size(595, 315);
            this.SpuskWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpuskWay.TabIndex = 15;
            this.SpuskWay.TabStop = false;
            this.SpuskWay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxGraf_MouseDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "x1^2+";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(171, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "x1*x2 +";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(248, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "x2^2+";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(320, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "x1+";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(385, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "x2+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Ansylabel);
            this.panel2.Controls.Add(this.Funlabel);
            this.panel2.Controls.Add(this.Anslabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTMin);
            this.panel2.Controls.Add(this.lblOtv);
            this.panel2.Location = new System.Drawing.Point(616, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 315);
            this.panel2.TabIndex = 18;
            // 
            // Ansylabel
            // 
            this.Ansylabel.AutoSize = true;
            this.Ansylabel.Location = new System.Drawing.Point(17, 69);
            this.Ansylabel.Name = "Ansylabel";
            this.Ansylabel.Size = new System.Drawing.Size(0, 13);
            this.Ansylabel.TabIndex = 17;
            // 
            // Funlabel
            // 
            this.Funlabel.AutoSize = true;
            this.Funlabel.Location = new System.Drawing.Point(8, 120);
            this.Funlabel.Name = "Funlabel";
            this.Funlabel.Size = new System.Drawing.Size(0, 13);
            this.Funlabel.TabIndex = 16;
            // 
            // Anslabel
            // 
            this.Anslabel.AutoSize = true;
            this.Anslabel.Location = new System.Drawing.Point(8, 56);
            this.Anslabel.Name = "Anslabel";
            this.Anslabel.Size = new System.Drawing.Size(0, 13);
            this.Anslabel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Результаты вычислений";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(616, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Начальная точка";
            // 
            // BegXtextBox
            // 
            this.BegXtextBox.Location = new System.Drawing.Point(660, 47);
            this.BegXtextBox.Name = "BegXtextBox";
            this.BegXtextBox.Size = new System.Drawing.Size(24, 20);
            this.BegXtextBox.TabIndex = 20;
            this.BegXtextBox.Text = "-2";
            // 
            // BegYtextBox
            // 
            this.BegYtextBox.Location = new System.Drawing.Point(700, 47);
            this.BegYtextBox.Name = "BegYtextBox";
            this.BegYtextBox.Size = new System.Drawing.Size(24, 20);
            this.BegYtextBox.TabIndex = 21;
            this.BegYtextBox.Text = "3";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(642, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "(";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(730, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = ")";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Дополнительные ограничения:";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(454, 403);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(156, 23);
            this.Addbutton.TabIndex = 24;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Addtbx1
            // 
            this.Addtbx1.Location = new System.Drawing.Point(22, 426);
            this.Addtbx1.Name = "Addtbx1";
            this.Addtbx1.Size = new System.Drawing.Size(32, 20);
            this.Addtbx1.TabIndex = 25;
            this.Addtbx1.Text = "0";
            // 
            // Addtbx2
            // 
            this.Addtbx2.Location = new System.Drawing.Point(86, 426);
            this.Addtbx2.Name = "Addtbx2";
            this.Addtbx2.Size = new System.Drawing.Size(29, 20);
            this.Addtbx2.TabIndex = 25;
            this.Addtbx2.Text = "0";
            // 
            // Addtbx3
            // 
            this.Addtbx3.Location = new System.Drawing.Point(150, 426);
            this.Addtbx3.Name = "Addtbx3";
            this.Addtbx3.Size = new System.Drawing.Size(32, 20);
            this.Addtbx3.TabIndex = 25;
            this.Addtbx3.Text = "0";
            // 
            // Addtbx4
            // 
            this.Addtbx4.Location = new System.Drawing.Point(219, 426);
            this.Addtbx4.Name = "Addtbx4";
            this.Addtbx4.Size = new System.Drawing.Size(32, 20);
            this.Addtbx4.TabIndex = 25;
            this.Addtbx4.Text = "0";
            // 
            // Addtbx5
            // 
            this.Addtbx5.Location = new System.Drawing.Point(276, 426);
            this.Addtbx5.Name = "Addtbx5";
            this.Addtbx5.Size = new System.Drawing.Size(26, 20);
            this.Addtbx5.TabIndex = 25;
            this.Addtbx5.Text = "0";
            // 
            // Addtbx6
            // 
            this.Addtbx6.Location = new System.Drawing.Point(326, 426);
            this.Addtbx6.Name = "Addtbx6";
            this.Addtbx6.Size = new System.Drawing.Size(32, 20);
            this.Addtbx6.TabIndex = 25;
            this.Addtbx6.Text = "0";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(54, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "x1^2+";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(114, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "x2^2+";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(181, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "x1*x2 +";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(254, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "x1+";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(302, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "x2+";
            // 
            // Doplabel1
            // 
            this.Doplabel1.Location = new System.Drawing.Point(12, 449);
            this.Doplabel1.Name = "Doplabel1";
            this.Doplabel1.Size = new System.Drawing.Size(346, 173);
            this.Doplabel1.TabIndex = 26;
            // 
            // Delbutton
            // 
            this.Delbutton.Location = new System.Drawing.Point(454, 433);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(156, 23);
            this.Delbutton.TabIndex = 28;
            this.Delbutton.Text = "Удалить";
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(685, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = ";";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(15, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "F (x) = ";
            // 
            // Kurs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.Doplabel1);
            this.Controls.Add(this.Addtbx1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BegYtextBox);
            this.Controls.Add(this.BegXtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpuskWay);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.K);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X1X2);
            this.Controls.Add(this.X22);
            this.Controls.Add(this.X12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Addtbx2);
            this.Controls.Add(this.Addtbx3);
            this.Controls.Add(this.Addtbx4);
            this.Controls.Add(this.Addtbx5);
            this.Controls.Add(this.Addtbx6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Name = "Kurs";
            this.Text = "Минимизация многомерной функции методом наискорейшего спуска";
            ((System.ComponentModel.ISupportInitialize)(this.SpuskWay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Kurs());
        }


        private void button1_Click(object sender, System.EventArgs e)
        {

            const double bi = 10.0;
            double mu = 0.001;
            double a1, b1, c1, d1, e1, f1;
            double xpred, ypred, x, y;
            
            VectorWay[0] = Double.Parse(BegXtextBox.Text);
            VectorWay[1] = Double.Parse(BegYtextBox.Text);
            xpred = VectorWay[0];
            ypred = VectorWay[1];

            g = SpuskWay.CreateGraphics();


            x = xpred;
            y = ypred;

            a = Double.Parse(X12.Text);
            b = Double.Parse(X22.Text);
            c = Double.Parse(X1X2.Text);
            d = Double.Parse(X1.Text);
            E = Double.Parse(X2.Text);
            f = Double.Parse(K.Text);

            do
            {
                mu *= bi;
                a1 = a;
                b1 = b;
                c1 = c;
                d1 = d;
                e1 = E;
                f1 = f;

                for (int i = 0; i < schogr; i++)
                {
                    if (func(dopogr[i][0], dopogr[i][1], dopogr[i][2], dopogr[i][3],
                        dopogr[i][4], dopogr[i][5], x, y) > 0.0)
                    {
                        a1 += dopogr[i][0] * mu;
                        b1 += dopogr[i][1] * mu;
                        c1 += dopogr[i][2] * mu;
                        d1 += dopogr[i][3] * mu;
                        e1 += dopogr[i][4] * mu;
                        f1 += dopogr[i][5] * mu;
                    }
                }

                ResOtvet = VeryFastDown(a1, b1, c1, d1, e1, f1, ref x, ref y);

                if (((x - xpred) * (x - xpred) + (y - ypred) * (y - ypred)) <= eps * eps * 20)
                {
                    break;
                }
                xpred = x;
                ypred = y;

            }
            while (ReturnAlfa(x, y) > 0.05);
            Anslabel.Text = "( " + x + " ;";
            Ansylabel.Text = "" + y + " )";
            Funlabel.Text = "F = " + ResOtvet;

            pererisovka(ResOtvet, x, y);

        }
        private void pererisovka(double otv, double x, double y)
        {
            risLine(x, y, x + 0.05, y + 0.05, grafic);
            const double shag = 50.0;
            for (int i = 1; i <= 10; i++)
            {
                risKrug(otv + shag * i, a, b, c, d, E, f, grafic);
            }
            for (int i = 0; i < schogr; i++)
            {
                risKrug(0, dopogr[i][0], dopogr[i][1], dopogr[i][2], dopogr[i][3], dopogr[i][4], dopogr[i][5], shtraf);
            }

        }

        void risKrug(double F, double aa, double bb, double cc, double dd,
            double ee, double ff, Color cvet)
        {
            const double nachX = -14.1, konX = 14;
            double j1 = 0.0, j2 = 0.0, predj1 = 20.0, predj2 = 20.0;
            bool firstit = true, lastit = false;
            double A, B, C, Diskr;
            double K;
            for (double i = nachX; i <= konX; i += 0.09)
            {
                if (bb == 0.0)
                {
                    K = cc * i + ee;
                    B = aa * i * i + dd * i + ff;
                    if (firstit)
                    {
                        predj1 = -B / K;
                        firstit = false;
                    }
                    else
                    {
                        j1 = -B / K;
                        risLine(i, j1, i - 0.09, predj1, cvet);
                        predj1 = j1;
                    }

                }
                else
                {

                    A = bb;
                    B = cc * i + ee;
                    C = aa * i * i + dd * i + ff - F;
                    Diskr = B * B - 4 * A * C;
                    if (Diskr >= 0.0)
                    {
                        if (firstit)
                        {
                            predj1 = (-B + Math.Sqrt(Diskr)) / (2 * A);
                            predj2 = (-B - Math.Sqrt(Diskr)) / (2 * A);
                            predj1 = predj2 = (predj1 + predj2) / 2.0;
                            firstit = false;
                        }
                        else
                        {
                            j1 = (-B + Math.Sqrt(Diskr)) / (2 * A);
                            risLine(i, j1, i - 0.09, predj1, cvet);
                            predj1 = j1;
                            j2 = (-B - Math.Sqrt(Diskr)) / (2 * A);
                            risLine(i, j2, i - 0.09, predj2, cvet);
                            predj2 = j2;
                        }
                    }
                    if (Diskr < 0.0 && !firstit && !lastit)
                    {
                        j1 = j2 = (j1 + j2) / 2.0;
                        risLine(i, j1, i - 0.09, predj1, cvet);
                        risLine(i, j2, i - 0.09, predj2, cvet);
                        lastit = true;
                    }
                }
            }
        }

        void risLine(double x, double y, double predx, double predy, Color clr)
        {
            const int otsX = 19, otsY = 15, shag = 20, krayX = -13, krayY = 7;
            int xx = (int)(otsX + shag * (x - krayX));
            int yy = (int)(otsY + shag * (krayY - y));
            int predxx = (int)(otsX + shag * (predx - krayX));
            int predyy = (int)(otsY + shag * (krayY - predy));

            g.DrawLine(new Pen(clr, 1.0f), xx, yy, predxx, predyy);

        }
        void risLineLine(double x, double y, double predx, double predy, Color clr)
        {
            const int otsX = 19, otsY = 15, shag = 20, krayX = -13, krayY = 7;
            int xx = (int)(otsX + shag * (x - krayX));
            int yy = (int)(otsY + shag * (krayY - y));
            int predxx = (int)(otsX + shag * (predx - krayX));
            int predyy = (int)(otsY + shag * (krayY - predy));

            g.DrawLine(new Pen(clr, 1.0f), xx, yy, predxx, yy);
            g.DrawLine(new Pen(clr, 1.0f), predxx, predyy, predxx, yy);
        }

        double ReturnAlfa(double x, double y)
        {
            double alpha = 0.00;
            for (int i = 0; i < schogr; i++)
            {
                double prom = func(dopogr[i][0], dopogr[i][1], dopogr[i][2],
                    dopogr[i][3], dopogr[i][4], dopogr[i][5], x, y);
                alpha += (prom <= 0) ? 0.0 : prom;
            }
            return alpha;
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {

            SpuskWay.Image = System.Drawing.Image.FromFile("12.bmp");

        }
        private void Addbutton_Click(object sender, System.EventArgs e)
        {
            if (errorOGR < 10)
            {
                if (schogr == 0.0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        dopogr[i] = new double[6];
                    }
                }

                dopogr[schogr][0] = Double.Parse(Addtbx1.Text);
                dopogr[schogr][1] = Double.Parse(Addtbx2.Text);
                dopogr[schogr][2] = Double.Parse(Addtbx3.Text);
                dopogr[schogr][3] = Double.Parse(Addtbx4.Text);
                dopogr[schogr][4] = Double.Parse(Addtbx5.Text);
                dopogr[schogr][5] = Double.Parse(Addtbx6.Text);
                schogr++;
                errorOGR++;
                printDop();
            }
            else
            {
                Doplabel1.Text = "Слишком много ограничений. Удалите лишние ограничения.";
            }
        }

        void printDop()
        {
            Doplabel1.Text = "";
            for (int i = 0; i < schogr; i++)
            {
                bool isFirst = true;
                for (int j = 0; j < 6; j++)
                {
                    if (dopogr[i][j] != 0.0)
                    {
                        if (!isFirst) Doplabel1.Text += " + ";
                        switch (j)
                        {
                            case 0:
                                Doplabel1.Text += dopogr[i][j].ToString() +
                                    "*x1^2"; break;
                            case 1:
                                Doplabel1.Text += dopogr[i][j].ToString() +
                                    "*x2^2"; break;
                            case 2:
                                Doplabel1.Text += dopogr[i][j].ToString() +
                                    "*x1*x2"; break;
                            case 3:
                                Doplabel1.Text += dopogr[i][j].ToString() +
                                    "*x1"; break;
                            case 4:
                                Doplabel1.Text += dopogr[i][j].ToString() +
                                    "*x2"; break;
                            case 5:
                                Doplabel1.Text += dopogr[i][j].ToString();
                                break;
                        }
                        isFirst = false;
                    }
                }
                if (!isFirst)
                {
                    Doplabel1.Text += " <= 0\n";
                }
                else schogr--;
            }
            if (Doplabel1.Text == "")
                Doplabel1.Text = "Дополнительных ограничений нет";
        }

        double func(double x)
        {
            return aa * x * x + bb * x + cc;
        }

        double func(double a, double b, double c, double d,
            double E, double f, double x1, double x2)
        {
            return a * x1 * x1 + b * x2 * x2 + c * x1 * x2 + d * x1 + E * x2 + f;
        }

        double dFpodX(double x1, double x2, int perem)
        {
            if (perem == 1)
                return 2 * a * x1 + c * x2 + d;
            else
                return 2 * b * x2 + c * x1 + E;
        }

        // Определение первоначального интервала неопределенности
        void BeginInterval()
        {
            double del = 3.0, a2 = 1.0, a1, a3;
            double f1, f2, f3;
            a1 = a2 - del;
            a3 = a2 + del;
            f2 = func(a2);
            f1 = func(a1);
            f3 = func(a3);
            while (true)
            {
                if (f1 < f3)
                {
                    if (f1 < f2)
                    {
                        a3 = a2;
                        a2 = a1;
                        f3 = f2;
                        f2 = f1;
                        a1 = a2 - del;
                    }
                    else break;
                }
                else
                {
                    if (f2 > f3)
                    {
                        a1 = a2;
                        a2 = a3;
                        f1 = f2;
                        f2 = f3;
                        a3 = a2 + del;
                    }
                    else break;
                }
            }
            beg = a1;
            end = a3;
        }

        //Метод "Золотого сечения"
        double Gold()
        {
            BeginInterval();
            double a = beg, b = end;
            double x1, x2, y1, y2;
            double delta;
            while (b - a >= eps)
            {
                x2 = a + (b - a) / ((1 + kor) / 2);
                x1 = a + b - x2;
                y1 = func(x1);
                y2 = func(x2);
                if (y1 < y2)
                {
                    delta = x2 - x1;
                    b = x2;
                    x2 = x1;
                    x1 = a + delta;
                    y2 = y1;
                }
                else if (y2 < y1)
                {
                    delta = x2 - x1;
                    a = x1;
                    x1 = x2;
                    x1 = b - delta;
                    y1 = y2;
                }
                else
                {
                    a = x1;
                    b = x2;
                    x1 = (a + b) / 2 - kor * (b - a) / 2;
                    x2 = (a + b) / 2 + kor * (b - a) / 2;
                }
            }
            return a;
        }

        // Метод наискорейшего спуска
        double VeryFastDown(double a, double b, double c, double d,
            double E, double f, ref double VectorWay0, ref double VectorWay1)
        {
            double[] grad = new double[2];
            double norma, lamb, otv;
            double predv1 = VectorWay0, predv2 = VectorWay1;
            grad[0] = -dFpodX(VectorWay0, VectorWay1, 1);
            grad[1] = -dFpodX(VectorWay0, VectorWay1, 2);
            do
            {

                aa = a * grad[0] * grad[0] + b * grad[1] * grad[1] + c * grad[0] * grad[1];
                bb = a * 2 * VectorWay0 * grad[0] + b * 2 * VectorWay1 * grad[1] + c * grad[0] * VectorWay1 +
                    c * grad[1] * VectorWay0 + d * grad[0] + E * grad[1];
                cc = a * VectorWay0 * VectorWay0 + b * VectorWay1 * VectorWay1 + c * VectorWay0 * VectorWay1 + d * VectorWay0 + E * VectorWay1 + f;

                lamb = Gold();
                VectorWay0 = VectorWay0 + lamb * grad[0];
                VectorWay1 = VectorWay1 + lamb * grad[1];
                otv = func(a, b, c, d, E, f, VectorWay0, VectorWay1);

                grad[0] = -dFpodX(VectorWay0, VectorWay1, 1);
                grad[1] = -dFpodX(VectorWay0, VectorWay1, 2);
                norma = Math.Sqrt(grad[0] * grad[0] + grad[1] * grad[1]);
                risLine(VectorWay0, VectorWay1, predv1, predv2, black);
                predv1 = VectorWay0;
                predv2 = VectorWay1;
            }
            while (norma >= eps);
            return otv;
        }

        private void pbxGraf_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            double[] VectorWay = {
                System.Windows.Forms.Control.MousePosition.X,System.Windows.Forms.Control.MousePosition.Y };
        }

        private void Delbutton_Click(object sender, System.EventArgs e)
        {
            if (schogr != 0)
            {
                errorOGR--;
                schogr--;
                printDop();
            }
        }
    }
}
