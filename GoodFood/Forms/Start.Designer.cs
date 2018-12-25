namespace GoodFood
{
    partial class Start
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
            this.btInreg = new System.Windows.Forms.Button();
            this.btAut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInreg
            // 
            this.btInreg.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btInreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btInreg.Location = new System.Drawing.Point(297, 40);
            this.btInreg.Name = "btInreg";
            this.btInreg.Size = new System.Drawing.Size(134, 36);
            this.btInreg.TabIndex = 0;
            this.btInreg.Text = "Înregistrare";
            this.btInreg.UseVisualStyleBackColor = true;
            this.btInreg.Click += new System.EventHandler(this.btInreg_Click);
            // 
            // btAut
            // 
            this.btAut.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btAut.Location = new System.Drawing.Point(297, 152);
            this.btAut.Name = "btAut";
            this.btAut.Size = new System.Drawing.Size(134, 36);
            this.btAut.TabIndex = 1;
            this.btAut.Text = "Autentificare";
            this.btAut.UseVisualStyleBackColor = true;
            this.btAut.Click += new System.EventHandler(this.btAut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Good Food";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::GoodFood.Properties.Resources.good_food_logo;
            this.ClientSize = new System.Drawing.Size(443, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAut);
            this.Controls.Add(this.btInreg);
            this.Name = "Start";
            this.Text = "Pagină de start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInreg;
        private System.Windows.Forms.Button btAut;
        private System.Windows.Forms.Label label1;

    }
}

