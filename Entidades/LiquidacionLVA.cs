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

        public LiquidacionLVA(int NumeroLiquidacion, string IdNit, string RazonSocial, double BaseGravable) : base(NumeroLiquidacion, IdNit, RazonSocial, BaseGravable)
        {
        }



    }
}
