namespace AirportInadRegister
{
    partial class Calısanlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudeInadDataSet2 = new AirportInadRegister.GudeInadDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCalisanTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCalisanDogum = new System.Windows.Forms.MaskedTextBox();
            this.txtCalisanName = new System.Windows.Forms.TextBox();
            this.txtCalisanSurName = new System.Windows.Forms.TextBox();
            this.txtCalisanEmail = new System.Windows.Forms.TextBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.txtCalisanSil = new System.Windows.Forms.Button();
            this.calisanTableAdapter = new AirportInadRegister.GudeInadDataSet2TableAdapters.CalisanTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNumarasýDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gudeInadDataSet11 = new AirportInadRegister.GudeInadDataSet11();
            this.calisanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter1 = new AirportInadRegister.GudeInadDataSet11TableAdapters.CalisanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ısimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.telefonNumarasýDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            this.calisanBindingSource.DataSource = this.gudeInadDataSet2;
            // 
            // gudeInadDataSet2
            // 
            this.gudeInadDataSet2.DataSetName = "GudeInadDataSet2";
            this.gudeInadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(184, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(184, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-posta";
            // 
            // mskCalisanTel
            // 
            this.mskCalisanTel.Location = new System.Drawing.Point(245, 315);
            this.mskCalisanTel.Mask = "(999) 000-0000";
            this.mskCalisanTel.Name = "mskCalisanTel";
            this.mskCalisanTel.Size = new System.Drawing.Size(100, 20);
            this.mskCalisanTel.TabIndex = 6;
            // 
            // mskCalisanDogum
            // 
            this.mskCalisanDogum.Location = new System.Drawing.Point(112, 344);
            this.mskCalisanDogum.Mask = "00/00/0000";
            this.mskCalisanDogum.Name = "mskCalisanDogum";
            this.mskCalisanDogum.Size = new System.Drawing.Size(100, 20);
            this.mskCalisanDogum.TabIndex = 7;
            this.mskCalisanDogum.ValidatingType = typeof(System.DateTime);
            // 
            // txtCalisanName
            // 
            this.txtCalisanName.Location = new System.Drawing.Point(71, 287);
            this.txtCalisanName.Name = "txtCalisanName";
            this.txtCalisanName.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanName.TabIndex = 8;
            // 
            // txtCalisanSurName
            // 
            this.txtCalisanSurName.Location = new System.Drawing.Point(71, 315);
            this.txtCalisanSurName.Name = "txtCalisanSurName";
            this.txtCalisanSurName.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanSurName.TabIndex = 9;
            // 
            // txtCalisanEmail
            // 
            this.txtCalisanEmail.Location = new System.Drawing.Point(245, 287);
            this.txtCalisanEmail.Name = "txtCalisanEmail";
            this.txtCalisanEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanEmail.TabIndex = 10;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanEkle.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__2_;
            this.btnCalisanEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalisanEkle.Location = new System.Drawing.Point(245, 341);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(100, 65);
            this.btnCalisanEkle.TabIndex = 11;
            this.btnCalisanEkle.Text = "Kayıt";
            this.btnCalisanEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(460, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // txtCalisanId
            // 
            this.txtCalisanId.Location = new System.Drawing.Point(449, 314);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanId.TabIndex = 13;
            // 
            // txtCalisanSil
            // 
            this.txtCalisanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisanSil.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__4_;
            this.txtCalisanSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCalisanSil.Location = new System.Drawing.Point(587, 283);
            this.txtCalisanSil.Name = "txtCalisanSil";
            this.txtCalisanSil.Size = new System.Drawing.Size(91, 63);
            this.txtCalisanSil.TabIndex = 14;
            this.txtCalisanSil.Text = "Sil";
            this.txtCalisanSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtCalisanSil.UseVisualStyleBackColor = true;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 50;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 150;
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            this.girisTarihiDataGridViewTextBoxColumn.Width = 144;
            // 
            // telefonNumarasýDataGridViewTextBoxColumn
            // 
            this.telefonNumarasýDataGridViewTextBoxColumn.DataPropertyName = "TelefonNumarasý";
            this.telefonNumarasýDataGridViewTextBoxColumn.HeaderText = "TelefonNumarasý";
            this.telefonNumarasýDataGridViewTextBoxColumn.Name = "telefonNumarasýDataGridViewTextBoxColumn";
            this.telefonNumarasýDataGridViewTextBoxColumn.Width = 144;
            // 
            // gudeInadDataSet11
            // 
            this.gudeInadDataSet11.DataSetName = "GudeInadDataSet11";
            this.gudeInadDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource1
            // 
            this.calisanBindingSource1.DataMember = "Calisan";
            this.calisanBindingSource1.DataSource = this.gudeInadDataSet11;
            // 
            // calisanTableAdapter1
            // 
            this.calisanTableAdapter1.ClearBeforeFill = true;
            // 
            // Calısanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirportInadRegister.Properties.Resources.Celebi_Kanatli_renkli_Logo_zeminde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 407);
            this.Controls.Add(this.txtCalisanSil);
            this.Controls.Add(this.txtCalisanId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.txtCalisanEmail);
            this.Controls.Add(this.txtCalisanSurName);
            this.Controls.Add(this.txtCalisanName);
            this.Controls.Add(this.mskCalisanDogum);
            this.Controls.Add(this.mskCalisanTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Calısanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Calısanlar";
            this.Load += new System.EventHandler(this.Calısanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCalisanTel;
        private System.Windows.Forms.MaskedTextBox mskCalisanDogum;
        private System.Windows.Forms.TextBox txtCalisanName;
        private System.Windows.Forms.TextBox txtCalisanSurName;
        private System.Windows.Forms.TextBox txtCalisanEmail;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalisanId;
        private System.Windows.Forms.Button txtCalisanSil;
        private GudeInadDataSet2 gudeInadDataSet2;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private GudeInadDataSet2TableAdapters.CalisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNumarasýDataGridViewTextBoxColumn;
        private GudeInadDataSet11 gudeInadDataSet11;
        private System.Windows.Forms.BindingSource calisanBindingSource1;
        private GudeInadDataSet11TableAdapters.CalisanTableAdapter calisanTableAdapter1;
    }
}