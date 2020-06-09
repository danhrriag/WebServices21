using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PedidoIndividual
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_PEDIDOINDIV;

        public int ID_PEDIDOINDIV
        {
            get { return iD_PEDIDOINDIV; }
            set { iD_PEDIDOINDIV = value; }
        }

        private DateTime fECHAYHORA;

        public DateTime FECHAYHORA
        {
            get { return fECHAYHORA; }
            set { fECHAYHORA = value; }
        }

        private int tOTALINDIV;

        public int TOTALINDIV
        {
            get { return tOTALINDIV; }
            set { tOTALINDIV = value; }
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

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        public PedidoIndividual()
        {

        }

        public PedidoIndividual(int iD_PEDIDOINDIV, DateTime fECHAYHORA, int tOTALINDIV, string eSTADO, int iD_PEDIDO, string dESCRIPCION)
        {
            this.iD_PEDIDOINDIV = iD_PEDIDOINDIV;
            this.fECHAYHORA = fECHAYHORA;
            this.tOTALINDIV = tOTALINDIV;
            this.eSTADO = eSTADO;
            this.iD_PEDIDO = iD_PEDIDO;
            this.dESCRIPCION = dESCRIPCION;
        }


    }
}
