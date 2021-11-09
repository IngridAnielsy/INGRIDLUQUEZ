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
    public partial class MezclaEquilibrada : Form
    {
        int n, i;
        public int rango { get; set; }
        public static int cantidad { get; set; }
        private static StreamReader LA, LA1, LA2, LA3;
        static StreamWriter EsA;
        static StreamWriter EsA1;
        static StreamWriter EsA2;
        static StreamWriter EsA3;
        public struct Clientes { public int Id; }
        Clientes[] cliente;

        private void btnordenar_Click(object sender, EventArgs e)
        {
            try
            {
                EsA.Close();
                mezclaequilibrada(LA, EsA, LA1, EsA1, LA2, EsA2, LA3, EsA3);
                LA2=new StreamReader("A.txt");
                Process.Start("A.txt");
                LA2.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hay un error: " + ex, "en el codigo ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btninic_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtcan.Text);
            cliente = new Clientes[n];
            EsA = new StreamWriter("A.txt");

        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            try
            {
                cliente[i].Id = int.Parse(txtid.Text);
                EsA.WriteLine(txtid.Text);
                EsA.Flush();
                Lista.Items.Add(cliente[i].Id);
               // lista.Items.Add(cliente[i].Id);
                i++;
                MessageBox.Show("Se guardo el dato");
                txtid.Clear();
                txtid.Focus();
                txtcan.Text = (Convert.ToInt32(txtcan.Text) - 1).ToString();
                if (i == n)
                {
                    MessageBox.Show("Limite de datos");
                    txtid.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Limite de datos");
                txtid.Clear();
            }
        }

        public static void mezclaequilibrada(StreamReader LA,StreamWriter EsA,StreamReader LA1,StreamWriter EsA1,StreamReader LA2,StreamWriter EsA2,StreamReader LA3,StreamWriter EsA3)
        {
            bool bandera;
            LA = new StreamReader("A.txt");
            EsA2 = new StreamWriter("A2.txt");
            EsA3 = new StreamWriter("A3.txt");
            particioninicial(LA, EsA2, EsA3);
            LA2 = new StreamReader("A2.txt");
            LA3 = new StreamReader("A3.txt");
            EsA = new StreamWriter("A.txt");
            EsA1 = new StreamWriter("A1.txt");
            fusionparticion(LA2, LA3, EsA, EsA1);
            bandera = false;

            while (vacio(LA1, "A1.txt") == false || vacio(LA3, "A3.txt") == false)
            {
                if (bandera == true)
                {

                    LA2 = new StreamReader("A2.txt");
                    LA3 = new StreamReader("A3.txt");
                    EsA = new StreamWriter("A.txt");
                    EsA1 = new StreamWriter("A1.txt");

                    fusionparticion(LA2, LA3, EsA, EsA1);
                    bandera = false;
                }
                else
                {

                    LA = new StreamReader("A.txt");
                    LA1 = new StreamReader("A1.txt");
                    EsA2 = new StreamWriter("A2.txt");
                   EsA3 = new StreamWriter("A3.txt");

                    fusionparticion(LA, LA1, EsA2, EsA3);
                    bandera = true;
                }
            }


        }
        public static bool vacio(StreamReader Archivo, string nombreArchivo)
        {
            cantidad = 0;

            Archivo = new StreamReader(nombreArchivo);

            while (!Archivo.EndOfStream)
            {
                string cadena = Archivo.ReadLine();
                cantidad++;
            }

            Archivo.Close();

            bool vacio = (cantidad == 0) ? true : false;
            return vacio;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ordenamientos o = new Ordenamientos();
            o.Show();
            this.Hide();
        }

        public static void particioninicial(StreamReader Lectura_Principal, StreamWriter Auxiliar_A2, StreamWriter Auxiliar_A3)
        {

            int auxiliar = 0, puntero = 0;
            bool bandera;

            puntero = Convert.ToInt32(Lectura_Principal.ReadLine());
            Auxiliar_A2.WriteLine(puntero);
            bandera = true;
            auxiliar = puntero;

            while (!Lectura_Principal.EndOfStream)
            {
                puntero = Convert.ToInt32(Lectura_Principal.ReadLine());

                if (puntero >= auxiliar)
                {
                    auxiliar = puntero;

                    if (bandera == true)
                    {
                        Auxiliar_A2.WriteLine(puntero);
                    }
                    else
                    {
                        Auxiliar_A3.WriteLine(puntero);
                    }
                }
                else
                {
                    auxiliar = puntero;

                    if (bandera == true)
                    {
                        Auxiliar_A3.WriteLine(puntero);
                        bandera = false;
                    }
                    else
                    {
                        Auxiliar_A2.WriteLine(puntero);
                        bandera = true;
                    }
                }
            }

            Lectura_Principal.Close();
            Auxiliar_A2.Close();
            Auxiliar_A3.Close();
        }
        public static void fusionparticion(StreamReader AA, StreamReader AB, StreamWriter AC, StreamWriter AD)

        {
            int auxiliar = 0, puntero_1 = 0, puntero_2 = 0;
            bool bandera_1, bandera_2, bandera_3;

            bandera_1 = true;
            bandera_2 = true;
            bandera_3 = true;


            auxiliar = -100;

            while ((!AA.EndOfStream || bandera_1 == false) && (!AB.EndOfStream || bandera_2 == false))
            {
                if (bandera_1 == true)
                {
                    puntero_1 = int.Parse(AA.ReadLine());
                    bandera_1 = false;
                }

                if (bandera_2 == true)
                {
                    puntero_2 = int.Parse(AB.ReadLine());
                    bandera_2 = false;
                }

                if (puntero_1 < puntero_2)
                {
                    if (puntero_1 >= auxiliar)
                    {
                        if (bandera_3 == true)
                        {
                            AC.WriteLine(puntero_1);
                        }
                        else
                        {
                            AD.WriteLine(puntero_1);
                        }

                        bandera_1 = true;
                        auxiliar = puntero_1;

                    }
                    else
                    {
                        if (bandera_3 == true)
                        {
                            AC.WriteLine(puntero_2);
                            bandera_3 = false;
                        }
                        else
                        {
                            AD.WriteLine(puntero_2);
                            bandera_3 = true;
                        }

                        bandera_2 = true;
                        auxiliar = -32768;
                    }
                }
                else
                {
                    if (puntero_2 >= auxiliar)
                    {
                        if (bandera_3 == true)
                        {
                            AC.WriteLine(puntero_2);
                        }
                        else
                        {
                            AD.WriteLine(puntero_2);
                        }

                        bandera_2 = true;
                        auxiliar = puntero_2;

                    }
                    else
                    {
                        if (bandera_3 == true)
                        {
                            AC.WriteLine(puntero_1);
                            bandera_3 = false;
                        }
                        else
                        {
                            AD.WriteLine(puntero_1);
                            bandera_3 = true;
                        }

                        bandera_1 = true;
                        auxiliar = -32768;
                    }
                }
            }

            if (bandera_1 == false)
            {
                if (bandera_3 == true)
                {
                    AC.WriteLine(puntero_1);

                    while (!AA.EndOfStream)
                    {
                        puntero_1 = Convert.ToInt32(AA.ReadLine());
                        AC.WriteLine(puntero_1);
                    }
                }
                else
                {
                    AD.WriteLine(puntero_1);

                    while (!AA.EndOfStream)
                    {
                        puntero_1 = Convert.ToInt32(AA.ReadLine());
                        AD.WriteLine(puntero_1);
                    }
                }
            }

            if (bandera_2 == false)
            {
                if (bandera_3 == true)
                {
                    AC.WriteLine(puntero_2);

                    while (!AB.EndOfStream)
                    {
                        puntero_2 = Convert.ToInt32(AB.ReadLine());
                        AC.WriteLine(puntero_2);
                    }
                }
                else
                {
                    AD.WriteLine(puntero_2);

                    while (!AB.EndOfStream)
                    {
                        puntero_2 = Convert.ToInt32(AB.ReadLine());
                        AD.WriteLine(puntero_2);
                    }
                }
            }

            AA.Close();
            AB.Close();
            AC.Close();
            AD.Close();
        }
        public MezclaEquilibrada()
        {
            InitializeComponent();
        }

        private void MezclaEquilibrada_Load(object sender, EventArgs e)
        {

        }
    }
}
