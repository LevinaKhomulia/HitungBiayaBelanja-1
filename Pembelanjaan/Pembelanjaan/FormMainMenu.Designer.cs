﻿namespace Pembelanjaan
{
    partial class FormMainMenu
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
<<<<<<< HEAD
=======
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            this.btnhitung = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.btnRefresh = new System.Windows.Forms.Button();
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
<<<<<<< HEAD
=======
            this.Quantity,
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            this.Harga,
            this.Pajak});
            this.dataGridView1.Location = new System.Drawing.Point(12, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
<<<<<<< HEAD
            this.dataGridView1.Size = new System.Drawing.Size(664, 362);
            this.dataGridView1.TabIndex = 71;
            // 
=======
            this.dataGridView1.Size = new System.Drawing.Size(678, 362);
            this.dataGridView1.TabIndex = 71;
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.Name = "Nama";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            // 
            // Pajak
            // 
            this.Pajak.HeaderText = "Pajak";
            this.Pajak.Name = "Pajak";
            // 
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            // btnhitung
            // 
            this.btnhitung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhitung.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhitung.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhitung.Location = new System.Drawing.Point(524, 237);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(102, 48);
            this.btnhitung.TabIndex = 70;
            this.btnhitung.Text = "Hitung ";
            this.btnhitung.UseVisualStyleBackColor = false;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhapus.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhapus.Location = new System.Drawing.Point(373, 237);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(103, 48);
            this.btnhapus.TabIndex = 69;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnedit.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnedit.Location = new System.Drawing.Point(221, 237);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 48);
            this.btnedit.TabIndex = 68;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btntambah.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.Control;
            this.btntambah.Location = new System.Drawing.Point(79, 237);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(110, 48);
            this.btntambah.TabIndex = 67;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(233, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 23);
            this.label10.TabIndex = 66;
            this.label10.Text = "Harga Murah , Untung Banyak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(73, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "DAFTAR BARANG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(73, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "MENU ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pembelanjaan.Properties.Resources.logo_pocket_shop;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
            // Kode
            // 
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            this.Kode.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // Pajak
            // 
            this.Pajak.HeaderText = "Pajak (%)";
            this.Pajak.Name = "Pajak";
            this.Pajak.ReadOnly = true;
=======
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(546, 308);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 35);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pembelanjaan.Properties.Resources.white_lights_backgroundfree_christmas_light_background_from_depositphotoscom_10steps_xybsnuqs;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(786, 744);
=======
            this.ClientSize = new System.Drawing.Size(702, 744);
            this.Controls.Add(this.btnRefresh);
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(79, 12);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Text = "Form Main Menu";
=======
            this.Text = "FormMainMenu";
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pajak;
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pajak;
        private System.Windows.Forms.Button btnRefresh;
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
    }
}