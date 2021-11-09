using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace INGRIDLUQUEZ
{
    class Binaria
    {
        int i = 0, N;

        public int[] Id;
        public string[] Nombre;
        public string[] Apellido;
        public string[] Cargo;
        public string[] Cedula;
        public double[] salario;

        public Binaria(int n)
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
        public void binaria(string x)
        {
            int iz, cen = 0, der;
            bool Ban = false;
            iz = 0; der = N - 1; Ban = false;
            while (iz<=der && Ban == false)
            {
                if (x == Cedula[cen])
                {
                    Ban = true;
                }
                else { cen++; }
                if (Cedula[cen].CompareTo(x) > 0)
                {
                    iz = cen + 1;
                }
                else
                {
                    der = cen - 1;
                }
            }
            if(Ban==true)
            {
                MessageBox.Show(string.Format("\n\nInformación: \n\n Id: {0} \n Nombre: {1} \n Cédula: {2} \n Cargo: {3} \n Salario: {4}"
                    , Id[cen], Nombre[cen], Cedula[cen], Cargo[cen], salario[cen]), "Datos Localizados"
                    );
            }
            else
            {
                MessageBox.Show("La  informacion no se haencontrado");
            }
        }
    }
}
