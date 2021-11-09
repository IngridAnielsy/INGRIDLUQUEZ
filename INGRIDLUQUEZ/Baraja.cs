using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Baraja
    {
        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;

        public Baraja(int n)
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
        public void Barajear()
        {
            for(int i = 0; i < N; i++)
            {
                int auxid = Id[i];
                string auxnom = Nombre[i];
                string auxcargo = Cargo[i];
                string auxcedu = Cedula[i];
                double auxsalario = salario[i];
                int j = i - 1;
                while ((j >= 0) && Id[j].CompareTo(Id[i])>0)
                {
                    Id[j + 1] = Id[j];
                    Nombre[j + 1] = Nombre[j];
                    Cargo[j + 1] = Cargo[j];
                    Cedula[j + 1] = Cedula[j];
                    salario[j + 1] = salario[j];
                    j--;
                }
                Id[j + 1] = auxid;
                Nombre[j + 1] = auxnom;
                Cargo[j + 1] = auxcargo;
                Cedula[j + 1] = auxcedu;
                salario[j + 1] = auxsalario;
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
