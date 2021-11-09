using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Shell
    {

        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;
        public Shell(int n)
        {
            this.N = n;
            Id = new int[n];
            Nombre = new string[n];
            Apellido = new string[n];
            Cargo = new string[n];
            Cedula = new string[n];
            salario = new double[n];

        }
        public void agregar(int id, string nombre, string cedula, string cargo,double salario)
        {
            if (i < N)
            { 
                this.Id[i] = id;
            this.Nombre[i] = nombre;
            //this.Apellido[i] = apellido;
            this.Cargo[i] = cargo;
            this.Cedula[i] = cedula;
            this.salario[i] = salario;
                i++;
            }
        }
        public void shell()
        {
            int auxid;
            string auxnombre, auxapellido, auxcargo, auxcedula;
            double auxsalario;
            int k, j, intervalo;
            intervalo = N / 2;
            while(intervalo>0)
            {
                for (int i = intervalo; i < N; i++)
                {
                    j = i - intervalo;
                    while(j>=0)
                    {
                        k = j + intervalo;
                        if (Id[j].CompareTo(Id[k]) <= 0)
                        {
                            j = -1;
                        }
                        else
                        {
                            auxid = Id[j];
                            Id[j] = Id[k];
                            Id[k] = auxid;

                            auxnombre = Nombre[j];
                            Nombre[j] = Nombre[k];
                            Nombre[k] = auxnombre;


                            auxcedula = Cedula[j];
                            Cedula[j] = Cedula[k];
                            Cedula[k] = auxcedula;

                            auxcargo = Cargo[j];
                            Cargo[j] = Cargo[k];
                            Cargo[k] = auxcargo;

                           

                            auxsalario = salario[j];
                            salario[j] = salario[k];
                            salario[k] = auxsalario;

                            j -= intervalo;
                        }
                    }
                }
                intervalo = intervalo / 2;
            }
        }
        public void mostrar(DataGridView dtempleados)
        {
            dtempleados.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                dtempleados.Rows.Add(Id[i], Nombre[i], Cedula[i], Cargo[i], salario[i]);
            }
        }
    }

}
