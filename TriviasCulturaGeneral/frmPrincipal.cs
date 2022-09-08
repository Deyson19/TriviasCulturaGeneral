using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviasCulturaGeneral
{
    public partial class frmPrincipal : Form
    {
       
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            frmPreguntas preguntas = new frmPreguntas();
            preguntas.Show();

            this.Hide();
            
        }

        private void btnIrATrivia_Click(object sender, EventArgs e)
        {
            frmPreguntas preguntas = new frmPreguntas();
            preguntas.Show();

            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
