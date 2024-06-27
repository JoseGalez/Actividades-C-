using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia13POO.Models
{
    public class Despacho
    {

        public int CodigoPostal { get; private set; }
        public double PesoGr { get; private set; }
        public double Pago { get; private set; }
        public int Emp { get; set; }
        public bool EsCer { get; set; }

        public double CostoBase { get; private set; }
        public double CostoIVA { get; private set; }
       
        public Despacho(int cp, double pesogr, int empdis, bool esCer)
        {
            this.CodigoPostal = cp;
            this.PesoGr = pesogr;
            this.Emp = empdis;
            this.EsCer = esCer;
            CalcularCosto();
        }

        private void CalcularCosto()
        {
            double tarifa = 0.5;
            if (EsCer) tarifa = 1;
            CostoBase = PesoGr * tarifa;
            CostoIVA = 0.21  * CostoBase;
            Pago = CostoBase + CostoIVA;
        }
    }
}
