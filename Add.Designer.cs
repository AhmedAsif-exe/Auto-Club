namespace Auto_Club
{
    partial class Add
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
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox9
            // 
            textBox9.Location = new Point(850, 323);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(850, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 47;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(297, 398);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(297, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 44;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(956, 500);
            button3.Name = "button3";
            button3.Size = new Size(111, 47);
            button3.TabIndex = 43;
            button3.Text = "SAVE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(578, 249);
            label6.Name = "label6";
            label6.Size = new Size(249, 37);
            label6.TabIndex = 41;
            label6.Text = "Engine Number:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(562, 316);
            label5.Name = "label5";
            label5.Size = new Size(264, 37);
            label5.TabIndex = 40;
            label5.Text = "Chassis Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(167, 389);
            label4.Name = "label4";
            label4.Size = new Size(103, 37);
            label4.TabIndex = 39;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 321);
            label3.Name = "label3";
            label3.Size = new Size(112, 37);
            label3.TabIndex = 38;
            label3.Text = "Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 251);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 37;
            label2.Text = "Maker:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 131);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 36;
            label1.Text = "Car Number: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(464, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 31);
            textBox1.TabIndex = 35;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(48, 48);
            button1.Name = "button1";
            button1.Size = new Size(111, 47);
            button1.TabIndex = 50;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 588);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}