using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using Logica;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LiquidacionLVA lva = new LiquidacionLVA("123","asd","Empresa",34);
            LiquidacionCC cc = new LiquidacionCC("12344", "asd", "Empresa3", 29000,"cerveza");
            ServicioLiquidacionLVA servi = new ServicioLiquidacionLVA();
            List<LiquidacionLVA> lista = servi.ObtenerLista();
            for (int i = 0; i < lista.Count; i ++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("Total: "+servi.TotalLiquidado());
            Console.ReadLine();

            
        }
    }
}
