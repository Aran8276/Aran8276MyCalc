namespace MyCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            divideBtn = new Button();
            multBtn = new Button();
            minBtn = new Button();
            plsBtn = new Button();
            equalBtn = new Button();
            textBox1 = new TextBox();
            clearBtn = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(104, 336);
            button1.Name = "button1";
            button1.Size = new Size(80, 72);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(192, 336);
            button2.Name = "button2";
            button2.Size = new Size(80, 72);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(280, 336);
            button3.Name = "button3";
            button3.Size = new Size(80, 72);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(104, 248);
            button4.Name = "button4";
            button4.Size = new Size(80, 72);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(192, 248);
            button5.Name = "button5";
            button5.Size = new Size(80, 72);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(280, 248);
            button6.Name = "button6";
            button6.Size = new Size(80, 72);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.MenuHighlight;
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(104, 160);
            button7.Name = "button7";
            button7.Size = new Size(80, 72);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.MenuHighlight;
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(192, 160);
            button8.Name = "button8";
            button8.Size = new Size(80, 72);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.MenuHighlight;
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(280, 160);
            button9.Name = "button9";
            button9.Size = new Size(80, 72);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = SystemColors.Info;
            divideBtn.Cursor = Cursors.Hand;
            divideBtn.Location = new Point(368, 248);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(80, 72);
            divideBtn.TabIndex = 10;
            divideBtn.Text = ":";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            // 
            // multBtn
            // 
            multBtn.BackColor = SystemColors.Info;
            multBtn.Cursor = Cursors.Hand;
            multBtn.Location = new Point(368, 160);
            multBtn.Name = "multBtn";
            multBtn.Size = new Size(80, 72);
            multBtn.TabIndex = 11;
            multBtn.Text = "X";
            multBtn.UseVisualStyleBackColor = false;
            multBtn.Click += multBtn_Click;
            // 
            // minBtn
            // 
            minBtn.BackColor = SystemColors.Info;
            minBtn.Cursor = Cursors.Hand;
            minBtn.Location = new Point(16, 248);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(80, 72);
            minBtn.TabIndex = 12;
            minBtn.Text = "-";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += minBtn_Click;
            // 
            // plsBtn
            // 
            plsBtn.BackColor = SystemColors.Info;
            plsBtn.Cursor = Cursors.Hand;
            plsBtn.Location = new Point(16, 160);
            plsBtn.Name = "plsBtn";
            plsBtn.Size = new Size(80, 72);
            plsBtn.TabIndex = 13;
            plsBtn.Text = "+";
            plsBtn.UseVisualStyleBackColor = false;
            plsBtn.Click += plsBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.FromArgb(255, 192, 128);
            equalBtn.Cursor = Cursors.Hand;
            equalBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            equalBtn.Location = new Point(368, 336);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(80, 72);
            equalBtn.TabIndex = 14;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += button10_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI Variable Small Semibol", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 32);
            textBox1.MaxLength = 15;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 80);
            textBox1.TabIndex = 15;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(255, 192, 128);
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(16, 336);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(80, 72);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "AC";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.MenuHighlight;
            button10.Cursor = Cursors.Hand;
            button10.Location = new Point(104, 416);
            button10.Name = "button10";
            button10.Size = new Size(256, 72);
            button10.TabIndex = 17;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(460, 505);
            Controls.Add(button10);
            Controls.Add(clearBtn);
            Controls.Add(textBox1);
            Controls.Add(equalBtn);
            Controls.Add(plsBtn);
            Controls.Add(minBtn);
            Controls.Add(multBtn);
            Controls.Add(divideBtn);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Aran8276 First Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button divideBtn;
        private Button multBtn;
        private Button minBtn;
        private Button plsBtn;
        private Button equalBtn;
        private TextBox textBox1;
        private Button clearBtn;
        private Button button10;
    }
}