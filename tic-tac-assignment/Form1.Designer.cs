﻿namespace tic_tac_assignment
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 92);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-B", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(203, 63);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 580);
            panel2.TabIndex = 1;
            // 
            // button9
            // 
            button9.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(389, 387);
            button9.Name = "button9";
            button9.Size = new Size(165, 165);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_click;
            // 
            // button8
            // 
            button8.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(210, 387);
            button8.Name = "button8";
            button8.Size = new Size(165, 165);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_click;
            // 
            // button7
            // 
            button7.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(32, 387);
            button7.Name = "button7";
            button7.Size = new Size(165, 165);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_click;
            // 
            // button6
            // 
            button6.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(389, 205);
            button6.Name = "button6";
            button6.Size = new Size(165, 165);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_click;
            // 
            // button5
            // 
            button5.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(210, 205);
            button5.Name = "button5";
            button5.Size = new Size(165, 165);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_click;
            // 
            // button4
            // 
            button4.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(32, 205);
            button4.Name = "button4";
            button4.Size = new Size(165, 165);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_click;
            // 
            // button3
            // 
            button3.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(389, 25);
            button3.Name = "button3";
            button3.Size = new Size(165, 165);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_click;
            // 
            // button2
            // 
            button2.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(209, 25);
            button2.Name = "button2";
            button2.Size = new Size(166, 165);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_click;
            // 
            // button1
            // 
            button1.Font = new Font("UD Digi Kyokasho NK-B", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(32, 25);
            button1.Name = "button1";
            button1.Size = new Size(165, 165);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 826);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
    }
}