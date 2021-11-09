using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Heapsort
    {
        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;

        public Heapsort(int n)
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
        public void sort(int inicio, int n)
        {
            int i, j;
            bool Ban = false;
            int auxid;
            string auxnombre, auxapellido, auxcargo, auxcedula;
            double auxsalario;
            i = inicio;
            j = 2 * i + 1;

            auxid = Id[i];
            auxnombre = Nombre[i];
            auxcargo =Cargo[i];
            auxcedula = Cedula[i];
            auxsalario = salario[i];

            while(j<=n &&(!Ban))
            {
                if(j<n)
                {
                    if (Id[j] < Id[j + 1])
                    {
                        j++;
                    }
                }
                if(auxid>=Id[j])
                {
                    Ban = true;
                }
                else
                {
                    Id[i] = Id[j];
                    Nombre[i] = Nombre[j];
                    Cargo[i]=Cargo[j];
                    Cedula[i] = Cedula[j];
                    salario[i] = salario[j];
                    i = j;
                    j = 2 * i + 1;

                }
            }
            Id[i] = auxid;
            Nombre[i] = auxnombre;
            Cargo[i] = auxcargo;
            Cedula[i] = auxcedula;
            salario[i] = auxsalario;

        }
         public void heapasort()
        {
            int auxid;
            string auxnombre, auxapellido, auxcargo, auxcedula;
            double auxsalario;
            int ultimo = N - 1;
            for(int i=(ultimo - 1) / 2; i >= 0; i--)
            {
                sort(i, ultimo);
            }
            for(int i = ultimo; i >= 1; i--)
            {
                auxid = Id[0];
                Id[0] = Id[i];
                Id[i] = auxid;

                auxnombre = Nombre[0];
                Nombre[0] = Nombre[i];
                Nombre[i] = auxnombre;

                auxcedula = Cedula[0];
                Cedula[0] = Cedula[i];
                Cedula[i] = auxcedula;

                auxcargo = Cargo[0];
                Cargo[0] = Cargo[i];
                Cargo[i] = auxcargo;



                auxsalario = salario[0];
                salario[0] = salario[i];
                salario[i] = auxsalario;

                sort(0, i - 1);
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
