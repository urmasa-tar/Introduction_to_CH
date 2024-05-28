
namespace Calculator
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
            textBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button6 = new Button();
            button9 = new Button();
            button10 = new Button();
            button_to_rad = new Button();
            button0 = new Button();
            button_pls = new Button();
            button_mns = new Button();
            button_mlt = new Button();
            button_div = new Button();
            button_full_clean = new Button();
            button_sin = new Button();
            button_cos = new Button();
            button_tg = new Button();
            button_ctg = new Button();
            button_clean_last_chr = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox.Location = new Point(12, 38);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(331, 52);
            textBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(28, 121);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 121);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(173, 121);
            button3.Name = "button3";
            button3.Size = new Size(52, 40);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(28, 175);
            button4.Name = "button4";
            button4.Size = new Size(50, 40);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(102, 176);
            button5.Name = "button5";
            button5.Size = new Size(50, 40);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(28, 239);
            button7.Name = "button7";
            button7.Size = new Size(50, 37);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(102, 239);
            button8.Name = "button8";
            button8.Size = new Size(50, 37);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Location = new Point(173, 178);
            button6.Name = "button6";
            button6.Size = new Size(52, 37);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.Location = new Point(173, 239);
            button9.Name = "button9";
            button9.Size = new Size(52, 37);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(384, 40);
            button10.Name = "button10";
            button10.Size = new Size(82, 44);
            button10.TabIndex = 10;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = true;
            // 
            // button_to_rad
            // 
            button_to_rad.Location = new Point(503, 40);
            button_to_rad.Name = "button_to_rad";
            button_to_rad.Size = new Size(52, 29);
            button_to_rad.TabIndex = 11;
            button_to_rad.Text = "rad";
            button_to_rad.UseVisualStyleBackColor = true;
            button_to_rad.Click += button_to_rad__Click;
            // 
            // button0
            // 
            button0.Location = new Point(102, 297);
            button0.Name = "button0";
            button0.Size = new Size(50, 37);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button_pls
            // 
            button_pls.Location = new Point(265, 121);
            button_pls.Name = "button_pls";
            button_pls.Size = new Size(78, 40);
            button_pls.TabIndex = 13;
            button_pls.Text = "+";
            button_pls.UseVisualStyleBackColor = true;
            // 
            // button_mns
            // 
            button_mns.Location = new Point(265, 175);
            button_mns.Name = "button_mns";
            button_mns.Size = new Size(78, 40);
            button_mns.TabIndex = 14;
            button_mns.Text = "-";
            button_mns.UseVisualStyleBackColor = true;
            // 
            // button_mlt
            // 
            button_mlt.Location = new Point(265, 236);
            button_mlt.Name = "button_mlt";
            button_mlt.Size = new Size(78, 40);
            button_mlt.TabIndex = 15;
            button_mlt.Text = "*";
            button_mlt.UseVisualStyleBackColor = true;
            // 
            // button_div
            // 
            button_div.Location = new Point(265, 294);
            button_div.Name = "button_div";
            button_div.Size = new Size(78, 40);
            button_div.TabIndex = 16;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            // 
            // button_full_clean
            // 
            button_full_clean.Location = new Point(477, 121);
            button_full_clean.Name = "button_full_clean";
            button_full_clean.Size = new Size(78, 40);
            button_full_clean.TabIndex = 17;
            button_full_clean.Text = "clean";
            button_full_clean.UseVisualStyleBackColor = true;
            // 
            // button_sin
            // 
            button_sin.Location = new Point(384, 121);
            button_sin.Name = "button_sin";
            button_sin.Size = new Size(78, 40);
            button_sin.TabIndex = 18;
            button_sin.Text = "sin(x)";
            button_sin.UseVisualStyleBackColor = true;
            // 
            // button_cos
            // 
            button_cos.Location = new Point(384, 178);
            button_cos.Name = "button_cos";
            button_cos.Size = new Size(78, 40);
            button_cos.TabIndex = 19;
            button_cos.Text = "cos(x)";
            button_cos.UseVisualStyleBackColor = true;
            // 
            // button_tg
            // 
            button_tg.Location = new Point(384, 236);
            button_tg.Name = "button_tg";
            button_tg.Size = new Size(78, 40);
            button_tg.TabIndex = 20;
            button_tg.Text = "tg(x)";
            button_tg.UseVisualStyleBackColor = true;
            // 
            // button_ctg
            // 
            button_ctg.Location = new Point(384, 294);
            button_ctg.Name = "button_ctg";
            button_ctg.Size = new Size(78, 40);
            button_ctg.TabIndex = 21;
            button_ctg.Text = "ctg(x)";
            button_ctg.UseVisualStyleBackColor = true;
            // 
            // button_clean_last_chr
            // 
            button_clean_last_chr.Location = new Point(506, 75);
            button_clean_last_chr.Name = "button_clean_last_chr";
            button_clean_last_chr.Size = new Size(49, 29);
            button_clean_last_chr.TabIndex = 22;
            button_clean_last_chr.Text = "<=";
            button_clean_last_chr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 356);
            Controls.Add(button_clean_last_chr);
            Controls.Add(button_ctg);
            Controls.Add(button_tg);
            Controls.Add(button_cos);
            Controls.Add(button_sin);
            Controls.Add(button_full_clean);
            Controls.Add(button_div);
            Controls.Add(button_mlt);
            Controls.Add(button_mns);
            Controls.Add(button_pls);
            Controls.Add(button0);
            Controls.Add(button_to_rad);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button_to_rad__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button6;
        private Button button9;
        private Button button10;
        private Button button_to_rad;
        private Button button0;
        private Button button_pls;
        private Button button_mns;
        private Button button_mlt;
        private Button button_div;
        private Button button_full_clean;
        private Button button_sin;
        private Button button_cos;
        private Button button_tg;
        private Button button_ctg;
        private Button button_clean_last_chr;
    }
}
