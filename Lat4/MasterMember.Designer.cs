namespace Lat4
{
    partial class MasterMember
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.HP = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.RichTextBox();
            this.DATE = new System.Windows.Forms.TextBox();
            this.MALE = new System.Windows.Forms.RadioButton();
            this.FEMALE = new System.Windows.Forms.RadioButton();
            this.MEMBERTYPE = new System.Windows.Forms.ComboBox();
            this.INSERT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.SMBINSERT = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.SMBUPDATE = new System.Windows.Forms.Button();
            this.SMBDELETE = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Membership Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gender";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(164, 316);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(208, 22);
            this.NAME.TabIndex = 9;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(164, 391);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(208, 22);
            this.EMAIL.TabIndex = 11;
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(164, 429);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(208, 22);
            this.HP.TabIndex = 12;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(164, 476);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(208, 68);
            this.ADDRESS.TabIndex = 13;
            this.ADDRESS.Text = "";
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(164, 556);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(208, 22);
            this.DATE.TabIndex = 14;
            this.DATE.TextChanged += new System.EventHandler(this.DATE_TextChanged);
            this.DATE.Validating += new System.ComponentModel.CancelEventHandler(this.DATE_Validating);
            // 
            // MALE
            // 
            this.MALE.AutoSize = true;
            this.MALE.Location = new System.Drawing.Point(164, 597);
            this.MALE.Name = "MALE";
            this.MALE.Size = new System.Drawing.Size(64, 20);
            this.MALE.TabIndex = 15;
            this.MALE.TabStop = true;
            this.MALE.Text = "MALE";
            this.MALE.UseVisualStyleBackColor = true;
            this.MALE.CheckedChanged += new System.EventHandler(this.MALE_CheckedChanged);
            // 
            // FEMALE
            // 
            this.FEMALE.AutoSize = true;
            this.FEMALE.Location = new System.Drawing.Point(262, 597);
            this.FEMALE.Name = "FEMALE";
            this.FEMALE.Size = new System.Drawing.Size(81, 20);
            this.FEMALE.TabIndex = 16;
            this.FEMALE.TabStop = true;
            this.FEMALE.Text = "FEMALE";
            this.FEMALE.UseVisualStyleBackColor = true;
            this.FEMALE.CheckedChanged += new System.EventHandler(this.FEMALE_CheckedChanged);
            // 
            // MEMBERTYPE
            // 
            this.MEMBERTYPE.FormattingEnabled = true;
            this.MEMBERTYPE.Location = new System.Drawing.Point(164, 355);
            this.MEMBERTYPE.Name = "MEMBERTYPE";
            this.MEMBERTYPE.Size = new System.Drawing.Size(208, 24);
            this.MEMBERTYPE.TabIndex = 17;
            this.MEMBERTYPE.SelectedIndexChanged += new System.EventHandler(this.MEMBERTYPE_SelectedIndexChanged);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(541, 363);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(104, 53);
            this.INSERT.TabIndex = 18;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(541, 451);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(104, 53);
            this.UPDATE.TabIndex = 19;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(541, 543);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(104, 53);
            this.DELETE.TabIndex = 20;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // SMBINSERT
            // 
            this.SMBINSERT.Location = new System.Drawing.Point(663, 414);
            this.SMBINSERT.Name = "SMBINSERT";
            this.SMBINSERT.Size = new System.Drawing.Size(104, 53);
            this.SMBINSERT.TabIndex = 21;
            this.SMBINSERT.Text = "SUBMIT";
            this.SMBINSERT.UseVisualStyleBackColor = true;
            this.SMBINSERT.Click += new System.EventHandler(this.SMBINSERT_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(663, 500);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(104, 53);
            this.CANCEL.TabIndex = 22;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // SMBUPDATE
            // 
            this.SMBUPDATE.Location = new System.Drawing.Point(663, 414);
            this.SMBUPDATE.Name = "SMBUPDATE";
            this.SMBUPDATE.Size = new System.Drawing.Size(104, 53);
            this.SMBUPDATE.TabIndex = 23;
            this.SMBUPDATE.Text = "SUBMIT";
            this.SMBUPDATE.UseVisualStyleBackColor = true;
            this.SMBUPDATE.Click += new System.EventHandler(this.SMBUPDATE_Click);
            // 
            // SMBDELETE
            // 
            this.SMBDELETE.Location = new System.Drawing.Point(663, 414);
            this.SMBDELETE.Name = "SMBDELETE";
            this.SMBDELETE.Size = new System.Drawing.Size(104, 53);
            this.SMBDELETE.TabIndex = 24;
            this.SMBDELETE.Text = "SUBMIT";
            this.SMBDELETE.UseVisualStyleBackColor = true;
            this.SMBDELETE.Click += new System.EventHandler(this.SMBDELETE_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(478, 671);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(184, 16);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "This record is last modified at ";
            // 
            // MasterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 696);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.SMBDELETE);
            this.Controls.Add(this.SMBUPDATE);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SMBINSERT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.MEMBERTYPE);
            this.Controls.Add(this.FEMALE);
            this.Controls.Add(this.MALE);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MasterMember";
            this.Text = "MasterMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.RichTextBox ADDRESS;
        private System.Windows.Forms.TextBox DATE;
        private System.Windows.Forms.RadioButton MALE;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.ComboBox MEMBERTYPE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button SMBINSERT;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button SMBUPDATE;
        private System.Windows.Forms.Button SMBDELETE;
        private System.Windows.Forms.Label labelStatus;
    }
}