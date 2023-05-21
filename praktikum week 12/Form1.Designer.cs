namespace praktikum_week_12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenagerFoATeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl88 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxnama = new System.Windows.Forms.MaskedTextBox();
            this.tboxnopung = new System.Windows.Forms.MaskedTextBox();
            this.tboxposisi = new System.Windows.Forms.MaskedTextBox();
            this.tboxtinggi = new System.Windows.Forms.MaskedTextBox();
            this.tboxberat = new System.Windows.Forms.MaskedTextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cboxnegara = new System.Windows.Forms.ComboBox();
            this.cboxteam = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxid = new System.Windows.Forms.MaskedTextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.cbokedit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.cbokremove = new System.Windows.Forms.ComboBox();
            this.butedit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editMenagerFoATeamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1570, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.addPlayerToolStripMenuItem.Text = "add player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // editMenagerFoATeamToolStripMenuItem
            // 
            this.editMenagerFoATeamToolStripMenuItem.Name = "editMenagerFoATeamToolStripMenuItem";
            this.editMenagerFoATeamToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editMenagerFoATeamToolStripMenuItem.Text = "edit and remove";
            this.editMenagerFoATeamToolStripMenuItem.Click += new System.EventHandler(this.editMenagerFoATeamToolStripMenuItem_Click);
            // 
            // lbl88
            // 
            this.lbl88.AutoSize = true;
            this.lbl88.Location = new System.Drawing.Point(13, 67);
            this.lbl88.Name = "lbl88";
            this.lbl88.Size = new System.Drawing.Size(44, 16);
            this.lbl88.TabIndex = 1;
            this.lbl88.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor punggung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Negara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Posisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tinggi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tanggal lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Berat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nama team";
            // 
            // tboxnama
            // 
            this.tboxnama.Location = new System.Drawing.Point(171, 67);
            this.tboxnama.Name = "tboxnama";
            this.tboxnama.Size = new System.Drawing.Size(100, 22);
            this.tboxnama.TabIndex = 2;
            // 
            // tboxnopung
            // 
            this.tboxnopung.Location = new System.Drawing.Point(171, 98);
            this.tboxnopung.Name = "tboxnopung";
            this.tboxnopung.Size = new System.Drawing.Size(100, 22);
            this.tboxnopung.TabIndex = 2;
            // 
            // tboxposisi
            // 
            this.tboxposisi.Location = new System.Drawing.Point(171, 162);
            this.tboxposisi.Name = "tboxposisi";
            this.tboxposisi.Size = new System.Drawing.Size(100, 22);
            this.tboxposisi.TabIndex = 2;
            // 
            // tboxtinggi
            // 
            this.tboxtinggi.Location = new System.Drawing.Point(171, 195);
            this.tboxtinggi.Name = "tboxtinggi";
            this.tboxtinggi.Size = new System.Drawing.Size(100, 22);
            this.tboxtinggi.TabIndex = 2;
            // 
            // tboxberat
            // 
            this.tboxberat.Location = new System.Drawing.Point(171, 226);
            this.tboxberat.Name = "tboxberat";
            this.tboxberat.Size = new System.Drawing.Size(100, 22);
            this.tboxberat.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(397, 31);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(378, 372);
            this.dgv1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxnegara
            // 
            this.cboxnegara.FormattingEnabled = true;
            this.cboxnegara.Location = new System.Drawing.Point(171, 131);
            this.cboxnegara.Name = "cboxnegara";
            this.cboxnegara.Size = new System.Drawing.Size(121, 24);
            this.cboxnegara.TabIndex = 5;
            // 
            // cboxteam
            // 
            this.cboxteam.FormattingEnabled = true;
            this.cboxteam.Location = new System.Drawing.Point(171, 290);
            this.cboxteam.Name = "cboxteam";
            this.cboxteam.Size = new System.Drawing.Size(121, 24);
            this.cboxteam.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID player";
            // 
            // tboxid
            // 
            this.tboxid.Location = new System.Drawing.Point(171, 321);
            this.tboxid.Name = "tboxid";
            this.tboxid.Size = new System.Drawing.Size(100, 22);
            this.tboxid.TabIndex = 2;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(858, 82);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(342, 305);
            this.dgv2.TabIndex = 8;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(1206, 82);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3.Size = new System.Drawing.Size(352, 305);
            this.dgv3.TabIndex = 9;
            this.dgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellContentClick);
            // 
            // cbokedit
            // 
            this.cbokedit.FormattingEnabled = true;
            this.cbokedit.Location = new System.Drawing.Point(1079, 41);
            this.cbokedit.Name = "cbokedit";
            this.cbokedit.Size = new System.Drawing.Size(121, 24);
            this.cbokedit.TabIndex = 10;
            this.cbokedit.SelectionChangeCommitted += new System.EventHandler(this.cbokedit_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(981, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Team Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(855, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "EDITING";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(855, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "REMOVEING";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(981, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Team Name";
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(984, 448);
            this.dgv4.Name = "dgv4";
            this.dgv4.RowHeadersWidth = 51;
            this.dgv4.RowTemplate.Height = 24;
            this.dgv4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv4.Size = new System.Drawing.Size(574, 256);
            this.dgv4.TabIndex = 9;
            this.dgv4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv4_CellContentClick);
            // 
            // cbokremove
            // 
            this.cbokremove.FormattingEnabled = true;
            this.cbokremove.Location = new System.Drawing.Point(1079, 407);
            this.cbokremove.Name = "cbokremove";
            this.cbokremove.Size = new System.Drawing.Size(121, 24);
            this.cbokremove.TabIndex = 10;
            this.cbokremove.SelectionChangeCommitted += new System.EventHandler(this.cbokremove_SelectionChangeCommitted);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(1319, 42);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(75, 23);
            this.butedit.TabIndex = 4;
            this.butedit.Text = "EDIT";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1319, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "REMOVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 716);
            this.Controls.Add(this.cbokremove);
            this.Controls.Add(this.cbokedit);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboxteam);
            this.Controls.Add(this.cboxnegara);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tboxposisi);
            this.Controls.Add(this.tboxid);
            this.Controls.Add(this.tboxberat);
            this.Controls.Add(this.tboxnopung);
            this.Controls.Add(this.tboxtinggi);
            this.Controls.Add(this.tboxnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl88);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenagerFoATeamToolStripMenuItem;
        private System.Windows.Forms.Label lbl88;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tboxnama;
        private System.Windows.Forms.MaskedTextBox tboxnopung;
        private System.Windows.Forms.MaskedTextBox tboxposisi;
        private System.Windows.Forms.MaskedTextBox tboxtinggi;
        private System.Windows.Forms.MaskedTextBox tboxberat;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboxnegara;
        private System.Windows.Forms.ComboBox cboxteam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tboxid;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.ComboBox cbokedit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.ComboBox cbokremove;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.Button button3;
    }
}

