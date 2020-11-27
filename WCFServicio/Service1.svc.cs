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

        public Numeros GetObtenerSuma(int numero)//numero es nuestro identificado

        {
                if (numero == 1)
                {
                    return new Numeros() { Numero1 = "15", Numero2 = "100", Numero3 = "27" };
                }
                if (numero == 2)
                {
                    return new Numeros() { Numero1 = "1745", Numero2 = "10", Numero3 = "97" };
                }
                if (numero == 3)
                {
                    return new Numeros() { Numero1 = "362", Numero2 = "10", Numero3 = "97" };
                }
                else
                {

                    return new Numeros() { Error3 = "Error 1. Los datos no coinciden en la busqueda del sistema" };
                }
        }

        public Escuela GetObtenerAlumno(int Alumno)//alumno es nuestro identificador
        {
            if (Alumno == 17030103)
            {
                return new Escuela() { Nombre = "Yamilet", AP_Paterno = "Retana", AP_Materno = "Hernandez", Curso = "7", Especialidad = "Informatica", Promedio = "10" };
            }
            if (Alumno == 17030104)
            {
                return new Escuela() { Nombre = "Fernando", AP_Paterno = "Vasquez", AP_Materno = "Sandoval", Curso = "4", Especialidad = "Mecatronica", Promedio = "9.0" };
            }
            if (Alumno == 17030105)
            {
                return new Escuela() { Nombre = "Gabriela", AP_Paterno = "Gramillo", AP_Materno = "Vaquera", Curso = "2", Especialidad = "Administracion", Promedio = "8.5" };
            }
            if (Alumno == 17030106)
            {
                return new Escuela() { Nombre = "Jaquline", AP_Paterno = "Fernandez", AP_Materno = "Maldonado", Curso = "8", Especialidad = "Industrial", Promedio = "7.0" };
            }
            else
            {
                return new Escuela() { Error2 = "Error 1. No se ha encontrado al Usuario" };
            }
        }

        public double conversionDolares(double dolares)
        {
            return dolares * 20.75;
        }

        public int GetSuma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

       
        