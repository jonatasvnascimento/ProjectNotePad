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

        private void FormLeituraOffline_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Filial", 50, HorizontalAlignment.Left);
        }
    }
}
