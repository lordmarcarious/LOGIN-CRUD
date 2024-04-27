namespace LOGIN_CRUD
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            PASSWORD = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(295, 287);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 0;
            button1.Text = "SIGNUP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(238, 343);
            button2.Name = "button2";
            button2.Size = new Size(253, 37);
            button2.TabIndex = 1;
            button2.Text = "PRESS HERE IF YOU HAVE ACCOUNT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 38);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "USER NAME";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 42);
            textBox2.TabIndex = 5;
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Location = new Point(197, 137);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(68, 15);
            PASSWORD.TabIndex = 6;
            PASSWORD.Text = "PASSWORD";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 194);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 53);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 209);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 8;
            label3.Text = "CONFIRM PASSOWORD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 449);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(PASSWORD);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "REGISTRATION";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label PASSWORD;
        private TextBox textBox3;
        private Label label3;
    }
}
