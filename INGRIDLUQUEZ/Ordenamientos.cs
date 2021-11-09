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

    public partial class Ordenamientos : Form
    {
        //><
        int i=0, n;
        public struct DatosE
        {
           public int id;
           public string nombre, apellido, cargo, cedula;
            public double salario;

        }

        public DatosE[] AVON;
        
        private void selDir_Click(object sender, EventArgs e)
        {
            SeleccionDirecta SD = new SeleccionDirecta(n);
            for(int i=0;i<n;i++)
            {
                SD.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo,AVON[i].salario);
            }
            SD.seleccion();
            SD.mostrar(dataGridView1);
        }


        private void AgregarF2_Click(object sender, EventArgs e)
        {
               
            
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Ordenamientos()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            dataGridView1.Visible = false;
            this.toolTip1.
                SetToolTip(this.txtbuscar, "Ingresa el salario a buscar");
            this.toolTip1.
                SetToolTip(this.textbuscar,"Ingresa el nombre a bsucar");

            this.toolTip1.
                SetToolTip(this.btnburbuja, "Método burbuja, ordena Descendentemente");
            this.toolTip1.
                SetToolTip(this.btnSD, "Selección directa, ordena Descendentemente");
            this.toolTip1.
                SetToolTip(btnShell, "Método Shell, Ordena Ascendentemente");
            this.toolTip1.
                SetToolTip(this.btnheapsort, "Heapsort, ordena Ascendentemente");
            this.toolTip1.
                SetToolTip(this.btnquicksort, "Quicksort, Ordena Descendentemente");
            this.toolTip1.
                SetToolTip(this.btnbaraja, "Baraja, Ordena Ascendentemente");
            this.toolTip1.SetToolTip
                (this.txtid, "Ingrese un valor de tipo entero");
            this.toolTip1.SetToolTip
                (this.textbuscar,"Busqueda Lineal, busca por el nombre"
                );
            this.toolTip1.SetToolTip
                (this.txtbuscar, "Busqueda Secuencial, busca por el salario"
                );
            this.toolTip1.SetToolTip
                (this.txtbinaria, "Busqueda Binaria, busca por la cedula"
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtn.Text) || int.Parse(txtn.Text) <=0)
            {
                MessageBox.Show("Debe ingresar datos en los campos de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtn.Clear(); txtn.Focus();
            }
            else
            {
                n = int.Parse(txtn.Text);
                AVON = new DatosE[n];
                groupBox2.Enabled = false;
                txtid.Focus();
                groupBox1.Visible = true;

                /*AVON[i].id = Convert.ToInt32(txtid.Text);
                AVON[i].nombre = txtnombre.Text;
                AVON[i].cargo = txtcargo.Text;
                AVON[i].cedula = txtcedula.Text;
                dataGridView1.Rows.Add(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo);
                */
            }
        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text)||string.IsNullOrEmpty(txtid.Text) || string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtcargo.Text))
            {
                MessageBox.Show("Debe ingresar datos en los campos de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Clear();
                txtid.Focus();
            }
            else
            {
               
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                dataGridView1.Visible = true;
                if (i < n)
                {
                    AVON[i].id = Convert.ToInt32(txtid.Text);
                    AVON[i].nombre = txtnombre.Text;
                    if (txtcargo.Text == "Vendedor")
                    {
                        AVON[i].salario = 6000;
                    }
                    if (txtcargo.Text == "Bodeguero")
                    {
                        AVON[i].salario = 5000;
                    }
                    if (txtcargo.Text == "Cajero")
                    {
                        AVON[i].salario = 6500;
                    }
                    if (txtcargo.Text == "Gerente")
                    {
                        AVON[i].salario = 8000;
                    }
                    if (txtcargo.Text == "Administrador")
                    {
                        AVON[i].salario = 7000;
                    }
                    /*Vendedor
Administrador
Bodeguero
Cajero
Gerente*/
                    AVON[i].cargo = txtcargo.Text;

                    AVON[i].cedula = txtcedula.Text;
                    dataGridView1.Rows.Add(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo,AVON[i].salario);

                    i++;
                }
                else
                {
                    MessageBox.Show("Ya ha ingresado la cantidad de empleados indicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid.Clear();
                    txtnombre.Clear();
                    txtcedula.Clear();
                    textapellido.Clear();
                    txtcargo.Text = "";
                }

            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Shell S = new Shell(n);
            for(int i = 0; i < n; i++)
            {
                S.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);

            }
            S.shell();
            S.mostrar(dataGridView1);
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            try
            {
                string PL = Convert.ToString(textbuscar.Text);
                i = 0;
                while (i <= n - 1 && AVON[i].nombre.CompareTo(PL) != 0) { i++; }
                if (i > n - 1)
                {
                    MessageBox.Show("No se ha encontrado la informacion que busca", "Error en la busqueda");
                   
                }
                else
                {
                    MessageBox.Show(string.Format("\nInformacion: \n \n- Codigo:{0} \n- Nombre:{1} \n- Salario:{2}",

                        AVON[i].id, AVON[i].nombre, AVON[i].salario), "Busqueda Finalizad");
                 }
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Busqueda no finalizada","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int B = Convert.ToInt32(txtbuscar.Text);
            int l = 0;
            while (l <= n && B != AVON[l].salario)

            {
                l = l + 1;
            }
            if(l>n)
            {
                MessageBox.Show("El elemento que busca no se encuentra");

            }
            else
            {
                MessageBox.Show("EL elemento se encuentra en la posicion" + (l + 1));
            }
        }

        private void btnburbuja_Click(object sender, EventArgs e)
        {
            Burbuja B = new Burbuja(n);
            for(int i=0;i < n; i++)
            {
                B.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);
            }
            B.burbuja();
            B.mostrar(dataGridView1);
        }

        private void btnheapsort_Click(object sender, EventArgs e)
        {
            Heapsort H = new Heapsort(n);
            for (int i = 0; i < n; i++)
            {
                H.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);
            }
            H.heapasort();
            H.mostrar(dataGridView1);
        }

        private void btnquicksort_Click(object sender, EventArgs e)
        {
            Quicksort Q = new Quicksort(n);
            for (int i = 0; i < n; i++)
            {
                Q.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);
            }
            Q.quicksort();
            Q.mostrar(dataGridView1);
        }

        private void btnbaraja_Click(object sender, EventArgs e)
        {
            Baraja B = new Baraja(n);
            for (int i = 0; i < n; i++)
            {
                B.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);
            }
            B.Barajear();
            B.mostrar(dataGridView1);
        }

        private void btnmezcla_Click(object sender, EventArgs e)
        {
            MezclaDirecta MD = new MezclaDirecta();
            MD.Show();
            this.Hide();
        }

        private void btnbinaria_Click(object sender, EventArgs e)
        {
            Binaria B = new Binaria(n);
            for (int i = 0; i < n; i++)
            {
                B.agregar(AVON[i].id, AVON[i].nombre, AVON[i].cedula, AVON[i].cargo, AVON[i].salario);
            }
            B.binaria(txtbinaria.Text);
        }

        private void btntransformacion_Click(object sender, EventArgs e)
        {

        }

        private void btnintercalar_Click(object sender, EventArgs e)
        {
            IntercalacionDeArchivos I = new IntercalacionDeArchivos();
            I.Show();
            this.Hide();
        }

        private void btnequilibrada_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
