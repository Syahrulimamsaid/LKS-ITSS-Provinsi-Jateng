namespace Lat4
{
    partial class MasterVehicle
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.SMBDELETE = new System.Windows.Forms.Button();
            this.SMBUPDATE = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.SMBINSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.VEHICLETYPE = new System.Windows.Forms.ComboBox();
            this.NOTES = new System.Windows.Forms.RichTextBox();
            this.OWNER = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SEARCH = new System.Windows.Forms.ComboBox();
            this.CARI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PLATE = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(427, 550);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(146, 13);
            this.labelStatus.TabIndex = 50;
            this.labelStatus.Text = "This record is last modified at ";
            // 
            // SMBDELETE
            // 
            this.SMBDELETE.Location = new System.Drawing.Point(496, 372);
            this.SMBDELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SMBDELETE.Name = "SMBDELETE";
            this.SMBDELETE.Size = new System.Drawing.Size(78, 43);
            this.SMBDELETE.TabIndex = 49;
            this.SMBDELETE.Text = "SUBMIT";
            this.SMBDELETE.UseVisualStyleBackColor = true;
            this.SMBDELETE.Click += new System.EventHandler(this.SMBDELETE_Click);
            // 
            // SMBUPDATE
            // 
            this.SMBUPDATE.Location = new System.Drawing.Point(496, 372);
            this.SMBUPDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SMBUPDATE.Name = "SMBUPDATE";
            this.SMBUPDATE.Size = new System.Drawing.Size(78, 43);
            this.SMBUPDATE.TabIndex = 48;
            this.SMBUPDATE.Text = "SUBMIT";
            this.SMBUPDATE.UseVisualStyleBackColor = true;
            this.SMBUPDATE.Click += new System.EventHandler(this.SMBUPDATE_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(496, 441);
            this.CANCEL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(78, 43);
            this.CANCEL.TabIndex = 47;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // SMBINSERT
            // 
            this.SMBINSERT.Location = new System.Drawing.Point(496, 372);
            this.SMBINSERT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SMBINSERT.Name = "SMBINSERT";
            this.SMBINSERT.Size = new System.Drawing.Size(78, 43);
            this.SMBINSERT.TabIndex = 46;
            this.SMBINSERT.Text = "SUBMIT";
            this.SMBINSERT.UseVisualStyleBackColor = true;
            this.SMBINSERT.Click += new System.EventHandler(this.SMBINSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(404, 476);
            this.DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(78, 43);
            this.DELETE.TabIndex = 45;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(404, 401);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(78, 43);
            this.UPDATE.TabIndex = 44;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(404, 330);
            this.INSERT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(78, 43);
            this.INSERT.TabIndex = 43;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // VEHICLETYPE
            // 
            this.VEHICLETYPE.FormattingEnabled = true;
            this.VEHICLETYPE.Location = new System.Drawing.Point(122, 399);
            this.VEHICLETYPE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VEHICLETYPE.Name = "VEHICLETYPE";
            this.VEHICLETYPE.Size = new System.Drawing.Size(157, 21);
            this.VEHICLETYPE.TabIndex = 42;
            this.VEHICLETYPE.SelectedIndexChanged += new System.EventHandler(this.VEHICLETYPE_SelectedIndexChanged);
            // 
            // NOTES
            // 
            this.NOTES.Location = new System.Drawing.Point(122, 439);
            this.NOTES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NOTES.Name = "NOTES";
            this.NOTES.Size = new System.Drawing.Size(157, 56);
            this.NOTES.TabIndex = 38;
            this.NOTES.Text = "";
            // 
            // OWNER
            // 
            this.OWNER.Location = new System.Drawing.Point(122, 362);
            this.OWNER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OWNER.Name = "OWNER";
            this.OWNER.Size = new System.Drawing.Size(157, 20);
            this.OWNER.TabIndex = 35;
            this.OWNER.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "NOTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Owner";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "VEHICLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 200);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SEARCH
            // 
            this.SEARCH.FormattingEnabled = true;
            this.SEARCH.Location = new System.Drawing.Point(50, 49);
            this.SEARCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(86, 21);
            this.SEARCH.TabIndex = 53;
            this.SEARCH.TextChanged += new System.EventHandler(this.SEARCH_TextChanged);
            // 
            // CARI
            // 
            this.CARI.Location = new System.Drawing.Point(140, 49);
            this.CARI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CARI.Name = "CARI";
            this.CARI.Size = new System.Drawing.Size(157, 20);
            this.CARI.TabIndex = 52;
            this.CARI.TextChanged += new System.EventHandler(this.CARI_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "License Plate";
            // 
            // PLATE
            // 
            this.PLATE.BackColor = System.Drawing.Color.Black;
            this.PLATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLATE.ForeColor = System.Drawing.Color.White;
            this.PLATE.Location = new System.Drawing.Point(122, 299);
            this.PLATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PLATE.Name = "PLATE";
            this.PLATE.Size = new System.Drawing.Size(157, 45);
            this.PLATE.TabIndex = 55;
            this.PLATE.Text = "XX XXXX XX";
            // 
            // MasterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.PLATE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.CARI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.SMBDELETE);
            this.Controls.Add(this.SMBUPDATE);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SMBINSERT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.VEHICLETYPE);
            this.Controls.Add(this.NOTES);
            this.Controls.Add(this.OWNER);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterVehicle";
            this.Text = "MasterVehicle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button SMBDELETE;
        private System.Windows.Forms.Button SMBUPDATE;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button SMBINSERT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.ComboBox VEHICLETYPE;
        private System.Windows.Forms.RichTextBox NOTES;
        private System.Windows.Forms.TextBox OWNER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SEARCH;
        private System.Windows.Forms.TextBox CARI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PLATE;
    }
}