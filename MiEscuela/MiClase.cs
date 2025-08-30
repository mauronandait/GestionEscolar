using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    internal interface MiClase: InterfacePrueba
    {
        string MiMetodo()
        {
            return "Hola desde MiMetodo";
        }
        string MiMensaje()
        {
            return "Hola desde MiMensaje";
        }
    }
}
