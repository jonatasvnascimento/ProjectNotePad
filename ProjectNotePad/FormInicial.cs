﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNotePad
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExportarBlocoDeNotas_Click(object sender, EventArgs e)
        {
            FormExportBlocoDeNotas formExportBlocoDeNotas = new FormExportBlocoDeNotas();
            this.Hide();
            formExportBlocoDeNotas.Show();

        }

        private void btnLeituraOffline_Click(object sender, EventArgs e)
        {
            FormLeituraOffline formLeituraOffline = new FormLeituraOffline();
            this.Hide();
            formLeituraOffline.Show();
        }
    }
}
