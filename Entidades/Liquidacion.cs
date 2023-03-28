using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        public string numeroLiquidacion { get; set; }
        public string idNit { get; set; }
        public string razonSocial { get; set; }
        public double baseGravable { get; set; }

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
