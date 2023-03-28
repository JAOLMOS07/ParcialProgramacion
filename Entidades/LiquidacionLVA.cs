using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LiquidacionLVA:Liquidacion
    {
        const String clave = "LVA";

        public LiquidacionLVA()
        {
        }

        public LiquidacionLVA(string NumeroLiquidacion, string IdNit, string RazonSocial, double BaseGravable) : base(NumeroLiquidacion, IdNit, RazonSocial, BaseGravable)
        {
        }

        public override string ToString()
        {

            return clave + ";" + numeroLiquidacion + ";" + idNit + ";" + razonSocial + ";" + baseGravable ;
        }

        public double valorLiquidado() {
            if (baseGravable <= 35)
            {

                return 272 * baseGravable;
            }
            else {
                return 446 * baseGravable;
            }

        
        }

    




    }
}
