using DAL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private string rUT_PERSONA;

        public string RUT_PERSONA
        {
            get { return rUT_PERSONA; }
            set { rUT_PERSONA = value; }
        }

        private string nOMBRE;

        public string NOMBRE
        {
            get { return nOMBRE; }
            set { nOMBRE = value; }
        }

        private string aPELLIDO;

        public string APELLIDO
        {
            get { return aPELLIDO; }
            set { aPELLIDO = value; }
        }

        private string cORREO;

        public string CORREO
        {
            get { return cORREO; }
            set { cORREO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string cONTRASENA;

        public string CONTRASENA
        {
            get { return cONTRASENA; }
            set { cONTRASENA = value; }
        }

        private string tELEFONO;

        public string TELEFONO
        {
            get { return tELEFONO; }
            set { tELEFONO = value; }
        }

        private int iD_ROL;

        public int ID_ROL
        {
            get { return iD_ROL; }
            set { iD_ROL = value; }
        }

        public Persona()
        {

        }

        public Persona(string rUT_PERSONA, string nOMBRE, string aPELLIDO, string cORREO, string eSTADO, string cONTRASENA, string tELEFONO, int iD_ROL)
        {
            this.rUT_PERSONA = rUT_PERSONA;
            this.nOMBRE = nOMBRE;
            this.aPELLIDO = aPELLIDO;
            this.cORREO = cORREO;
            this.eSTADO = eSTADO;
            this.cONTRASENA = cONTRASENA;
            this.tELEFONO = tELEFONO;
            this.iD_ROL = iD_ROL;
        }

        public List<PERSONA> LoginUsuario(string rut, string pass)
        {
            List<PERSONA> usuarios = null;
           
                ora.Open();
                OracleCommand comand = new OracleCommand("SP_VALIDAR_USUARIO", ora);
                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Parameters.Add("usuario", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
                comand.Parameters.Add("username", OracleDbType.Varchar2).Value = rut;
                comand.Parameters.Add("contrasena", OracleDbType.Varchar2).Value = pass;
                OracleDataAdapter da = new OracleDataAdapter(comand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                PERSONA p = new PERSONA();
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    usuarios = (from DataRow row in dt.Rows
                                select new PERSONA
                                {
                                    RUT_PERSONA = row["RUT_PERSONA"].ToString(),
                                    NOMBRE =     row["NOMBRE"].ToString(),
                                    APELLIDO = row["APELLIDO"].ToString(),
                                    CORREO = row["CORREO"].ToString(),
                                    ESTADO = row["ESTADO"].ToString(),
                                    CONTRASENA = row["CONTRASENA"].ToString(),
                                    TELEFONO = row["TELEFONO"].ToString(),
                                    ROL_ID_ROL =  short.Parse(row["ROL_ID_ROL"].ToString()),                                    
                                }).ToList();

                }
                ora.Close();
                return usuarios;
        }

        public bool AddPersona()
        {
            CommonBC.ModeloEntities.PRO_CREAR_PERSONA(RUT_PERSONA, NOMBRE, APELLIDO, CORREO, ESTADO, CONTRASENA, TELEFONO , ID_ROL);
            return true;
        }

        public bool modPersona()
        {
            CommonBC.ModeloEntities.PRO_MODIFICAR_PERSONA(RUT_PERSONA, NOMBRE, APELLIDO, CORREO, ESTADO, CONTRASENA, TELEFONO, ID_ROL);
            return true;
        }
        public List<PERSONA> listarPersona()
        {
            List<PERSONA> usuarios = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_PERSONA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("pers_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                usuarios = (from DataRow row in dt.Rows
                            select new PERSONA
                            {
                                RUT_PERSONA = row["RUT_PERSONA"].ToString(),
                                NOMBRE = row["NOMBRE"].ToString(),
                                APELLIDO = row["APELLIDO"].ToString(),
                                CORREO = row["CORREO"].ToString(),
                                ESTADO = row["ESTADO"].ToString(),
                                CONTRASENA = row["CONTRASENA"].ToString(),
                                TELEFONO = row["TELEFONO"].ToString(),
                                ROL_ID_ROL = short.Parse(row["ROL_ID_ROL"].ToString()),
                            }).ToList();
            }
            ora.Close();
            return usuarios;
        }

        public List<PERSONA> listarPersonaRut(string rut)
        {
            List<PERSONA> usuarios = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_PERSONA_RUT", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("pers_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("xrut_persona", OracleDbType.Varchar2).Value = rut;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                usuarios = (from DataRow row in dt.Rows
                            select new PERSONA
                            {
                                RUT_PERSONA = row["RUT_PERSONA"].ToString(),
                                NOMBRE = row["NOMBRE"].ToString(),
                                APELLIDO = row["APELLIDO"].ToString(),
                                CORREO = row["CORREO"].ToString(),
                                ESTADO = row["ESTADO"].ToString(),
                                CONTRASENA = row["CONTRASENA"].ToString(),
                                TELEFONO = row["TELEFONO"].ToString(),
                                ROL_ID_ROL = short.Parse(row["ROL_ID_ROL"].ToString()),
                            }).ToList();
            }
            ora.Close();
            return usuarios;
        }



    }
}
