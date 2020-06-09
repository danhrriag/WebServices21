using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class Dirección
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private int iD_DIRECCION;

        public int ID_DIRECCION
        {
            get { return iD_DIRECCION; }
            set { iD_DIRECCION = value; }
        }

        private string nOMBRECALLE;

        public string NOMBRECALLE
        {
            get { return nOMBRECALLE; }
            set { nOMBRECALLE = value; }
        }

        private int nUMEROCALLE;

        public int NUMEROCALLE
        {
            get { return nUMEROCALLE; }
            set { nUMEROCALLE = value; }
        }


        private int iD_CIUDAD;

        public int ID_CIUDAD
        {
            get { return iD_CIUDAD; }
            set { iD_CIUDAD = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Dirección()
        {

        }

        public Dirección(int iD_DIRECCION, string nOMBRECALLE, int nUMEROCALLE, int iD_CIUDAD, string eSTADO)
        {
            this.iD_DIRECCION = iD_DIRECCION;
            this.nOMBRECALLE = nOMBRECALLE;
            this.nUMEROCALLE = nUMEROCALLE;
            this.iD_CIUDAD = iD_CIUDAD;
            this.eSTADO = eSTADO;
        }
    }
}
