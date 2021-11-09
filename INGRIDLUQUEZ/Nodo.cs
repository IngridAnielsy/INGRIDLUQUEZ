using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGRIDLUQUEZ
{
    class Nodo
    {//DECLARAMOS LASS VARIABLES PARA CONTROLAR LA RAMA
        public Nodo izquierdo { get; set;}
        public Nodo derecho { get; set; }

        public double salario;
        int coordenadasX = 130,
            coordenadasY = 10,
            coordenadasXderecho,
            coordenadasYderecho,
            elipse = 35;
        public int nivel { get; set;}
        public int fe;
        public Nodo()
        {

        }
        public Nodo(double var)
        {
            salario = var;
            fe = 0;
            izquierdo = null;
            derecho = null;
        }
        public Nodo(double dato, Nodo
             Izquierdo, Nodo Derecho,
            Nodo padre)
        {
            salario = dato;
            this.izquierdo = Izquierdo;
            this.derecho = Derecho;
        }
        public void UbicacionNodo(int posX, int posY)
            {
            int aux1,
                aux2;
            coordenadasYderecho = Convert.ToInt32(posY + elipse / 2);
            if (izquierdo != null)
            {
                izquierdo.UbicacionNodo(posX, posY + elipse + coordenadasY);
            }
            if ((izquierdo != null)&&(derecho!= null))
            {
                posX += coordenadasX;
            }
            if(derecho!=null)
            {
                derecho.UbicacionNodo(posX, posY + elipse + coordenadasY);
            }
            if(izquierdo!=null && derecho != null)
            {
                coordenadasXderecho = Convert.ToInt32((izquierdo.coordenadasXderecho + derecho.coordenadasXderecho) / 2);

            }
            else if (izquierdo != null)
            {
                aux1 = izquierdo.coordenadasXderecho;
                izquierdo.coordenadasXderecho = coordenadasXderecho - 80;
                coordenadasXderecho = aux1;
            }
            else if (derecho != null)
            {
                aux2 = derecho.coordenadasXderecho;
                derecho.coordenadasXderecho = coordenadasXderecho + 80;
                coordenadasXderecho = aux2;
            }
            else
            {
                coordenadasXderecho = Convert.ToInt32(posX + elipse / 2);
                posX += elipse;
            }
            
        }
        public void dibujarramas(Graphics grafico,Pen relacion)
        {
            if(izquierdo != null)
            {
                grafico.DrawLine(relacion, coordenadasXderecho, coordenadasYderecho, izquierdo.coordenadasXderecho, izquierdo.coordenadasYderecho);
                izquierdo.dibujarramas(grafico, relacion);
            }
            if(derecho != null)
            {
                grafico.DrawLine(relacion, coordenadasXderecho, coordenadasYderecho, derecho.coordenadasXderecho, derecho.coordenadasYderecho);
                derecho.dibujarramas(grafico, relacion);
            }
        }
        public void dibujarnodo(Graphics grafico, Font fuente, Brush color, Brush colorfuente, Pen relacion, Brush b)
        {
            Rectangle temp = new Rectangle(Convert.ToInt32(coordenadasXderecho - elipse / 2), Convert.ToInt32(coordenadasYderecho - elipse / 2), elipse, elipse);
            grafico.FillEllipse(b, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafico.DrawString(salario.ToString(), fuente, colorfuente, coordenadasXderecho, coordenadasYderecho, formato);
            if(izquierdo != null)
            {
                izquierdo.dibujarnodo(grafico, fuente, color, colorfuente, relacion, b);
            }
            if(derecho != null)
            {
                derecho.dibujarnodo(grafico, fuente, color, colorfuente, relacion, b);
            }
        }
    }
}
