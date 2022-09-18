namespace ExcelVeriOkumaveYazdirma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnDosyasec = new System.Windows.Forms.Button();
            this.btnSeciliKayitlariAktar = new System.Windows.Forms.Button();
            this.comboBoxSayfalar = new System.Windows.Forms.ComboBox();
            this.btnTümKayitlariAktar = new System.Windows.Forms.Button();
            this.tbVeri1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1655, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayfalar";
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(108, 469);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(178, 22);
            this.txtDosyaAdi.TabIndex = 3;
            // 
            // btnDosyasec
            // 
            this.btnDosyasec.Location = new System.Drawing.Point(310, 469);
            this.btnDosyasec.Name = "btnDosyasec";
            this.btnDosyasec.Size = new System.Drawing.Size(170, 68);
            this.btnDosyasec.TabIndex = 5;
            this.btnDosyasec.Text = "Dosya Seç";
            this.btnDosyasec.UseVisualStyleBackColor = true;
            this.btnDosyasec.Click += new System.EventHandler(this.btnDosyasec_Click);
            // 
            // btnSeciliKayitlariAktar
            // 
            this.btnSeciliKayitlariAktar.Location = new System.Drawing.Point(885, 469);
            this.btnSeciliKayitlariAktar.Name = "btnSeciliKayitlariAktar";
            this.btnSeciliKayitlariAktar.Size = new System.Drawing.Size(170, 67);
            this.btnSeciliKayitlariAktar.TabIndex = 6;
            this.btnSeciliKayitlariAktar.Text = "Seçili Kayıtları Aktar";
            this.btnSeciliKayitlariAktar.UseVisualStyleBackColor = true;
            this.btnSeciliKayitlariAktar.Click += new System.EventHandler(this.btnSeciliKayitlariAktar_Click);
            // 
            // comboBoxSayfalar
            // 
            this.comboBoxSayfalar.FormattingEnabled = true;
            this.comboBoxSayfalar.Location = new System.Drawing.Point(108, 512);
            this.comboBoxSayfalar.Name = "comboBoxSayfalar";
            this.comboBoxSayfalar.Size = new System.Drawing.Size(178, 24);
            this.comboBoxSayfalar.TabIndex = 7;
            this.comboBoxSayfalar.SelectedIndexChanged += new System.EventHandler(this.comboBoxSayfalar_SelectedIndexChanged);
            // 
            // btnTümKayitlariAktar
            // 
            this.btnTümKayitlariAktar.Location = new System.Drawing.Point(496, 469);
            this.btnTümKayitlariAktar.Name = "btnTümKayitlariAktar";
            this.btnTümKayitlariAktar.Size = new System.Drawing.Size(170, 69);
            this.btnTümKayitlariAktar.TabIndex = 8;
            this.btnTümKayitlariAktar.Text = "Tüm Kayıtları Aktar";
            this.btnTümKayitlariAktar.UseVisualStyleBackColor = true;
            this.btnTümKayitlariAktar.Click += new System.EventHandler(this.btnTümKayitlariAktar_Click);
            // 
            // tbVeri1
            // 
            this.tbVeri1.Location = new System.Drawing.Point(686, 482);
            this.tbVeri1.Name = "tbVeri1";
            this.tbVeri1.Size = new System.Drawing.Size(178, 22);
            this.tbVeri1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 568);
            this.Controls.Add(this.tbVeri1);
            this.Controls.Add(this.btnTümKayitlariAktar);
            this.Controls.Add(this.comboBoxSayfalar);
            this.Controls.Add(this.btnSeciliKayitlariAktar);
            this.Controls.Add(this.btnDosyasec);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Button btnDosyasec;
        private System.Windows.Forms.Button btnSeciliKayitlariAktar;
        private System.Windows.Forms.ComboBox comboBoxSayfalar;
        private System.Windows.Forms.Button btnTümKayitlariAktar;
        private System.Windows.Forms.TextBox tbVeri1;
    }
}

