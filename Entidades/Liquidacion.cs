using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        protected String numeroLiquidacion { get; set; }
        protected string idNit { get; set; }
        protected string razonSocial { get; set; }
        protected double baseGravable { get; set; }

        public Liquidacion() 
        {

        }

        public Liquidacion( String NumeroLiquidacion, string IdNit, string RazonSocial, double BaseGravable )
        {
            this.numeroLiquidacion = NumeroLiquidacion;
            this.idNit = IdNit;  
            this.razonSocial = RazonSocial;
            this.baseGravable = BaseGravable;
        }
    }
}
