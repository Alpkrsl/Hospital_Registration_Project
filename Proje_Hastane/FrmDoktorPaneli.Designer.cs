namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtşifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmbbranş = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.lbltcc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Değ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Branş:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(128, 29);
            this.Txtad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(160, 22);
            this.Txtad.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(88, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ad:";
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(128, 60);
            this.Txtsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(160, 22);
            this.Txtsoyad.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "TC Kimlik No:";
            // 
            // Txtşifre
            // 
            this.Txtşifre.Location = new System.Drawing.Point(128, 150);
            this.Txtşifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtşifre.Name = "Txtşifre";
            this.Txtşifre.Size = new System.Drawing.Size(160, 22);
            this.Txtşifre.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Şifre:";
            // 
            // Cmbbranş
            // 
            this.Cmbbranş.FormattingEnabled = true;
            this.Cmbbranş.Location = new System.Drawing.Point(129, 90);
            this.Cmbbranş.Name = "Cmbbranş";
            this.Cmbbranş.Size = new System.Drawing.Size(159, 24);
            this.Cmbbranş.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 261);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnekle.Location = new System.Drawing.Point(128, 179);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(60, 23);
            this.btnekle.TabIndex = 56;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.Location = new System.Drawing.Point(228, 179);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(60, 23);
            this.btnsil.TabIndex = 57;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btngüncelle.Location = new System.Drawing.Point(128, 208);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(159, 26);
            this.btngüncelle.TabIndex = 58;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(128, 121);
            this.txttc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(160, 22);
            this.txttc.TabIndex = 60;
            // 
            // lbltcc
            // 
            this.lbltcc.AutoSize = true;
            this.lbltcc.Location = new System.Drawing.Point(128, 6);
            this.lbltcc.Name = "lbltcc";
            this.lbltcc.Size = new System.Drawing.Size(44, 16);
            this.lbltcc.TabIndex = 61;
            this.lbltcc.Text = "label4";
            this.lbltcc.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Değ
            // 
            this.Değ.AutoSize = true;
            this.Değ.Location = new System.Drawing.Point(242, 6);
            this.Değ.Name = "Değ";
            this.Değ.Size = new System.Drawing.Size(43, 16);
            this.Değ.TabIndex = 63;
            this.Değ.Text = "Değiş";
            this.Değ.Visible = false;
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(975, 268);
            this.Controls.Add(this.Değ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltcc);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cmbbranş);
            this.Controls.Add(this.Txtşifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtşifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmbbranş;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label lbltcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Değ;
    }
}