using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public enum FrecuenciaPago
    {
        Mensual,
        Quincenal,
        Semanal
    }
    public class Empleado
    {
        #region Atributos
        private int id;
        private string nombre;
        private bool activo;
        private string nacionalidad;
        private int edad;
        private double pago;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public double Pago
        {get;}
        #endregion

        #region Metodos
        public  void CalcularSalario()
        {
            //cálculo de salario
        }
        #endregion
    }
}