using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sucursal
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");
        private int iD_SUSCURSAL;

        public int ID_SUSCURSAL
        {
            get { return iD_SUSCURSAL; }
            set { iD_SUSCURSAL = value; }
        }

        private string rAZONSOCIAL;

        public string RAZONSOCIAL
        {
            get { return rAZONSOCIAL; }
            set { rAZONSOCIAL = value; }
        }

        private string tELEFONO;

        public string TELEFONO
        {
            get { return tELEFONO; }
            set { tELEFONO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private int iD_DIRECCION;

        public int ID_DIRECCION
        {
            get { return iD_DIRECCION; }
            set { iD_DIRECCION = value; }
        }

        public Sucursal()
        {

        }

        public Sucursal(int iD_SUSCURSAL, string rAZONSOCIAL, string tELEFONO, string eSTADO, int iD_DIRECCION)
        {
            this.iD_SUSCURSAL = iD_SUSCURSAL;
            this.rAZONSOCIAL = rAZONSOCIAL;
            this.tELEFONO = tELEFONO;
            this.eSTADO = eSTADO;
            this.iD_DIRECCION = iD_DIRECCION;
        }
    }
}
