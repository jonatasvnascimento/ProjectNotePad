using System;
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
    public partial class FormLeituraOffline : Form
    {
        public FormLeituraOffline()
        {
            InitializeComponent();
        }

        public class offline
        {
            public string filial { get; set; }
            public string codbar { get; set; }
            public string data { get; set; }
            public string hora { get; set; }
        }

        private void FormLeituraOffline_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            this.Hide();
            formInicial.Show();
        }
    }
}
