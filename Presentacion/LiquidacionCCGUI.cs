using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class LiquidacionCCGUI
    {
        ServicioLiquidacionCC ServicioCC = new ServicioLiquidacionCC();
        public void ObtenerDatosCC()
        {
            Console.Clear();

            string numeroLiquidacion, identificacion, razonSocial,tipo, msg;
            double baseGravable;

            Console.WriteLine("----------Cervezas, sifones y refajos----------");
            Console.WriteLine("Número de liquidación : "); numeroLiquidacion = Console.ReadLine();
            Console.WriteLine("Identificación / NIT : "); identificacion = Console.ReadLine();
            Console.WriteLine("Razón social : "); razonSocial = Console.ReadLine();
            Console.WriteLine("Tipo : "); tipo = Console.ReadLine();    
            Console.WriteLine("Base Gravable : "); baseGravable = double.Parse(Console.ReadLine());

            LiquidacionCC liquidacionLVA = new LiquidacionCC(numeroLiquidacion, identificacion, razonSocial, baseGravable,tipo);

            msg = ServicioCC.Agregar(liquidacionLVA);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        public void VisualizarLiquidacionCC()
        {
            string msg="----------Cervezas,sifones y refajos----------\n";
            foreach(var s in ServicioCC.ObtenerLista())
            {
                msg += "Numero liquidacion : " + s.numeroLiquidacion+ "\n";
                msg += "Id/NIT : "+s.idNit + "\n";
                msg += "Razón Social : "+s.razonSocial + "\n";
                msg += "Tipo : " + s.Tipo + "\n";
                msg += "Base Gravable : " + s.baseGravable + "\n";
                msg += "-----------------";
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public void MostrarLiquidacionCC()
        {
            string msg = $"El total liquidado por cervezas, sifones y refajos " +
            $"es de {ServicioCC.TotalLiquidado()} pesos";
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
