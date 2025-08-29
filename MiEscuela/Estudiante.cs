using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public class Estudiante
    {
        private string Estatus;
        #region Atributos
        #endregion
        #region Metodos
        public string Registrar() {
            //método para registrar
            string reg = "Alumno registrado";
            return reg;
        }
        public string DarBaja() {
            this.Estatus = "false";
            string baja_correcta = "Alumno dado de baja";
            return baja_correcta;
        }
        public string DarBaja(string motivo) {
            this.Estatus = "false";
            //guardamos en la bd el motivo
            string baja_correcta = "Alumno dado de baja por el motivo: " + motivo;
            return baja_correcta;
        }
        public void DarBaja(string usuario, string clave, string motivo){
            //validamos usuario y clave
            //verificar_usuario(usuario, clave);
            //validamos permisos
        }
        public string Controlar()
        {
            DateTime horaActual = DateTime.Now;
            //guardamos en la bd la hora
            string respuesta = "Hora registrada es: " + horaActual;
            return respuesta;
        }
        #endregion
    }
}
