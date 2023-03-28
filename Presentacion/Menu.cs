using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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
            LiquidacionLVAGUI LVAGUI = new LiquidacionLVAGUI();
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
                            do
                            {
                                texto.Submenu();
                                Op1 = int.Parse(Console.ReadLine());
                                switch (Op1)
                                {
                                    case 1:
                                        {
                                            LVAGUI.ObtenerDatosLVA();
                                        }
                                        break;
                                    case 2:
                                        {
                                            CCGUI.ObtenerDatosCC();
                                        }
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Digite una opción válida");
                                        }
                                        break;
                                }
                            } while (Op1 != 3);
                        }break;
                    case 2:
                        {
                            LVAGUI.VisualizarLiquidacionLVA();
                        }
                        break;
                    case 3:
                        {
                            CCGUI.VisualizarLiquidacionCC();
                            Console.ReadKey();
                            
                        }break;
                    case 4:
                        {
                            LVAGUI.MostrarLiquidacionesLVA();
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("----------Total Liquidado----------\n");
                            LVAGUI.MostrarValorLiquidacionLVA();
                            Console.WriteLine();
                            CCGUI.MostrarLiquidacionCC();  
                        }break;
                    case 6:
                        {

                        }break;
                    case 7:
                        break;
                }
            } while (Op != 7);
        }
    }
}
