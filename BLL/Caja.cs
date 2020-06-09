using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Caja
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_CAJA;

        public int ID_CAJA
        {
            get { return iD_CAJA; }
            set { iD_CAJA = value; }
        }


        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        public Caja()
        {

        }

        public Caja(int iD_CAJA, string eSTADO, string dESCRIPCION)
        {
            this.iD_CAJA = iD_CAJA;
            this.eSTADO = eSTADO;
            this.dESCRIPCION = dESCRIPCION;
        }



    }
}
