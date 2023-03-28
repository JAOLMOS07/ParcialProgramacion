using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioLiquidacionLVA : ILiquidacion1<LiquidacionLVA>
    {
        
        RepositorioLVA repo = new RepositorioLVA();
        public string Agregar(LiquidacionLVA Liquidacion)
        {

            String txt = repo.Guardar(Liquidacion);
            ServicioLiquidacionCC serv = new ServicioLiquidacionCC();
            double lva = TotalLiquidado();
            double cc = serv.TotalLiquidado();
            Archivo ar = new Archivo();
            ar.Actualizar(cc, lva);
            return txt;
        }

        public LiquidacionLVA buscar(string numero)
        {
            List<LiquidacionLVA> lista = ObtenerLista();
            for (int i = 0; i < lista.Count; i++)
            {
                if (numero.Equals(lista[i].numeroLiquidacion))
                {
                    return lista[i];
                }
            }
            return new LiquidacionLVA();
        }

        public List<LiquidacionLVA> ObtenerLista()
        {
           
            return repo.TraerLista();
        }

        public double Tarifa(double Tarifa)
        {
            throw new NotImplementedException();
        }

        public double TotalLiquidado()
        {
            List<LiquidacionLVA> lista = ObtenerLista();
            double total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += lista[i].valorLiquidado();
            }
            return total;
            
        }

        public double ValorLiquidado(double Tarifa, double BaseGravable)
        {
            throw new NotImplementedException();
        }
    }
}
