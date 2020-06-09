using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private string rUT_PROVEEDOR;

        public string RUT_PROVEEDOR
        {
            get { return rUT_PROVEEDOR; }
            set { rUT_PROVEEDOR = value; }
        }

        private string raZONSOCIAL;

        public string RAZONSOCIAL
        {
            get { return raZONSOCIAL; }
            set { raZONSOCIAL = value; }
        }

        private string gIRO;

        public string GIRO
        {
            get { return gIRO; }
            set { gIRO = value; }
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

        public Proveedor()
        {

        }

        public Proveedor(string rUT_PROVEEDOR, string raZONSOCIAL, string gIRO, string tELEFONO, string eSTADO, int iD_DIRECCION)
        {
            this.rUT_PROVEEDOR = rUT_PROVEEDOR;
            this.raZONSOCIAL = raZONSOCIAL;
            this.gIRO = gIRO;
            this.tELEFONO = tELEFONO;
            this.eSTADO = eSTADO;
            this.iD_DIRECCION = iD_DIRECCION;
        }


    }
}
