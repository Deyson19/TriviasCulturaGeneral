using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace TriviasCulturaGeneral
{
    public partial class frmPreguntas : Form
    {
        public frmPreguntas()
        {
            InitializeComponent();
            pnlMuroBerlin.Hide();
            pnlTransilvania.Hide();
            
            imgGanador.Hide();
            imgDerrota.Hide();

            
        }
        int puntos = 0;
       void ocultarTodo()
        {
            pnlMuroBerlin.Hide();
            pnlTransilvania.Hide();
            pnlRioMasGrande.Hide();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNilo_Click(object sender, EventArgs e)
        {
            frmIncorrecta frmIncorrecta = new frmIncorrecta();
            frmIncorrecta.Show();
            restarPuntos();
        }
        void sumarPuntos()
        {
            puntos = puntos+150;
            lblPuntos.Text = puntos.ToString();
        }
        void restarPuntos()
        {
            puntos = puntos-50;
            lblPuntos.Text = puntos.ToString();
        }
        void respuestaCorrecta()
        {
            frmCorrecta frmCorrecta = new frmCorrecta();
            frmCorrecta.Show();
            sumarPuntos();
        }
        void respuestaIncorrecta()
        {
            frmIncorrecta frmIncorrecta = new frmIncorrecta();
            frmIncorrecta.Show();
            restarPuntos();
        }
        private void btnAmazonas_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            pnlMuroBerlin.Show();
        }

        private void btnPlata_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btn1989_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            pnlFinal.Hide();
            pnlTransilvania.Show();
        }

        private void btn1986_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btn1995_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnAlemania_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnRepCheca_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnRumania_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            
            pnlFinal.Show();

            lblTitulo.Text = "Felicidades por el puntaje obtenido".ToUpperInvariant();
            
            lblPuntosFinales.Text = puntos.ToString();
            if (puntos >= 300)
            {
                imgGanador.Visible = true;
            }
            else
            {
                imgDerrota.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlFinal.Show();
        }
    }
}
