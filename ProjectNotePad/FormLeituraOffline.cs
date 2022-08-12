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

        public class Offline
        {
            public string filial { get; set; }
            public string codbar { get; set; }
            public string data { get; set; }
            public string hora { get; set; }
        }

        private void FormLeituraOffline_Load(object sender, EventArgs e)
        {
            Offline offline = new Offline()
            {
                filial = "36",
                codbar = "1002354768",
                data = "20220801",
                hora = "10:00"
            };

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Filial", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("CodBar", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Hora", 100, HorizontalAlignment.Left);

            ListViewItem listViewItem = new ListViewItem();


            listViewItem.SubItems.Add(offline.filial);
            listViewItem.SubItems.Add(offline.codbar);
            listViewItem.SubItems.Add(offline.data);
            listViewItem.SubItems.Add(offline.hora);
            listView1.Items.Add(listViewItem);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            this.Hide();
            formInicial.Show();
        }
    }
}
