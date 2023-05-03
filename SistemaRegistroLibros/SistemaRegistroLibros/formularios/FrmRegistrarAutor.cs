using SistemaRegistroLibros.clases;
using SistemaRegistroLibros.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroLibros.formularios
{
    public partial class FrmRegistrarAutor : Form
    {
        public FrmRegistrarAutor()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DAutor dAutor = new DAutor();
            Autor autor = new Autor(0, txtFN.Text, txtLN.Text);

            if (dAutor.Guardar(autor))
            {
                MessageBox.Show("Registro Guardado");

                if (cBVR.Checked == true)
                {
                    FrmAutor frmautor = new FrmAutor();
                    frmautor.Show();
                }
                BtnDelete.Enabled = true;
                BtnEdit.Enabled = true;
                BtnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
            llenarGrid();


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            DAutor dAutor = new DAutor();

            autor.Id = int.Parse(tbBuscar.Text);
            autor.FirstName = txtFN.Text;
            autor.LastName = txtLN.Text;



            if (dAutor.Editar(autor))
            {
                MessageBox.Show("Editado Correctamente");
                if (cBVR.Checked == true)
                {
                    FrmAutor frmautor = new FrmAutor();
                    frmautor.Show();
                }

            }
            else
            {
                MessageBox.Show("Error al Editar");
            }
            llenarGrid();
        }

        private void chkBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscar.Checked)
            {
                tbBuscar.Enabled = true;
            }
            else
            {
                tbBuscar.Enabled = false;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Autor autor = new Autor();
                DAutor dAutor = new DAutor();

                autor = dAutor.BuscarPorId(int.Parse(tbBuscar.Text));
                txtFN.Text = autor.FirstName;
                txtLN.Text = autor.LastName;

                BtnDelete.Enabled = true;
                BtnEdit.Enabled = true;
                BtnSave.Enabled = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DAutor dAutor = new DAutor();
            dAutor.Eliminar(int.Parse(tbBuscar.Text));

            MessageBox.Show("Eliminado Correctamente");
            if (cBVR.Checked == true)
            {
                FrmAutor frmautor = new FrmAutor();
                frmautor.Show();
            }
            llenarGrid();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            tbBuscar.Clear();
            txtFN.Clear();
            txtLN.Clear();
            chkBuscar.Checked = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Enabled = true;

            txtFN.Focus();
        }

        private void llenarGrid()
        {
            DAutor dAutor = new DAutor();
            DataSet ds = new DataSet();
            ds = dAutor.mostrarRegistro();
            dgvRegistros.DataSource = ds.Tables[0];
            dgvRegistros.Refresh();
        }

        private void FrmRegistrarAutor_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            try
            {
                DAutor dAutor = new DAutor();
                DataSet ds = new DataSet();
                string campo = "";
                switch (cbCampo.SelectedIndex)
                {
                    case 0:
                        campo = "Firstname";
                        break;
                    case 1:
                        campo = "Lastname";
                        break;

                }

                ds = dAutor.mostrarRegistro(campo, tbFiltro.Text);
                dgvRegistros.DataSource = ds.Tables[0];
                dgvRegistros.Refresh();
            }catch (Exception ex)
            {

            }
            
        }

        
    }
}
