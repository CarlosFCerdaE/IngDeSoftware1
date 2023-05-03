namespace SistemaRegistroLibros
{
    partial class FrmAutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.bDLibrosDataSet = new SistemaRegistroLibros.BDLibrosDataSet();
            this.bDLibrosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorTableAdapter = new SistemaRegistroLibros.BDLibrosDataSetTableAdapters.AutorTableAdapter();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLibrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLibrosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de autores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistros);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autores Guardados";
            // 
            // dgvRegistros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistros.AutoGenerateColumns = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn});
            this.dgvRegistros.DataSource = this.autorBindingSource;
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistros.Location = new System.Drawing.Point(3, 18);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(1050, 587);
            this.dgvRegistros.TabIndex = 0;
            // 
            // bDLibrosDataSet
            // 
            this.bDLibrosDataSet.DataSetName = "BDLibrosDataSet";
            this.bDLibrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDLibrosDataSetBindingSource
            // 
            this.bDLibrosDataSetBindingSource.DataSource = this.bDLibrosDataSet;
            this.bDLibrosDataSetBindingSource.Position = 0;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.bDLibrosDataSetBindingSource;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIDDataGridViewTextBoxColumn.Visible = false;
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLibrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLibrosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.BindingSource bDLibrosDataSetBindingSource;
        private BDLibrosDataSet bDLibrosDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private BDLibrosDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
    }
}

