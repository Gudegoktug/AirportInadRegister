namespace AirportInadRegister
{
    partial class InadSebep
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInadSebepEkle = new System.Windows.Forms.TextBox();
            this.btnInadSebepEkle = new System.Windows.Forms.Button();
            this.celebiInadDataSet7 = new AirportInadRegister.CelebiInadDataSet7();
            this.ınadSebepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inadSebepTableAdapter = new AirportInadRegister.CelebiInadDataSet7TableAdapters.InadSebepTableAdapter();
            this.gudeInadDataSet9 = new AirportInadRegister.GudeInadDataSet9();
            this.ınadSebepBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inadSebepTableAdapter1 = new AirportInadRegister.GudeInadDataSet9TableAdapters.InadSebepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadSebepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadSebepBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.ınadSebepBindingSource1;
            this.listBox1.DisplayMember = "Sebep";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(291, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Sebep";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inad Sebep";
            // 
            // txtInadSebepEkle
            // 
            this.txtInadSebepEkle.Location = new System.Drawing.Point(318, 249);
            this.txtInadSebepEkle.Name = "txtInadSebepEkle";
            this.txtInadSebepEkle.Size = new System.Drawing.Size(173, 20);
            this.txtInadSebepEkle.TabIndex = 2;
            // 
            // btnInadSebepEkle
            // 
            this.btnInadSebepEkle.BackColor = System.Drawing.Color.White;
            this.btnInadSebepEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInadSebepEkle.Image = global::AirportInadRegister.Properties.Resources.pngwing_com__6_;
            this.btnInadSebepEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInadSebepEkle.Location = new System.Drawing.Point(386, 275);
            this.btnInadSebepEkle.Name = "btnInadSebepEkle";
            this.btnInadSebepEkle.Size = new System.Drawing.Size(105, 73);
            this.btnInadSebepEkle.TabIndex = 3;
            this.btnInadSebepEkle.Text = "Kayıt";
            this.btnInadSebepEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInadSebepEkle.UseVisualStyleBackColor = false;
            this.btnInadSebepEkle.Click += new System.EventHandler(this.btnInadSebepEkle_Click);
            // 
            // celebiInadDataSet7
            // 
            this.celebiInadDataSet7.DataSetName = "CelebiInadDataSet7";
            this.celebiInadDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ınadSebepBindingSource
            // 
            this.ınadSebepBindingSource.DataMember = "InadSebep";
            this.ınadSebepBindingSource.DataSource = this.celebiInadDataSet7;
            // 
            // inadSebepTableAdapter
            // 
            this.inadSebepTableAdapter.ClearBeforeFill = true;
            // 
            // gudeInadDataSet9
            // 
            this.gudeInadDataSet9.DataSetName = "GudeInadDataSet9";
            this.gudeInadDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ınadSebepBindingSource1
            // 
            this.ınadSebepBindingSource1.DataMember = "InadSebep";
            this.ınadSebepBindingSource1.DataSource = this.gudeInadDataSet9;
            // 
            // inadSebepTableAdapter1
            // 
            this.inadSebepTableAdapter1.ClearBeforeFill = true;
            // 
            // InadSebep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirportInadRegister.Properties.Resources.celebi_etik_ve_itibar_dernegine_katildi_h13837_37e50;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 352);
            this.Controls.Add(this.btnInadSebepEkle);
            this.Controls.Add(this.txtInadSebepEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "InadSebep";
            this.Text = "InadSebep";
            this.Load += new System.EventHandler(this.InadSebep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.celebiInadDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadSebepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeInadDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınadSebepBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInadSebepEkle;
        private System.Windows.Forms.Button btnInadSebepEkle;
        private CelebiInadDataSet7 celebiInadDataSet7;
        private System.Windows.Forms.BindingSource ınadSebepBindingSource;
        private CelebiInadDataSet7TableAdapters.InadSebepTableAdapter inadSebepTableAdapter;
        private GudeInadDataSet9 gudeInadDataSet9;
        private System.Windows.Forms.BindingSource ınadSebepBindingSource1;
        private GudeInadDataSet9TableAdapters.InadSebepTableAdapter inadSebepTableAdapter1;
    }
}