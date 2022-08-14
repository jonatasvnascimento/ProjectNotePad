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
            listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.FullRowSelect = true;

            listView1.Columns.Add("Filial", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("CodBar", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Hora", 100, HorizontalAlignment.Left);
        }
        public static class getTime
        {
            public static string Data()
            {
                return DateTime.UtcNow.ToString("MM-dd-yyyy");
            }
            public static string Hora()
            {
                return DateTime.Now.ToString("HH:mm");
            }
        }
        private void InsertValueInListView()
        {
            Offline offline = new Offline()
            {
                filial = "36",
                codbar = textBox1.Text.ToString(),
                data = getTime.Data(),
                hora = getTime.Hora()
            };
            ListViewItem item = new ListViewItem(new[] { offline.filial.ToString(), offline.codbar.ToString(), offline.data.ToString(), offline.hora.ToString() });
            listView1.Items.Add(item);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                InsertValueInListView();
            }
        }

        private void FormLeituraOffline_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            this.Hide();
            formInicial.Show();
        }
    }
}
