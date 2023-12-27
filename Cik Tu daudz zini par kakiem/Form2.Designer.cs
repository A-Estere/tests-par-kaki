namespace Cik_Tu_daudz_zini_par_kakiem
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.butt1 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(5, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.Color.Peru;
            this.butt1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butt1.Location = new System.Drawing.Point(24, 542);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(221, 80);
            this.butt1.TabIndex = 2;
            this.butt1.Tag = "1";
            this.butt1.Text = "butt1";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.ParbauditAtbildesNotikumu);
            // 
            // butt2
            // 
            this.butt2.BackColor = System.Drawing.Color.Peru;
            this.butt2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butt2.Location = new System.Drawing.Point(297, 542);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(221, 80);
            this.butt2.TabIndex = 3;
            this.butt2.Tag = "2";
            this.butt2.Text = "butt2";
            this.butt2.UseVisualStyleBackColor = false;
            this.butt2.Click += new System.EventHandler(this.ParbauditAtbildesNotikumu);
            // 
            // butt3
            // 
            this.butt3.BackColor = System.Drawing.Color.Peru;
            this.butt3.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butt3.Location = new System.Drawing.Point(561, 542);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(221, 80);
            this.butt3.TabIndex = 4;
            this.butt3.Tag = "3";
            this.butt3.Text = "butt3";
            this.butt3.UseVisualStyleBackColor = false;
            this.butt3.Click += new System.EventHandler(this.ParbauditAtbildesNotikumu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Image = global::Cik_Tu_daudz_zini_par_kakiem.Properties.Resources.Pukes1;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(813, 648);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Cik Tu daudz zini par kaķiem?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button butt3;
    }
}