namespace Mobile_Ririer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status_cmbo = new System.Windows.Forms.ComboBox();
            this.sn_txt = new System.Windows.Forms.TextBox();
            this.pattern_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobile_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mcard_chck = new System.Windows.Forms.CheckBox();
            this.physicl_chck = new System.Windows.Forms.CheckBox();
            this.waterdmage_chck = new System.Windows.Forms.CheckBox();
            this.power_chck = new System.Windows.Forms.CheckBox();
            this.btry_chck = new System.Windows.Forms.CheckBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.balance_txt = new System.Windows.Forms.TextBox();
            this.repairPrice_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stotal_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paid_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.assign_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.datetime_choser = new System.Windows.Forms.DateTimePicker();
            this.print_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RepairID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coustomer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Device S/N";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.status_cmbo);
            this.groupBox1.Controls.Add(this.sn_txt);
            this.groupBox1.Controls.Add(this.pattern_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mobile_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // status_cmbo
            // 
            this.status_cmbo.FormattingEnabled = true;
            this.status_cmbo.Items.AddRange(new object[] {
            "Select Status",
            "Pending",
            "Complete"});
            this.status_cmbo.Location = new System.Drawing.Point(90, 107);
            this.status_cmbo.Name = "status_cmbo";
            this.status_cmbo.Size = new System.Drawing.Size(176, 21);
            this.status_cmbo.TabIndex = 9;
            // 
            // sn_txt
            // 
            this.sn_txt.Location = new System.Drawing.Point(90, 54);
            this.sn_txt.Name = "sn_txt";
            this.sn_txt.Size = new System.Drawing.Size(176, 20);
            this.sn_txt.TabIndex = 8;
            // 
            // pattern_txt
            // 
            this.pattern_txt.Location = new System.Drawing.Point(90, 82);
            this.pattern_txt.Name = "pattern_txt";
            this.pattern_txt.Size = new System.Drawing.Size(176, 20);
            this.pattern_txt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // mobile_txt
            // 
            this.mobile_txt.Location = new System.Drawing.Point(90, 28);
            this.mobile_txt.Name = "mobile_txt";
            this.mobile_txt.Size = new System.Drawing.Size(176, 20);
            this.mobile_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pattern";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(121, 23);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(176, 20);
            this.id_txt.TabIndex = 5;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(121, 49);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(176, 20);
            this.name_txt.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mcard_chck);
            this.groupBox2.Controls.Add(this.physicl_chck);
            this.groupBox2.Controls.Add(this.waterdmage_chck);
            this.groupBox2.Controls.Add(this.power_chck);
            this.groupBox2.Controls.Add(this.btry_chck);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 147);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Condition";
            // 
            // mcard_chck
            // 
            this.mcard_chck.AutoSize = true;
            this.mcard_chck.Location = new System.Drawing.Point(9, 123);
            this.mcard_chck.Name = "mcard_chck";
            this.mcard_chck.Size = new System.Drawing.Size(88, 17);
            this.mcard_chck.TabIndex = 4;
            this.mcard_chck.Text = "Memory Card";
            this.mcard_chck.UseVisualStyleBackColor = true;
            // 
            // physicl_chck
            // 
            this.physicl_chck.AutoSize = true;
            this.physicl_chck.Location = new System.Drawing.Point(9, 100);
            this.physicl_chck.Name = "physicl_chck";
            this.physicl_chck.Size = new System.Drawing.Size(108, 17);
            this.physicl_chck.TabIndex = 3;
            this.physicl_chck.Text = "Physical Damage";
            this.physicl_chck.UseVisualStyleBackColor = true;
            // 
            // waterdmage_chck
            // 
            this.waterdmage_chck.AutoSize = true;
            this.waterdmage_chck.Location = new System.Drawing.Point(9, 77);
            this.waterdmage_chck.Name = "waterdmage_chck";
            this.waterdmage_chck.Size = new System.Drawing.Size(98, 17);
            this.waterdmage_chck.TabIndex = 2;
            this.waterdmage_chck.Text = "Water Damage";
            this.waterdmage_chck.UseVisualStyleBackColor = true;
            // 
            // power_chck
            // 
            this.power_chck.AutoSize = true;
            this.power_chck.Location = new System.Drawing.Point(9, 54);
            this.power_chck.Name = "power_chck";
            this.power_chck.Size = new System.Drawing.Size(73, 17);
            this.power_chck.TabIndex = 1;
            this.power_chck.Text = "Power On";
            this.power_chck.UseVisualStyleBackColor = true;
            // 
            // btry_chck
            // 
            this.btry_chck.AutoSize = true;
            this.btry_chck.Location = new System.Drawing.Point(9, 31);
            this.btry_chck.Name = "btry_chck";
            this.btry_chck.Size = new System.Drawing.Size(59, 17);
            this.btry_chck.TabIndex = 0;
            this.btry_chck.Text = "Battery";
            this.btry_chck.UseVisualStyleBackColor = true;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(390, 23);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(176, 20);
            this.phone_txt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.balance_txt);
            this.groupBox3.Controls.Add(this.repairPrice_txt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.stotal_txt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.paid_txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(332, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 141);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Billing Information";
            // 
            // balance_txt
            // 
            this.balance_txt.Location = new System.Drawing.Point(97, 108);
            this.balance_txt.Name = "balance_txt";
            this.balance_txt.Size = new System.Drawing.Size(225, 20);
            this.balance_txt.TabIndex = 15;
            // 
            // repairPrice_txt
            // 
            this.repairPrice_txt.Location = new System.Drawing.Point(97, 28);
            this.repairPrice_txt.Name = "repairPrice_txt";
            this.repairPrice_txt.Size = new System.Drawing.Size(225, 20);
            this.repairPrice_txt.TabIndex = 14;
            this.repairPrice_txt.TextChanged += new System.EventHandler(this.repairPrice_txt_TextChanged);
            this.repairPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repairPrice_txt_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sub Total";
            // 
            // stotal_txt
            // 
            this.stotal_txt.Location = new System.Drawing.Point(97, 54);
            this.stotal_txt.Name = "stotal_txt";
            this.stotal_txt.Size = new System.Drawing.Size(225, 20);
            this.stotal_txt.TabIndex = 16;
            this.stotal_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stotal_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Repair Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Paid";
            // 
            // paid_txt
            // 
            this.paid_txt.Location = new System.Drawing.Point(97, 82);
            this.paid_txt.Name = "paid_txt";
            this.paid_txt.Size = new System.Drawing.Size(225, 20);
            this.paid_txt.TabIndex = 13;
            this.paid_txt.TextChanged += new System.EventHandler(this.paid_txt_TextChanged);
            this.paid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Balance";
            // 
            // assign_txt
            // 
            this.assign_txt.Location = new System.Drawing.Point(406, 252);
            this.assign_txt.Name = "assign_txt";
            this.assign_txt.Size = new System.Drawing.Size(176, 20);
            this.assign_txt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Assaign";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date";
            // 
            // datetime_choser
            // 
            this.datetime_choser.Location = new System.Drawing.Point(406, 278);
            this.datetime_choser.Name = "datetime_choser";
            this.datetime_choser.Size = new System.Drawing.Size(200, 20);
            this.datetime_choser.TabIndex = 14;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(579, 372);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 23);
            this.print_btn.TabIndex = 15;
            this.print_btn.Text = "Print Bill";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 416);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.datetime_choser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.assign_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Repair";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox sn_txt;
        private System.Windows.Forms.TextBox pattern_txt;
        private System.Windows.Forms.TextBox mobile_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox mcard_chck;
        private System.Windows.Forms.CheckBox physicl_chck;
        private System.Windows.Forms.CheckBox waterdmage_chck;
        private System.Windows.Forms.CheckBox power_chck;
        private System.Windows.Forms.CheckBox btry_chck;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox balance_txt;
        private System.Windows.Forms.TextBox repairPrice_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stotal_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paid_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox assign_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datetime_choser;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.ComboBox status_cmbo;
    }
}

