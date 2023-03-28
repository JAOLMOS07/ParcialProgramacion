using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorio<T>
    {
         String Guardar(T liquidacion);
         List<T> TraerLista();

  
         
    }
}
