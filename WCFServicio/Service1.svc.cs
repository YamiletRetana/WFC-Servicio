using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Empleado GetNumeroEmpleado(string trabajador)//el trabajador es nuestro identificador
        {
            if (trabajador == "1")
            {
                return new Empleado() { Nombre = "Yamilet", ApellidoP = "Retana", ApellidoM = "Hernandez", Puesto = "Gerente", Salarario = "10000" };
            }
            else if (trabajador == "2")
            {
                return new Empleado() { Nombre = "Aracely", ApellidoP = "Hernandez", ApellidoM = "Hernandez", Puesto = "Supervisora", Salarario = "15000" };
            }
            else if (trabajador == "3")
            {
                return new Empleado() { Nombre = "Juan", ApellidoP = "Perez", ApellidoM = "Muro", Puesto = "Mantenimiento", Salarario = "25000" };
            }
            else if (trabajador == "4")
            {
                return new Empleado() { Nombre = "Maria", ApellidoP = "Casales", ApellidoM = "Trejo", Puesto = "Limpieza", Salarario = "2000" };
            }
            else
            {
                return new Empleado() { Error1 = "Error 1. Empleado no encontrado" };
            }
        }

        public Pelicula GetObtenerPelicula(int Pelicula)//pelicula es nuestro identificador
        {
            if (Pelicula == 1)
            {
                return new Pelicula() { Nombre = "Buscando a Nemo", Codigo = "10001", Clasificacion = "A", Duracion = "120", Director = "Martin Scorsese"};
            }
            if (Pelicula == 2)
            {
                return new Pelicula() { Nombre = "Dumbo", Codigo = "10002", Clasificacion = "A", Duracion = "130", Director = "Stanley Kubrick" };
            }
            if (Pelicula == 3)
            {
                return new Pelicula() { Nombre = "Toy Story", Codigo = "10003", Clasificacion = "A", Duracion = "160", Director = "Steve Spielberg" };
            }
            if (Pelicula == 4)
            {
                return new Pelicula() { Nombre = "Cenicienta", Codigo = "10004", Clasificacion = "A", Duracion = "90", Director = "Alfred Hitchock" };
            }
            else
            {
                return new Pelicula() { Error3 = "Error 1. Los datos no coinciden en la busqueda del sistema" };
            }
                 
        }

        public Escuela GetObtenerAlumno(int Alumno)//alumno es nuestro identificador
        {
            if (Alumno == 17030103)
            {
                return new Escuela() { Nombre = "Yamilet", AP_Paterno = "Retana", AP_Materno= "Hernandez", Curso ="7", Especialidad= "Informatica" };
            }
            if (Alumno == 17030104)
            {
                return new Escuela() { Nombre = "Fernando", AP_Paterno = "Vasquez", AP_Materno = "Sandoval", Curso = "4", Especialidad = "Mecatronica" };
            }
            if (Alumno == 17030105)
            {
                return new Escuela() { Nombre = "Gabriela", AP_Paterno = "Gramillo", AP_Materno = "Vaquera", Curso = "2", Especialidad = "Administracion" };
            }
            if (Alumno == 17030106)
            {
                return new Escuela() { Nombre = "Jaquline", AP_Paterno = "Fernandez", AP_Materno = "Maldonado", Curso = "8", Especialidad = "Industrial" };
            }
            else
            {
                return new Escuela() { Error2 = "Error 1. No se ha encontrado al Usuario" };
            }
        }
    }
}

       
        