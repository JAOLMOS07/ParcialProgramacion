using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioLiquidacionCC : ILiquidacion1<LiquidacionCC>
    {
        
        List<LiquidacionCC> liquidacions = new List<LiquidacionCC>();

        public List<LiquidacionCC> GetLiquidacionCCs() { return liquidacions; }
        public string Agregar(LiquidacionCC Liquidacion)
        {

            throw new NotImplementedException();
        }

        public List<LiquidacionCC> ObtenerLista()
        {
            throw new NotImplementedException();
        }

        public double Tarifa(double Tarifa)
        {
            throw new NotImplementedException();
        }

        public double TotalLiquidado(List<LiquidacionCC> Liquidado)
        {
            throw new NotImplementedException();
        }

        public double ValorLiquidado(double Tarifa, double BaseGravable)
        {
            throw new NotImplementedException();
        }
    }
}
