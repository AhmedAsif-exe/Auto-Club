namespace Auto_Club
{
    partial class Login
    {
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 273);
            label1.Name = "label1";
            label1.Size = new Size(217, 43);
            label1.TabIndex = 7;
            label1.Text = "User Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(519, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 31);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 334);
            label2.Name = "label2";
            label2.Size = new Size(198, 43);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(519, 345);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(362, 31);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(491, 448);
            button1.Name = "button1";
            button1.Size = new Size(126, 43);
            button1.TabIndex = 10;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 588);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}