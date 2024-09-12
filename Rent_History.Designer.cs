namespace Auto_Club
{
    partial class Rent_History
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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(66, 42);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(969, 360);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(973, 542);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(641, 100);
            label12.Name = "label12";
            label12.Size = new Size(60, 38);
            label12.TabIndex = 65;
            label12.Text = "To:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(99, 100);
            label11.Name = "label11";
            label11.Size = new Size(100, 38);
            label11.TabIndex = 64;
            label11.Text = "From:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(727, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 62;
            // 
            // Rent_History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 588);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Rent_History";
            Text = "Rent_History";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label12;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}