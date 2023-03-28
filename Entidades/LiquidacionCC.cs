using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LiquidacionCC:Liquidacion
    {
        String Tipo { get; set; }
        const String clave = "CC";

        public LiquidacionCC(int NumeroLiquidacion, string IdNit, string RazonSocial, double BaseGravable,string tipo) : base(NumeroLiquidacion, IdNit, RazonSocial, BaseGravable)
        {
            Tipo = tipo;
        }


        public override string ToString()
        {

            return clave+";"+numeroLiquidacion + ";" +idNit + ";" +razonSocial + ";"+baseGravable+ ";" +Tipo;
        }

        public double valorLiquidado()
        {
            if (Tipo.Equals("cervezas")|| Tipo.Equals("sifones"))
            {

                return 0.48 * baseGravable;
            }
            else
            {
                return 0.20 * baseGravable;
            }


        }

    }
}
