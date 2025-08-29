using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public class Profesor : Empleado
    {
        #region Atributos
        private string matricula;
        private Materia materia;
        private FrecuenciaPago frecuenciaPago;
        #endregion

        #region Propiedades
        public string Matricula
        {
            get
            {
                return matricula + "2017";
            }
        }
        public Materia Materia { get; set; }
        #endregion

        #region Metodos
        public string RevisarHora()
        {
            DateTime hora_actual = DateTime.Now;
            string hora = hora_actual.ToString();
            return hora;
        }
        public void AsignarMateria(Materia materia)
        {
            Materia = materia;
        }
        #endregion
    }
}