using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        String Ruta = "LiquidacionesTotales.txt";
        public void Actualizar(double cc, double lva) {
            try
            {
                StreamWriter sw = new StreamWriter(Ruta);

                sw.WriteLine("Liquidacion de Impuestos de Licores, vinos y aperitivos: " + lva);
                sw.WriteLine("Impuesto al consumo de cervezas: " + cc);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un problema:");
                Console.WriteLine(e.Message);
            }




        }
    }
}
