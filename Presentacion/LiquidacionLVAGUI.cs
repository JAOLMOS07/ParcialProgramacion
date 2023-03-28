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
        public void ObtenerDatos()
        {
            Console.Clear();

            ServicioLiquidacionLVA ServicioLVA = new ServicioLiquidacionLVA();
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
        }

        public void VisualizarLiquidacion()
        {

        }
    }
}
