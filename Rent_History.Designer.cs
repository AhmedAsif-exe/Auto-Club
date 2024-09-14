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
            dateTimePicker3 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker4 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(44, 26);
            button2.Name = "button2";
            button2.Size = new Size(111, 47);
            button2.TabIndex = 13;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1531, 360);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1460, 586);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 11;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(978, 100);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(300, 31);
            dateTimePicker3.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(881, 96);
            label1.Name = "label1";
            label1.Size = new Size(64, 37);
            label1.TabIndex = 68;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(369, 94);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 67;
            label2.Text = "From:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(500, 100);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(300, 31);
            dateTimePicker4.TabIndex = 66;
            // 
            // Rent_History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1627, 645);
            Controls.Add(dateTimePicker3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Rent_History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent_History";
            Load += Rent_History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private DateTimePicker dateTimePicker3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker4;
    }
}