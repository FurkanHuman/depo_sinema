namespace depo_sinema
{
    partial class Duzenle
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faditrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fadienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyapimyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kacincifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimdbpuaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyuklemetarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkayittarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDataSet = new depo_sinema.depoDataSet();
            this.s_depoTableAdapter = new depo_sinema.depoDataSetTableAdapters.s_depoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdepoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siraDataGridViewTextBoxColumn,
            this.faditrDataGridViewTextBoxColumn,
            this.fadienDataGridViewTextBoxColumn,
            this.fyapimyiliDataGridViewTextBoxColumn,
            this.kacincifDataGridViewTextBoxColumn,
            this.fimdbpuaniDataGridViewTextBoxColumn,
            this.fsuresiDataGridViewTextBoxColumn,
            this.fturuDataGridViewTextBoxColumn,
            this.fyuklemetarihDataGridViewTextBoxColumn,
            this.fkonusuDataGridViewTextBoxColumn,
            this.fkayittarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sdepoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 188);
            this.dataGridView1.TabIndex = 4;
            // 
            // siraDataGridViewTextBoxColumn
            // 
            this.siraDataGridViewTextBoxColumn.DataPropertyName = "sira";
            this.siraDataGridViewTextBoxColumn.HeaderText = "Sıra No";
            this.siraDataGridViewTextBoxColumn.Name = "siraDataGridViewTextBoxColumn";
            this.siraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faditrDataGridViewTextBoxColumn
            // 
            this.faditrDataGridViewTextBoxColumn.DataPropertyName = "f_adi_tr";
            this.faditrDataGridViewTextBoxColumn.HeaderText = "Türkçe Adı";
            this.faditrDataGridViewTextBoxColumn.Name = "faditrDataGridViewTextBoxColumn";
            this.faditrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fadienDataGridViewTextBoxColumn
            // 
            this.fadienDataGridViewTextBoxColumn.DataPropertyName = "f_adi_en";
            this.fadienDataGridViewTextBoxColumn.HeaderText = "İngilizce Adı";
            this.fadienDataGridViewTextBoxColumn.Name = "fadienDataGridViewTextBoxColumn";
            this.fadienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyapimyiliDataGridViewTextBoxColumn
            // 
            this.fyapimyiliDataGridViewTextBoxColumn.DataPropertyName = "f_yapim_yili";
            this.fyapimyiliDataGridViewTextBoxColumn.HeaderText = "Film Yapım Tarihi";
            this.fyapimyiliDataGridViewTextBoxColumn.Name = "fyapimyiliDataGridViewTextBoxColumn";
            this.fyapimyiliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kacincifDataGridViewTextBoxColumn
            // 
            this.kacincifDataGridViewTextBoxColumn.DataPropertyName = "Kacinci_f";
            this.kacincifDataGridViewTextBoxColumn.HeaderText = "Kaçıncı Film";
            this.kacincifDataGridViewTextBoxColumn.Name = "kacincifDataGridViewTextBoxColumn";
            this.kacincifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fimdbpuaniDataGridViewTextBoxColumn
            // 
            this.fimdbpuaniDataGridViewTextBoxColumn.DataPropertyName = "f_imdb_puani";
            this.fimdbpuaniDataGridViewTextBoxColumn.HeaderText = "İmdb Puani";
            this.fimdbpuaniDataGridViewTextBoxColumn.Name = "fimdbpuaniDataGridViewTextBoxColumn";
            this.fimdbpuaniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fsuresiDataGridViewTextBoxColumn
            // 
            this.fsuresiDataGridViewTextBoxColumn.DataPropertyName = "f_suresi";
            this.fsuresiDataGridViewTextBoxColumn.HeaderText = "Film Süresi";
            this.fsuresiDataGridViewTextBoxColumn.Name = "fsuresiDataGridViewTextBoxColumn";
            this.fsuresiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fturuDataGridViewTextBoxColumn
            // 
            this.fturuDataGridViewTextBoxColumn.DataPropertyName = "f_turu";
            this.fturuDataGridViewTextBoxColumn.HeaderText = "Film Türü";
            this.fturuDataGridViewTextBoxColumn.Name = "fturuDataGridViewTextBoxColumn";
            this.fturuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyuklemetarihDataGridViewTextBoxColumn
            // 
            this.fyuklemetarihDataGridViewTextBoxColumn.DataPropertyName = "f_yukleme_tarih";
            this.fyuklemetarihDataGridViewTextBoxColumn.HeaderText = "Yükleme Tarih";
            this.fyuklemetarihDataGridViewTextBoxColumn.Name = "fyuklemetarihDataGridViewTextBoxColumn";
            this.fyuklemetarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkonusuDataGridViewTextBoxColumn
            // 
            this.fkonusuDataGridViewTextBoxColumn.DataPropertyName = "f_konusu";
            this.fkonusuDataGridViewTextBoxColumn.HeaderText = "Konu";
            this.fkonusuDataGridViewTextBoxColumn.Name = "fkonusuDataGridViewTextBoxColumn";
            this.fkonusuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkayittarihDataGridViewTextBoxColumn
            // 
            this.fkayittarihDataGridViewTextBoxColumn.DataPropertyName = "f_kayit_tarih";
            this.fkayittarihDataGridViewTextBoxColumn.HeaderText = "Kayit Tarihi";
            this.fkayittarihDataGridViewTextBoxColumn.Name = "fkayittarihDataGridViewTextBoxColumn";
            this.fkayittarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sdepoBindingSource
            // 
            this.sdepoBindingSource.DataMember = "s_depo";
            this.sdepoBindingSource.DataSource = this.depoDataSetBindingSource;
            // 
            // depoDataSetBindingSource
            // 
            this.depoDataSetBindingSource.DataSource = this.depoDataSet;
            this.depoDataSetBindingSource.Position = 0;
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "depoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_depoTableAdapter
            // 
            this.s_depoTableAdapter.ClearBeforeFill = true;
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(646, 241);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Duzenle";
            this.Text = "Düzenle";
            this.Load += new System.EventHandler(this.Duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdepoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource depoDataSetBindingSource;
        private depoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource sdepoBindingSource;
        private depoDataSetTableAdapters.s_depoTableAdapter s_depoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faditrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fadienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyapimyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kacincifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimdbpuaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyuklemetarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkayittarihDataGridViewTextBoxColumn;
    }
}