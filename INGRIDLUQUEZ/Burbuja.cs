using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Burbuja
    {
        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;

        public Burbuja(int n)
        {
            this.N = n;
            Id = new int[n];
            Nombre = new string[n];
            Apellido = new string[n];
            Cargo = new string[n];
            Cedula = new string[n];
            salario = new double[n];
        }

        public void agregar(int id, string nombre, string cedula, string cargo, double salario)
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
        public void burbuja()
        {
            int auxid;
            string auxnombre, auxapellido, auxcargo, auxcedula;
            double auxsalario;
            for(int i=0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if(Id[j].CompareTo(Id[i]) >= 0)
                    {
                        auxid = Id[i];
                        Id[i] = Id[j];
                        Id[j] = auxid;

                        auxnombre = Nombre[i];
                        Nombre[i] = Nombre[j];
                        Nombre[j] = auxnombre;

                        auxcedula = Cedula[i];
                        Cedula[i] = Cedula[j];
                        Cedula[j] = auxcedula;
                        auxcargo = Cargo[i];
                        Cargo[i] = Cargo[j];
                        Cargo[j] = auxcargo;

                       

                        auxsalario = salario[i];
                        salario[i] = salario[j];
                        salario[j] = auxsalario;
                    }
                }
            }
        }
        public void mostrar(DataGridView dtEmpleados)
        {
            dtEmpleados.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                dtEmpleados.Rows.Add(Id[i], Nombre[i], Cedula[i], Cargo[i], salario[i]);
            }
        }
    }
}