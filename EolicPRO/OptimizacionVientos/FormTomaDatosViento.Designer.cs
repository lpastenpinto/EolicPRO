namespace OptimizacionVientos
{
    partial class FormTomaDatosViento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramodiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadvientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosclimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBoxTramo8 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo7 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo6 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo5 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo4 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo3 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTramo1 = new System.Windows.Forms.ComboBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVelocidadTramo4 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo3 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo6 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo5 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo8 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo7 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo2 = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadTramo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowserTomaDatos = new System.Windows.Forms.WebBrowser();
            this.historicos_climaTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.Historicos_climaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(4, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 484);
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserTomaDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 484);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tramodiaDataGridViewTextBoxColumn,
            this.direccionvientoDataGridViewTextBoxColumn,
            this.velocidadvientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historicosclimaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 38;
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
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.comboBoxTramo8);
            this.groupBox1.Controls.Add(this.comboBoxTramo7);
            this.groupBox1.Controls.Add(this.comboBoxTramo6);
            this.groupBox1.Controls.Add(this.comboBoxTramo5);
            this.groupBox1.Controls.Add(this.comboBoxTramo4);
            this.groupBox1.Controls.Add(this.comboBoxTramo3);
            this.groupBox1.Controls.Add(this.comboBoxTramo2);
            this.groupBox1.Controls.Add(this.comboBoxTramo1);
            this.groupBox1.Controls.Add(this.buttonIngresar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo4);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo3);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo6);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo5);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo8);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo7);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo2);
            this.groupBox1.Controls.Add(this.textBoxVelocidadTramo1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 454);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toma de Datos";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(197, 438);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Rosa de los Vientos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBoxTramo8
            // 
            this.comboBoxTramo8.FormattingEnabled = true;
            this.comboBoxTramo8.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo8.Location = new System.Drawing.Point(105, 254);
            this.comboBoxTramo8.Name = "comboBoxTramo8";
            this.comboBoxTramo8.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo8.TabIndex = 15;
            this.comboBoxTramo8.Text = "N";
            // 
            // comboBoxTramo7
            // 
            this.comboBoxTramo7.FormattingEnabled = true;
            this.comboBoxTramo7.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo7.Location = new System.Drawing.Point(105, 227);
            this.comboBoxTramo7.Name = "comboBoxTramo7";
            this.comboBoxTramo7.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo7.TabIndex = 13;
            this.comboBoxTramo7.Text = "N";
            // 
            // comboBoxTramo6
            // 
            this.comboBoxTramo6.FormattingEnabled = true;
            this.comboBoxTramo6.Items.AddRange(new object[] {
            "E",
            "ENE",
            "ESE",
            "NE",
            "NNE",
            "NNW",
            "NW",
            "S",
            "SE",
            "SSW",
            "SW",
            "W",
            "WNW",
            "WSW"});
            this.comboBoxTramo6.Location = new System.Drawing.Point(105, 202);
            this.comboBoxTramo6.Name = "comboBoxTramo6";
            this.comboBoxTramo6.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo6.Sorted = true;
            this.comboBoxTramo6.TabIndex = 11;
            this.comboBoxTramo6.Text = "N";
            // 
            // comboBoxTramo5
            // 
            this.comboBoxTramo5.FormattingEnabled = true;
            this.comboBoxTramo5.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo5.Location = new System.Drawing.Point(105, 176);
            this.comboBoxTramo5.Name = "comboBoxTramo5";
            this.comboBoxTramo5.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo5.TabIndex = 9;
            this.comboBoxTramo5.Text = "N";
            // 
            // comboBoxTramo4
            // 
            this.comboBoxTramo4.FormattingEnabled = true;
            this.comboBoxTramo4.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo4.Location = new System.Drawing.Point(105, 150);
            this.comboBoxTramo4.Name = "comboBoxTramo4";
            this.comboBoxTramo4.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo4.TabIndex = 7;
            this.comboBoxTramo4.Text = "N";
            // 
            // comboBoxTramo3
            // 
            this.comboBoxTramo3.FormattingEnabled = true;
            this.comboBoxTramo3.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo3.Location = new System.Drawing.Point(105, 124);
            this.comboBoxTramo3.Name = "comboBoxTramo3";
            this.comboBoxTramo3.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo3.TabIndex = 5;
            this.comboBoxTramo3.Text = "N";
            // 
            // comboBoxTramo2
            // 
            this.comboBoxTramo2.FormattingEnabled = true;
            this.comboBoxTramo2.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo2.Location = new System.Drawing.Point(105, 98);
            this.comboBoxTramo2.Name = "comboBoxTramo2";
            this.comboBoxTramo2.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo2.TabIndex = 3;
            this.comboBoxTramo2.Text = "N";
            // 
            // comboBoxTramo1
            // 
            this.comboBoxTramo1.FormattingEnabled = true;
            this.comboBoxTramo1.Items.AddRange(new object[] {
            "W",
            "WNW",
            "NW",
            "NNW",
            "WSW",
            "S",
            "SSW",
            "SW",
            "NNE",
            "NE",
            "ENE",
            "E",
            "ESE",
            "SE",
            "SSE"});
            this.comboBoxTramo1.Location = new System.Drawing.Point(105, 72);
            this.comboBoxTramo1.Name = "comboBoxTramo1";
            this.comboBoxTramo1.Size = new System.Drawing.Size(75, 21);
            this.comboBoxTramo1.TabIndex = 1;
            this.comboBoxTramo1.Text = "N";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(130, 321);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 29;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "11";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "17";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "2";
            // 
            // textBoxVelocidadTramo4
            // 
            this.textBoxVelocidadTramo4.Location = new System.Drawing.Point(211, 151);
            this.textBoxVelocidadTramo4.MaxLength = 2;
            this.textBoxVelocidadTramo4.Name = "textBoxVelocidadTramo4";
            this.textBoxVelocidadTramo4.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo4.TabIndex = 8;
            this.textBoxVelocidadTramo4.Text = "0";
            this.textBoxVelocidadTramo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo4_KeyPress);
            // 
            // textBoxVelocidadTramo3
            // 
            this.textBoxVelocidadTramo3.Location = new System.Drawing.Point(211, 125);
            this.textBoxVelocidadTramo3.MaxLength = 2;
            this.textBoxVelocidadTramo3.Name = "textBoxVelocidadTramo3";
            this.textBoxVelocidadTramo3.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo3.TabIndex = 6;
            this.textBoxVelocidadTramo3.Text = "0";
            this.textBoxVelocidadTramo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo3_KeyPress);
            // 
            // textBoxVelocidadTramo6
            // 
            this.textBoxVelocidadTramo6.Location = new System.Drawing.Point(211, 203);
            this.textBoxVelocidadTramo6.MaxLength = 2;
            this.textBoxVelocidadTramo6.Name = "textBoxVelocidadTramo6";
            this.textBoxVelocidadTramo6.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo6.TabIndex = 12;
            this.textBoxVelocidadTramo6.Text = "0";
            this.textBoxVelocidadTramo6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo6_KeyPress);
            // 
            // textBoxVelocidadTramo5
            // 
            this.textBoxVelocidadTramo5.Location = new System.Drawing.Point(211, 177);
            this.textBoxVelocidadTramo5.MaxLength = 2;
            this.textBoxVelocidadTramo5.Name = "textBoxVelocidadTramo5";
            this.textBoxVelocidadTramo5.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo5.TabIndex = 10;
            this.textBoxVelocidadTramo5.Text = "0";
            this.textBoxVelocidadTramo5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo5_KeyPress);
            // 
            // textBoxVelocidadTramo8
            // 
            this.textBoxVelocidadTramo8.Location = new System.Drawing.Point(211, 255);
            this.textBoxVelocidadTramo8.MaxLength = 2;
            this.textBoxVelocidadTramo8.Name = "textBoxVelocidadTramo8";
            this.textBoxVelocidadTramo8.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo8.TabIndex = 16;
            this.textBoxVelocidadTramo8.Text = "0";
            this.textBoxVelocidadTramo8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo8_KeyPress);
            // 
            // textBoxVelocidadTramo7
            // 
            this.textBoxVelocidadTramo7.Location = new System.Drawing.Point(211, 229);
            this.textBoxVelocidadTramo7.MaxLength = 2;
            this.textBoxVelocidadTramo7.Name = "textBoxVelocidadTramo7";
            this.textBoxVelocidadTramo7.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo7.TabIndex = 14;
            this.textBoxVelocidadTramo7.Text = "0";
            this.textBoxVelocidadTramo7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo7_KeyPress);
            // 
            // textBoxVelocidadTramo2
            // 
            this.textBoxVelocidadTramo2.Location = new System.Drawing.Point(211, 99);
            this.textBoxVelocidadTramo2.MaxLength = 2;
            this.textBoxVelocidadTramo2.Name = "textBoxVelocidadTramo2";
            this.textBoxVelocidadTramo2.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo2.TabIndex = 4;
            this.textBoxVelocidadTramo2.Text = "0";
            this.textBoxVelocidadTramo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo2_KeyPress);
            // 
            // textBoxVelocidadTramo1
            // 
            this.textBoxVelocidadTramo1.Location = new System.Drawing.Point(211, 73);
            this.textBoxVelocidadTramo1.MaxLength = 2;
            this.textBoxVelocidadTramo1.Name = "textBoxVelocidadTramo1";
            this.textBoxVelocidadTramo1.Size = new System.Drawing.Size(87, 20);
            this.textBoxVelocidadTramo1.TabIndex = 2;
            this.textBoxVelocidadTramo1.Text = "0";
            this.textBoxVelocidadTramo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVelocidadTramo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVelocidadTramo1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidad M/S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // webBrowserTomaDatos
            // 
            this.webBrowserTomaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTomaDatos.Location = new System.Drawing.Point(0, 0);
            this.webBrowserTomaDatos.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTomaDatos.Name = "webBrowserTomaDatos";
            this.webBrowserTomaDatos.Size = new System.Drawing.Size(684, 484);
            this.webBrowserTomaDatos.TabIndex = 0;
            // 
            // historicos_climaTableAdapter
            // 
            this.historicos_climaTableAdapter.ClearBeforeFill = true;
            // 
            // FormTomaDatosViento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 557);
            this.Controls.Add(this.panel1);
            this.Name = "FormTomaDatosViento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomar Datos Viento";
            this.Load += new System.EventHandler(this.FormTomaDatosViento_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicosclimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowserTomaDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo4;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo3;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo6;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo5;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo8;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo7;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo2;
        private System.Windows.Forms.TextBox textBoxVelocidadTramo1;
        private System.Windows.Forms.ComboBox comboBoxTramo8;
        private System.Windows.Forms.ComboBox comboBoxTramo7;
        private System.Windows.Forms.ComboBox comboBoxTramo6;
        private System.Windows.Forms.ComboBox comboBoxTramo5;
        private System.Windows.Forms.ComboBox comboBoxTramo4;
        private System.Windows.Forms.ComboBox comboBoxTramo3;
        private System.Windows.Forms.ComboBox comboBoxTramo2;
        private System.Windows.Forms.ComboBox comboBoxTramo1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource historicosclimaBindingSource;
        private VientosDataSetTableAdapters.Historicos_climaTableAdapter historicos_climaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramodiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadvientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
      
    }
}