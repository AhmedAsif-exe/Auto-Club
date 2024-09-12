namespace Auto_Club
{
    partial class Dashboard
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(285, 191);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(217, 38);
            button3.TabIndex = 2;
            button3.Text = "RENT HISTORY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(285, 124);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(217, 38);
            button2.TabIndex = 1;
            button2.Text = "CUSTOMERS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(285, 57);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(217, 39);
            button1.TabIndex = 0;
            button1.Text = "RENT A CAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(285, 251);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(217, 38);
            button4.TabIndex = 3;
            button4.Text = "CARS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 353);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}