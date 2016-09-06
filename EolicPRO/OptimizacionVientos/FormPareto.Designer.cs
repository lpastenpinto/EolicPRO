namespace OptimizacionVientos
{
    partial class FormPareto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPareto));
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.pareto_tramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pareto_tramoTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.pareto_tramoTableAdapter();
            this.tableAdapterManager = new OptimizacionVientos.VientosDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTramo1 = new System.Windows.Forms.TextBox();
            this.textBoxTramo4 = new System.Windows.Forms.TextBox();
            this.textBoxTramo5 = new System.Windows.Forms.TextBox();
            this.textBoxTramo8 = new System.Windows.Forms.TextBox();
            this.textBoxTramo6 = new System.Windows.Forms.TextBox();
            this.textBoxTramo7 = new System.Windows.Forms.TextBox();
            this.textBoxTramo3 = new System.Windows.Forms.TextBox();
            this.textBoxTramo2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPareto = new System.Windows.Forms.DataGridView();
            this.tramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paretotramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEtramo1 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo4 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo5 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo6 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo7 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo8 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo3 = new System.Windows.Forms.TextBox();
            this.textBoxEtramo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEnergia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxVelocidad1 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad2 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad3 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad4 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad5 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad6 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad7 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pareto_tramoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPareto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretotramoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pareto_tramoBindingSource
            // 
            this.pareto_tramoBindingSource.DataMember = "pareto_tramo";
            this.pareto_tramoBindingSource.DataSource = this.vientosDataSet;
            // 
            // pareto_tramoTableAdapter
            // 
            this.pareto_tramoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisponibilidadTableAdapter = null;
            this.tableAdapterManager.Historicos_climaTableAdapter = null;
            this.tableAdapterManager.HistoricosTableAdapter = null;
            this.tableAdapterManager.pareto_tramoTableAdapter = this.pareto_tramoTableAdapter;
            this.tableAdapterManager.UpdateOrder = OptimizacionVientos.VientosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tramo 2:01-5:00 a.m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramo 20:01-23:00 p.m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tramo 14:01-17:00 p.m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tramo 17:01-20:00 p.m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tramo 11:01-14:00 p.m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tramo 8:01-11:00 a.m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tramo 5:01-8:00 a.m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tramo 23:01-2:00 a.m";
            // 
            // textBoxTramo1
            // 
            this.textBoxTramo1.Location = new System.Drawing.Point(257, 139);
            this.textBoxTramo1.MaxLength = 4;
            this.textBoxTramo1.Name = "textBoxTramo1";
            this.textBoxTramo1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo1.TabIndex = 1;
            this.textBoxTramo1.TextChanged += new System.EventHandler(this.textBoxTramo1_TextChanged);
            this.textBoxTramo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo1_KeyPress);
            // 
            // textBoxTramo4
            // 
            this.textBoxTramo4.Location = new System.Drawing.Point(257, 216);
            this.textBoxTramo4.MaxLength = 4;
            this.textBoxTramo4.Name = "textBoxTramo4";
            this.textBoxTramo4.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo4.TabIndex = 4;
            this.textBoxTramo4.TextChanged += new System.EventHandler(this.textBoxTramo4_TextChanged);
            this.textBoxTramo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo4_KeyPress);
            // 
            // textBoxTramo5
            // 
            this.textBoxTramo5.Location = new System.Drawing.Point(257, 242);
            this.textBoxTramo5.MaxLength = 4;
            this.textBoxTramo5.Name = "textBoxTramo5";
            this.textBoxTramo5.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo5.TabIndex = 5;
            this.textBoxTramo5.TextChanged += new System.EventHandler(this.textBoxTramo5_TextChanged);
            this.textBoxTramo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo5_KeyPress);
            // 
            // textBoxTramo8
            // 
            this.textBoxTramo8.Location = new System.Drawing.Point(257, 320);
            this.textBoxTramo8.MaxLength = 4;
            this.textBoxTramo8.Name = "textBoxTramo8";
            this.textBoxTramo8.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo8.TabIndex = 8;
            this.textBoxTramo8.TextChanged += new System.EventHandler(this.textBoxTramo8_TextChanged);
            this.textBoxTramo8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo8_KeyPress);
            // 
            // textBoxTramo6
            // 
            this.textBoxTramo6.Location = new System.Drawing.Point(257, 268);
            this.textBoxTramo6.MaxLength = 4;
            this.textBoxTramo6.Name = "textBoxTramo6";
            this.textBoxTramo6.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo6.TabIndex = 6;
            this.textBoxTramo6.TextChanged += new System.EventHandler(this.textBoxTramo6_TextChanged);
            this.textBoxTramo6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo6_KeyPress);
            // 
            // textBoxTramo7
            // 
            this.textBoxTramo7.Location = new System.Drawing.Point(257, 294);
            this.textBoxTramo7.MaxLength = 4;
            this.textBoxTramo7.Name = "textBoxTramo7";
            this.textBoxTramo7.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo7.TabIndex = 7;
            this.textBoxTramo7.TextChanged += new System.EventHandler(this.textBoxTramo7_TextChanged);
            this.textBoxTramo7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo7_KeyPress);
            // 
            // textBoxTramo3
            // 
            this.textBoxTramo3.Location = new System.Drawing.Point(257, 190);
            this.textBoxTramo3.MaxLength = 4;
            this.textBoxTramo3.Name = "textBoxTramo3";
            this.textBoxTramo3.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo3.TabIndex = 3;
            this.textBoxTramo3.TextChanged += new System.EventHandler(this.textBoxTramo3_TextChanged);
            this.textBoxTramo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo3_KeyPress);
            // 
            // textBoxTramo2
            // 
            this.textBoxTramo2.Location = new System.Drawing.Point(257, 164);
            this.textBoxTramo2.MaxLength = 4;
            this.textBoxTramo2.Name = "textBoxTramo2";
            this.textBoxTramo2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTramo2.TabIndex = 2;
            this.textBoxTramo2.TextChanged += new System.EventHandler(this.textBoxTramo2_TextChanged);
            this.textBoxTramo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTramo2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPareto
            // 
            this.dataGridViewPareto.AutoGenerateColumns = false;
            this.dataGridViewPareto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPareto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tramoDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn});
            this.dataGridViewPareto.DataSource = this.paretotramoBindingSource;
            this.dataGridViewPareto.Location = new System.Drawing.Point(1, 326);
            this.dataGridViewPareto.Name = "dataGridViewPareto";
            this.dataGridViewPareto.Size = new System.Drawing.Size(14, 13);
            this.dataGridViewPareto.TabIndex = 18;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEtramo1
            // 
            this.textBoxEtramo1.Location = new System.Drawing.Point(396, 138);
            this.textBoxEtramo1.Name = "textBoxEtramo1";
            this.textBoxEtramo1.ReadOnly = true;
            this.textBoxEtramo1.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo1.TabIndex = 20;
            // 
            // textBoxEtramo4
            // 
            this.textBoxEtramo4.Location = new System.Drawing.Point(396, 216);
            this.textBoxEtramo4.Name = "textBoxEtramo4";
            this.textBoxEtramo4.ReadOnly = true;
            this.textBoxEtramo4.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo4.TabIndex = 21;
            // 
            // textBoxEtramo5
            // 
            this.textBoxEtramo5.Location = new System.Drawing.Point(396, 242);
            this.textBoxEtramo5.Name = "textBoxEtramo5";
            this.textBoxEtramo5.ReadOnly = true;
            this.textBoxEtramo5.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo5.TabIndex = 22;
            // 
            // textBoxEtramo6
            // 
            this.textBoxEtramo6.Location = new System.Drawing.Point(396, 268);
            this.textBoxEtramo6.Name = "textBoxEtramo6";
            this.textBoxEtramo6.ReadOnly = true;
            this.textBoxEtramo6.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo6.TabIndex = 23;
            // 
            // textBoxEtramo7
            // 
            this.textBoxEtramo7.Location = new System.Drawing.Point(396, 294);
            this.textBoxEtramo7.Name = "textBoxEtramo7";
            this.textBoxEtramo7.ReadOnly = true;
            this.textBoxEtramo7.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo7.TabIndex = 24;
            // 
            // textBoxEtramo8
            // 
            this.textBoxEtramo8.Location = new System.Drawing.Point(396, 320);
            this.textBoxEtramo8.Name = "textBoxEtramo8";
            this.textBoxEtramo8.ReadOnly = true;
            this.textBoxEtramo8.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo8.TabIndex = 25;
            // 
            // textBoxEtramo3
            // 
            this.textBoxEtramo3.Location = new System.Drawing.Point(396, 190);
            this.textBoxEtramo3.Name = "textBoxEtramo3";
            this.textBoxEtramo3.ReadOnly = true;
            this.textBoxEtramo3.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo3.TabIndex = 26;
            // 
            // textBoxEtramo2
            // 
            this.textBoxEtramo2.Location = new System.Drawing.Point(396, 164);
            this.textBoxEtramo2.Name = "textBoxEtramo2";
            this.textBoxEtramo2.ReadOnly = true;
            this.textBoxEtramo2.Size = new System.Drawing.Size(62, 20);
            this.textBoxEtramo2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "La Energía a Producir es: ";
            // 
            // labelEnergia
            // 
            this.labelEnergia.AutoSize = true;
            this.labelEnergia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEnergia.Location = new System.Drawing.Point(150, 76);
            this.labelEnergia.Name = "labelEnergia";
            this.labelEnergia.Size = new System.Drawing.Size(0, 13);
            this.labelEnergia.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "[Mw]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(464, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "[Mw]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(464, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "[Mw]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "[Mw]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(464, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "[Mw]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(464, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "[Mw]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(464, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "[Mw]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(464, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "[Mw]";
            // 
            // textBoxVelocidad1
            // 
            this.textBoxVelocidad1.Location = new System.Drawing.Point(189, 139);
            this.textBoxVelocidad1.Name = "textBoxVelocidad1";
            this.textBoxVelocidad1.ReadOnly = true;
            this.textBoxVelocidad1.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad1.TabIndex = 38;
            // 
            // textBoxVelocidad2
            // 
            this.textBoxVelocidad2.Location = new System.Drawing.Point(189, 164);
            this.textBoxVelocidad2.Name = "textBoxVelocidad2";
            this.textBoxVelocidad2.ReadOnly = true;
            this.textBoxVelocidad2.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad2.TabIndex = 39;
            // 
            // textBoxVelocidad3
            // 
            this.textBoxVelocidad3.Location = new System.Drawing.Point(189, 190);
            this.textBoxVelocidad3.Name = "textBoxVelocidad3";
            this.textBoxVelocidad3.ReadOnly = true;
            this.textBoxVelocidad3.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad3.TabIndex = 40;
            // 
            // textBoxVelocidad4
            // 
            this.textBoxVelocidad4.Location = new System.Drawing.Point(189, 217);
            this.textBoxVelocidad4.Name = "textBoxVelocidad4";
            this.textBoxVelocidad4.ReadOnly = true;
            this.textBoxVelocidad4.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad4.TabIndex = 41;
            // 
            // textBoxVelocidad5
            // 
            this.textBoxVelocidad5.Location = new System.Drawing.Point(189, 242);
            this.textBoxVelocidad5.Name = "textBoxVelocidad5";
            this.textBoxVelocidad5.ReadOnly = true;
            this.textBoxVelocidad5.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad5.TabIndex = 42;
            // 
            // textBoxVelocidad6
            // 
            this.textBoxVelocidad6.Location = new System.Drawing.Point(189, 268);
            this.textBoxVelocidad6.Name = "textBoxVelocidad6";
            this.textBoxVelocidad6.ReadOnly = true;
            this.textBoxVelocidad6.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad6.TabIndex = 43;
            // 
            // textBoxVelocidad7
            // 
            this.textBoxVelocidad7.Location = new System.Drawing.Point(189, 294);
            this.textBoxVelocidad7.Name = "textBoxVelocidad7";
            this.textBoxVelocidad7.ReadOnly = true;
            this.textBoxVelocidad7.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad7.TabIndex = 44;
            // 
            // textBoxVelocidad8
            // 
            this.textBoxVelocidad8.Location = new System.Drawing.Point(189, 320);
            this.textBoxVelocidad8.Name = "textBoxVelocidad8";
            this.textBoxVelocidad8.ReadOnly = true;
            this.textBoxVelocidad8.Size = new System.Drawing.Size(39, 20);
            this.textBoxVelocidad8.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(164, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Velocidad Viento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(287, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Pareto";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(393, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Energía a Producir:";
            // 
            // FormPareto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 457);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxVelocidad8);
            this.Controls.Add(this.textBoxVelocidad7);
            this.Controls.Add(this.textBoxVelocidad6);
            this.Controls.Add(this.textBoxVelocidad5);
            this.Controls.Add(this.textBoxVelocidad4);
            this.Controls.Add(this.textBoxVelocidad3);
            this.Controls.Add(this.textBoxVelocidad2);
            this.Controls.Add(this.textBoxVelocidad1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelEnergia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEtramo2);
            this.Controls.Add(this.textBoxEtramo3);
            this.Controls.Add(this.textBoxEtramo8);
            this.Controls.Add(this.textBoxEtramo7);
            this.Controls.Add(this.textBoxEtramo6);
            this.Controls.Add(this.textBoxEtramo5);
            this.Controls.Add(this.textBoxEtramo4);
            this.Controls.Add(this.textBoxEtramo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewPareto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTramo2);
            this.Controls.Add(this.textBoxTramo3);
            this.Controls.Add(this.textBoxTramo7);
            this.Controls.Add(this.textBoxTramo6);
            this.Controls.Add(this.textBoxTramo8);
            this.Controls.Add(this.textBoxTramo5);
            this.Controls.Add(this.textBoxTramo4);
            this.Controls.Add(this.textBoxTramo1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPareto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Pareto Tramos";
            this.Load += new System.EventHandler(this.FormPareto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pareto_tramoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPareto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretotramoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource pareto_tramoBindingSource;
        private VientosDataSetTableAdapters.pareto_tramoTableAdapter pareto_tramoTableAdapter;
        private VientosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTramo1;
        private System.Windows.Forms.TextBox textBoxTramo4;
        private System.Windows.Forms.TextBox textBoxTramo5;
        private System.Windows.Forms.TextBox textBoxTramo8;
        private System.Windows.Forms.TextBox textBoxTramo6;
        private System.Windows.Forms.TextBox textBoxTramo7;
        private System.Windows.Forms.TextBox textBoxTramo3;
        private System.Windows.Forms.TextBox textBoxTramo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPareto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paretotramoBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEtramo1;
        private System.Windows.Forms.TextBox textBoxEtramo4;
        private System.Windows.Forms.TextBox textBoxEtramo5;
        private System.Windows.Forms.TextBox textBoxEtramo6;
        private System.Windows.Forms.TextBox textBoxEtramo7;
        private System.Windows.Forms.TextBox textBoxEtramo8;
        private System.Windows.Forms.TextBox textBoxEtramo3;
        private System.Windows.Forms.TextBox textBoxEtramo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEnergia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxVelocidad1;
        private System.Windows.Forms.TextBox textBoxVelocidad2;
        private System.Windows.Forms.TextBox textBoxVelocidad3;
        private System.Windows.Forms.TextBox textBoxVelocidad4;
        private System.Windows.Forms.TextBox textBoxVelocidad5;
        private System.Windows.Forms.TextBox textBoxVelocidad6;
        private System.Windows.Forms.TextBox textBoxVelocidad7;
        private System.Windows.Forms.TextBox textBoxVelocidad8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}