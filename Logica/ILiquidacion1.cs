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
        double TotalLiquidado();
        double ValorLiquidado(double Tarifa, double BaseGravable);
        double Tarifa(double Tarifa);
    }
}
