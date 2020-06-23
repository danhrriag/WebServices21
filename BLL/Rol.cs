using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Rol
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_ROL;

        public int ID_ROL
        {
            get { return iD_ROL; }
            set { iD_ROL = value; }
        }

        private string tIPO;

        public string TIPO
        {
            get { return tIPO; }
            set { tIPO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Rol()
        {

        }

        public Rol(int iD_ROL, string tIPO, string eSTADO)
        {
            this.iD_ROL = iD_ROL;
            this.tIPO = tIPO;
            this.eSTADO = eSTADO;
        }


    }
}
