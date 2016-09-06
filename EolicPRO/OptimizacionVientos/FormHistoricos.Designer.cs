namespace OptimizacionVientos
{
    partial class FormHistoricos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePickerHistoricos = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTramoHorario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEnergiaTotalDia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEnergiaTotal = new System.Windows.Forms.Label();
            this.labelTramo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.historicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowserHistoricos = new System.Windows.Forms.WebBrowser();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.historicosTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.HistoricosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aerogeneradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaproducidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(4, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 484);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerHistoricos);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTramoHorario);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserHistoricos);
            this.splitContainer1.Size = new System.Drawing.Size(994, 484);
            this.splitContainer1.SplitterDistance = 473;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateTimePickerHistoricos
            // 
            this.dateTimePickerHistoricos.Location = new System.Drawing.Point(8, 3);
            this.dateTimePickerHistoricos.Name = "dateTimePickerHistoricos";
            this.dateTimePickerHistoricos.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHistoricos.TabIndex = 6;
            // 
            // comboBoxTramoHorario
            // 
            this.comboBoxTramoHorario.FormattingEnabled = true;
            this.comboBoxTramoHorario.Items.AddRange(new object[] {
            "2:01-5:00",
            "5:01-8:00",
            "8:01-11:00",
            "11:01-14:00",
            "14:01-17:00",
            "17:01-20:00",
            "20:01-23:00",
            "23:01-2:00"});
            this.comboBoxTramoHorario.Location = new System.Drawing.Point(8, 29);
            this.comboBoxTramoHorario.Name = "comboBoxTramoHorario";
            this.comboBoxTramoHorario.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTramoHorario.TabIndex = 4;
            this.comboBoxTramoHorario.Text = "Tramo Hora";
            this.comboBoxTramoHorario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTramoHorario_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelEnergiaTotalDia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelEnergiaTotal);
            this.groupBox1.Controls.Add(this.labelTramo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewHistorico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(4, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Historicos";
            // 
            // labelEnergiaTotalDia
            // 
            this.labelEnergiaTotalDia.AutoSize = true;
            this.labelEnergiaTotalDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergiaTotalDia.Location = new System.Drawing.Point(229, 345);
            this.labelEnergiaTotalDia.Name = "labelEnergiaTotalDia";
            this.labelEnergiaTotalDia.Size = new System.Drawing.Size(0, 42);
            this.labelEnergiaTotalDia.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Energía Total diaria Producida:";
            // 
            // labelEnergiaTotal
            // 
            this.labelEnergiaTotal.AutoSize = true;
            this.labelEnergiaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergiaTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEnergiaTotal.Location = new System.Drawing.Point(6, 345);
            this.labelEnergiaTotal.Name = "labelEnergiaTotal";
            this.labelEnergiaTotal.Size = new System.Drawing.Size(0, 42);
            this.labelEnergiaTotal.TabIndex = 11;
            // 
            // labelTramo
            // 
            this.labelTramo.AutoSize = true;
            this.labelTramo.Location = new System.Drawing.Point(122, 321);
            this.labelTramo.Name = "labelTramo";
            this.labelTramo.Size = new System.Drawing.Size(0, 13);
            this.labelTramo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Energía Tramo día:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(305, 279);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ver Históricos Vientos";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(122, 299);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 13);
            this.labelFecha.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Producción:";
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.AllowUserToAddRows = false;
            this.dataGridViewHistorico.AllowUserToDeleteRows = false;
            this.dataGridViewHistorico.AllowUserToOrderColumns = true;
            this.dataGridViewHistorico.AutoGenerateColumns = false;
            this.dataGridViewHistorico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aerogeneradorDataGridViewTextBoxColumn,
            this.energiaproducidaDataGridViewTextBoxColumn,
            this.direccionvientoDataGridViewTextBoxColumn,
            this.velocidadvientoDataGridViewTextBoxColumn});
            this.dataGridViewHistorico.DataSource = this.historicosBindingSource;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.ReadOnly = true;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(409, 232);
            this.dataGridViewHistorico.TabIndex = 5;
            // 
            // historicosBindingSource
            // 
            this.historicosBindingSource.DataMember = "Historicos";
            this.historicosBindingSource.DataSource = this.vientosDataSet;
            // 
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aerogeneradores que Funcionaron:";
            // 
            // webBrowserHistoricos
            // 
            this.webBrowserHistoricos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserHistoricos.Location = new System.Drawing.Point(0, 0);
            this.webBrowserHistoricos.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserHistoricos.Name = "webBrowserHistoricos";
            this.webBrowserHistoricos.Size = new System.Drawing.Size(517, 484);
            this.webBrowserHistoricos.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(878, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Rosa de los Vientos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // historicosTableAdapter
            // 
            this.historicosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // aerogeneradorDataGridViewTextBoxColumn
            // 
            this.aerogeneradorDataGridViewTextBoxColumn.DataPropertyName = "aerogenerador";
            this.aerogeneradorDataGridViewTextBoxColumn.HeaderText = "Aero";
            this.aerogeneradorDataGridViewTextBoxColumn.Name = "aerogeneradorDataGridViewTextBoxColumn";
            this.aerogeneradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.aerogeneradorDataGridViewTextBoxColumn.Width = 50;
            // 
            // energiaproducidaDataGridViewTextBoxColumn
            // 
            this.energiaproducidaDataGridViewTextBoxColumn.DataPropertyName = "energia_producida";
            this.energiaproducidaDataGridViewTextBoxColumn.HeaderText = "Energía Producida";
            this.energiaproducidaDataGridViewTextBoxColumn.Name = "energiaproducidaDataGridViewTextBoxColumn";
            this.energiaproducidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionvientoDataGridViewTextBoxColumn
            // 
            this.direccionvientoDataGridViewTextBoxColumn.DataPropertyName = "direccion_viento";
            this.direccionvientoDataGridViewTextBoxColumn.HeaderText = "Dirección Viento";
            this.direccionvientoDataGridViewTextBoxColumn.Name = "direccionvientoDataGridViewTextBoxColumn";
            this.direccionvientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velocidadvientoDataGridViewTextBoxColumn
            // 
            this.velocidadvientoDataGridViewTextBoxColumn.DataPropertyName = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn.HeaderText = "Velocidad Viento";
            this.velocidadvientoDataGridViewTextBoxColumn.Name = "velocidadvientoDataGridViewTextBoxColumn";
            this.velocidadvientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistoricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Históricos Planificación";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowserHistoricos;
        private System.Windows.Forms.ComboBox comboBoxTramoHorario;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistoricos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHistorico;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource historicosBindingSource;
        private VientosDataSetTableAdapters.HistoricosTableAdapter historicosTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label labelEnergiaTotal;
        private System.Windows.Forms.Label labelEnergiaTotalDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTramo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerogeneradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaproducidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn;
    }
}