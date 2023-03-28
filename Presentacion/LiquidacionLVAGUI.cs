using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class LiquidacionLVAGUI
    {
        ServicioLiquidacionLVA ServicioLVA = new ServicioLiquidacionLVA();
        public void ObtenerDatosLVA()
        {
            Console.Clear();

            string numeroLiquidacion, identificacion, razonSocial,msg;
            double baseGravable;

            Console.WriteLine("----------Licores, vinos y aperitivos----------");
            Console.WriteLine("Número de liquidación : "); numeroLiquidacion =Console.ReadLine();
            Console.WriteLine("Identificación / NIT : "); identificacion =Console.ReadLine();
            Console.WriteLine("Razón social : "); razonSocial =Console.ReadLine();
            Console.WriteLine("Base Gravable : "); baseGravable = double.Parse(Console.ReadLine());

            LiquidacionLVA liquidacionLVA = new LiquidacionLVA(numeroLiquidacion, identificacion, razonSocial, baseGravable);

            msg = ServicioLVA.Agregar(liquidacionLVA);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public void VisualizarLiquidacionLVA()
        {

        }

        public void MostrarLiquidacionesLVA()
        {
            Console.Clear();
            foreach(var s in ServicioLVA.ObtenerLista())
            {
                Console.WriteLine(s.GetType());
                Console.WriteLine("----------");
            }
        }

        public void MostrarValorLiquidacionLVA()
        {
            string msg = $"El total liquidado por licores, vinos y aperitivos " +
            $"es de {ServicioLVA.TotalLiquidado()} pesos";
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
