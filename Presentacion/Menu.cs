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
            LiquidacionLVAGUI LVA = new LiquidacionLVAGUI();
            LiquidacionCCGUI CCGUI = new LiquidacionCCGUI();
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
                                        LVA.ObtenerDatosLVA();
                                    }break;
                            }

                        }break;
                    case 2:
                        {

                        }break;
                    case 3:
                        {

                        }break;
                    case 4:
                        {
                            LVA.MostrarLiquidacionLVA();
                        }
                        break;
                }
            } while (Op != 7);
        }
    }
}
