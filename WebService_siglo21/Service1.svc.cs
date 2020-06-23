using BLL;
using DAL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
       
        public List<PERSONA> LoginUsuario(string rut, string pass)
        {
            Persona p = new Persona();
            return p.LoginUsuario(rut, pass);
        }

        public List<CAJA> listarCaja()
        {
            Caja c = new Caja();
            return c.listarCaja();
        }

        public List<Mesa> listarMesa()
        {
            Mesa m = new Mesa();
            return m.listarMesa();

        }
        public List<Mesa> listarMesaID(int nro)
        {
            Mesa m = new Mesa();
            return m.listarMesaID(nro);
        }

        public bool modMesa(int nr, string descr, int asientos, string estado)
        {
            Mesa m = new Mesa();

            m.NROMESA = nr;
            m.DESCRIPCION = descr;
            m.CANTIDADASIENTOS = asientos;
            m.ESTADO = estado;
            m.modMesa();
            return true;
        }

        public bool AddMesa(int nr, string descr, int asientos, string estado)
        {
            Mesa m = new Mesa();

            m.NROMESA = nr;
            m.DESCRIPCION = descr;
            m.CANTIDADASIENTOS = asientos;
            m.ESTADO = estado;
            m.AddMesa();
            return true;
        }

        public List<PERSONA> listarPersona()
        {
            Persona p = new Persona();
            return p.listarPersona();
        }

        public bool AddPersona(string RUT_PERSONA, string NOMBRE, string APELLIDO, string CORREO, string ESTADO, string CONTRASENA, string TELEFONO, short ID_ROL)
        {
            Persona p = new Persona();
            p.RUT_PERSONA = RUT_PERSONA;
            p.NOMBRE = NOMBRE;
            p.APELLIDO = APELLIDO;
            p.CORREO = CORREO;
            p.ESTADO = ESTADO;
            p.CONTRASENA = CONTRASENA;
            p.TELEFONO = TELEFONO;
            p.ID_ROL = ID_ROL;
            p.AddPersona();
            return true;
        }

        public bool modPersona(string RUT_PERSONA, string NOMBRE, string APELLIDO, string CORREO, string ESTADO, string CONTRASENA, string TELEFONO, short ID_ROL)
        {
            Persona p = new Persona();
            p.RUT_PERSONA = RUT_PERSONA;
            p.NOMBRE = NOMBRE;
            p.APELLIDO = APELLIDO;
            p.CORREO = CORREO;
            p.ESTADO = ESTADO;
            p.CONTRASENA = CONTRASENA;
            p.TELEFONO = TELEFONO;
            p.ID_ROL = ID_ROL;
            p.modPersona();
            return true;
        }
        public List<PERSONA> listarPersonaRut(string rut)
        {
            Persona p = new Persona();
            return p.listarPersonaRut(rut);
        }

        public List<Rol> listarRol()
        {
            Rol rol = new Rol();

           return  rol.listarRol();
        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public string top_platos(string finicio, string ffin)
        {
            TopPlatos tp = new TopPlatos();
            return tp.top_platos(finicio, ffin);
        }


    }
}
