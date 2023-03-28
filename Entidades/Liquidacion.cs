using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        protected int numeroLiquidacion { get; set; }
        protected string idNit { get; set; }
        protected string razonSocial { get; set; }
        protected double baseGravable { get; set; }

        public Liquidacion() 
        {

        }

        public Liquidacion( int NumeroLiquidacion, string IdNit, string RazonSocial, double BaseGravable )
        {
            numeroLiquidacion = NumeroLiquidacion;
            idNit = IdNit;  
            razonSocial = RazonSocial;
            baseGravable = BaseGravable;
        }
    }
}
