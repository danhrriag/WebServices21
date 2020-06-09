using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pago
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_PAGO;

        public int ID_PAGO
        {
            get { return iD_PAGO; }
            set { iD_PAGO = value; }
        }

        private int nONTO;

        public int MONTO
        {
            get { return nONTO; }
            set { nONTO = value; }
        }

        private string mEDIODEPAGO;

        public string MEDIODEPAGO
        {
            get { return mEDIODEPAGO; }
            set { mEDIODEPAGO = value; }
        }

        private string tIPOPAGO;

        public string TIPOPAGO
        {
            get { return tIPOPAGO; }
            set { tIPOPAGO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private int iD_PEDIDO;

        public int ID_PEDIDO
        {
            get { return iD_PEDIDO; }
            set { iD_PEDIDO = value; }
        }

        private string iD_BOLETA;

        public string ID_BOLETA
        {
            get { return iD_BOLETA; }
            set { iD_BOLETA = value; }
        }

        public Pago()
        {

        }

        public Pago(int iD_PAGO, int nONTO, string mEDIODEPAGO, string tIPOPAGO, string eSTADO, int iD_PEDIDO, string iD_BOLETA)
        {
            this.iD_PAGO = iD_PAGO;
            this.nONTO = nONTO;
            this.mEDIODEPAGO = mEDIODEPAGO;
            this.tIPOPAGO = tIPOPAGO;
            this.eSTADO = eSTADO;
            this.iD_PEDIDO = iD_PEDIDO;
            this.iD_BOLETA = iD_BOLETA;
        }
    }
}
