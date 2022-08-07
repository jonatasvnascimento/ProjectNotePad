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
    public partial class FormExportBlocoDeNotas : Form
    {
        public string path { get; set; }
        FileInfo file;
        public FormExportBlocoDeNotas()
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

        List<offline> ret;
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadTxt();
        }

        private void ReadTxt()
        {
            if (!string.IsNullOrEmpty(path))
            {
                using (StreamReader txt = new StreamReader(path))
                {
                    string line;
                    List<offline> codbar = new List<offline>();

                    while ((line = txt.ReadLine()) != null)
                    {
                        codbar.Add(new offline() { filial = tbxFilial.Text, codbar = line.ToString(), data = tbxData.Text, hora = tbxHora.Text });
                    }

                    dataGridView1.DataSource = codbar;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenTxt();
        }

        private void tbxFilial_TextChanged(object sender, EventArgs e)
        {
            ReadTxt();
        }

        private void tbxData_TextChanged(object sender, EventArgs e)
        {
            ReadTxt();
        }

        private void tbxHora_TextChanged(object sender, EventArgs e)
        {
            ReadTxt();
        }
        public void OpenTxt()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "NotePad|*.txt" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //txtFilename.Text = openFileDialog.FileName;
                    path = openFileDialog.FileName;
                    lblPath.Text = openFileDialog.FileName;
                    //path = Path.GetTempFileName();
                    //var fi1 = new FileInfo(path);
                    ReadTxt();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Selecione um txt");
                return;
            }
            TextWriter writer = new StreamWriter($"{path}_Exported.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 3)
                    {
                        writer.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()},");
                    }
                    else
                    {
                        writer.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");
                    }
                }
                writer.Write("\r\n");
            }
            writer.Close();
            MessageBox.Show("TXT Exported");

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReadTxt();
        }
    }
}
