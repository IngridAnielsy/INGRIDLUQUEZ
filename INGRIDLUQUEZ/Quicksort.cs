using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Quicksort
    {
        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;
        public Quicksort(int n)
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
        
        public void quicksort()
        {
            rapidorecursivo();
            void rapidorecursivo()
            {
                int inicio = 0;
                int fin = N - 1;
                reduceresursivo(inicio,fin);
            }
            void reduceresursivo(int inicio, int fin)
            {
                int izquierda, derecha, posicion;
                int auxid;
                string auxnombre, auxapellido, auxcargo, auxcedula;
                double auxsalario;
                bool Ban = true;
                izquierda = inicio;
                derecha = fin;
                posicion = inicio;
                while (Ban == true)
                {
                    Ban = false;
                    while(Id[posicion].CompareTo(Id[derecha])>=0 && posicion != derecha) { derecha--; }
                    if(posicion!=derecha)
                    {
                        auxid = Id[posicion];
                        Id[posicion] = Id[derecha];
                        Id[derecha] = auxid;

                        auxnombre = Nombre[posicion];
                        Nombre[posicion] = Nombre[derecha];
                        Nombre[derecha] = auxnombre;

                        auxcedula = Cedula[posicion];
                        Cedula[posicion] = Cedula[derecha];
                        Cedula[derecha] = auxcedula;

                        auxcargo = Cargo[posicion];
                        Cargo[posicion] = Cargo[derecha];
                        Cargo[derecha] = auxcargo;

                        auxsalario = salario[posicion];
                        salario[posicion] = salario[derecha];
                        salario[derecha] = auxsalario;
                        posicion = derecha;
                        while (Id
                            [posicion].CompareTo(Id[izquierda])<=0&& posicion!=izquierda)
                        {
                            izquierda++;
                        }
                        if (posicion != izquierda)
                        {
                            Ban = true;

                            auxid = Id[posicion];
                            Id[posicion] = Id[izquierda];
                            Id[izquierda] = auxid;

                            auxnombre = Nombre[posicion];
                            Nombre[posicion] = Nombre[izquierda];
                            Nombre[izquierda] = auxnombre;

                            auxcedula = Cedula[posicion];
                            Cedula[posicion] = Cedula[izquierda];
                            Cedula[izquierda] = auxcedula;

                            auxcargo = Cargo[posicion];
                            Cargo[posicion] = Cargo[izquierda];
                            Cargo[izquierda] = auxcargo;

                            auxsalario = salario[posicion];
                            salario[posicion] = salario[izquierda];
                            salario[izquierda] = auxsalario;
                            posicion = izquierda;
                        }
                    }
                }
                if ((posicion - 1) > inicio)
                {
                    reduceresursivo(inicio, posicion - 1);
                }
                if(fin>(posicion+1))
                {
                    reduceresursivo(posicion + 1, fin);
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
