namespace Auto_Club
{
    partial class Form1
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            maker = new Label();
            model = new Label();
            color = new Label();
            chassis = new Label();
            engine = new Label();
            status = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 16);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 2;
            label1.Text = "Car Number: ";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(559, 59);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 3;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maker
            // 
            maker.AutoSize = true;
            maker.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            maker.Location = new Point(124, 121);
            maker.Margin = new Padding(2, 0, 2, 0);
            maker.Name = "maker";
            maker.Size = new Size(73, 24);
            maker.TabIndex = 4;
            maker.Text = "Maker:";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            model.Location = new Point(124, 172);
            model.Margin = new Padding(2, 0, 2, 0);
            model.Name = "model";
            model.Size = new Size(74, 24);
            model.TabIndex = 5;
            model.Text = "Model:";
            // 
            // color
            // 
            color.AutoSize = true;
            color.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            color.Location = new Point(127, 227);
            color.Margin = new Padding(2, 0, 2, 0);
            color.Name = "color";
            color.Size = new Size(66, 24);
            color.TabIndex = 6;
            color.Text = "Color:";
            color.Click += color_Click;
            // 
            // chassis
            // 
            chassis.AutoSize = true;
            chassis.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            chassis.Location = new Point(358, 172);
            chassis.Margin = new Padding(2, 0, 2, 0);
            chassis.Name = "chassis";
            chassis.Size = new Size(169, 24);
            chassis.TabIndex = 7;
            chassis.Text = "Chassis Number:";
            // 
            // engine
            // 
            engine.AutoSize = true;
            engine.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            engine.Location = new Point(368, 227);
            engine.Margin = new Padding(2, 0, 2, 0);
            engine.Name = "engine";
            engine.Size = new Size(164, 24);
            engine.TabIndex = 8;
            engine.Text = "Engine Number:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            status.Location = new Point(458, 121);
            status.Margin = new Padding(2, 0, 2, 0);
            status.Name = "status";
            status.Size = new Size(72, 24);
            status.TabIndex = 11;
            status.Text = "Status:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(631, 318);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 28);
            button2.TabIndex = 12;
            button2.Text = "RENT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(37, 19);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 28);
            button3.TabIndex = 13;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 353);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(status);
            Controls.Add(engine);
            Controls.Add(chassis);
            Controls.Add(color);
            Controls.Add(model);
            Controls.Add(maker);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label maker;
        private Label model;
        private Label color;
        private Label chassis;
        private Label engine;
        private Label status;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
    }
}