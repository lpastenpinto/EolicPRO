namespace OptimizacionVientos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.planificacion = new System.Windows.Forms.GroupBox();
            this.groupBoxInformacion = new System.Windows.Forms.GroupBox();
            this.labelEnergiaAnual = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaAnualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet1 = new OptimizacionVientos.VientosDataSet();
            this.labelProgreso = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewEnergiacadaUno = new System.Windows.Forms.DataGridView();
            this.Aero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMensajeError = new System.Windows.Forms.Label();
            this.dataGridViewVelocidad = new System.Windows.Forms.DataGridView();
            this.velocidadvientoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosclimaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramodiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaproducidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionvientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadvientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerogeneradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardarPlanificacion = new System.Windows.Forms.Button();
            this.dataGridViewPareto = new System.Windows.Forms.DataGridView();
            this.tramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paretotramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewVelocidadDireccion = new System.Windows.Forms.DataGridView();
            this.direccionvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosclimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPlanificacion = new System.Windows.Forms.DataGridView();
            this.Tramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aerogeneradores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergiaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPlanificar = new System.Windows.Forms.Button();
            this.textBoxEnergiaProducir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIteraciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.labelEnergiaTotalProducida = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFechaPlanificacion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTiempodeEjecucion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxNoticia = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridViewNoDisponibles = new System.Windows.Forms.DataGridView();
            this.numeroAeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarDisponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarParetoTramosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarMetaAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistoricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistoricosAerogeneradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistoricosVientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaDeLosVientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.disponibilidadTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.DisponibilidadTableAdapter();
            this.historicos_climaTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.Historicos_climaTableAdapter();
            this.pareto_tramoTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.pareto_tramoTableAdapter();
            this.historicosTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.HistoricosTableAdapter();
            this.meta_AnualTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.Meta_AnualTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.planificacion.SuspendLayout();
            this.groupBoxInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaAnualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnergiacadaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPareto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretotramoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelocidadDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanificacion)).BeginInit();
            this.groupBoxResultados.SuspendLayout();
            this.groupBoxNoticia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 570);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.planificacion);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxNoticia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1307, 570);
            this.splitContainer1.SplitterDistance = 781;
            this.splitContainer1.TabIndex = 0;
            // 
            // planificacion
            // 
            this.planificacion.Controls.Add(this.groupBoxInformacion);
            this.planificacion.Controls.Add(this.dataGridView2);
            this.planificacion.Controls.Add(this.labelProgreso);
            this.planificacion.Controls.Add(this.progressBar);
            this.planificacion.Controls.Add(this.label12);
            this.planificacion.Controls.Add(this.dataGridViewEnergiacadaUno);
            this.planificacion.Controls.Add(this.labelMensajeError);
            this.planificacion.Controls.Add(this.dataGridViewVelocidad);
            this.planificacion.Controls.Add(this.dataGridView1);
            this.planificacion.Controls.Add(this.buttonGuardarPlanificacion);
            this.planificacion.Controls.Add(this.dataGridViewPareto);
            this.planificacion.Controls.Add(this.dataGridViewVelocidadDireccion);
            this.planificacion.Controls.Add(this.dataGridViewPlanificacion);
            this.planificacion.Controls.Add(this.label7);
            this.planificacion.Controls.Add(this.buttonPlanificar);
            this.planificacion.Controls.Add(this.textBoxEnergiaProducir);
            this.planificacion.Controls.Add(this.label6);
            this.planificacion.Controls.Add(this.textBoxIteraciones);
            this.planificacion.Controls.Add(this.label5);
            this.planificacion.Controls.Add(this.groupBoxResultados);
            this.planificacion.Location = new System.Drawing.Point(0, 0);
            this.planificacion.Name = "planificacion";
            this.planificacion.Size = new System.Drawing.Size(778, 570);
            this.planificacion.TabIndex = 1;
            this.planificacion.TabStop = false;
            this.planificacion.Text = "Planificación (Algoritmo Genético)";
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.labelEnergiaAnual);
            this.groupBoxInformacion.Controls.Add(this.label14);
            this.groupBoxInformacion.Controls.Add(this.label11);
            this.groupBoxInformacion.Controls.Add(this.labelPorcentaje);
            this.groupBoxInformacion.Controls.Add(this.label13);
            this.groupBoxInformacion.Location = new System.Drawing.Point(410, 17);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(361, 66);
            this.groupBoxInformacion.TabIndex = 24;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Información";
            // 
            // labelEnergiaAnual
            // 
            this.labelEnergiaAnual.AutoSize = true;
            this.labelEnergiaAnual.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEnergiaAnual.Location = new System.Drawing.Point(117, 17);
            this.labelEnergiaAnual.Name = "labelEnergiaAnual";
            this.labelEnergiaAnual.Size = new System.Drawing.Size(0, 13);
            this.labelEnergiaAnual.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Meta Energía Anual:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "de la Meta anual de Energía.";
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPorcentaje.Location = new System.Drawing.Point(172, 39);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.labelPorcentaje.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Hasta la fecha se a generado un: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.metaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.metaAnualBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(518, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Visible = false;
            // 
            // metaDataGridViewTextBoxColumn
            // 
            this.metaDataGridViewTextBoxColumn.DataPropertyName = "meta";
            this.metaDataGridViewTextBoxColumn.HeaderText = "meta";
            this.metaDataGridViewTextBoxColumn.Name = "metaDataGridViewTextBoxColumn";
            // 
            // metaAnualBindingSource
            // 
            this.metaAnualBindingSource.DataMember = "Meta_Anual";
            this.metaAnualBindingSource.DataSource = this.vientosDataSet1;
            // 
            // vientosDataSet1
            // 
            this.vientosDataSet1.DataSetName = "VientosDataSet";
            this.vientosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelProgreso
            // 
            this.labelProgreso.AutoSize = true;
            this.labelProgreso.Location = new System.Drawing.Point(6, 373);
            this.labelProgreso.Name = "labelProgreso";
            this.labelProgreso.Size = new System.Drawing.Size(58, 13);
            this.labelProgreso.TabIndex = 23;
            this.labelProgreso.Text = "Progreso...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 389);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(585, 10);
            this.progressBar.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "[Mw]";
            // 
            // dataGridViewEnergiacadaUno
            // 
            this.dataGridViewEnergiacadaUno.AllowUserToDeleteRows = false;
            this.dataGridViewEnergiacadaUno.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEnergiacadaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnergiacadaUno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aero,
            this.Energia});
            this.dataGridViewEnergiacadaUno.Location = new System.Drawing.Point(604, 126);
            this.dataGridViewEnergiacadaUno.Name = "dataGridViewEnergiacadaUno";
            this.dataGridViewEnergiacadaUno.ReadOnly = true;
            this.dataGridViewEnergiacadaUno.Size = new System.Drawing.Size(168, 230);
            this.dataGridViewEnergiacadaUno.TabIndex = 2;
            this.dataGridViewEnergiacadaUno.Visible = false;
            // 
            // Aero
            // 
            this.Aero.HeaderText = "Aero";
            this.Aero.Name = "Aero";
            this.Aero.ReadOnly = true;
            this.Aero.Width = 35;
            // 
            // Energia
            // 
            this.Energia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Energia.HeaderText = "Energía";
            this.Energia.Name = "Energia";
            this.Energia.ReadOnly = true;
            this.Energia.Width = 70;
            // 
            // labelMensajeError
            // 
            this.labelMensajeError.AutoSize = true;
            this.labelMensajeError.Location = new System.Drawing.Point(-3, 551);
            this.labelMensajeError.Name = "labelMensajeError";
            this.labelMensajeError.Size = new System.Drawing.Size(559, 13);
            this.labelMensajeError.TabIndex = 7;
            this.labelMensajeError.Text = "(*) \"No se puede producir energía porque la meta es muy alta y las condiciones de" +
                "l viento no permiten producir ésta.\"";
            this.labelMensajeError.Visible = false;
            // 
            // dataGridViewVelocidad
            // 
            this.dataGridViewVelocidad.AutoGenerateColumns = false;
            this.dataGridViewVelocidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelocidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.velocidadvientoDataGridViewTextBoxColumn2});
            this.dataGridViewVelocidad.DataSource = this.historicosclimaBindingSource1;
            this.dataGridViewVelocidad.Location = new System.Drawing.Point(534, 110);
            this.dataGridViewVelocidad.Name = "dataGridViewVelocidad";
            this.dataGridViewVelocidad.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewVelocidad.TabIndex = 17;
            this.dataGridViewVelocidad.Visible = false;
            // 
            // velocidadvientoDataGridViewTextBoxColumn2
            // 
            this.velocidadvientoDataGridViewTextBoxColumn2.DataPropertyName = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn2.HeaderText = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn2.Name = "velocidadvientoDataGridViewTextBoxColumn2";
            // 
            // historicosclimaBindingSource1
            // 
            this.historicosclimaBindingSource1.DataMember = "Historicos_clima";
            this.historicosclimaBindingSource1.DataSource = this.vientosDataSet;
            // 
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tramodiaDataGridViewTextBoxColumn,
            this.energiaproducidaDataGridViewTextBoxColumn,
            this.direccionvientoDataGridViewTextBoxColumn1,
            this.velocidadvientoDataGridViewTextBoxColumn1,
            this.aerogeneradorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historicosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(550, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(11, 10);
            this.dataGridView1.TabIndex = 7;
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
            // direccionvientoDataGridViewTextBoxColumn1
            // 
            this.direccionvientoDataGridViewTextBoxColumn1.DataPropertyName = "direccion_viento";
            this.direccionvientoDataGridViewTextBoxColumn1.HeaderText = "direccion_viento";
            this.direccionvientoDataGridViewTextBoxColumn1.Name = "direccionvientoDataGridViewTextBoxColumn1";
            // 
            // velocidadvientoDataGridViewTextBoxColumn1
            // 
            this.velocidadvientoDataGridViewTextBoxColumn1.DataPropertyName = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn1.HeaderText = "velocidad_viento";
            this.velocidadvientoDataGridViewTextBoxColumn1.Name = "velocidadvientoDataGridViewTextBoxColumn1";
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
            // buttonGuardarPlanificacion
            // 
            this.buttonGuardarPlanificacion.Location = new System.Drawing.Point(6, 362);
            this.buttonGuardarPlanificacion.Name = "buttonGuardarPlanificacion";
            this.buttonGuardarPlanificacion.Size = new System.Drawing.Size(129, 23);
            this.buttonGuardarPlanificacion.TabIndex = 16;
            this.buttonGuardarPlanificacion.Text = "Guardar Planificación";
            this.buttonGuardarPlanificacion.UseVisualStyleBackColor = true;
            this.buttonGuardarPlanificacion.Visible = false;
            this.buttonGuardarPlanificacion.Click += new System.EventHandler(this.buttonGuardarPlanificacion_Click);
            // 
            // dataGridViewPareto
            // 
            this.dataGridViewPareto.AutoGenerateColumns = false;
            this.dataGridViewPareto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPareto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tramoDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn});
            this.dataGridViewPareto.DataSource = this.paretotramoBindingSource;
            this.dataGridViewPareto.Location = new System.Drawing.Point(567, 110);
            this.dataGridViewPareto.Name = "dataGridViewPareto";
            this.dataGridViewPareto.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewPareto.TabIndex = 15;
            this.dataGridViewPareto.Visible = false;
            // 
            // tramoDataGridViewTextBoxColumn
            // 
            this.tramoDataGridViewTextBoxColumn.DataPropertyName = "tramo";
            this.tramoDataGridViewTextBoxColumn.HeaderText = "tramo";
            this.tramoDataGridViewTextBoxColumn.Name = "tramoDataGridViewTextBoxColumn";
            // 
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            // 
            // paretotramoBindingSource
            // 
            this.paretotramoBindingSource.DataMember = "pareto_tramo";
            this.paretotramoBindingSource.DataSource = this.vientosDataSet;
            // 
            // dataGridViewVelocidadDireccion
            // 
            this.dataGridViewVelocidadDireccion.AutoGenerateColumns = false;
            this.dataGridViewVelocidadDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelocidadDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.direccionvientoDataGridViewTextBoxColumn,
            this.velocidadvientoDataGridViewTextBoxColumn});
            this.dataGridViewVelocidadDireccion.DataSource = this.historicosclimaBindingSource;
            this.dataGridViewVelocidadDireccion.Location = new System.Drawing.Point(585, 110);
            this.dataGridViewVelocidadDireccion.Name = "dataGridViewVelocidadDireccion";
            this.dataGridViewVelocidadDireccion.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewVelocidadDireccion.TabIndex = 9;
            this.dataGridViewVelocidadDireccion.Visible = false;
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
            // historicosclimaBindingSource
            // 
            this.historicosclimaBindingSource.DataMember = "Historicos_clima";
            this.historicosclimaBindingSource.DataSource = this.vientosDataSet;
            // 
            // dataGridViewPlanificacion
            // 
            this.dataGridViewPlanificacion.AllowUserToDeleteRows = false;
            this.dataGridViewPlanificacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPlanificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tramo,
            this.Velocidad,
            this.Direccion,
            this.Aerogeneradores,
            this.EnergiaTotal});
            this.dataGridViewPlanificacion.Location = new System.Drawing.Point(6, 126);
            this.dataGridViewPlanificacion.Name = "dataGridViewPlanificacion";
            this.dataGridViewPlanificacion.ReadOnly = true;
            this.dataGridViewPlanificacion.Size = new System.Drawing.Size(589, 230);
            this.dataGridViewPlanificacion.TabIndex = 6;
            this.dataGridViewPlanificacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlanificacion_CellClick);
            // 
            // Tramo
            // 
            this.Tramo.HeaderText = "Tramo Diario";
            this.Tramo.Name = "Tramo";
            this.Tramo.ReadOnly = true;
            this.Tramo.Width = 75;
            // 
            // Velocidad
            // 
            this.Velocidad.HeaderText = "Velocidad Viento";
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.ReadOnly = true;
            this.Velocidad.Width = 60;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 60;
            // 
            // Aerogeneradores
            // 
            this.Aerogeneradores.HeaderText = "Aeros Funcionando";
            this.Aerogeneradores.Name = "Aerogeneradores";
            this.Aerogeneradores.ReadOnly = true;
            this.Aerogeneradores.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aerogeneradores.Width = 250;
            // 
            // EnergiaTotal
            // 
            this.EnergiaTotal.HeaderText = "Energía Producida";
            this.EnergiaTotal.Name = "EnergiaTotal";
            this.EnergiaTotal.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Planificación:";
            // 
            // buttonPlanificar
            // 
            this.buttonPlanificar.Location = new System.Drawing.Point(200, 82);
            this.buttonPlanificar.Name = "buttonPlanificar";
            this.buttonPlanificar.Size = new System.Drawing.Size(100, 23);
            this.buttonPlanificar.TabIndex = 4;
            this.buttonPlanificar.Text = "Planificar";
            this.buttonPlanificar.UseVisualStyleBackColor = true;
            this.buttonPlanificar.Click += new System.EventHandler(this.buttonPlanificar_Click);
            // 
            // textBoxEnergiaProducir
            // 
            this.textBoxEnergiaProducir.Location = new System.Drawing.Point(200, 56);
            this.textBoxEnergiaProducir.MaxLength = 6;
            this.textBoxEnergiaProducir.Name = "textBoxEnergiaProducir";
            this.textBoxEnergiaProducir.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnergiaProducir.TabIndex = 3;
            this.textBoxEnergiaProducir.Text = "30";
            this.textBoxEnergiaProducir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnergiaProducir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnergiaProducir_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Energía a Producir Recomendada:";
            // 
            // textBoxIteraciones
            // 
            this.textBoxIteraciones.Location = new System.Drawing.Point(200, 27);
            this.textBoxIteraciones.MaxLength = 7;
            this.textBoxIteraciones.Name = "textBoxIteraciones";
            this.textBoxIteraciones.Size = new System.Drawing.Size(100, 20);
            this.textBoxIteraciones.TabIndex = 1;
            this.textBoxIteraciones.Text = "700";
            this.textBoxIteraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIteraciones.Visible = false;
            this.textBoxIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIteraciones_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número de Iteraciones:";
            this.label5.Visible = false;
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.labelEnergiaTotalProducida);
            this.groupBoxResultados.Controls.Add(this.label10);
            this.groupBoxResultados.Controls.Add(this.labelFechaPlanificacion);
            this.groupBoxResultados.Controls.Add(this.label9);
            this.groupBoxResultados.Controls.Add(this.labelTiempodeEjecucion);
            this.groupBoxResultados.Controls.Add(this.label8);
            this.groupBoxResultados.Location = new System.Drawing.Point(0, 414);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(778, 111);
            this.groupBoxResultados.TabIndex = 20;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            this.groupBoxResultados.Visible = false;
            // 
            // labelEnergiaTotalProducida
            // 
            this.labelEnergiaTotalProducida.AutoSize = true;
            this.labelEnergiaTotalProducida.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergiaTotalProducida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEnergiaTotalProducida.Location = new System.Drawing.Point(444, 47);
            this.labelEnergiaTotalProducida.Name = "labelEnergiaTotalProducida";
            this.labelEnergiaTotalProducida.Size = new System.Drawing.Size(0, 55);
            this.labelEnergiaTotalProducida.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Energía Total Producida:";
            // 
            // labelFechaPlanificacion
            // 
            this.labelFechaPlanificacion.AutoSize = true;
            this.labelFechaPlanificacion.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFechaPlanificacion.Location = new System.Drawing.Point(156, 43);
            this.labelFechaPlanificacion.Name = "labelFechaPlanificacion";
            this.labelFechaPlanificacion.Size = new System.Drawing.Size(0, 13);
            this.labelFechaPlanificacion.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Planificación realizada para:";
            // 
            // labelTiempodeEjecucion
            // 
            this.labelTiempodeEjecucion.AutoSize = true;
            this.labelTiempodeEjecucion.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTiempodeEjecucion.Location = new System.Drawing.Point(156, 59);
            this.labelTiempodeEjecucion.Name = "labelTiempodeEjecucion";
            this.labelTiempodeEjecucion.Size = new System.Drawing.Size(0, 13);
            this.labelTiempodeEjecucion.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tiempo de Ejecución:";
            // 
            // groupBoxNoticia
            // 
            this.groupBoxNoticia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxNoticia.Controls.Add(this.label2);
            this.groupBoxNoticia.Location = new System.Drawing.Point(6, 3);
            this.groupBoxNoticia.Name = "groupBoxNoticia";
            this.groupBoxNoticia.Size = new System.Drawing.Size(766, 81);
            this.groupBoxNoticia.TabIndex = 0;
            this.groupBoxNoticia.TabStop = false;
            this.groupBoxNoticia.Text = "Noticia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = " (*) Para hacer una planificación (Archivo -> Planificar)\r\n (*) Para Acceder al M" +
                "anual de Usuario (Ver -> Manual de Usuario)";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(522, 570);
            this.webBrowser1.TabIndex = 0;
            // 
            // dataGridViewNoDisponibles
            // 
            this.dataGridViewNoDisponibles.AutoGenerateColumns = false;
            this.dataGridViewNoDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroAeroDataGridViewTextBoxColumn,
            this.disponibilidadDataGridViewTextBoxColumn});
            this.dataGridViewNoDisponibles.DataSource = this.disponibilidadBindingSource;
            this.dataGridViewNoDisponibles.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewNoDisponibles.Name = "dataGridViewNoDisponibles";
            this.dataGridViewNoDisponibles.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewNoDisponibles.TabIndex = 6;
            this.dataGridViewNoDisponibles.Visible = false;
            // 
            // numeroAeroDataGridViewTextBoxColumn
            // 
            this.numeroAeroDataGridViewTextBoxColumn.DataPropertyName = "NumeroAero";
            this.numeroAeroDataGridViewTextBoxColumn.HeaderText = "NumeroAero";
            this.numeroAeroDataGridViewTextBoxColumn.Name = "numeroAeroDataGridViewTextBoxColumn";
            // 
            // disponibilidadDataGridViewTextBoxColumn
            // 
            this.disponibilidadDataGridViewTextBoxColumn.DataPropertyName = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.HeaderText = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.Name = "disponibilidadDataGridViewTextBoxColumn";
            // 
            // disponibilidadBindingSource
            // 
            this.disponibilidadBindingSource.DataMember = "Disponibilidad";
            this.disponibilidadBindingSource.DataSource = this.vientosDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.historicosToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planificarToolStripMenuItem,
            this.cerrarAplicacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // planificarToolStripMenuItem
            // 
            this.planificarToolStripMenuItem.Name = "planificarToolStripMenuItem";
            this.planificarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.planificarToolStripMenuItem.Text = "Planificar";
            this.planificarToolStripMenuItem.Click += new System.EventHandler(this.planificarToolStripMenuItem_Click);
            // 
            // cerrarAplicacionToolStripMenuItem
            // 
            this.cerrarAplicacionToolStripMenuItem.Name = "cerrarAplicacionToolStripMenuItem";
            this.cerrarAplicacionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cerrarAplicacionToolStripMenuItem.Text = "Cerrar Aplicacion";
            this.cerrarAplicacionToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicacionToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarDisponibilidadToolStripMenuItem,
            this.configurarParetoTramosToolStripMenuItem,
            this.configurarMetaAnualToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configurarDisponibilidadToolStripMenuItem
            // 
            this.configurarDisponibilidadToolStripMenuItem.Name = "configurarDisponibilidadToolStripMenuItem";
            this.configurarDisponibilidadToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.configurarDisponibilidadToolStripMenuItem.Text = "Configurar Disponibilidad";
            this.configurarDisponibilidadToolStripMenuItem.Click += new System.EventHandler(this.configurarDisponibilidadToolStripMenuItem_Click);
            // 
            // configurarParetoTramosToolStripMenuItem
            // 
            this.configurarParetoTramosToolStripMenuItem.Name = "configurarParetoTramosToolStripMenuItem";
            this.configurarParetoTramosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.configurarParetoTramosToolStripMenuItem.Text = "Configurar Pareto Tramos";
            this.configurarParetoTramosToolStripMenuItem.Click += new System.EventHandler(this.configurarParetoTramosToolStripMenuItem_Click);
            // 
            // configurarMetaAnualToolStripMenuItem
            // 
            this.configurarMetaAnualToolStripMenuItem.Name = "configurarMetaAnualToolStripMenuItem";
            this.configurarMetaAnualToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.configurarMetaAnualToolStripMenuItem.Text = "Configurar Meta Anual";
            this.configurarMetaAnualToolStripMenuItem.Click += new System.EventHandler(this.configurarMetaAnualToolStripMenuItem_Click);
            // 
            // historicosToolStripMenuItem
            // 
            this.historicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verHistoricosToolStripMenuItem,
            this.verHistoricosAerogeneradoresToolStripMenuItem,
            this.verHistoricosVientosToolStripMenuItem});
            this.historicosToolStripMenuItem.Name = "historicosToolStripMenuItem";
            this.historicosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.historicosToolStripMenuItem.Text = "Historicos";
            // 
            // verHistoricosToolStripMenuItem
            // 
            this.verHistoricosToolStripMenuItem.Name = "verHistoricosToolStripMenuItem";
            this.verHistoricosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.verHistoricosToolStripMenuItem.Text = "Ver Historicos Planificaciones";
            this.verHistoricosToolStripMenuItem.Click += new System.EventHandler(this.verHistoricosToolStripMenuItem_Click);
            // 
            // verHistoricosAerogeneradoresToolStripMenuItem
            // 
            this.verHistoricosAerogeneradoresToolStripMenuItem.Name = "verHistoricosAerogeneradoresToolStripMenuItem";
            this.verHistoricosAerogeneradoresToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.verHistoricosAerogeneradoresToolStripMenuItem.Text = "Ver Historicos Aerogeneradores";
            this.verHistoricosAerogeneradoresToolStripMenuItem.Click += new System.EventHandler(this.verHistoricosAerogeneradoresToolStripMenuItem_Click);
            // 
            // verHistoricosVientosToolStripMenuItem
            // 
            this.verHistoricosVientosToolStripMenuItem.Name = "verHistoricosVientosToolStripMenuItem";
            this.verHistoricosVientosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.verHistoricosVientosToolStripMenuItem.Text = "Ver Historicos Vientos";
            this.verHistoricosVientosToolStripMenuItem.Click += new System.EventHandler(this.verHistoricosVientosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rosaDeLosVientosToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // rosaDeLosVientosToolStripMenuItem
            // 
            this.rosaDeLosVientosToolStripMenuItem.Name = "rosaDeLosVientosToolStripMenuItem";
            this.rosaDeLosVientosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rosaDeLosVientosToolStripMenuItem.Text = "Rosa de los Vientos";
            this.rosaDeLosVientosToolStripMenuItem.Click += new System.EventHandler(this.rosaDeLosVientosToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "EolicPRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1218, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1232, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NO Disponible";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1218, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1233, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponible";
            // 
            // disponibilidadTableAdapter
            // 
            this.disponibilidadTableAdapter.ClearBeforeFill = true;
            // 
            // historicos_climaTableAdapter
            // 
            this.historicos_climaTableAdapter.ClearBeforeFill = true;
            // 
            // pareto_tramoTableAdapter
            // 
            this.pareto_tramoTableAdapter.ClearBeforeFill = true;
            // 
            // historicosTableAdapter
            // 
            this.historicosTableAdapter.ClearBeforeFill = true;
            // 
            // meta_AnualTableAdapter
            // 
            this.meta_AnualTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 665);
            this.Controls.Add(this.dataGridViewNoDisponibles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.planificacion.ResumeLayout(false);
            this.planificacion.PerformLayout();
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaAnualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnergiacadaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPareto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretotramoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelocidadDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanificacion)).EndInit();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.groupBoxNoticia.ResumeLayout(false);
            this.groupBoxNoticia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarDisponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistoricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxNoticia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistoricosVientosToolStripMenuItem;
        private System.Windows.Forms.GroupBox planificacion;
        private System.Windows.Forms.DataGridView dataGridViewPlanificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPlanificar;
        private System.Windows.Forms.TextBox textBoxEnergiaProducir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIteraciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewNoDisponibles;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource disponibilidadBindingSource;
        private VientosDataSetTableAdapters.DisponibilidadTableAdapter disponibilidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewVelocidadDireccion;
        private System.Windows.Forms.BindingSource historicosclimaBindingSource;
        private VientosDataSetTableAdapters.Historicos_climaTableAdapter historicos_climaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem configurarParetoTramosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewPareto;
        private System.Windows.Forms.BindingSource paretotramoBindingSource;
        private VientosDataSetTableAdapters.pareto_tramoTableAdapter pareto_tramoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonGuardarPlanificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource historicosBindingSource;
        private VientosDataSetTableAdapters.HistoricosTableAdapter historicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramodiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaproducidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionvientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerogeneradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewVelocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource historicosclimaBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem verHistoricosAerogeneradoresToolStripMenuItem;
        private System.Windows.Forms.Label labelMensajeError;
        private System.Windows.Forms.DataGridView dataGridViewEnergiacadaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energia;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaDeLosVientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Label labelEnergiaTotalProducida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFechaPlanificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTiempodeEjecucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aerogeneradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergiaTotal;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgreso;
        private System.Windows.Forms.DataGridView dataGridView2;
        private VientosDataSet vientosDataSet1;
        private System.Windows.Forms.BindingSource metaAnualBindingSource;
        private VientosDataSetTableAdapters.Meta_AnualTableAdapter meta_AnualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem configurarMetaAnualToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.Label labelEnergiaAnual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.Label label13;
    }
}

