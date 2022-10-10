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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void text_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Input_KeyDown(object sender, KeyEventArgs e)
        {
            //dois clicks no keydow do textbox, \n\r pula linha 
            txt_Msg.AppendText("\r\n" + "Pressione uma tecla: " + e.KeyCode + "\r\n");

            txt_Msg.AppendText("\t" + "Codigo da Tecla: " + (int)e.KeyCode + "\r\n");
            
            txt_Msg.AppendText("\t" + "Nome da Tecla: " + (int)e.KeyData + "\r\n");

            lbl_Lower.Text = e.KeyCode.ToString().ToLower(); 
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            






        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            lbl_Lower.Text = "";
            lbl_Upper.Text = "";  
        }
    }
}
