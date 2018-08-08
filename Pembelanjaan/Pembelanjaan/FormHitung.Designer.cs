namespace Pembelanjaan
{
    partial class FormHitung
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewHitung = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHitung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(526, 717);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 35);
            this.txtTotal.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(380, 720);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 104;
            this.label5.Text = "TOTAL :";
            // 
            // dataGridViewHitung
            // 
            this.dataGridViewHitung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHitung.Location = new System.Drawing.Point(93, 433);
            this.dataGridViewHitung.Name = "dataGridViewHitung";
            this.dataGridViewHitung.RowTemplate.Height = 24;
            this.dataGridViewHitung.Size = new System.Drawing.Size(633, 271);
            this.dataGridViewHitung.TabIndex = 103;
            this.dataGridViewHitung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pembelanjaan.Properties.Resources.smiley_PNG189;
            this.pictureBox2.Location = new System.Drawing.Point(586, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(184, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Hitung Biaya Pembelanjaan";
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnminus.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnminus.Location = new System.Drawing.Point(445, 392);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(38, 35);
            this.btnminus.TabIndex = 100;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnplus.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnplus.Location = new System.Drawing.Point(331, 392);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(40, 35);
            this.btnplus.TabIndex = 99;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnkembali
            // 
            this.btnkembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnkembali.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkembali.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkembali.Location = new System.Drawing.Point(93, 717);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(128, 48);
            this.btnkembali.TabIndex = 98;
            this.btnkembali.Text = "KEMBALI";
            this.btnkembali.UseVisualStyleBackColor = false;
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(598, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 48);
            this.btnSubmit.TabIndex = 97;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(377, 392);
            this.txtjumlah.Multiline = true;
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.ReadOnly = true;
            this.txtjumlah.Size = new System.Drawing.Size(49, 35);
            this.txtjumlah.TabIndex = 96;
            this.txtjumlah.Text = "0";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(331, 341);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.ReadOnly = true;
            this.txtnama.Size = new System.Drawing.Size(290, 35);
            this.txtnama.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(87, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 94;
            this.label4.Text = "JUMLAH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(84, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 36);
            this.label3.TabIndex = 93;
            this.label3.Text = "NAMA BARANG";
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(331, 291);
            this.txtkode.Multiline = true;
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(212, 35);
            this.txtkode.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(87, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 91;
            this.label2.Text = "KODE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(284, -39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 23);
            this.label10.TabIndex = 90;
            this.label10.Text = "Harga Murah , Untung Banyak";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pembelanjaan.Properties.Resources.logo_pocket_shop;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerate.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(561, 291);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(165, 36);
            this.btnGenerate.TabIndex = 106;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FormHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pembelanjaan.Properties.Resources.white_lights_backgroundfree_christmas_light_background_from_depositphotoscom_10steps_xybsnuqs;
            this.ClientSize = new System.Drawing.Size(829, 795);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewHitung);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHitung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHitung";
            this.Load += new System.EventHandler(this.FormHitung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHitung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewHitung;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerate;
    }
}