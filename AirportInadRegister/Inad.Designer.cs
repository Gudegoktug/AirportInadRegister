namespace AirportInadRegister
{
    partial class Inad
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
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geldigiTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucusNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidecegiTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidecegiUcusNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refakatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınadCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınadYolcuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celebiInadDataSet5 = new AirportInadRegister.CelebiInadDataSet5();
            this.btnInadSil = new System.Windows.Forms.Button();
            this.txtInadId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inadYolcuTableAdapter = new AirportInadRegister.CelebiInadDataSet5TableAdapters.InadYolcuTableAdapter();
            this.gudeInadDataSet3 = new AirportInadRegister.GudeInadDataSet3();
            this.ınadYolcuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inadYolcuTableAdapter1 = new AirportInadRegister.GudeInadDataSet3TableAdapters.InadYolcuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadYolcuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadYolcuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ısimDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.uyrukDataGridViewTextBoxColumn,
            this.geldigiTarihDataGridViewTextBoxColumn,
            this.ucusNoDataGridViewTextBoxColumn,
            this.gidecegiTarihDataGridViewTextBoxColumn,
            this.gidecegiUcusNoDataGridViewTextBoxColumn,
            this.refakatDataGridViewTextBoxColumn,
            this.belgeNoDataGridViewTextBoxColumn,
            this.ınadCinsiyetDataGridViewTextBoxColumn,
            this.gelisSaatDataGridViewTextBoxColumn,
            this.gidisSaatDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ınadYolcuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            // 
            // dogumYeriDataGridViewTextBoxColumn
            // 
            this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
            // 
            // uyrukDataGridViewTextBoxColumn
            // 
            this.uyrukDataGridViewTextBoxColumn.DataPropertyName = "Uyruk";
            this.uyrukDataGridViewTextBoxColumn.HeaderText = "Uyruk";
            this.uyrukDataGridViewTextBoxColumn.Name = "uyrukDataGridViewTextBoxColumn";
            // 
            // geldigiTarihDataGridViewTextBoxColumn
            // 
            this.geldigiTarihDataGridViewTextBoxColumn.DataPropertyName = "GeldigiTarih";
            this.geldigiTarihDataGridViewTextBoxColumn.HeaderText = "GeldigiTarih";
            this.geldigiTarihDataGridViewTextBoxColumn.Name = "geldigiTarihDataGridViewTextBoxColumn";
            // 
            // ucusNoDataGridViewTextBoxColumn
            // 
            this.ucusNoDataGridViewTextBoxColumn.DataPropertyName = "UcusNo";
            this.ucusNoDataGridViewTextBoxColumn.HeaderText = "UcusNo";
            this.ucusNoDataGridViewTextBoxColumn.Name = "ucusNoDataGridViewTextBoxColumn";
            // 
            // gidecegiTarihDataGridViewTextBoxColumn
            // 
            this.gidecegiTarihDataGridViewTextBoxColumn.DataPropertyName = "GidecegiTarih";
            this.gidecegiTarihDataGridViewTextBoxColumn.HeaderText = "GidecegiTarih";
            this.gidecegiTarihDataGridViewTextBoxColumn.Name = "gidecegiTarihDataGridViewTextBoxColumn";
            // 
            // gidecegiUcusNoDataGridViewTextBoxColumn
            // 
            this.gidecegiUcusNoDataGridViewTextBoxColumn.DataPropertyName = "GidecegiUcusNo";
            this.gidecegiUcusNoDataGridViewTextBoxColumn.HeaderText = "GidecegiUcusNo";
            this.gidecegiUcusNoDataGridViewTextBoxColumn.Name = "gidecegiUcusNoDataGridViewTextBoxColumn";
            // 
            // refakatDataGridViewTextBoxColumn
            // 
            this.refakatDataGridViewTextBoxColumn.DataPropertyName = "Refakat";
            this.refakatDataGridViewTextBoxColumn.HeaderText = "Refakat";
            this.refakatDataGridViewTextBoxColumn.Name = "refakatDataGridViewTextBoxColumn";
            // 
            // belgeNoDataGridViewTextBoxColumn
            // 
            this.belgeNoDataGridViewTextBoxColumn.DataPropertyName = "BelgeNo";
            this.belgeNoDataGridViewTextBoxColumn.HeaderText = "BelgeNo";
            this.belgeNoDataGridViewTextBoxColumn.Name = "belgeNoDataGridViewTextBoxColumn";
            // 
            // ınadCinsiyetDataGridViewTextBoxColumn
            // 
            this.ınadCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "InadCinsiyet";
            this.ınadCinsiyetDataGridViewTextBoxColumn.HeaderText = "InadCinsiyet";
            this.ınadCinsiyetDataGridViewTextBoxColumn.Name = "ınadCinsiyetDataGridViewTextBoxColumn";
            // 
            // gelisSaatDataGridViewTextBoxColumn
            // 
            this.gelisSaatDataGridViewTextBoxColumn.DataPropertyName = "GelisSaat";
            this.gelisSaatDataGridViewTextBoxColumn.HeaderText = "GelisSaat";
            this.gelisSaatDataGridViewTextBoxColumn.Name = "gelisSaatDataGridViewTextBoxColumn";
            // 
            // gidisSaatDataGridViewTextBoxColumn
            // 
            this.gidisSaatDataGridViewTextBoxColumn.DataPropertyName = "GidisSaat";
            this.gidisSaatDataGridViewTextBoxColumn.HeaderText = "GidisSaat";
            this.gidisSaatDataGridViewTextBoxColumn.Name = "gidisSaatDataGridViewTextBoxColumn";
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // ınadYolcuBindingSource
            // 
            this.ınadYolcuBindingSource.DataMember = "InadYolcu";
            this.ınadYolcuBindingSource.DataSource = this.celebiInadDataSet5;
            // 
            // celebiInadDataSet5
            // 
            this.celebiInadDataSet5.DataSetName = "CelebiInadDataSet5";
            this.celebiInadDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInadSil
            // 
            this.btnInadSil.BackColor = System.Drawing.Color.White;
            this.btnInadSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInadSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInadSil.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__4_;
            this.btnInadSil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInadSil.Location = new System.Drawing.Point(456, 341);
            this.btnInadSil.Name = "btnInadSil";
            this.btnInadSil.Size = new System.Drawing.Size(99, 67);
            this.btnInadSil.TabIndex = 1;
            this.btnInadSil.Text = "Sil";
            this.btnInadSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInadSil.UseVisualStyleBackColor = false;
            this.btnInadSil.Click += new System.EventHandler(this.btnInadSil_Click);
            // 
            // txtInadId
            // 
            this.txtInadId.Location = new System.Drawing.Point(326, 365);
            this.txtInadId.Name = "txtInadId";
            this.txtInadId.Size = new System.Drawing.Size(100, 20);
            this.txtInadId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(326, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // inadYolcuTableAdapter
            // 
            this.inadYolcuTableAdapter.ClearBeforeFill = true;
            // 
            // gudeInadDataSet3
            // 
            this.gudeInadDataSet3.DataSetName = "GudeInadDataSet3";
            this.gudeInadDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ınadYolcuBindingSource1
            // 
            this.ınadYolcuBindingSource1.DataMember = "InadYolcu";
            this.ınadYolcuBindingSource1.DataSource = this.gudeInadDataSet3;
            // 
            // inadYolcuTableAdapter1
            // 
            this.inadYolcuTableAdapter1.ClearBeforeFill = true;
            // 
            // Inad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirportInadRegister.Properties.Resources.çelebi_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInadId);
            this.Controls.Add(this.btnInadSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inad";
            this.Text = "Inad";
            this.Load += new System.EventHandler(this.Inad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadYolcuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadYolcuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInadSil;
        private System.Windows.Forms.TextBox txtInadId;
        private System.Windows.Forms.Label label1;
        private CelebiInadDataSet5 celebiInadDataSet5;
        private System.Windows.Forms.BindingSource ınadYolcuBindingSource;
        private CelebiInadDataSet5TableAdapters.InadYolcuTableAdapter inadYolcuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geldigiTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucusNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidecegiTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidecegiUcusNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refakatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınadCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private GudeInadDataSet3 gudeInadDataSet3;
        private System.Windows.Forms.BindingSource ınadYolcuBindingSource1;
        private GudeInadDataSet3TableAdapters.InadYolcuTableAdapter inadYolcuTableAdapter1;
    }
}