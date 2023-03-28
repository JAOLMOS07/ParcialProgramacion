using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ILiquidacion1 <T>
    {
        List<T> ObtenerLista();
        string Agregar(T Liquidacion);
        double TotalLiquidado(List<T> Liquidado);
        double ValorLiquidado(double Tarifa, double BaseGravable);
        double Tarifa(double Tarifa);
    }
}
