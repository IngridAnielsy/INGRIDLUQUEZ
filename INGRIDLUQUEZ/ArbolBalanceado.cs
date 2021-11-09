using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class ArbolBalanceado
    {

        //declaracion de variables
        public Nodo raiz;
        Graphics nodo;
        Font font;
        int cordenadasX = 300;
        int cordenadasY = 45;
        bool duplicar = false;
        bool existe = false;
        //Crear constructores
        public ArbolBalanceado()
        {

        }
        public ArbolBalanceado(Nodo nueva)
        {
            raiz = nueva;
        }
        public ArbolBalanceado(Graphics nodo, Font font)
        {
            this.nodo = nodo;
            this.font = font;
        }
        //Factor de equilibrio
        private int FactorEquilibrio(Nodo x)
        {
            if (x == null)
            {
                return -1;
            }
            else
            {
                return x.fe;
            }
        }
        //1. Rotaciones
        //1.1 Rotacion izquierdaderecha
        private Nodo RotarIzquierdaDer(Nodo x)
        {
            Nodo auxiliar = x.izquierdo;
            x.izquierdo = auxiliar.derecho;
            auxiliar.derecho = x;
            x.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            auxiliar.fe = Math.Max(FactorEquilibrio(auxiliar.izquierdo), FactorEquilibrio(auxiliar.derecho)) + 1;
            return auxiliar;
        }
        //1.2 Rotacion derchaizquierda
        private Nodo RotarDerechaIzq(Nodo x)
        {
            Nodo auxiliar = x.derecho;
            x.derecho = auxiliar.izquierdo;
            auxiliar.izquierdo = x;
            x.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            auxiliar.fe = Math.Max(FactorEquilibrio(auxiliar.izquierdo), FactorEquilibrio(auxiliar.derecho)) + 1;
            return auxiliar;
        }
        //1.3 Rotacion derecha derecha
        private Nodo DerechaDerecha(Nodo x)
        {
            Nodo temp;
            x.derecho = RotarIzquierdaDer(x.derecho);
            temp = RotarDerechaIzq(x);
            return temp;
        }
        //1.4 Rotacion izquierda izquierda
        private Nodo IzquierdaIzquierda(Nodo x)
        {
            Nodo temp;
            x.izquierdo = RotarDerechaIzq(x.izquierdo);
            temp = RotarIzquierdaDer(x);
            return temp;

        }
        //Insertar Nodo
        private Nodo InsertarN(Nodo neuvo, Nodo Subar)
        {
            Nodo nuevopadre = Subar;
            if (neuvo.salario <= Subar.salario)
            {
                if (Subar.izquierdo == null)
                {
                    Subar.izquierdo = neuvo;
                }
                else
                {
                    Subar.izquierdo = InsertarN(neuvo, Subar.izquierdo);
                    if (FactorEquilibrio(Subar.izquierdo) - FactorEquilibrio(Subar.derecho) == 2)
                    {
                        if (neuvo.salario <= Subar.izquierdo.salario)
                        {
                            nuevopadre = RotarIzquierdaDer(Subar);
                        }
                        else
                        {
                            nuevopadre = IzquierdaIzquierda(Subar);
                        }
                    }
                }
                duplicar = false;
            }
            else if (neuvo.salario >= Subar.salario)
            {
                if (Subar.derecho == null)
                {
                    Subar.derecho = neuvo;
                }
                else
                {
                    Subar.derecho = InsertarN(neuvo, Subar.derecho);
                    if (FactorEquilibrio(Subar.derecho) - FactorEquilibrio(Subar.izquierdo) == 2)
                    {
                        if (neuvo.salario >= Subar.derecho.salario)
                        {
                            nuevopadre = RotarDerechaIzq(Subar);
                        }
                        else
                        {
                            nuevopadre = DerechaDerecha(Subar);
                        }
                    }
                }
                duplicar = false;
            }
            else { duplicar = true; }
            if ((Subar.izquierdo == null) && (Subar.derecho != null))
            {
                Subar.fe = Subar.derecho.fe + 1;
            }
            else if ((Subar.derecho == null) && (Subar.izquierdo != null))
            {
                Subar.fe = Subar.izquierdo.fe + 1;
            }
            else
            {
                Subar.fe = Math.Max(FactorEquilibrio(Subar.izquierdo), FactorEquilibrio(Subar.derecho)) + 1;
            }
            return nuevopadre;
        }
        //Insertar datos
        public bool InsertarDAtos(double total)
        {
            Nodo nuevo = new Nodo(total);
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                raiz = InsertarN(nuevo, raiz);
            }
            return duplicar;
        }
        //Cambiar
        private Nodo Cambiar(Nodo axu)
        {
            Nodo temp = axu, temp2 = axu.izquierdo;
            while (temp2.derecho != null)
            {
                temp = temp2;
                temp2 = temp2.derecho;
            }
            axu.salario = temp2.salario;
            if (temp == axu)
            {
                temp.izquierdo = temp2.izquierdo;
            }
            else
            {
                temp.derecho = temp2.izquierdo;
            }
            return temp2;
        }
        //eliminar el nodo
        private Nodo eliminarnodo(Nodo Raiz, double total)
        {
            if (Raiz == null)
            {
                existe = false;
            }
            else if (total < Raiz.salario)
            {
                Nodo izq = eliminarnodo(Raiz.izquierdo, total);
                Raiz.izquierdo = izq;
            }
            else if (total > Raiz.salario)
            {
                Nodo der = eliminarnodo(Raiz.derecho, total);
                Raiz.derecho = der;
            }
            else
            {
                Nodo axu = Raiz;
                if (axu.derecho == null)
                {
                    Raiz = axu.izquierdo;
                }
                else if (axu.izquierdo == null)
                {
                    Raiz = axu.derecho;
                }
                else
                {
                    axu = Cambiar(axu);
                }
                axu = null;
                existe = true;
            }
            return Raiz;
        }
        //Eliminar
        public bool eliminar(double total)
        {
            raiz = eliminarnodo(raiz, total);
            return existe;
        }
        //Mostrar el arbol
        public void mostrararbol(PaintEventArgs e, Color c)
        {
            e.Graphics.Clear(c);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nodo = e.Graphics;
            dibujarArbol(nodo, font, Brushes.Beige, Brushes.BlueViolet, Pens.Gray, Brushes.Black);
        }
        //Dibujar el arbol
        private void dibujarArbol(Graphics grafico, Font fuente, Brush colorrelleno, Brush colorfuente, Pen relacion, Brush borde)
        {
            if (raiz == null)
            {
                return;
            }
            raiz.UbicacionNodo(cordenadasX, cordenadasY);
            raiz.dibujarramas(grafico, relacion);
            raiz.dibujarnodo(grafico, fuente, colorrelleno, colorfuente, relacion, borde);
        }
        //REcorrido INORDEN
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
        //RECORRIDO POSSTORDEN
        public void PostOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PostOrden(raiz, lst, lbl);
        }
        public void PostOrden(Nodo tempm, ListBox lst, Label lbl)
        {
            if (tempm != null)
            {
                lbl.Text = "Recorrido  PostOrden";
                PostOrden(tempm.izquierdo, lst, lbl);
                PostOrden(tempm.derecho, lst, lbl);
                lst.Items.Add(tempm.salario.ToString());
            }
        }
        //RECORRIDO PREORDEN
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
