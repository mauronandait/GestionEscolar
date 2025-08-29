namespace MiEscuela
{
    public class Prueba
    {
        protected int pruebaA;
    }
    public class Program
    {
        public static void  MostrarMensaje(string mensaje) {
            Console.WriteLine("Esta es una prueba del sistema");
            Console.WriteLine(mensaje);
        }
        public static void ImprimirMensaje() { 
            Console.WriteLine("Mensaje de prueba");
        }
        static void Main(string[] args)
        {
            Console.Title = "Gestión Escolar";
            Estudiante nuevoEstudiante = new Estudiante("Juan Perez", "3A");
            nuevoEstudiante = null;
            //Profesor nuevoProfesor = new Profesor();
            //string resp = nuevoProfesor.RevisarHora();
            //MostrarMensaje(resp);
            /*
            Console.WriteLine("Bienvenidos a la escuela, presione 0 para continuar");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                ImprimirMensaje();
            }*/
        }
    }
}