namespace OptimizacionVientos
{
    partial class FormHistoricosVientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricosVientos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewHistoricosVientos = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramodia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionviento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadviento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosclimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.historicos_climaTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.Historicos_climaTableAdapter();
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.MostrarTodoHistorico = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricosVientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewHistoricosVientos
            // 
            this.dataGridViewHistoricosVientos.AllowUserToAddRows = false;
            this.dataGridViewHistoricosVientos.AllowUserToDeleteRows = false;
            this.dataGridViewHistoricosVientos.AllowUserToOrderColumns = true;
            this.dataGridViewHistoricosVientos.AutoGenerateColumns = false;
            this.dataGridViewHistoricosVientos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHistoricosVientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricosVientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.tramodia,
            this.direccionviento,
            this.velocidadviento});
            this.dataGridViewHistoricosVientos.DataSource = this.historicosclimaBindingSource;
            this.dataGridViewHistoricosVientos.Location = new System.Drawing.Point(291, 78);
            this.dataGridViewHistoricosVientos.Name = "dataGridViewHistoricosVientos";
            this.dataGridViewHistoricosVientos.ReadOnly = true;
            this.dataGridViewHistoricosVientos.Size = new System.Drawing.Size(375, 298);
            this.dataGridViewHistoricosVientos.TabIndex = 1;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 80;
            // 
            // tramodia
            // 
            this.tramodia.DataPropertyName = "tramo_dia";
            this.tramodia.HeaderText = "Tramo Día";
            this.tramodia.Name = "tramodia";
            this.tramodia.ReadOnly = true;
            this.tramodia.Width = 80;
            // 
            // direccionviento
            // 
            this.direccionviento.DataPropertyName = "direccion_viento";
            this.direccionviento.HeaderText = "Dirección";
            this.direccionviento.Name = "direccionviento";
            this.direccionviento.ReadOnly = true;
            this.direccionviento.Width = 80;
            // 
            // velocidadviento
            // 
            this.velocidadviento.DataPropertyName = "velocidad_viento";
            this.velocidadviento.HeaderText = "Velocidad";
            this.velocidadviento.Name = "velocidadviento";
            this.velocidadviento.ReadOnly = true;
            this.velocidadviento.Width = 80;
            // 
            // historicosclimaBindingSource
            // 
            this.historicosclimaBindingSource.DataMember = "Historicos_clima";
            this.historicosclimaBindingSource.DataSource = this.vientosDataSet;
            // 
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicos_climaTableAdapter
            // 
            this.historicos_climaTableAdapter.ClearBeforeFill = true;
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(33, 78);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 2;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarTodoHistorico
            // 
            this.MostrarTodoHistorico.Location = new System.Drawing.Point(291, 382);
            this.MostrarTodoHistorico.Name = "MostrarTodoHistorico";
            this.MostrarTodoHistorico.Size = new System.Drawing.Size(86, 23);
            this.MostrarTodoHistorico.TabIndex = 4;
            this.MostrarTodoHistorico.Text = "Mostrar Todo";
            this.MostrarTodoHistorico.UseVisualStyleBackColor = true;
            this.MostrarTodoHistorico.Click += new System.EventHandler(this.MostrarTodoHistorico_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FormHistoricosVientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 470);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MostrarTodoHistorico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calendar1);
            this.Controls.Add(this.dataGridViewHistoricosVientos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHistoricosVientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Históricos Vientos";
            this.Load += new System.EventHandler(this.FormHistoricosVientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricosVientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewHistoricosVientos;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource historicosclimaBindingSource;
        private VientosDataSetTableAdapters.Historicos_climaTableAdapter historicos_climaTableAdapter;
        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MostrarTodoHistorico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramodia;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionviento;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadviento;
    }
}