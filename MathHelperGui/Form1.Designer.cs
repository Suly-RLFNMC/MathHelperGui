namespace MathHelperGui
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(642, 466);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(634, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "2D shape area calc";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(266, 349);
            button4.Name = "button4";
            button4.Size = new Size(110, 40);
            button4.TabIndex = 3;
            button4.Text = "Triangle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(478, 180);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 2;
            button3.Text = "Circle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 52);
            button2.Name = "button2";
            button2.Size = new Size(108, 40);
            button2.TabIndex = 1;
            button2.Text = "Rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(50, 180);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 0;
            button1.Text = "Square";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(634, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "3D volume calc";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(634, 433);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Surface Area calc";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(634, 433);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Law of cosines";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(634, 433);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Pythagorean Theorem";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(253, 56);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "Cube";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(441, 190);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 1;
            button6.Text = "Cuboid";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(253, 327);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 2;
            button7.Text = "Sphere";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(73, 190);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 3;
            button8.Text = "Cone";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 471);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Math Helper";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
    }
}
