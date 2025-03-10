﻿namespace WindowsFormsApplication1
{
    //--------(последняя правка: 12.04.2017)----------------------------------------------------
    public class Rinswind
    {
        public Rinswind()
        {

        }

        public int Nelength(string u)
        {
            int x = 0;

            foreach (char c in u)
            {
                x++;
            }

            return x;
        }

        public string reverse(string u)
        {
            string n = string.Empty;

            for (int x = Nelength(u) - 1; x >= 0; x--)
            {
                n += u[x];
            }

            return n;
        }

        public string enter(float x, string y, string z)
        {
            string e = string.Empty;

            switch (y)
            {
                case "+":
                    e = (x + float.Parse(z)).ToString();
                    break;

                case "-":
                    e = (x - float.Parse(z)).ToString();
                    break;

                case "*":
                    e = (x * float.Parse(z)).ToString();
                    break;

                case "/":

                    if (z == "0")
                    {
                        e = "не-а, не буду!";
                    }

                    else
                    {
                        e = (x / float.Parse(z)).ToString();
                    }

                    break;

                case "x^y":

                    float r = x;

                    for (int t = 1; t < float.Parse(z); t++)
                    {
                        r = r * x;
                    }

                    e = r.ToString();

                    break;

                case "y_sqrt":

                    float k = 1;

                    for (int t = 1; t <= x; t++)
                    {
                        for (int w = 1; w <= float.Parse(z); w++)
                        {
                            k = k * t;
                        }
                        if (k == x)
                        {
                            e = t.ToString();
                            break;
                        }
                    }

                    break;
            }

            return e;
        }

        public string sqrt(float s)
        {
            string i = "/(*>*)/";
            for (int x = 0; x < s; x++)
            {
                if (x * x == s)
                {
                    i = x.ToString();
                }

            }

            return i;
        }

        public string negative(string s)
        {
            return (0 - float.Parse(s)).ToString();
        }

        public string opposite(string s)
        {
            return (1 / float.Parse(s)).ToString();
        }

        public string procent(string s, float x)
        {
            return (x / 100 * float.Parse(s)).ToString();
        }

        public string sqr(string s)
        {
            return (float.Parse(s) * float.Parse(s)).ToString();
        }

        public string factorial(string s)
        {
            float w = 1;

            for (int t = 1; t <= float.Parse(s); t++)
            {
                w = w * t;
            }

            return w.ToString();
        }

        public string ten(string s)
        {
            float u = 1;

            if (s == "")
            {
                u = 0;
            }
            else
            {
                for (int t = 1; t <= float.Parse(s); t++)
                {
                    u = u * 10;
                }

            }

            return u.ToString();
        }
        //----------CONVERT------------------------------------
                //---10----
        public string conv10to2(string s)
        {
            string p = string.Empty;
            int d = int.Parse(s);

            while (d > 0)
            {
                p = p + (d % 2);
                d = d / 2;
            }

            return reverse(p);
        }
        public string conv10to8(string s)
        {
            string p = string.Empty;
            int n = int.Parse(s);

            while (n > 0)
            {
                p = p + (n % 8);
                n = n / 8;
            }

            return reverse(p);
        }
        public string conv10to16(string s)
        {
            string p = string.Empty;
            int n = int.Parse(s);
            string q = "ABCDEF";

            while (n > 0)
            {
                if ((n % 16) < 10)
                {
                    p = (n % 16) + p;
                }
                else
                {
                    p = p + q[n % 16 - 10];
                }

                n = n / 16;
            }

            return p;
        }
                //---2-----
        public string conv2to10(string s)
        {
            float k = 1;
            float e = 0;

            for (int x = Nelength(s) - 1; x >= 0; x--)
            {
                e = float.Parse(s[x].ToString()) * k + e;
                k = k * 2;
            }

            return e.ToString();
        }
        public string conv2to8(string s)
        {
            string k = string.Empty;
            k = k + conv10to8(conv2to10(s));
            return k;
        }
        public string conv2to16(string s)
        {
            string k = string.Empty;
            k = k + conv10to16(conv2to10(s));
            return k;
        }
                //---8-----
        public string conv8to2(string s)
        {
            string k = string.Empty;
            k = k + conv10to2(conv8to10(s));
            return k;
        }
        public string conv8to10(string s)
        {
            float k = 1;
            float e = 0;

            for (int x = Nelength(s)-1; x >= 0; x--)
            {
                e = e + float.Parse(s[x].ToString()) * k;
                k = k * 8;
            }

            return e.ToString();
        }
        public string conv8to16(string s)
        {
            string k = string.Empty;
            k = k + conv10to16(conv8to10(s));
            return k;
        }
                //---16----
        public string conv16to2(string s)
        {
            string k = string.Empty;
            k = k + conv10to2(conv16to10(s));
            return k;
        }
        public string conv16to8(string s)
        {
            string k = string.Empty;
            k = k + conv10to8(conv16to10(s));
            return k;
        }
        public string conv16to10(string s)
        {
            float k = 1;
            float e = 0;
            string t = string.Empty;

            for (int x = Nelength(s)-1; x >= 0; x--)
            {
                t = s[x].ToString();

                switch (t)
                {
                    case "A":
                        t = "10";
                        break;
                    case "B":
                        t = "11";
                        break;
                    case "C":
                        t = "12";
                        break;
                    case "D":
                        t = "13";
                        break;
                    case "E":
                        t = "14";
                        break;
                    case "F":
                        t = "15";
                        break;

                }
                e = e + float.Parse(t) * k;
                k = k * 16;
            }

            return e.ToString();
        
        }
        //-----------------------------------------------------
       
    }
    

    partial class Form1
    {
        private Rinswind l = null;

        float x = 0;
        string y = string.Empty;
        float m = 0;

        string hal = string.Empty; // system covrert
        
      

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(151, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(116, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(116, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(116, 129);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(33, 29);
            this.button10.TabIndex = 11;
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(116, 98);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(33, 29);
            this.button12.TabIndex = 13;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(11, 99);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(33, 29);
            this.button13.TabIndex = 18;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(46, 99);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(33, 29);
            this.button14.TabIndex = 19;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(11, 129);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(33, 29);
            this.button15.TabIndex = 20;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(81, 98);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(33, 29);
            this.button16.TabIndex = 21;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(46, 129);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(33, 29);
            this.button17.TabIndex = 22;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(46, 159);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(33, 29);
            this.button18.TabIndex = 23;
            this.button18.Text = "8";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(11, 159);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(33, 29);
            this.button19.TabIndex = 24;
            this.button19.Text = "7";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(81, 129);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(33, 29);
            this.button20.TabIndex = 25;
            this.button20.Text = "6";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(81, 159);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(33, 29);
            this.button21.TabIndex = 26;
            this.button21.Text = "9";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(11, 189);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(68, 29);
            this.button22.TabIndex = 27;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(81, 189);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(33, 29);
            this.button23.TabIndex = 28;
            this.button23.Text = ",";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(47, 67);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(33, 29);
            this.button24.TabIndex = 29;
            this.button24.Text = "CE";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(82, 67);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(33, 29);
            this.button25.TabIndex = 35;
            this.button25.Text = "C";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(11, 67);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(33, 29);
            this.button26.TabIndex = 36;
            this.button26.Text = "<--";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(117, 36);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(33, 29);
            this.button27.TabIndex = 37;
            this.button27.Text = "M+";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(11, 36);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(33, 29);
            this.button28.TabIndex = 38;
            this.button28.Text = "MC";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(47, 36);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(33, 29);
            this.button29.TabIndex = 39;
            this.button29.Text = "MR";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(152, 36);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(33, 29);
            this.button30.TabIndex = 40;
            this.button30.Text = "M-";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "M";
            this.label2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 29);
            this.button3.TabIndex = 43;
            this.button3.Text = "+/-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 29);
            this.button4.TabIndex = 44;
            this.button4.Text = "sqrt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(151, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 29);
            this.button8.TabIndex = 46;
            this.button8.Text = "1/x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(151, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 29);
            this.button9.TabIndex = 47;
            this.button9.Text = "%";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 48;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(245, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 49;
            this.radioButton1.Text = "bin";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(245, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 50;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "dec";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 28);
            this.button2.TabIndex = 53;
            this.button2.Text = "x^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(240, 190);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 29);
            this.button11.TabIndex = 54;
            this.button11.Text = "n!";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(285, 159);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(43, 28);
            this.button31.TabIndex = 55;
            this.button31.Text = "y_sqrt";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(285, 128);
            this.button32.Name = "button32";
            this.button32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button32.Size = new System.Drawing.Size(43, 28);
            this.button32.TabIndex = 56;
            this.button32.Text = "x^y";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(240, 159);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(43, 28);
            this.button33.TabIndex = 57;
            this.button33.Text = "10^x";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 17);
            this.radioButton3.TabIndex = 62;
            this.radioButton3.Text = "oct";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(245, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 63;
            this.radioButton4.Text = "hex";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button34
            // 
            this.button34.Enabled = false;
            this.button34.Location = new System.Drawing.Point(194, 36);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(33, 29);
            this.button34.TabIndex = 64;
            this.button34.Text = "A";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Enabled = false;
            this.button35.Location = new System.Drawing.Point(194, 66);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(33, 29);
            this.button35.TabIndex = 65;
            this.button35.Text = "B";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Enabled = false;
            this.button36.Location = new System.Drawing.Point(194, 97);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(33, 29);
            this.button36.TabIndex = 66;
            this.button36.Text = "C";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Enabled = false;
            this.button37.Location = new System.Drawing.Point(194, 159);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(33, 29);
            this.button37.TabIndex = 67;
            this.button37.Text = "E";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Enabled = false;
            this.button38.Location = new System.Drawing.Point(194, 128);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(33, 29);
            this.button38.TabIndex = 68;
            this.button38.Text = "D";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Enabled = false;
            this.button39.Location = new System.Drawing.Point(194, 190);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(33, 29);
            this.button39.TabIndex = 69;
            this.button39.Text = "F";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 227);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
    }
}

