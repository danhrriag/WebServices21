using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mesa
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int nROMESA;

        public int NROMESA
        {
            get { return nROMESA; }
            set { nROMESA = value; }
        }

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        private int cANTIDADASIENTOS;

        public int CANTIDADASIENTOS
        {
            get { return cANTIDADASIENTOS; }
            set { cANTIDADASIENTOS = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Mesa()
        {

        }

        public Mesa(int nROMESA, string dESCRIPCION, int cANTIDADASIENTOS, string eSTADO)
        {
            this.nROMESA = nROMESA;
            this.dESCRIPCION = dESCRIPCION;
            this.cANTIDADASIENTOS = cANTIDADASIENTOS;
            this.eSTADO = eSTADO;
        }
    }
}
