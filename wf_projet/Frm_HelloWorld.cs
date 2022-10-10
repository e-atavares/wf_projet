using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_projet
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            // fechar programa ou Application
             this.Close(); 
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = "Label Modificada!"; 


        }

        private void textConteudoLabel_TextChanged(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = textConteudoLabel.Text;
        }

        private void Lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
