using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garzon
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private string rUT_GARZON;

        public string RUT_GARZON
        {
            get { return rUT_GARZON; }
            set { rUT_GARZON = value; }
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

        private string cONTRASENA;

        public string CONTRASENA
        {
            get { return cONTRASENA; }
            set { cONTRASENA = value; }
        }

        public Garzon()
        {

        }

        public Garzon(string rUT_GARZON, string nOMBRE, string aPELLIDO, string cORREO, string cONTRASENA)
        {
            this.rUT_GARZON = rUT_GARZON;
            this.nOMBRE = nOMBRE;
            this.aPELLIDO = aPELLIDO;
            this.cORREO = cORREO;
            this.cONTRASENA = cONTRASENA;
        }


    }
}
