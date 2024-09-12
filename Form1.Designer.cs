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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 88);
            label1.Name = "label1";
            label1.Size = new Size(242, 43);
            label1.TabIndex = 2;
            label1.Text = "Car Number: ";
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(798, 99);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maker
            // 
            maker.AutoSize = true;
            maker.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            maker.Location = new Point(177, 201);
            maker.Name = "maker";
            maker.Size = new Size(105, 34);
            maker.TabIndex = 4;
            maker.Text = "Maker:";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            model.Location = new Point(177, 286);
            model.Name = "model";
            model.Size = new Size(106, 34);
            model.TabIndex = 5;
            model.Text = "Model:";
            // 
            // color
            // 
            color.AutoSize = true;
            color.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            color.Location = new Point(181, 379);
            color.Name = "color";
            color.Size = new Size(94, 34);
            color.TabIndex = 6;
            color.Text = "Color:";
            color.Click += color_Click;
            // 
            // chassis
            // 
            chassis.AutoSize = true;
            chassis.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            chassis.Location = new Point(511, 286);
            chassis.Name = "chassis";
            chassis.Size = new Size(241, 34);
            chassis.TabIndex = 7;
            chassis.Text = "Chassis Number:";
            // 
            // engine
            // 
            engine.AutoSize = true;
            engine.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            engine.Location = new Point(525, 379);
            engine.Name = "engine";
            engine.Size = new Size(227, 34);
            engine.TabIndex = 8;
            engine.Text = "Engine Number:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            status.Location = new Point(654, 201);
            status.Name = "status";
            status.Size = new Size(108, 34);
            status.TabIndex = 11;
            status.Text = "Status:";
            // 
            // button2
            // 
            button2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(901, 530);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "RENT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(53, 31);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 588);
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
            Name = "Form1";
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
    }
}