using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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


    }
}
