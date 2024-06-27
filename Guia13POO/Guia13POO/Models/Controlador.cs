using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia13POO.Models
{
    public class Controlador
    {
        const int Ind = 1000;
        Despacho[] despacho = new Despacho[Ind];
        public int Contador = 0;


        public void Despachar(int cp, double peso, int empDis, bool esCer) {

            Despacho bob = new Despacho(cp, peso, empDis, esCer);
            despacho[Contador++] = bob;
            

        }
        public int CantCorrXEmp(int nEmp)
        {
            int cont = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (despacho[i].Emp == nEmp)
                {
                    cont++;
                }
            }
            return cont;
        }
        public double RecxEmp(int nEmp)
        {
            double acum = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (despacho[i].Emp == nEmp)
                {
                    acum += despacho[i].Pago;
                }
            }
            return acum;

        }
        public int CorrspxEmp(int nEmp)
        {
            int  cartMy= 0;
            int empMy = 0;

            for (int i = 1; i < 3; i++)
            {
                int carta = CantCorrXEmp(i);
                if (i == 1 || cartMy < carta) {
                    empMy = i;
                    cartMy = carta;
                }
            }
            return empMy;
        }
        public double RecaudacionT()
        {
            double acum = 0;
            for (int i = 0; i < Contador; i++)
            {
              acum += despacho[i].Pago;    
            }
            return acum;
        }
     
        public int[] PrepararDisEmp(int emp,ref int cant)
        {
            cant = 0;
            int[] posiciones = new int[Ind];
            for (int i = 0; i < Contador; i++)
            {
                if (despacho[i].Emp == emp)
                {
                    posiciones[cant] = i;
                }
            }
            return posiciones;
        }

    }
}
