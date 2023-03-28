using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using System.Runtime.CompilerServices;

namespace Datos
{
    public class RepositorioLVA : IRepositorio<LiquidacionLVA>
    {
        String Ruta = "Archivo.txt";
        public string Guardar(LiquidacionLVA liquidacion)
        {
            throw new NotImplementedException();
        }

        public List<LiquidacionLVA> TraerLista()
        {
            List<LiquidacionLVA> lista = new List<LiquidacionLVA>();

            try
            {
                StreamReader sr = new StreamReader(Ruta);
                while (!sr.EndOfStream) {
                    String linea = sr.ReadLine();
                    String[] aux = linea.Split(';');
                    if (aux[0].Equals("LVA")) {

                        lista.Add(Mapeador(linea));
                    }
                }
            }
            catch (Exception) { 
            
            }

            return lista;
        }

        LiquidacionLVA Mapeador(String linea) {
           
            String[] aux = linea.Split(';');
            String numeroLiquidacion = aux[1];
            string idNit = aux[2];
            string razonSocial = aux[3];
            double baseGravable = double.Parse(aux[4]);
            LiquidacionLVA lva = new LiquidacionLVA(numeroLiquidacion,idNit,razonSocial,baseGravable);
            return lva;
        }
    }
}
