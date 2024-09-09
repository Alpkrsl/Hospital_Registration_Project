namespace Proje_Hastane
{
    partial class FrmBranşpaneli
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
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.Değiş = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btngüncelle.Location = new System.Drawing.Point(90, 137);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(159, 26);
            this.btngüncelle.TabIndex = 72;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.Location = new System.Drawing.Point(188, 108);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(61, 23);
            this.btnsil.TabIndex = 71;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnekle.Location = new System.Drawing.Point(90, 108);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(60, 23);
            this.btnekle.TabIndex = 70;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 151);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(89, 24);
            this.Txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(160, 22);
            this.Txtid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Branş id:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(89, 66);
            this.Txtad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(160, 22);
            this.Txtad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Branş ad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(87, 1);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(44, 16);
            this.lbltc.TabIndex = 74;
            this.lbltc.Text = "label1";
            this.lbltc.Visible = false;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(137, 1);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(44, 16);
            this.lblad.TabIndex = 75;
            this.lblad.Text = "label2";
            this.lblad.Visible = false;
            // 
            // Değiş
            // 
            this.Değiş.AutoSize = true;
            this.Değiş.Location = new System.Drawing.Point(187, 1);
            this.Değiş.Name = "Değiş";
            this.Değiş.Size = new System.Drawing.Size(43, 16);
            this.Değiş.TabIndex = 76;
            this.Değiş.Text = "Değiş";
            this.Değiş.Visible = false;
            // 
            // FrmBranşpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(636, 178);
            this.Controls.Add(this.Değiş);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtad);
            this.Controls.Add(this.label5);
            this.Name = "FrmBranşpaneli";
            this.Text = "FrmBranşpaneli";
            this.Load += new System.EventHandler(this.FrmBranşpaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label Değiş;
    }
}