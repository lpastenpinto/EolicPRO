namespace OptimizacionVientos
{
    partial class FormHistoricosAerogeneradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricosAerogeneradores));
            this.dataGridViewHistoricosAeros = new System.Windows.Forms.DataGridView();
            this.Aerogenerador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramodiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaproducidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerogeneradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.historicosTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.HistoricosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricosAeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoricosAeros
            // 
            this.dataGridViewHistoricosAeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricosAeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aerogenerador,
            this.energia,
            this.horas});
            this.dataGridViewHistoricosAeros.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewHistoricosAeros.Name = "dataGridViewHistoricosAeros";
            this.dataGridViewHistoricosAeros.Size = new System.Drawing.Size(546, 382);
            this.dataGridViewHistoricosAeros.TabIndex = 0;
            // 
            // Aerogenerador
            // 
            this.Aerogenerador.HeaderText = "Aerogenerador";
            this.Aerogenerador.Name = "Aerogenerador";
            this.Aerogenerador.Width = 200;
            // 
            // energia
            // 
            this.energia.HeaderText = "Energía Producida";
            this.energia.Name = "energia";
            this.energia.Width = 150;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas Trabajadas";
            this.horas.Name = "horas";
            this.horas.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tramodiaDataGridViewTextBoxColumn,
            this.energiaproducidaDataGridViewTextBoxColumn,
            this.direccionvientoDataGridViewTextBoxColumn,
            this.velocidadvientoDataGridViewTextBoxColumn,
            this.aerogeneradorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historicosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(548, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tramodiaDataGridViewTextBoxColumn
            // 
            this.tramodiaDataGridViewTextBoxColumn.DataPropertyName = "tramo_dia";
            this.tramodiaDataGridViewTextBoxColumn.HeaderText = "tramo_dia";
            this.tramodiaDataGridViewTextBoxColumn.Name = "tramodiaDataGridViewTextBoxColumn";
            // 
            // energiaproducidaDataGridViewTextBoxColumn
            // 
            this.energiaproducidaDataGridViewTextBoxColumn.DataPropertyName = "energia_producida";
            this.energiaproducidaDataGridViewTextBoxColumn.HeaderText = "energia_producida";
            this.energiaproducidaDataGridViewTextBoxColumn.Name = "energiaproducidaDataGridViewTextBoxColumn";
            // 
            // direccionvientoDataGridViewTextBoxColumn
            // 
            this.direccionvientoDataGridViewTextBoxColumn.DataPropertyName = "direccion_viento";
            this.direccionvientoDataGridViewTextBoxColumn.HeaderText = "direccion_viento";
            this.direccionvientoDataGridViewTextBoxColumn.Name = "direccionvientoDataGridViewTextBoxColumn";
            // 
            // velocidadvientoDataGridViewTextBoxColumn
            // 
            this.velocidadvientoDataGridViewTextBoxColumn.DataPropertyName = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn.HeaderText = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn.Name = "velocidadvientoDataGridViewTextBoxColumn";
            // 
            // aerogeneradorDataGridViewTextBoxColumn
            // 
            this.aerogeneradorDataGridViewTextBoxColumn.DataPropertyName = "aerogenerador";
            this.aerogeneradorDataGridViewTextBoxColumn.HeaderText = "aerogenerador";
            this.aerogeneradorDataGridViewTextBoxColumn.Name = "aerogeneradorDataGridViewTextBoxColumn";
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
            // historicosTableAdapter
            // 
            this.historicosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exportar a Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormHistoricosAerogeneradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewHistoricosAeros);
            this.Name = "FormHistoricosAerogeneradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Históricos Aerogeneradores";
            this.Load += new System.EventHandler(this.FormHistoricosAerogeneradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricosAeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistoricosAeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aerogenerador;
        private System.Windows.Forms.DataGridViewTextBoxColumn energia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource historicosBindingSource;
        private VientosDataSetTableAdapters.HistoricosTableAdapter historicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramodiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaproducidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerogeneradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}