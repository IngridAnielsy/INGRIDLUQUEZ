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
    public partial class ArbolBalancead : Form
    {

        //Variables
        public int Ncantidad { get; set; }
        int aux, posX, posY, i = 0;

        ArbolBalanceado A;
        Graphics nodo;

        public struct avon
        {
            public string cliente { get; set; }
            public double salario { get; set; }
            public string cargo { get; set; }

            public int id { get; set; }
        }
        avon[] Avon;

        private void txtagregar_Click(object sender, EventArgs e)
        {
            //insertar datos
            if (i == Ncantidad)
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
                    if (A.InsertarDAtos(Avon[i].salario))
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
                        i++; aux++;
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

        private void ArbolBalancead_Paint(object sender, PaintEventArgs e)
        {
            A.mostrararbol(e, this.BackColor);
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

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            if (A.eliminar(x))
            {
                ElimnarData(x);
                Refresh();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el nodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Eliminar el datagridview
        private void ElimnarData(double x)
        {
            bool encontrado = false;
            for(int i = 0; i < Avon.Length - 1; i++)
            {

                if (x == Avon[i].salario)
                {
                    for(int j = i; j < Avon.Length - 1; j++)
                    {
                        Avon[j].id = Avon[j + 1].id;
                        Avon[j].cliente = Avon[j + 1].cliente;
                        Avon[j].salario = Avon[j + 1].salario;
                        if (j == Avon.Length - 1)
                        {
                            Avon[j].id = Convert.ToInt32(null);
                            Avon[j].cliente = null;
                            Avon[j].salario = Convert.ToDouble(null);
                        }
                    }
                    encontrado = true;
                }
            }
            if (encontrado) i--;aux--;
            dataGridView1.Rows.Clear();
            for(int j = 0; j < aux; j++)
            {
                dataGridView1.Rows.Add(Avon[j].id, Avon[j].cliente, Avon[j].salario);
            }
        }

        private void lblrecorrido_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public ArbolBalancead()
        {
            InitializeComponent();
            nodo = CreateGraphics();
            A = new ArbolBalanceado(nodo, Font);
            gdatos.Enabled = false;
            grecorridos.Enabled = false;
            geliminar.Enabled = false;
            aux = 0;

        }

        private void ArbolBalancead_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Ncantidad = Convert.ToInt32(txtn.Text);
                aux = 0;
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

    }
}
