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
            String[] strings = { "Liquidaciones Licores,vinos o aperitivos", "Liquidaciones Cervezas" };
            
            for (int i=0; i<strings.Count(); i++) 
            {
                msg+= (i+1) + strings[i]+ "\n";
            }
            return msg;
        }
    }
}
