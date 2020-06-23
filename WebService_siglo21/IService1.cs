using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WebService_siglo21.Service1;

namespace WebService_siglo21
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<PERSONA> LoginUsuario(string rut, string pass);

        [OperationContract]
        List<CAJA> listarCaja();

        [OperationContract]
        List<Mesa> listarMesa();

        [OperationContract]
        List<Mesa> listarMesaID(int nro);

        [OperationContract]
        bool modMesa(int nr, string descr, int asientos, string estado);

        [OperationContract]
        bool AddMesa(int nr, string descr, int asientos, string estado);

        [OperationContract]
        List<PERSONA> listarPersona();

        [OperationContract]
        bool AddPersona(string RUT_PERSONA,string NOMBRE,string  APELLIDO,string CORREO,string  ESTADO,string  CONTRASENA,string  TELEFONO ,short ID_ROL);

        [OperationContract]
        bool modPersona(string RUT_PERSONA, string NOMBRE, string APELLIDO, string CORREO, string ESTADO, string CONTRASENA, string TELEFONO, short ID_ROL);
       
        [OperationContract]
        List<PERSONA> listarPersonaRut(string rut);

        [OperationContract]
        List<Rol> listarRol();

        [OperationContract]
        bool validarRut(string rut);

        [OperationContract]
        string top_platos(string finicio, string ffin);
     
    }

}
