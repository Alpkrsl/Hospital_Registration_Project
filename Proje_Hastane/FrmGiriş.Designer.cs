﻿namespace Proje_Hastane
{
    partial class FrmGiriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiriş));
            this.Btndoktor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhasta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsekreter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btndoktor
            // 
            this.Btndoktor.Image = ((System.Drawing.Image)(resources.GetObject("Btndoktor.Image")));
            this.Btndoktor.Location = new System.Drawing.Point(13, 197);
            this.Btndoktor.Name = "Btndoktor";
            this.Btndoktor.Size = new System.Drawing.Size(312, 188);
            this.Btndoktor.TabIndex = 0;
            this.Btndoktor.UseVisualStyleBackColor = true;
            this.Btndoktor.Click += new System.EventHandler(this.Btndoktor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // btnhasta
            // 
            this.btnhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhasta.Image = ((System.Drawing.Image)(resources.GetObject("btnhasta.Image")));
            this.btnhasta.Location = new System.Drawing.Point(361, 197);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(312, 188);
            this.btnhasta.TabIndex = 2;
            this.btnhasta.UseVisualStyleBackColor = true;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // btnsekreter
            // 
            this.btnsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekreter.Image = ((System.Drawing.Image)(resources.GetObject("btnsekreter.Image")));
            this.btnsekreter.Location = new System.Drawing.Point(695, 197);
            this.btnsekreter.Name = "btnsekreter";
            this.btnsekreter.Size = new System.Drawing.Size(312, 188);
            this.btnsekreter.TabIndex = 4;
            this.btnsekreter.UseVisualStyleBackColor = true;
            this.btnsekreter.Click += new System.EventHandler(this.btnsekreter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 46.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 91);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sea Green Hospital";
            // 
            // FrmGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1023, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsekreter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btndoktor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmGiriş";
            this.Text = "Sea Green Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btndoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsekreter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

