namespace Lab_13
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
            plus = new Button();
            returnbox = new TextBox();
            add1 = new TextBox();
            panel1 = new Panel();
            clear = new Button();
            output = new Label();
            add2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plus
            // 
            plus.Location = new Point(165, 3);
            plus.Name = "plus";
            plus.Size = new Size(25, 23);
            plus.TabIndex = 0;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // returnbox
            // 
            returnbox.BackColor = SystemColors.Control;
            returnbox.BorderStyle = BorderStyle.None;
            returnbox.Location = new Point(126, 277);
            returnbox.Name = "returnbox";
            returnbox.Size = new Size(100, 16);
            returnbox.TabIndex = 1;
            returnbox.TextChanged += textBox1_TextChanged;
            // 
            // add1
            // 
            add1.Location = new Point(3, 3);
            add1.Name = "add1";
            add1.PlaceholderText = "number 1";
            add1.Size = new Size(100, 23);
            add1.TabIndex = 2;
            add1.TextChanged += textBox1_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(clear);
            panel1.Controls.Add(output);
            panel1.Controls.Add(add2);
            panel1.Controls.Add(add1);
            panel1.Controls.Add(plus);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 3;
            // 
            // clear
            // 
            clear.Location = new Point(140, 140);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(150, 100);
            output.Name = "output";
            output.Size = new Size(54, 15);
            output.TabIndex = 4;
            output.Text = "= output";
            output.TextAlign = ContentAlignment.MiddleCenter;
            output.Click += label1_Click;
            // 
            // add2
            // 
            add2.Location = new Point(257, 3);
            add2.Name = "add2";
            add2.PlaceholderText = "number 2";
            add2.Size = new Size(100, 23);
            add2.TabIndex = 3;
            add2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            Controls.Add(returnbox);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plus;
        private TextBox returnbox;
        private TextBox add1;
        private Panel panel1;
        private TextBox add2;
        private Label output;
        private Button clear;
    }
}