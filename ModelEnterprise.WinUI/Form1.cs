using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelEnterprise.Service;

namespace ModelEnterprise.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly GeneralService _generalService = new GeneralService("Server=37.148.212.86;Database=BildirimTakip;User Id=sa;Password=ModelMbi2019@;");
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _generalService.GetAllIssue("hidir.isitmez").ToList();
        }
    }
}
