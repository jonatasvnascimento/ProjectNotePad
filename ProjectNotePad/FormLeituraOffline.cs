using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNotePad
{
    public partial class FormLeituraOffline : Form
    {
        public string path { get; set; }
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
                string data = DateTime.UtcNow.ToString("MM-dd-yyyy");
                var result = data.Split("-");
                var novaData = $"{result[2]}{result[0]}{result[1]}";
                return novaData;
            }
            public static string Hora()
            {
                return DateTime.Now.ToString("HH:mm");
            }
        }
        private void InsertValueInListView()
        {
            string codbar = textBox1.Text.ToString();

            if (codbar.Length < 10)
            {
                MessageBox.Show("Codigo de barra menor que 10 caracteres");
                return;
            }
            else
            {
                Offline offline = new Offline()
                {
                    filial = "36",
                    codbar = codbar,
                    data = getTime.Data(),
                    hora = getTime.Hora()
                };
                ListViewItem item = new ListViewItem(new[] { offline.filial.ToString(), offline.codbar.ToString(), offline.data.ToString(), offline.hora.ToString() });
                listView1.Items.Add(item);
                lblQtdLidas.Text = listView1.Items.Count.ToString();
                textBox1.Text = "";
                textBox1.Focus();

                SaveCodbar();
            }
        }

        private void SaveCodbar()
        {
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());

            if (!Directory.Exists($"{directory.FullName}\\backup"))
            {
                Directory.CreateDirectory($"{directory.FullName}\\backup");
            }

            using (TextWriter textWriter = new StreamWriter(new FileStream($"{directory.FullName}\\backup\\Teste.txt", FileMode.Create), Encoding.UTF8))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    textWriter.Write($"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text},{item.SubItems[3].Text}");
                    textWriter.Write("\r\n");
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                InsertValueInListView();
            }
        }

        private void saveTXT()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter textWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            textWriter.Write($"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text},{item.SubItems[3].Text}");
                            textWriter.Write("\r\n");
                        }
                        MessageBox.Show("Salvo");
                    }
                }
            }
        }

        private void FormLeituraOffline_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            this.Hide();
            formInicial.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            saveTXT();
        }
    }
}
