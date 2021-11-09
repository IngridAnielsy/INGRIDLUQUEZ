using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ordenamientos OSD = new Ordenamientos();
            OSD.Show();
            this.Hide();

        }

        private void btnMezcla_Click(object sender, EventArgs e)
        {
            ArbolBinario A = new ArbolBinario();
            A.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArbolBalancead ab = new ArbolBalancead();
            ab.Show();
            this.Hide();
        }
    }
}
