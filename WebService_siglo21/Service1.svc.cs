using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService_siglo21
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
    
        public  List<PERSONA>LoginUsuario(string rut, string pass)
        {
            Persona p = new Persona();
            return p.LoginUsuario(rut,pass);
        }

        public List<CAJA> listarCaja()
        {
            Caja c = new Caja();
            return c.listarCaja();
        }
    }
}
