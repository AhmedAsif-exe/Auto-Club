namespace Auto_Club
{
    partial class Customer
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
            button1 = new Button();
            curr_address = new TextBox();
            phone_address = new TextBox();
            phone_num = new TextBox();
            cnic = new TextBox();
            parent_name = new TextBox();
            name = new TextBox();
            button3 = new Button();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            g_current_address = new TextBox();
            g_phone_address = new TextBox();
            g_num = new TextBox();
            g_cnic = new TextBox();
            g_parent_name = new TextBox();
            g_name = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(55, 24);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 51;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // curr_address
            // 
            curr_address.Location = new Point(135, 204);
            curr_address.Margin = new Padding(2);
            curr_address.Name = "curr_address";
            curr_address.Size = new Size(673, 23);
            curr_address.TabIndex = 50;
            curr_address.TextChanged += curr_address_TextChanged;
            // 
            // phone_address
            // 
            phone_address.Location = new Point(494, 164);
            phone_address.Margin = new Padding(2);
            phone_address.Name = "phone_address";
            phone_address.Size = new Size(314, 23);
            phone_address.TabIndex = 49;
            phone_address.TextChanged += phone_address_TextChanged;
            // 
            // phone_num
            // 
            phone_num.Location = new Point(672, 126);
            phone_num.Margin = new Padding(2);
            phone_num.Name = "phone_num";
            phone_num.Size = new Size(136, 23);
            phone_num.TabIndex = 48;
            phone_num.TextChanged += phone_num_TextChanged;
            // 
            // cnic
            // 
            cnic.Location = new Point(135, 162);
            cnic.Margin = new Padding(2);
            cnic.Name = "cnic";
            cnic.Size = new Size(229, 23);
            cnic.TabIndex = 47;
            cnic.TextChanged += cnic_TextChanged;
            // 
            // parent_name
            // 
            parent_name.Location = new Point(394, 124);
            parent_name.Margin = new Padding(2);
            parent_name.Name = "parent_name";
            parent_name.Size = new Size(136, 23);
            parent_name.TabIndex = 46;
            parent_name.TextChanged += parent_name_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(135, 124);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(136, 23);
            name.TabIndex = 45;
            name.TextChanged += name_TextChanged;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(714, 463);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(94, 28);
            button3.TabIndex = 44;
            button3.Text = "NEXT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(381, 164);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 17);
            label9.TabIndex = 43;
            label9.Text = "Phone Address:";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(556, 128);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 42;
            label6.Text = "Phone Number *:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 206);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 41;
            label5.Text = "Current Address*:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 164);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 40;
            label4.Text = "CNIC *:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 126);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 39;
            label3.Text = "Parent Name *:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 38;
            label2.Text = "Name *:";
            label2.Click += label2_Click;
            // 
            // g_current_address
            // 
            g_current_address.Location = new Point(238, 421);
            g_current_address.Margin = new Padding(2);
            g_current_address.Name = "g_current_address";
            g_current_address.Size = new Size(570, 23);
            g_current_address.TabIndex = 63;
            g_current_address.TextChanged += g_current_address_TextChanged;
            // 
            // g_phone_address
            // 
            g_phone_address.Location = new Point(238, 387);
            g_phone_address.Margin = new Padding(2);
            g_phone_address.Name = "g_phone_address";
            g_phone_address.Size = new Size(570, 23);
            g_phone_address.TabIndex = 62;
            g_phone_address.TextChanged += g_phone_address_TextChanged;
            // 
            // g_num
            // 
            g_num.Location = new Point(569, 349);
            g_num.Margin = new Padding(2);
            g_num.Name = "g_num";
            g_num.Size = new Size(239, 23);
            g_num.TabIndex = 61;
            g_num.TextChanged += g_num_TextChanged;
            // 
            // g_cnic
            // 
            g_cnic.Location = new Point(182, 349);
            g_cnic.Margin = new Padding(2);
            g_cnic.Name = "g_cnic";
            g_cnic.Size = new Size(229, 23);
            g_cnic.TabIndex = 60;
            g_cnic.TextChanged += g_cnic_TextChanged;
            // 
            // g_parent_name
            // 
            g_parent_name.Location = new Point(569, 311);
            g_parent_name.Margin = new Padding(2);
            g_parent_name.Name = "g_parent_name";
            g_parent_name.Size = new Size(239, 23);
            g_parent_name.TabIndex = 59;
            g_parent_name.TextChanged += g_parent_name_TextChanged;
            // 
            // g_name
            // 
            g_name.Location = new Point(173, 309);
            g_name.Margin = new Padding(2);
            g_name.Name = "g_name";
            g_name.Size = new Size(158, 23);
            g_name.TabIndex = 58;
            g_name.TextChanged += g_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 389);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 17);
            label1.TabIndex = 57;
            label1.Text = "Guarantor Phone Address:";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(429, 355);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 17);
            label7.TabIndex = 56;
            label7.Text = "Guarantor Number*:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(45, 427);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(189, 17);
            label8.TabIndex = 55;
            label8.Text = "Guarantor Current Address*:";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(57, 355);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(121, 17);
            label10.TabIndex = 54;
            label10.Text = "Guarantor CNIC *:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(401, 313);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(164, 17);
            label11.TabIndex = 53;
            label11.Text = "Guarantor Parent Name:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(45, 311);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(127, 17);
            label12.TabIndex = 52;
            label12.Text = "Guarantor Name *:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(55, 69);
            label13.Name = "label13";
            label13.Size = new Size(258, 37);
            label13.TabIndex = 64;
            label13.Text = "Customer Details : ";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(45, 267);
            label14.Name = "label14";
            label14.Size = new Size(258, 37);
            label14.TabIndex = 65;
            label14.Text = "Guarantor Details :";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(873, 517);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(g_current_address);
            Controls.Add(g_phone_address);
            Controls.Add(g_num);
            Controls.Add(g_cnic);
            Controls.Add(g_parent_name);
            Controls.Add(g_name);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(curr_address);
            Controls.Add(phone_address);
            Controls.Add(phone_num);
            Controls.Add(cnic);
            Controls.Add(parent_name);
            Controls.Add(name);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox curr_address;
        private TextBox phone_address;
        private TextBox phone_num;
        private TextBox cnic;
        private TextBox parent_name;
        private TextBox name;
        private Button button3;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox g_current_address;
        private TextBox g_phone_address;
        private TextBox g_num;
        private TextBox g_cnic;
        private TextBox g_parent_name;
        private TextBox g_name;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}