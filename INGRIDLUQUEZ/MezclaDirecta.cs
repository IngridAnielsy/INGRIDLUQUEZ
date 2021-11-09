using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace INGRIDLUQUEZ
{
    public partial class MezclaDirecta : Form
    {
        int n, i;
        static StreamReader A_Leer;
        static StreamReader A1_Leer;
        static StreamReader A2_Leer;

        static StreamWriter A_Escribir;
        static StreamWriter A1_Escribir;
        static StreamWriter A2_Escribir;

        public struct IngresoEmpleado { public int Id; }
        IngresoEmpleado[] Empleado;
        public MezclaDirecta()
        {
            InitializeComponent();
            n = 0;
            i = 0;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtn.Text);
            Empleado = new IngresoEmpleado[n];
            A_Escribir = new StreamWriter("A.text");
            txtn.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado[i].Id = Convert.ToInt32(txtid.Text);
                A_Escribir.WriteLine(txtid.Text);
                A_Escribir.Flush();
                listBox1.Items.Add(Empleado[i].Id);
                i++;
                MessageBox.Show("se ha guardado el id");
                txtid.Clear();
            }
            catch { MessageBox.Show("Limite de datos");
                txtid.Clear();
            }
        }

        private void btnOrdena_Click(object sender, EventArgs e)
        {
            try
            {
                A_Escribir.Close();
                Mezclar(A_Leer, A_Escribir, A1_Leer, A1_Escribir, A2_Leer, A2_Escribir);
                MessageBox.Show("Se han ordenado los datos");
              //A1_Leer = new StreamReader("A.txt");
              //  Process.Start("A.txt");
              //  A1_Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public static int ObtenerN(StreamReader APrincipal)
        {
            APrincipal = new StreamReader("A.text");
            int n = 0;
            while (!APrincipal.EndOfStream) 
            { string cadena = APrincipal.ReadLine(); n++; }
            APrincipal.Close();
            return n;

        }

        public static void Mezclar(StreamReader ALee, StreamWriter AEscribe, StreamReader A1Lee, StreamWriter A1Escribe, StreamReader A2Lee, StreamWriter A2Escribe)
        {
           // A_Leer = new StreamReader("F.text");
            int particion = 1, vueltas = ObtenerN(ALee);

            while (particion <= vueltas)
            {
                ALee = new StreamReader("A.text");
                A1Escribe = new StreamWriter("A1.txt");
                A2Escribe = new StreamWriter("A2.txt");

                Particionar(ALee, A1Escribe, A2Escribe, particion);

                ALee.Close();
                A1Escribe.Close();
                A2Escribe.Close();

                AEscribe = new StreamWriter("A.txt");
                A1Lee = new StreamReader("A1.txt");
                A2Lee = new StreamReader("A2.txt");

                Fusionar(AEscribe, A1Lee, A2Lee, particion);

                particion *= 2;
            }

            Console.WriteLine("\n*** Fin del archivo ***");
        }

        public static void Particionar(StreamReader A_Lectura, StreamWriter A1_Escritura, StreamWriter A2_Escritura, int particion)
        {
            int puntero = 0;

            while (!A_Lectura.EndOfStream)
            {
                int puntero_F1 = 0;
                while (puntero_F1 < particion && !A_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(A_Lectura.ReadLine());
                    A1_Escritura.WriteLine(puntero);
                    puntero_F1++;
                }

                int puntero_F2 = 0;
                while (puntero_F2 < particion && !A_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(A_Lectura.ReadLine());
                    A2_Escritura.WriteLine(puntero);
                    puntero_F2++;
                }
            }
        }

        public static void Fusionar(StreamWriter A_Escritura, StreamReader A1_Lectura, StreamReader A2_Lectura, int particion)
        {
            bool bandera_1 = true, bandera_2 = true;

            int read_1 = 0, read_2 = 0;


            if (!A1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                bandera_1 = false;
            }

            if (!A2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                bandera_2 = false;
            }

            while ((!A1_Lectura.EndOfStream || bandera_1 == false) && (!A2_Lectura.EndOfStream || bandera_2 == false))
            {
                int puntero_1 = 0, puntero_2 = 0;

                while ((puntero_1 < particion && bandera_1 == false) && (puntero_2 < particion && bandera_2 == false))
                {
                    if (read_1 <= read_2)
                    {
                        A_Escritura.WriteLine(read_1);
                        bandera_1 = true; puntero_1++;

                        if (!A1_Lectura.EndOfStream)
                        {
                            read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                            bandera_1 = false;
                        }
                    }
                    else
                    {
                        A_Escritura.WriteLine(read_2);
                        bandera_2 = true; puntero_2++;
                        if (!A2_Lectura.EndOfStream)
                        {
                            read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                            bandera_2 = false;
                        }
                    }
                }

                while (puntero_1 < particion && bandera_1 == false)
                {
                    A_Escritura.WriteLine(read_1);
                    bandera_1 = true; puntero_1++;

                    if (!A1_Lectura.EndOfStream)
                    {
                        read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                        bandera_1 = false;
                    }
                }

                while (puntero_2 < particion && bandera_2 == false)
                {
                    A_Escritura.WriteLine(read_2);
                    bandera_2 = true; puntero_2++;

                    if (!A2_Lectura.EndOfStream)
                    {
                        read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                        bandera_2 = false;
                    }
                }

            }

            if (bandera_1 == false) { A_Escritura.WriteLine(read_1); }

            if (bandera_2 == false) { A_Escritura.WriteLine(read_2); }

            while (!A1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(A1_Lectura.ReadLine());
                A_Escritura.WriteLine(read_1);
            }

            while (!A2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(A2_Lectura.ReadLine());
                A_Escritura.WriteLine(read_2);
            }

            A_Escritura.Close();
            A1_Lectura.Close();
            A2_Lectura.Close();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            
            A1_Leer = new StreamReader("A.txt");
            Process.Start("A.txt");
          
            A1_Leer.Close();
            while (!A1_Leer.EndOfStream)
            {
                listBox2.Items.Add(A1_Leer.ReadLine());
            }
            A1_Leer.Close();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void MezclaDirecta_Load(object sender, EventArgs e)
            {

            }
    }
}   
