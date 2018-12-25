namespace GoodFood
{
    partial class Optiuni
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
            this.genMeniu = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tbBuget = new System.Windows.Forms.TextBox();
            this.tbNecesarZilnic2 = new System.Windows.Forms.TextBox();
            this.cmd = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPretTotal = new System.Windows.Forms.TextBox();
            this.tbKcalTotal = new System.Windows.Forms.TextBox();
            this.tbNecesarZilnic = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calcKcal = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.calcKcal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // genMeniu
            // 
            this.genMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(138)))));
            this.genMeniu.Controls.Add(this.label9);
            this.genMeniu.Controls.Add(this.label8);
            this.genMeniu.Controls.Add(this.dataGridView2);
            this.genMeniu.Controls.Add(this.button3);
            this.genMeniu.Controls.Add(this.tbBuget);
            this.genMeniu.Controls.Add(this.tbNecesarZilnic2);
            this.genMeniu.Location = new System.Drawing.Point(4, 22);
            this.genMeniu.Name = "genMeniu";
            this.genMeniu.Padding = new System.Windows.Forms.Padding(3);
            this.genMeniu.Size = new System.Drawing.Size(874, 341);
            this.genMeniu.TabIndex = 2;
            this.genMeniu.Text = "Generare meniu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Buget (peste 33 de lei)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Necesarul zilnic de kcal";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(52, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 248);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generează";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbBuget
            // 
            this.tbBuget.Location = new System.Drawing.Point(144, 52);
            this.tbBuget.Name = "tbBuget";
            this.tbBuget.Size = new System.Drawing.Size(100, 20);
            this.tbBuget.TabIndex = 1;
            // 
            // tbNecesarZilnic2
            // 
            this.tbNecesarZilnic2.Enabled = false;
            this.tbNecesarZilnic2.Location = new System.Drawing.Point(144, 26);
            this.tbNecesarZilnic2.Name = "tbNecesarZilnic2";
            this.tbNecesarZilnic2.Size = new System.Drawing.Size(100, 20);
            this.tbNecesarZilnic2.TabIndex = 0;
            // 
            // cmd
            // 
            this.cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(138)))));
            this.cmd.Controls.Add(this.button6);
            this.cmd.Controls.Add(this.label7);
            this.cmd.Controls.Add(this.label6);
            this.cmd.Controls.Add(this.label5);
            this.cmd.Controls.Add(this.button2);
            this.cmd.Controls.Add(this.tbPretTotal);
            this.cmd.Controls.Add(this.tbKcalTotal);
            this.cmd.Controls.Add(this.tbNecesarZilnic);
            this.cmd.Controls.Add(this.dataGridView1);
            this.cmd.Location = new System.Drawing.Point(4, 22);
            this.cmd.Name = "cmd";
            this.cmd.Padding = new System.Windows.Forms.Padding(3);
            this.cmd.Size = new System.Drawing.Size(874, 341);
            this.cmd.TabIndex = 1;
            this.cmd.Text = "Comanda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preț total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Necesar zilnic";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comandă";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPretTotal
            // 
            this.tbPretTotal.Enabled = false;
            this.tbPretTotal.Location = new System.Drawing.Point(698, 256);
            this.tbPretTotal.Name = "tbPretTotal";
            this.tbPretTotal.Size = new System.Drawing.Size(100, 20);
            this.tbPretTotal.TabIndex = 3;
            // 
            // tbKcalTotal
            // 
            this.tbKcalTotal.Enabled = false;
            this.tbKcalTotal.Location = new System.Drawing.Point(120, 275);
            this.tbKcalTotal.Name = "tbKcalTotal";
            this.tbKcalTotal.Size = new System.Drawing.Size(100, 20);
            this.tbKcalTotal.TabIndex = 2;
            // 
            // tbNecesarZilnic
            // 
            this.tbNecesarZilnic.Enabled = false;
            this.tbNecesarZilnic.Location = new System.Drawing.Point(120, 249);
            this.tbNecesarZilnic.Name = "tbNecesarZilnic";
            this.tbNecesarZilnic.Size = new System.Drawing.Size(100, 20);
            this.tbNecesarZilnic.TabIndex = 1;
            this.tbNecesarZilnic.TextChanged += new System.EventHandler(this.tbNecesarZilnic_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // calcKcal
            // 
            this.calcKcal.Controls.Add(this.pictureBox1);
            this.calcKcal.Controls.Add(this.label4);
            this.calcKcal.Controls.Add(this.label3);
            this.calcKcal.Controls.Add(this.label2);
            this.calcKcal.Controls.Add(this.label1);
            this.calcKcal.Controls.Add(this.button1);
            this.calcKcal.Controls.Add(this.textBox4);
            this.calcKcal.Controls.Add(this.textBox3);
            this.calcKcal.Controls.Add(this.textBox2);
            this.calcKcal.Controls.Add(this.textBox1);
            this.calcKcal.Location = new System.Drawing.Point(4, 22);
            this.calcKcal.Name = "calcKcal";
            this.calcKcal.Padding = new System.Windows.Forms.Padding(3);
            this.calcKcal.Size = new System.Drawing.Size(874, 341);
            this.calcKcal.TabIndex = 0;
            this.calcKcal.Text = "Calculator Kcal";
            this.calcKcal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Necesar zilnic (kcal)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Greutate (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Înălțime (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vârsta (ani)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculează";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(137, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calcKcal);
            this.tabControl1.Controls.Add(this.cmd);
            this.tabControl1.Controls.Add(this.genMeniu);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 367);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(330, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Deschide grafic";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodFood.Properties.Resources.calories_in_vegtable;
            this.pictureBox1.Location = new System.Drawing.Point(347, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 305);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 437);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.Text = "Optiuni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Optiuni_FormClosing);
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.genMeniu.ResumeLayout(false);
            this.genMeniu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cmd.ResumeLayout(false);
            this.cmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.calcKcal.ResumeLayout(false);
            this.calcKcal.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage genMeniu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbBuget;
        private System.Windows.Forms.TextBox tbNecesarZilnic2;
        private System.Windows.Forms.TabPage cmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPretTotal;
        private System.Windows.Forms.TextBox tbKcalTotal;
        private System.Windows.Forms.TextBox tbNecesarZilnic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage calcKcal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

    }
}