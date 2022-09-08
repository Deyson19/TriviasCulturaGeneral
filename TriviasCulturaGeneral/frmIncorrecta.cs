using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace TriviasCulturaGeneral
{
    public partial class frmIncorrecta : Form
    {
        public frmIncorrecta()
        {
            InitializeComponent();
            playSimpleSound();
        }
        string rutaAudio = "D:/Proyectos/.NetProjects/Escritorio/TriviasCulturaGeneral/TriviasCulturaGeneral/sonidos/incorrecto.wav";
        private void playSimpleSound()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
