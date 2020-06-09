using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class MovimientoCaja
    {

        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_MOVIMIENTOCAJA;

        public int ID_MOVIMIENTOCAJA
        {
            get { return iD_MOVIMIENTOCAJA; }
            set { iD_MOVIMIENTOCAJA = value; }
        }

        private DateTime fECHA;

        public DateTime FECHA
        {
            get { return fECHA; }
            set { fECHA = value; }
        }

        private int mONTO;

        public int MONTO
        {
            get { return mONTO; }
            set { mONTO = value; }
        }

        private string tIPO;

        public string TIPO
        {
            get { return tIPO; }
            set { tIPO = value; }
        }


        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string rUT_PERSONA;

        public string RUT_PERSONA
        {
            get { return rUT_PERSONA; }
            set { rUT_PERSONA = value; }
        }

        private int iD_CAJA;

        public int ID_CAJA
        {
            get { return iD_CAJA; }
            set { iD_CAJA = value; }
        }

        private int iD_PAGO;

        public int ID_PAGO
        {
            get { return iD_PAGO; }
            set { iD_PAGO = value; }
        }

        private int nRO_ORDEN;

        public int NRO_ORDEN
        {
            get { return nRO_ORDEN; }
            set { nRO_ORDEN = value; }
        }

        public MovimientoCaja()
        {

        }
        public MovimientoCaja(int iD_MOVIMIENTOCAJA, DateTime fECHA, int mONTO, string tIPO, string dESCRIPCION, string eSTADO, string rUT_PERSONA, int iD_CAJA, int iD_PAGO, int nRO_ORDEN)
        {
            this.iD_MOVIMIENTOCAJA = iD_MOVIMIENTOCAJA;
            this.fECHA = fECHA;
            this.mONTO = mONTO;
            this.tIPO = tIPO;
            this.dESCRIPCION = dESCRIPCION;
            this.eSTADO = eSTADO;
            this.rUT_PERSONA = rUT_PERSONA;
            this.iD_CAJA = iD_CAJA;
            this.iD_PAGO = iD_PAGO;
            this.nRO_ORDEN = nRO_ORDEN;
        }
    }
}
