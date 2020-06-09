using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class OrdenDeCompra
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int nRO_ORDEN;

        public int NRO_ORDEN
        {
            get { return nRO_ORDEN; }
            set { nRO_ORDEN = value; }
        }

        private DateTime fECHA;

        public DateTime FECHA
        {
            get { return fECHA; }
            set { fECHA = value; }
        }

        private int fIRMADIGITAL;

        public int FIRMADIGITAL
        {
            get { return fIRMADIGITAL; }
            set { fIRMADIGITAL = value; }
        }

        private string rUT_PROVEEDOR;

        public string RUT_PROVEEDOR
        {
            get { return rUT_PROVEEDOR; }
            set { rUT_PROVEEDOR = value; }
        }

        private int iD_SUSCURSAL;

        public int ID_SUSCURSAL
        {
            get { return iD_SUSCURSAL; }
            set { iD_SUSCURSAL = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public OrdenDeCompra()
        {

        }

        public OrdenDeCompra(int nRO_ORDEN, DateTime fECHA, int fIRMADIGITAL, string rUT_PROVEEDOR, int iD_SUSCURSAL, string eSTADO)
        {
            this.nRO_ORDEN = nRO_ORDEN;
            this.fECHA = fECHA;
            this.fIRMADIGITAL = fIRMADIGITAL;
            this.rUT_PROVEEDOR = rUT_PROVEEDOR;
            this.iD_SUSCURSAL = iD_SUSCURSAL;
            this.eSTADO = eSTADO;
        }


    }
}
