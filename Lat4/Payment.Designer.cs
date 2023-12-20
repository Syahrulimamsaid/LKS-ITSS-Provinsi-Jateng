namespace Lat4
{
    partial class Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.VEHICLETYPE = new System.Windows.Forms.ComboBox();
            this.PLATE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DATEOUT = new System.Windows.Forms.TextBox();
            this.TIMEOUT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TIMEIN = new System.Windows.Forms.TextBox();
            this.DATEIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AMOUNT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.HOURLY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PARDUR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MEMBERTYPE = new System.Windows.Forms.TextBox();
            this.OWNER = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VEHICLETYPE);
            this.panel1.Controls.Add(this.PLATE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 611);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VEHICLETYPE
            // 
            this.VEHICLETYPE.FormattingEnabled = true;
            this.VEHICLETYPE.Location = new System.Drawing.Point(159, 88);
            this.VEHICLETYPE.Name = "VEHICLETYPE";
            this.VEHICLETYPE.Size = new System.Drawing.Size(288, 24);
            this.VEHICLETYPE.TabIndex = 6;
            this.VEHICLETYPE.SelectedIndexChanged += new System.EventHandler(this.VEHICLETYPE_SelectedIndexChanged);
            // 
            // PLATE
            // 
            this.PLATE.Location = new System.Drawing.Point(159, 43);
            this.PLATE.Name = "PLATE";
            this.PLATE.Size = new System.Drawing.Size(288, 22);
            this.PLATE.TabIndex = 5;
            this.PLATE.TextChanged += new System.EventHandler(this.PLATE_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Plate";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.DATEOUT);
            this.panel4.Controls.Add(this.TIMEOUT);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(13, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 169);
            this.panel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "OUT";
            // 
            // DATEOUT
            // 
            this.DATEOUT.Location = new System.Drawing.Point(128, 71);
            this.DATEOUT.Name = "DATEOUT";
            this.DATEOUT.Size = new System.Drawing.Size(288, 22);
            this.DATEOUT.TabIndex = 14;
            this.DATEOUT.TextChanged += new System.EventHandler(this.DATEOUT_TextChanged);
            this.DATEOUT.Validating += new System.ComponentModel.CancelEventHandler(this.DATEOUT_Validating);
            // 
            // TIMEOUT
            // 
            this.TIMEOUT.Location = new System.Drawing.Point(128, 118);
            this.TIMEOUT.Name = "TIMEOUT";
            this.TIMEOUT.Size = new System.Drawing.Size(288, 22);
            this.TIMEOUT.TabIndex = 15;
            this.TIMEOUT.TextChanged += new System.EventHandler(this.TIMEOUT_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "TIME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "DATE";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TIMEIN);
            this.panel3.Controls.Add(this.DATEIN);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 169);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "IN ";
            // 
            // TIMEIN
            // 
            this.TIMEIN.Location = new System.Drawing.Point(128, 112);
            this.TIMEIN.Name = "TIMEIN";
            this.TIMEIN.Size = new System.Drawing.Size(288, 22);
            this.TIMEIN.TabIndex = 10;
            this.TIMEIN.TextChanged += new System.EventHandler(this.TIMEIN_TextChanged);
            // 
            // DATEIN
            // 
            this.DATEIN.Location = new System.Drawing.Point(128, 65);
            this.DATEIN.Name = "DATEIN";
            this.DATEIN.Size = new System.Drawing.Size(288, 22);
            this.DATEIN.TabIndex = 9;
            this.DATEIN.TextChanged += new System.EventHandler(this.DATEIN_TextChanged);
            this.DATEIN.Validating += new System.ComponentModel.CancelEventHandler(this.DATEIN_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "TIME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "PAYMENT";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AMOUNT);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.HOURLY);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.PARDUR);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(520, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 365);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AMOUNT
            // 
            this.AMOUNT.Location = new System.Drawing.Point(181, 213);
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(288, 22);
            this.AMOUNT.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Amount To Pay";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(448, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "X";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(14, 173);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(417, 10);
            this.panel6.TabIndex = 11;
            // 
            // HOURLY
            // 
            this.HOURLY.Location = new System.Drawing.Point(181, 122);
            this.HOURLY.Name = "HOURLY";
            this.HOURLY.Size = new System.Drawing.Size(288, 22);
            this.HOURLY.TabIndex = 14;
            this.HOURLY.TextChanged += new System.EventHandler(this.HOURLY_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Hourly Rate";
            // 
            // PARDUR
            // 
            this.PARDUR.Location = new System.Drawing.Point(181, 58);
            this.PARDUR.Name = "PARDUR";
            this.PARDUR.Size = new System.Drawing.Size(288, 22);
            this.PARDUR.TabIndex = 12;
            this.PARDUR.TextChanged += new System.EventHandler(this.PARDUR_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Parking Duration";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.MEMBERTYPE);
            this.panel5.Controls.Add(this.OWNER);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(520, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 199);
            this.panel5.TabIndex = 2;
            // 
            // MEMBERTYPE
            // 
            this.MEMBERTYPE.Location = new System.Drawing.Point(165, 119);
            this.MEMBERTYPE.Name = "MEMBERTYPE";
            this.MEMBERTYPE.Size = new System.Drawing.Size(288, 22);
            this.MEMBERTYPE.TabIndex = 10;
            // 
            // OWNER
            // 
            this.OWNER.Location = new System.Drawing.Point(165, 56);
            this.OWNER.Name = "OWNER";
            this.OWNER.Size = new System.Drawing.Size(288, 22);
            this.OWNER.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Member Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Owner";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 696);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox VEHICLETYPE;
        private System.Windows.Forms.TextBox PLATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DATEOUT;
        private System.Windows.Forms.TextBox TIMEOUT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TIMEIN;
        private System.Windows.Forms.TextBox DATEIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AMOUNT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox HOURLY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PARDUR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox MEMBERTYPE;
        private System.Windows.Forms.TextBox OWNER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}