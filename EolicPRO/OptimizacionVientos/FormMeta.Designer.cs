namespace OptimizacionVientos
{
    partial class FormMeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaAnualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vientosDataSet = new OptimizacionVientos.VientosDataSet();
            this.meta_AnualTableAdapter = new OptimizacionVientos.VientosDataSetTableAdapters.Meta_AnualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaAnualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meta Anual:";
            // 
            // textBoxMeta
            // 
            this.textBoxMeta.Location = new System.Drawing.Point(135, 63);
            this.textBoxMeta.MaxLength = 5;
            this.textBoxMeta.Name = "textBoxMeta";
            this.textBoxMeta.Size = new System.Drawing.Size(109, 20);
            this.textBoxMeta.TabIndex = 1;
            this.textBoxMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMeta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "[Gw]";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(152, 105);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 3;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.metaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.metaAnualBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(11, 10);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
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
            this.metaAnualBindingSource.DataSource = this.vientosDataSet;
            // 
            // vientosDataSet
            // 
            this.vientosDataSet.DataSetName = "VientosDataSet";
            this.vientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meta_AnualTableAdapter
            // 
            this.meta_AnualTableAdapter.ClearBeforeFill = true;
            // 
            // FormMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 179);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMeta);
            this.Controls.Add(this.label1);
            this.Name = "FormMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Meta Anual";
            this.Load += new System.EventHandler(this.FormMeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaAnualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vientosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VientosDataSet vientosDataSet;
        private System.Windows.Forms.BindingSource metaAnualBindingSource;
        private VientosDataSetTableAdapters.Meta_AnualTableAdapter meta_AnualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataGridViewTextBoxColumn;
    }
}