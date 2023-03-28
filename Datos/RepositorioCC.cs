using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Datos
{
    public class RepositorioCC : IRepositorio<LiquidacionCC>
    {
        String Ruta = "Liquidaciones.txt";
        public string Guardar(LiquidacionCC liquidacion)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Ruta, true);

                sw.WriteLine(liquidacion.ToString());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un problema:");
                Console.WriteLine(e.Message);
            }
          

            return "guardado";
        }

        public List<LiquidacionCC> TraerLista()
        {
            List <LiquidacionCC> lista = new List<LiquidacionCC>();


            try
            {
                StreamReader sr = new StreamReader(Ruta);
                while (!sr.EndOfStream)
                {
                    String linea = sr.ReadLine();
                    String[] aux = linea.Split(';');
                    if (aux[0].Equals("CC"))
                    {

                        lista.Add(Mapeador(linea));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un problema:");
                Console.WriteLine(e.Message);
            }

            return lista;
        }
        LiquidacionCC Mapeador(String linea)
        {

            String[] aux = linea.Split(';');
            String numeroLiquidacion = aux[1];
            string idNit = aux[2];
            string razonSocial = aux[3];
            double baseGravable = double.Parse(aux[4]);
            String tipo = aux[5];
            LiquidacionCC cc = new LiquidacionCC(numeroLiquidacion, idNit, razonSocial, baseGravable,tipo);
            return cc;
        }
    }
}
