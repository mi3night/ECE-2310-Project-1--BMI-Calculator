using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;






namespace test
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            Label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainpanel = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 67, 88);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 450);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 67, 88);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 67, 88);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 50, 65);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 50, 65);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 231);
            button4.Name = "button4";
            button4.Size = new Size(154, 50);
            button4.TabIndex = 5;
            button4.Text = "Credits";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 67, 88);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 67, 88);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(231, 76, 60);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 62);
            button3.Name = "button3";
            button3.Size = new Size(154, 50);
            button3.TabIndex = 4;
            button3.Text = "Main Menu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 67, 88);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 67, 88);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 55, 236);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 55, 236);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 174);
            button2.Name = "button2";
            button2.Size = new Size(154, 51);
            button2.TabIndex = 3;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 67, 88);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 67, 88);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(253, 116, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 116, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 118);
            button1.Name = "button1";
            button1.Size = new Size(154, 50);
            button1.TabIndex = 2;
            button1.Text = "Calculate (imperial)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 52, 65);
            panel2.Controls.Add(Label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 68);
            panel2.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(3, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(130, 50);
            Label1.TabIndex = 1;
            Label1.Text = "BMI \r\nCalculator";
            Label1.Click += label1_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(26, 26, 26);
            mainpanel.Controls.Add(label2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(154, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(646, 450);
            mainpanel.TabIndex = 1;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(118, 50);
            label2.Name = "label2";
            label2.Size = new Size(393, 102);
            label2.TabIndex = 1;
            label2.Text = "WELCOME TO THE \r\nBMI CALCULATOR\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "BMI Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Label1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel mainpanel;
        private Label label2;
    }
}