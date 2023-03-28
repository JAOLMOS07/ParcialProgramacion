using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Textos
    {
        public string MenuPrincipal()
        {
            Console.WriteLine();
            var msg = "----------Menu----------";
            String[] strings = { "Registrar información de liquidación","Visualizar la información de liquidación",
            "Visualizar liquidaciones del impuesto consumo de cervezas,silfones y refajos",
            "Visualizar liquidaciones del impuesto licores,vinos y aperitivos","Visualizar Total recaudado por liquidaciones",
            "Generar un archivo plano con un balance de las liquidaciones"};
            
            for (int i=0; i<strings.Count(); i++) 
            {
                msg+= (i+1) + strings[i]+ "\n";
            }
            return msg;
        }
        public string Submenu() 
        {
            Console.Clear();
            var msg = "----------Registro de información de liquidación----------\n";
            String[] strings = { "Liquidación Licores,vinos o aperitivos", "Liquidaciones Cervezas", "Salir" };

            for (int i = 0; i < strings.Count(); i++)
            {
                msg += $"{i + 1}->{strings[i]}\n";
            }
            msg += "Digite una opción ";
            return msg;
        }
    }
}
