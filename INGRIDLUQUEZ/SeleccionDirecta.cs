using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class SeleccionDirecta
    {
        int i = 0, N;

        public int [] Id;
            public string [] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;
        public SeleccionDirecta(int n)
        {
            this.N = n;
            Id = new int[n];
            Nombre = new string[n];
            Apellido = new string[n];
            Cargo = new string[n];
            Cedula = new string[n];
            salario = new double[n];

        }
        public void agregar(int id, string nombre, string cedula,string cargo,double salario)
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
        public void seleccion()
        {
            int auxid;
            string auxnombre, auxcargo, auxcedula;
            double auxsalario;
            for (i = 0; i < N-1; i++)
            {
                int aux = i;
                for(int j=i+1;j<N; j++)
                {
                    if (Id[i].CompareTo(Id[j]) <= 0)
                    {
                        aux = j;
                    }
                }
                if(i !=aux)
                {
                    auxid = Id[i];
                    Id[i] = Id[aux];
                    Id[aux] = auxid;

                    auxnombre = Nombre[i];
                    Nombre[i] = Nombre[aux];
                    Nombre[aux] = auxnombre;

                    auxcedula = Cedula[i];
                    Cedula[i] = Cedula[aux];
                    Cedula[aux] = auxcedula;

                    auxcargo = Cargo[i];
                    Cargo[i] = Cargo[aux];
                    Cargo[aux] = auxcargo;

                    auxsalario = salario[i];
                    salario[i] = salario[aux];
                    salario[aux] = auxsalario;
                }
                
            }
            
        }
        public void mostrar(DataGridView dtEmpleados)
        {
            dtEmpleados.Rows.Clear();
            for(int i=0;i<N;i++)
            {
                dtEmpleados.Rows.Add(Id[i], Nombre[i], Cedula[i], Cargo[i],salario[i]);
            }
        }

    }
}
