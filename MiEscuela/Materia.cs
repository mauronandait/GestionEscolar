﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public abstract class Materia
    {
        #region Atributos
        string clave;
        string nombre;
        #endregion
        #region Metodos
        public abstract decimal AsignarCalificacion();
        #endregion
    }
}
