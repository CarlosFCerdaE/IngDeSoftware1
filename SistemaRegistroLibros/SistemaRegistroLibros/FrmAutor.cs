using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroLibros
{
    public partial class FrmAutor : Form
    {
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDLibrosDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.bDLibrosDataSet.Autor);

        }
    }
}
