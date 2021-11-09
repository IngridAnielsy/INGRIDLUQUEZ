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
    public partial class IntercalacionDeArchivos : Form
    {
        TextWriter Archivo;
        int F = 1, n, i = 0;
       
        int R1, R2;
        int[] AVON;
        
        
        public IntercalacionDeArchivos()
        {
            InitializeComponent();
            n = 0;
            i = 0;
        }

        private void guarda2_Click(object sender, EventArgs e)
        {
        }

        private void guardaE1_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                n = Convert.ToInt32(txtE1.Text);
                if(n<=0||txtE1.Text.Length>8)
                { MessageBox.Show("Ha cantidad ingresada no es validad", "Verifique nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"EL archivo{F} puede contener un total de {n} elementos");
                    AVON = new int[n];
                    if(F==1)
                    {
                        R1 = n;
                    }
                    else
                    {
                        R2 = n;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Los datos no son validos");
            }
        }

        private void guardaN_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"El archivo {F} se ha creado exitosamente", MessageBoxButtons.OK);
            if (F == 1)
            {
                Archivo = new StreamWriter($"Archivo{F}.txt");
            }
            else
            {
                Archivo = new StreamWriter("archivo2.txt");

            }

        }

        private void guardaE2_Click(object sender, EventArgs e)
        {
            int elemento;
            if (i != n)
            {
                try
                {
                    elemento = Convert.ToInt32(txtE2.Text);
                    if(elemento<=0||txtE2.Text.Length>8)
                    {
                        MessageBox.Show("El valor ni es valido");
                    }
                    else
                    {
                        AVON[i] = elemento;
                        MessageBox.Show($"{elemento}se ha ingresado al archivo{F}");
                        txtE2.Focus();
                        txtE1.Text = (Convert.ToInt32(txtE1.Text) - 1).ToString();
                        i++;
                    }
                    if (i == n)
                    {
                        Asignar(AVON);
                        Mostrar();

                    }
                    if (i == n && F == 2) {
                        MessageBox.Show($"Pulse crear el siguiente archivo {F}");
                            }
                    if(i==n&&F==3)
                    {
                        btnintercalar.Enabled = true;
                    }
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"Los datos no son validos");
                }
            }
            else
            {
                MessageBox.Show($"Ya no puedes agregar mas elementos");
            }
        }

        private void btnintercalar_Click(object sender, EventArgs e)
        {
            StreamReader A1_Lec = new StreamReader("archivo1.txt");
            StreamReader A2_Lec = new StreamReader("archivo2.txt");
            TextWriter intercalado = new StreamWriter("lisOrde.ListBox");
            int []F1 = new int[R1 + 1];
            int[] F2 = new int[R2 + 1];
            int i = 0, j = 0, k;
            while(!A1_Lec.EndOfStream)
            {
                F1[i] = int.Parse(A1_Lec.ReadLine());
                i++;
             }
            while (!A2_Lec.EndOfStream)
            {
                F2[j] = int.Parse(A2_Lec.ReadLine());
                j++;
            }
            for(i=k=j=0;i<(F1.Length-1)&& j < (F2.Length - 1); k++)
            {
                if (F1[i] < F2[j])
                {
                    intercalado.WriteLine(F1[i]);i++;
                }
                else
                {
                    intercalado.WriteLine(F2[j]);j++; 
                }
            }
            for (; i < F1.Length - 1; i++)
            {
                intercalado.WriteLine(F1[i]);
            }
            for (; j < F2.Length - 1; j++)
            {
                intercalado.WriteLine(F2[j]);
            }
            A1_Lec.Close();
            A2_Lec.Close();
            intercalado.Close();
            StreamReader leerarchivo = new StreamReader("lisOrde.ListBox");
            Process.Start("lisOrde.ListBox");
            leerarchivo.Close();
            

        }
        public void Asignar(int[] avon)
        {
            int aux, j;
            for(int i=(avon
                .Length-1);i>0;i--)
            {
                for(j=(i-1);j>=0;j--)
                {
                    if(avon[i]<avon[j])
                    {
                        aux = avon[i];
                        avon[i] = avon[j];
                        avon[j] = aux;
                    }
                }
            }
            foreach(var avo in avon)
            {
                if (F == 1)
                {
                    dataGridView1.Rows.Add(avo, null);
                }
                else
                {
                    dataGridView2.Rows.Add(avo, null);
                }
                Archivo.WriteLine(avo);
            }
            Archivo.Close();
            if (F == 1)
            {
                F = 2;
            }
            else
            {
                F = 3;
            }
        }
        public  void Mostrar()
        {
            TextReader leerarchivo;
            if (F == 2)
            {
                leerarchivo = new StreamReader($"archivo1.txt");
                MessageBox.Show($"el contenido del archivo F1 es:\n {leerarchivo.ReadToEnd()}");
                leerarchivo.Close();
            }
            else
            {
                leerarchivo = new StreamReader($"archivo2.txt");
                MessageBox.Show($"el contenido del archivo F2 es:\n {leerarchivo.ReadToEnd()}");
                leerarchivo.Close();    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F = 1;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ordenamientos o = new Ordenamientos();
            o.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void IntercalacionDeArchivos_Load(object sender, EventArgs e)
        {

        }
        public void Intercalar(StreamReader F1, StreamReader F2, StreamWriter F3 )
        {
            bool bandera_1, bandera_2;
            bandera_1 = true;
            bandera_2 = true;
            while((!F1.EndOfStream)||(bandera_1=false) && ((!F2.EndOfStream) || (bandera_2 = false)))
            {
                if (bandera_1 == true)
                {
                    R1 = Convert.ToInt32(F1.ReadLine());
                    bandera_1 = false;
                }
                if (bandera_2 == true)
                {
                    R2 = Convert.ToInt32(F2.ReadLine());
                    bandera_2 = false;
                }
                if (R1 < R2)
                {
                    F3.WriteLine(R1);
                    bandera_1 = true;
                }
                else
                {
                    F3.WriteLine(R2);
                    bandera_2 = true;
                }

            }
            if (bandera_1 == false)
            {
                F3.WriteLine(R1);
                while (!F1.EndOfStream)
                {
                    R1 = Convert.ToInt32(F1.ReadLine());
                    F3.WriteLine(R1);
                }
            }
            if (bandera_2 == false)
            {
                F3.WriteLine(R2);
                while (!F2.EndOfStream)
                {
                    R2 = Convert.ToInt32(F2.ReadLine());
                    F3.WriteLine(R2);
                }
            }
            F1.Close();
            F2.Close();
            F3.Close();
        }
    }
}
