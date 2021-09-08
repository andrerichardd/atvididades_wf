using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHelloworld : Form
    {
        public FrmHelloworld()
        {
            InitializeComponent();
        }

        private void Btm_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld.Text = "Texto mudado";
        }

        private void txt_ConteudoLabel_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld.Text = txt_ConteudoLabel.Text;
        }
    }
}
