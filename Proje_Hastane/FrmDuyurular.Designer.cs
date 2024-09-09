namespace Proje_Hastane
{
    partial class FrmDuyurular
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSekreteradd = new System.Windows.Forms.Label();
            this.lblSekretertcc = new System.Windows.Forms.Label();
            this.lblSekreterDeğişkenn = new System.Windows.Forms.Label();
            this.lbldoktortc = new System.Windows.Forms.Label();
            this.lbldoktoradsoyad = new System.Windows.Forms.Label();
            this.lbldoktordeğişken = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doktor";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sekreter";
            this.label2.Visible = false;
            // 
            // lblSekreteradd
            // 
            this.lblSekreteradd.AutoSize = true;
            this.lblSekreteradd.Location = new System.Drawing.Point(174, 18);
            this.lblSekreteradd.Name = "lblSekreteradd";
            this.lblSekreteradd.Size = new System.Drawing.Size(44, 16);
            this.lblSekreteradd.TabIndex = 27;
            this.lblSekreteradd.Text = "label6";
            this.lblSekreteradd.Visible = false;
            // 
            // lblSekretertcc
            // 
            this.lblSekretertcc.AutoSize = true;
            this.lblSekretertcc.Location = new System.Drawing.Point(160, 7);
            this.lblSekretertcc.Name = "lblSekretertcc";
            this.lblSekretertcc.Size = new System.Drawing.Size(44, 16);
            this.lblSekretertcc.TabIndex = 28;
            this.lblSekretertcc.Text = "label7";
            this.lblSekretertcc.Visible = false;
            // 
            // lblSekreterDeğişkenn
            // 
            this.lblSekreterDeğişkenn.AutoSize = true;
            this.lblSekreterDeğişkenn.Location = new System.Drawing.Point(125, 18);
            this.lblSekreterDeğişkenn.Name = "lblSekreterDeğişkenn";
            this.lblSekreterDeğişkenn.Size = new System.Drawing.Size(43, 16);
            this.lblSekreterDeğişkenn.TabIndex = 29;
            this.lblSekreterDeğişkenn.Text = "Değiş";
            this.lblSekreterDeğişkenn.Visible = false;
            // 
            // lbldoktortc
            // 
            this.lbldoktortc.AutoSize = true;
            this.lbldoktortc.Location = new System.Drawing.Point(57, 2);
            this.lbldoktortc.Name = "lbldoktortc";
            this.lbldoktortc.Size = new System.Drawing.Size(44, 16);
            this.lbldoktortc.TabIndex = 30;
            this.lbldoktortc.Text = "label3";
            this.lbldoktortc.Visible = false;
            // 
            // lbldoktoradsoyad
            // 
            this.lbldoktoradsoyad.AutoSize = true;
            this.lbldoktoradsoyad.Location = new System.Drawing.Point(107, 2);
            this.lbldoktoradsoyad.Name = "lbldoktoradsoyad";
            this.lbldoktoradsoyad.Size = new System.Drawing.Size(44, 16);
            this.lbldoktoradsoyad.TabIndex = 31;
            this.lbldoktoradsoyad.Text = "label4";
            this.lbldoktoradsoyad.Visible = false;
            // 
            // lbldoktordeğişken
            // 
            this.lbldoktordeğişken.AutoSize = true;
            this.lbldoktordeğişken.Location = new System.Drawing.Point(210, 2);
            this.lbldoktordeğişken.Name = "lbldoktordeğişken";
            this.lbldoktordeğişken.Size = new System.Drawing.Size(50, 16);
            this.lbldoktordeğişken.TabIndex = 32;
            this.lbldoktordeğişken.Text = "Değişş";
            this.lbldoktordeğişken.Visible = false;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(299, 314);
            this.Controls.Add(this.lbldoktordeğişken);
            this.Controls.Add(this.lbldoktoradsoyad);
            this.Controls.Add(this.lbldoktortc);
            this.Controls.Add(this.lblSekreterDeğişkenn);
            this.Controls.Add(this.lblSekretertcc);
            this.Controls.Add(this.lblSekreteradd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDuyurular";
            this.Text = "FrmDuyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSekreteradd;
        private System.Windows.Forms.Label lblSekretertcc;
        private System.Windows.Forms.Label lblSekreterDeğişkenn;
        private System.Windows.Forms.Label lbldoktortc;
        private System.Windows.Forms.Label lbldoktoradsoyad;
        private System.Windows.Forms.Label lbldoktordeğişken;
    }
}