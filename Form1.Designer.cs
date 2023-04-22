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
            SuspendLayout();
            // 
            // plus
            // 
            plus.Location = new Point(98, 171);
            plus.Name = "plus";
            plus.Size = new Size(25, 25);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(returnbox);
            Controls.Add(plus);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plus;
        private TextBox returnbox;
    }
}