namespace AirportInadRegister
{
    partial class HavaYolları
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
            this.havayoluIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havayoluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gudeInadDataSet1 = new AirportInadRegister.GudeInadDataSet1();
            this.havayoluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celebiInadDataSet4 = new AirportInadRegister.CelebiInadDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHavayoluName = new System.Windows.Forms.TextBox();
            this.txtHavayoluId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.havayoluTableAdapter = new AirportInadRegister.CelebiInadDataSet4TableAdapters.HavayoluTableAdapter();
            this.havayoluTableAdapter1 = new AirportInadRegister.GudeInadDataSet1TableAdapters.HavayoluTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havayoluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havayoluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.havayoluIsimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.havayoluBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // havayoluIsimDataGridViewTextBoxColumn
            // 
            this.havayoluIsimDataGridViewTextBoxColumn.DataPropertyName = "HavayoluIsim";
            this.havayoluIsimDataGridViewTextBoxColumn.HeaderText = "HavayoluIsim";
            this.havayoluIsimDataGridViewTextBoxColumn.Name = "havayoluIsimDataGridViewTextBoxColumn";
            this.havayoluIsimDataGridViewTextBoxColumn.Width = 700;
            // 
            // havayoluBindingSource1
            // 
            this.havayoluBindingSource1.DataMember = "Havayolu";
            this.havayoluBindingSource1.DataSource = this.gudeInadDataSet1;
            // 
            // gudeInadDataSet1
            // 
            this.gudeInadDataSet1.DataSetName = "GudeInadDataSet1";
            this.gudeInadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havayoluBindingSource
            // 
            this.havayoluBindingSource.DataMember = "Havayolu";
            this.havayoluBindingSource.DataSource = this.celebiInadDataSet4;
            // 
            // celebiInadDataSet4
            // 
            this.celebiInadDataSet4.DataSetName = "CelebiInadDataSet4";
            this.celebiInadDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Havayolu İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(346, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Havayolu Id";
            // 
            // txtHavayoluName
            // 
            this.txtHavayoluName.Location = new System.Drawing.Point(15, 406);
            this.txtHavayoluName.Name = "txtHavayoluName";
            this.txtHavayoluName.Size = new System.Drawing.Size(127, 20);
            this.txtHavayoluName.TabIndex = 3;
            // 
            // txtHavayoluId
            // 
            this.txtHavayoluId.Location = new System.Drawing.Point(349, 406);
            this.txtHavayoluId.Name = "txtHavayoluId";
            this.txtHavayoluId.Size = new System.Drawing.Size(100, 20);
            this.txtHavayoluId.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__6_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(184, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__4_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(494, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // havayoluTableAdapter
            // 
            this.havayoluTableAdapter.ClearBeforeFill = true;
            // 
            // havayoluTableAdapter1
            // 
            this.havayoluTableAdapter1.ClearBeforeFill = true;
            // 
            // HavaYolları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirportInadRegister.Properties.Resources.çelebi_icon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHavayoluId);
            this.Controls.Add(this.txtHavayoluName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HavaYolları";
            this.Text = "HavaYolları";
            this.Load += new System.EventHandler(this.HavaYolları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havayoluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havayoluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHavayoluName;
        private System.Windows.Forms.TextBox txtHavayoluId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CelebiInadDataSet4 celebiInadDataSet4;
        private System.Windows.Forms.BindingSource havayoluBindingSource;
        private CelebiInadDataSet4TableAdapters.HavayoluTableAdapter havayoluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn havayoluIsimDataGridViewTextBoxColumn;
        private GudeInadDataSet1 gudeInadDataSet1;
        private System.Windows.Forms.BindingSource havayoluBindingSource1;
        private GudeInadDataSet1TableAdapters.HavayoluTableAdapter havayoluTableAdapter1;
    }
}