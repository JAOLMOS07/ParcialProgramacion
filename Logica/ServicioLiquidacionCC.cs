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
       
        RepositorioCC repo = new RepositorioCC();

        public string Agregar(LiquidacionCC Liquidacion)
        {

           return repo.Guardar(Liquidacion);
        }

        public List<LiquidacionCC> ObtenerLista()
        {
            return repo.TraerLista();
        }

        public double Tarifa(double Tarifa)
        {
            throw new NotImplementedException();
        }

        public double TotalLiquidado()
        {
            List<LiquidacionCC> lista = ObtenerLista();
            double total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += lista[i].valorLiquidado();
            }
            return total;
        }

        public double TotalLiquidado()
        {
            throw new NotImplementedException();
        }

        public double ValorLiquidado(double Tarifa, double BaseGravable)
        {
            throw new NotImplementedException();
        }
    }
}
