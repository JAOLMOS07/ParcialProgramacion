using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Textos
    {
        public void MenuPrincipal()
        {
            Console.Clear();
            var msg = "---------------Menu---------------\n\n";
            String[] strings = { "Registrar información de liquidación","Visualizar la información de liquidación",
            "Visualizar liquidaciones del impuesto consumo de cervezas,silfones y refajos",
            "Visualizar liquidaciones del impuesto licores,vinos y aperitivos","Visualizar Total recaudado por liquidaciones",
            "Generar un archivo plano con un balance de las liquidaciones", "Salir"};
            
            for (int i=0; i<strings.Count(); i++) 
            {
                msg+= (i+1) +"->"+ strings[i]+ "\n\n";
            }
            msg += "Digite una opción ";
            Console.WriteLine(msg);
        }
        public void Submenu() 
        {
            Console.Clear();
            var msg = "----------Registro de información de liquidación----------\n";
            String[] strings = { "Liquidación Licores,vinos o aperitivos", "Liquidaciones Cervezas, sifones o refajos", "Volver" };

            for (int i = 0; i < strings.Count(); i++)
            {
                msg += $"{i + 1}->{strings[i]}\n";
            }
            msg += "Digite una opción ";
            Console.WriteLine(msg);
        }
        public void SubmenuBuscar()
        {
            Console.Clear();
            var msg = "----------Visualizar un dato----------\n";
            String[] strings = { "Liquidación Licores,vinos o aperitivos", "Liquidaciones Cervezas, sifones o refajos", "Volver" };

            for (int i = 0; i < strings.Count(); i++)
            {
                msg += $"{i + 1}->{strings[i]}\n";
            }
            msg += "Digite una opción ";
            Console.WriteLine(msg);
        }
    }
}
