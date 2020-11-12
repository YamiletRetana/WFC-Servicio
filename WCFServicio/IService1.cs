using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]

    public interface IService1
    {

        [OperationContract]
        Empleado GetNumeroEmpleado(string trabajador);

        [OperationContract]
        Pelicula GetObtenerPelicula(int Pelicula);

        [OperationContract]
        Escuela GetObtenerAlumno(int Alumno);

        // TODO: agregue aquí sus operaciones de servicio
    }
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]//Cliente GetNumeroControl
    public class Empleado: Respuesta
    {
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string ApellidoP { get; set; }

        [DataMember]
        public string ApellidoM { get; set; }
        [DataMember]
        public string Puesto { get; set; }
        [DataMember]
        public string Salarario { get; set; }
    }
    [DataContract]//producto getobtenerproducto
    public class Escuela : Respuesta2
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string AP_Paterno { get; set; }
        [DataMember]
        public string AP_Materno { get; set; }

        [DataMember]
        public string Curso { get; set; }

        [DataMember]
        public string Especialidad { get; set; }
    }

    [DataContract]//Pelicula getobtenerpelicula
    public class Pelicula : Respuesta3
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Clasificacion { get; set; }

        [DataMember]
        public string Duracion { get; set; }

        [DataMember]
        public String Director { get; set; }
    }
    [DataContract]
    public class Respuesta
    {
        public string Error1 { get; set; }
    }

    [DataContract]
    public class Respuesta2
    {
        public string Error2 { get; set; }
    }

    [DataContract]
    public class Respuesta3
    {
        public string Error3 { get; set; }
    }
}
