﻿namespace Auto_Club
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
            button1.Location = new Point(79, 40);
            button1.Name = "button1";
            button1.Size = new Size(134, 47);
            button1.TabIndex = 51;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // curr_address
            // 
            curr_address.Location = new Point(193, 340);
            curr_address.Name = "curr_address";
            curr_address.Size = new Size(960, 31);
            curr_address.TabIndex = 50;
            curr_address.TextChanged += curr_address_TextChanged;
            // 
            // phone_address
            // 
            phone_address.Location = new Point(706, 273);
            phone_address.Name = "phone_address";
            phone_address.Size = new Size(447, 31);
            phone_address.TabIndex = 49;
            phone_address.TextChanged += phone_address_TextChanged;
            // 
            // phone_num
            // 
            phone_num.Location = new Point(960, 210);
            phone_num.Name = "phone_num";
            phone_num.Size = new Size(193, 31);
            phone_num.TabIndex = 48;
            phone_num.TextChanged += phone_num_TextChanged;
            // 
            // cnic
            // 
            cnic.Location = new Point(193, 270);
            cnic.Name = "cnic";
            cnic.Size = new Size(325, 31);
            cnic.TabIndex = 47;
            cnic.TextChanged += cnic_TextChanged;
            // 
            // parent_name
            // 
            parent_name.Location = new Point(563, 207);
            parent_name.Name = "parent_name";
            parent_name.Size = new Size(193, 31);
            parent_name.TabIndex = 46;
            parent_name.TextChanged += parent_name_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(193, 207);
            name.Name = "name";
            name.Size = new Size(193, 31);
            name.TabIndex = 45;
            name.TextChanged += name_TextChanged;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1020, 772);
            button3.Name = "button3";
            button3.Size = new Size(134, 47);
            button3.TabIndex = 44;
            button3.Text = "NEXT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(535, 276);
            label9.Name = "label9";
            label9.Size = new Size(165, 25);
            label9.TabIndex = 43;
            label9.Text = "Phone Number 2:";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(794, 213);
            label6.Name = "label6";
            label6.Size = new Size(162, 25);
            label6.TabIndex = 42;
            label6.Text = "Phone Number *:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 343);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 41;
            label5.Text = "Current Address*:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(117, 273);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 40;
            label4.Text = "CNIC *:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(409, 210);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 39;
            label3.Text = "Parent Name *:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 210);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 38;
            label2.Text = "Name *:";
            label2.Click += label2_Click;
            // 
            // g_current_address
            // 
            g_current_address.Location = new Point(340, 702);
            g_current_address.Name = "g_current_address";
            g_current_address.Size = new Size(813, 31);
            g_current_address.TabIndex = 63;
            g_current_address.TextChanged += g_current_address_TextChanged;
            // 
            // g_phone_address
            // 
            g_phone_address.Location = new Point(340, 645);
            g_phone_address.Name = "g_phone_address";
            g_phone_address.Size = new Size(813, 31);
            g_phone_address.TabIndex = 62;
            g_phone_address.TextChanged += g_phone_address_TextChanged;
            // 
            // g_num
            // 
            g_num.Location = new Point(813, 582);
            g_num.Name = "g_num";
            g_num.Size = new Size(340, 31);
            g_num.TabIndex = 61;
            g_num.TextChanged += g_num_TextChanged;
            // 
            // g_cnic
            // 
            g_cnic.Location = new Point(242, 582);
            g_cnic.Name = "g_cnic";
            g_cnic.Size = new Size(325, 31);
            g_cnic.TabIndex = 60;
            g_cnic.TextChanged += g_cnic_TextChanged;
            // 
            // g_parent_name
            // 
            g_parent_name.Location = new Point(813, 518);
            g_parent_name.Name = "g_parent_name";
            g_parent_name.Size = new Size(340, 31);
            g_parent_name.TabIndex = 59;
            g_parent_name.TextChanged += g_parent_name_TextChanged;
            // 
            // g_name
            // 
            g_name.Location = new Point(247, 515);
            g_name.Name = "g_name";
            g_name.Size = new Size(224, 31);
            g_name.TabIndex = 58;
            g_name.TextChanged += g_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 648);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 57;
            label1.Text = "Guarantor Phone Number 2:";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(563, 585);
            label7.Name = "label7";
            label7.Size = new Size(249, 25);
            label7.TabIndex = 56;
            label7.Text = "Guarantor Phone Number*:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(64, 712);
            label8.Name = "label8";
            label8.Size = new Size(261, 25);
            label8.TabIndex = 55;
            label8.Text = "Guarantor Current Address*:";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(64, 585);
            label10.Name = "label10";
            label10.Size = new Size(172, 25);
            label10.TabIndex = 54;
            label10.Text = "Guarantor CNIC *:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(573, 522);
            label11.Name = "label11";
            label11.Size = new Size(224, 25);
            label11.TabIndex = 53;
            label11.Text = "Guarantor Parent Name:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(64, 518);
            label12.Name = "label12";
            label12.Size = new Size(175, 25);
            label12.TabIndex = 52;
            label12.Text = "Guarantor Name *:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(79, 115);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(386, 55);
            label13.TabIndex = 64;
            label13.Text = "Customer Details : ";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(64, 445);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(385, 55);
            label14.TabIndex = 65;
            label14.Text = "Guarantor Details :";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1247, 862);
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