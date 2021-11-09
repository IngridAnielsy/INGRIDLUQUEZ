using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.ComponentModel;

namespace INGRIDLUQUEZ
{
    class Arbol
    {
        public Nodo raiz
            ;
        Graphics nodo
            ;
        Font font;
        int coordenadasX = 740;
        int coordenadasY = 45;

        bool encontrado = false;
        public Arbol()
        {
            raiz = null;
        }
        public Arbol(Graphics nodo, Font font)
        {
            this.nodo = nodo;
            this.font = font;
        }
        public bool insertardatos(double salario)
        {
            Nodo temp = new Nodo();
            temp.salario = salario;
            temp.izquierdo = null;
            temp.derecho = null;

            if (raiz == null)
            {
                raiz = temp;
                temp.nivel = 1;
                return true;
            }
            else
            {
                Nodo anterior = null, ant;
                ant = raiz;
                while (ant != null)
                {
                    anterior = ant;
                    if (salario < ant.salario)
                    {
                        ant = ant.izquierdo;
                    }
                    else
                    {
                        ant = ant.derecho;
                    }
                }
                if (salario < anterior.salario)
                {
                    temp.nivel++;
                    anterior.izquierdo = temp;
                    return true;
                }
                else if (salario > anterior.salario)
                {
                    temp.nivel++;
                    anterior.derecho = temp;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        public void dibujararbol(Graphics grafico, Font fuente, Brush colorrelleno, Brush colorfuente, Pen relacion, Brush borde)
        {
            if (raiz == null)
            {
                return;
            }
            raiz.UbicacionNodo(coordenadasX, coordenadasY);
            raiz.dibujarramas(grafico, relacion);
            raiz.dibujarnodo(grafico, fuente, colorrelleno, colorfuente, relacion, borde);
        }
        public void mostrararbol(PaintEventArgs e, Color c)
        {
            e.Graphics.Clear(c);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nodo = e.Graphics;
            dibujararbol(nodo, font, Brushes.White, Brushes.Black, Pens.White, Brushes.Black);
        }
        protected Nodo cambiar(Nodo aux)
        {
            Nodo temp = aux;
            Nodo temp2 = aux.izquierdo;
            while (temp2.derecho != null)
            {
                temp = temp2;
                temp2 = temp2.derecho;
            }
            aux.salario = temp2.salario;
            if (temp == aux)
            {
                temp.izquierdo = temp2.izquierdo;
            }
            else
            {
                temp.derecho = temp2.izquierdo;
            }
            return temp2;
        }
        public Nodo eliminarnodo(Nodo raiz, double salario)
        {
            if (raiz == null)
            {
                MessageBox.Show("No  se ha encontrado el nodo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            else if (salario < raiz.salario)
            {
                Nodo iz = eliminarnodo(raiz.izquierdo, salario);
                raiz.izquierdo = iz;
            }
            else if (salario > raiz.salario)
            {
                Nodo de = eliminarnodo(raiz.derecho, salario);
                raiz.derecho = de;
            }
            else
            {
                Nodo aux = raiz;
                if (aux.derecho == null)
                {
                    raiz = aux.izquierdo;
                }
                else if (aux.izquierdo == null)
                {
                    raiz = aux.derecho;
                }
                else
                {
                    aux = cambiar(aux);
                }
                aux = null;
                encontrado = true;
            }
            return raiz;

        }
        public bool Eliminar(double salario)
        {
            raiz = eliminarnodo(raiz, salario);
            return encontrado;
        }
        //Recorrido InOrden
        public void InOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            InOrden(raiz, lst, lbl);

        }
        public void InOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido InOrden";
                InOrden(temp.izquierdo, lst, lbl);
                lst.Items.Add(temp.salario.ToString());
                InOrden(temp.derecho, lst, lbl);
            }
        }
        //Recorrido PostOrden
        public void PostOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PostOrden(raiz, lst, lbl);
        }
        public void PostOrden(Nodo tempm,ListBox lst, Label lbl)
        {
            if(tempm!= null)
            {
                lbl.Text = "Recorrido  PostOrden";
                PostOrden(tempm.izquierdo, lst, lbl);
                PostOrden(tempm.derecho, lst, lbl);
                lst.Items.Add(tempm.salario.ToString());
            }
        }
        //Recorrido PreOrden
        public void PreOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PreOrden(raiz, lst, lbl);
        }
        public void PreOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido  PreOrden";
                lst.Items.Add(temp.salario.ToString());
                PreOrden(temp.izquierdo, lst, lbl);
                PreOrden(temp.derecho, lst, lbl);
                
            }
        }
    }
}
