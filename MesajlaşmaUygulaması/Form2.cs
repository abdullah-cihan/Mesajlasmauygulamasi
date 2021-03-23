using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace MesajlaşmaUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string numara,adsoyad;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            lblAdSoyad.Text = adsoyad;
        }
    }
}
