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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 88);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 2;
            label1.Text = "Car Number: ";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(799, 98);
            button1.Name = "button1";
            button1.Size = new Size(114, 47);
            button1.TabIndex = 3;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maker
            // 
            maker.AutoSize = true;
            maker.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            maker.Location = new Point(177, 202);
            maker.Name = "maker";
            maker.Size = new Size(106, 32);
            maker.TabIndex = 4;
            maker.Text = "Maker:";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            model.Location = new Point(177, 287);
            model.Name = "model";
            model.Size = new Size(106, 32);
            model.TabIndex = 5;
            model.Text = "Model:";
            // 
            // color
            // 
            color.AutoSize = true;
            color.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            color.Location = new Point(181, 378);
            color.Name = "color";
            color.Size = new Size(96, 32);
            color.TabIndex = 6;
            color.Text = "Color:";
            color.Click += color_Click;
            // 
            // chassis
            // 
            chassis.AutoSize = true;
            chassis.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            chassis.Location = new Point(511, 287);
            chassis.Name = "chassis";
            chassis.Size = new Size(245, 32);
            chassis.TabIndex = 7;
            chassis.Text = "Chassis Number:";
            // 
            // engine
            // 
            engine.AutoSize = true;
            engine.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            engine.Location = new Point(526, 378);
            engine.Name = "engine";
            engine.Size = new Size(233, 32);
            engine.TabIndex = 8;
            engine.Text = "Engine Number:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            status.Location = new Point(654, 202);
            status.Name = "status";
            status.Size = new Size(110, 32);
            status.TabIndex = 11;
            status.Text = "Status:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(799, 475);
            button2.Name = "button2";
            button2.Size = new Size(111, 47);
            button2.TabIndex = 12;
            button2.Text = "Rent";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(53, 32);
            button3.Name = "button3";
            button3.Size = new Size(111, 47);
            button3.TabIndex = 13;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 102);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(363, 33);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 588);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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