namespace SistemaRegistroLibros.formularios
{
    partial class FrmRegistrarAutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBuscar = new System.Windows.Forms.CheckBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.cBVR = new System.Windows.Forms.CheckBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAutor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbAutor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBuscar);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.cBVR);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // chkBuscar
            // 
            this.chkBuscar.AutoSize = true;
            this.chkBuscar.Location = new System.Drawing.Point(24, 30);
            this.chkBuscar.Name = "chkBuscar";
            this.chkBuscar.Size = new System.Drawing.Size(71, 20);
            this.chkBuscar.TabIndex = 7;
            this.chkBuscar.Text = "Buscar";
            this.chkBuscar.UseVisualStyleBackColor = true;
            this.chkBuscar.CheckedChanged += new System.EventHandler(this.chkBuscar_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Enabled = false;
            this.tbBuscar.Location = new System.Drawing.Point(141, 29);
            this.tbBuscar.MaxLength = 30;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(199, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // cBVR
            // 
            this.cBVR.AutoSize = true;
            this.cBVR.Location = new System.Drawing.Point(24, 175);
            this.cBVR.Name = "cBVR";
            this.cBVR.Size = new System.Drawing.Size(111, 20);
            this.cBVR.TabIndex = 4;
            this.cBVR.Text = "Ver Registros";
            this.cBVR.UseVisualStyleBackColor = true;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(141, 131);
            this.txtLN.MaxLength = 30;
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(199, 22);
            this.txtLN.TabIndex = 3;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(141, 78);
            this.txtFN.MaxLength = 30;
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(199, 22);
            this.txtFN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.BtnEdit,
            this.BtnDelete,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNew.Image = global::SistemaRegistroLibros.Properties.Resources.newIcon;
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(29, 24);
            this.BtnNew.Text = "toolStripButton1";
            this.BtnNew.ToolTipText = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::SistemaRegistroLibros.Properties.Resources.saveIcon;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(29, 24);
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Image = global::SistemaRegistroLibros.Properties.Resources.editIcon;
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(29, 24);
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = global::SistemaRegistroLibros.Properties.Resources.deleteIcon;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(29, 24);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbAutor
            // 
            this.tbAutor.Controls.Add(this.tabPage1);
            this.tbAutor.Controls.Add(this.tabPage2);
            this.tbAutor.Location = new System.Drawing.Point(37, 59);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.SelectedIndex = 0;
            this.tbAutor.Size = new System.Drawing.Size(626, 375);
            this.tbAutor.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de Autor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbCampo);
            this.tabPage2.Controls.Add(this.tbFiltro);
            this.tabPage2.Controls.Add(this.dgvRegistros);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(3, 105);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(612, 215);
            this.dgvRegistros.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(196, 60);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(393, 22);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbCampo.Location = new System.Drawing.Point(20, 60);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(139, 24);
            this.cbCampo.TabIndex = 3;
            // 
            // FrmRegistrarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 507);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarAutor";
            this.Text = "Registro de Autor";
            this.Load += new System.EventHandler(this.FrmRegistrarAutor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbAutor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.CheckBox cBVR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TabControl tbAutor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.ComboBox cbCampo;
    }
}