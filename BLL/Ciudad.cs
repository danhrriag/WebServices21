using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ciudad
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_CIUDAD;

        public int ID_CIUDAD
        {
            get { return iD_CIUDAD; }
            set { iD_CIUDAD = value; }
        }

        private string nOMBRECIUDAD;

        public string NOMBRECIUDAD
        {
            get { return nOMBRECIUDAD; }
            set { nOMBRECIUDAD = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Ciudad()
        {

        }
        public Ciudad(int iD_CIUDAD, string nOMBRECIUDAD, string eSTADO)
        {
            this.iD_CIUDAD = iD_CIUDAD;
            this.nOMBRECIUDAD = nOMBRECIUDAD;
            this.eSTADO = eSTADO;
        }
    }
}
