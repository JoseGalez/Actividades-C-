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
            for (int i = 0; i < Contador; i++)
            {
                if (despacho[i].Emp == nEmp)
                {

                }

                     
            }
        }
        public double RecxEmp(int nEmp)
        {

        }
        public int CorrspxEmp(int nEmp)
        {

        }
        public double RecaudacionT()
        {

        }
        public int TransMyCorres()
        {

        }
        public int[] PrepararDisEmp(int emp,ref int cant)
        {

        }

    }
}
