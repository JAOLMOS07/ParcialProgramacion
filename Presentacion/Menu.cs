using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
   public class Menu
    {
        Textos texto = new Textos();
        public void MostrarMenu()
        {
            int Op;
            do
            {
                texto.MenuPrincipal();
                Op = int.Parse(Console.ReadLine());

                switch (Op) 
                {
                    case 1:
                        {
                            int Op1; 
                           texto.Submenu();
                            Op1=int.Parse(Console.ReadLine());
                            switch (Op1) 
                            {
                                case 1:
                                    {
                                        LiquidacionLVAGUI LVA = new LiquidacionLVAGUI();
                                        LVA.ObtenerDatos();
                                    }break;
                            }

                        }break;
                }
            } while (Op != 7);
        }
    }
}
