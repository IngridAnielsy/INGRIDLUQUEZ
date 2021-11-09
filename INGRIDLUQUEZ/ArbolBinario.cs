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
    public partial class ArbolBinario : Form
    {
        //Variables
        public int Ncantidad { get; set; }
        int aux, posX, posY, i = 0;

        Arbol A;
        Graphics nodo;
        
        public struct avon
        {
            public string cliente { get; set; }
            public double salario { get; set; }
            public string cargo { get; set; }

            public int id { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ncantidad = Convert.ToInt32(txtn.Text);
                aux = Ncantidad;
                if (Ncantidad < 0 || txtn.Text.Length > 8)
                {
                    MessageBox.Show("El dato no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Avon = new avon[Ncantidad];
                    MessageBox.Show($"Podra guardar {Ncantidad} id", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.Enabled = true;
                    gdatos.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El dato no es valido");
            }
        }

        private void gIngrese_Enter(object sender, EventArgs e)
        {

        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
            //insertar datos
            if(i==Ncantidad)
            {
                MessageBox.Show("No es posible ingresar mas elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Avon[i].cliente = txtnombre.Text;
                    Avon[i].id = Convert.ToInt32(txtid.Text);
                    Avon[i].cargo = txtcargo.Text;
                    
                    if (txtcargo.Text == "Vendedor")
                    {
                        Avon[i].salario = 6000;
                    }
                    if (txtcargo.Text == "Bodeguero")
                    {
                        Avon[i].salario = 5000;
                    }
                    if (txtcargo.Text == "Cajero")
                    {
                        Avon[i].salario = 6500;
                    }
                    if (txtcargo.Text == "Gerente")
                    {
                        Avon[i].salario = 8000;
                    }
                    if (txtcargo.Text == "Administrador")
                    {
                        Avon[i].salario = 7000;
                    }
                    if (!A.insertardatos(Avon[i].salario))
                        {
                        MessageBox.Show("No se pueden ingresar valores");
                        txtid.Clear();
                        txtid.Focus();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(Avon[i].id, Avon[i].cliente, Avon[i].salario);
                        Refresh();
                        limpiarcampos();
                        txtnombre.Focus();
                        i++;
                    }
                    if (i > 0)
                    {
                        grecorridos.Enabled = true;
                    }
                    if (i == Ncantidad)
                    {
                        geliminar.Enabled = true;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Datos Incorrectos, Revise los datos");
                }
            }
        }
        public void limpiarcampos()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtcargo.Text = "";
        }
        avon[] Avon;

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtelimi.Text);
            if (A.Eliminar(x))
            {
                Refresh();
                Eliminar(x);
            }
            else return;
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            A.InOrden(listrecorrido, lblrecorrido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A.PreOrden(listrecorrido, lblrecorrido);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A.PostOrden(listrecorrido, lblrecorrido);
        }

        private void ArbolBinario_Paint(object sender, PaintEventArgs e)
        {
            A.mostrararbol(e, this.BackColor);
        }

        private void lblrecorrido_Click(object sender, EventArgs e)
        {

        }

        public ArbolBinario()
        {
            InitializeComponent();
            nodo = CreateGraphics();
            A = new Arbol(nodo, Font);
            gdatos.Enabled = false;
            grecorridos.Enabled = false;
            geliminar.Enabled = false;
        }

        private void ArbolBinario_Load(object sender, EventArgs e)
        {

        }
        public void Eliminar(double x)
        {
            for(int i=0;i< Avon.Length; i++)
            {
                if (Avon[i].salario==x)
                {
                    for(int j = i; j < Avon.Length - 1; j++)
                    {
                        Avon[j].salario = Avon[j + 1].salario;
                        Avon[j].cliente = Avon[j + 1].cliente;
                        Avon[j].id = Avon[j + 1].id;
                        Avon[j].cargo = Avon[j + 1].cargo;
                        if (j == Avon.Length)
                        {
                            Avon[i].cliente = null;
                            Avon[i].id = Convert.ToInt32(null);
                            Avon[i].cargo = null;
                            Avon[j].salario = Convert.ToDouble("");
                        }
                    }
                }
            }
            aux--;
            dataGridView1.Rows.Clear();
            for(int i = 0; i < aux; i++)
            {
                dataGridView1.Rows.Add(Avon[i].id, Avon[i].cliente, Avon[i].salario);
            }
        }
    }
}
