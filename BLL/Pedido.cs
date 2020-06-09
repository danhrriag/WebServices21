using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pedido
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private int iD_PEDIDO;

        public int ID_PEDIDO
        {
            get { return iD_PEDIDO; }
            set { iD_PEDIDO = value; }
        }

        private DateTime fECHAYHORA;

        public DateTime FECHAYHORA
        {
            get { return fECHAYHORA; }
            set { fECHAYHORA = value; }
        }

        private int tOTAL;

        public int TOTAL
        {
            get { return tOTAL; }
            set { tOTAL = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private DateTime fECHAHORA_ENTREGA;

        public DateTime FECHAHORA_ENTREGA
        {
            get { return fECHAHORA_ENTREGA; }
            set { fECHAHORA_ENTREGA = value; }
        }

        private int cANTIDADPEDIDOSINDIVIDUALES;

        public int CANTIDADPEDIDOSINDIVIDUALES
        {
            get { return cANTIDADPEDIDOSINDIVIDUALES; }
            set { cANTIDADPEDIDOSINDIVIDUALES = value; }
        }

        private string rUT_PERSONA;

        public string RUT_PERSONA
        {
            get { return rUT_PERSONA; }
            set { rUT_PERSONA = value; }
        }

        private int nROMESA;

        public int NROMESA
        {
            get { return nROMESA; }
            set { nROMESA = value; }
        }

        private string rUT_GARZON;

        public string RUT_GARZON
        {
            get { return rUT_GARZON; }
            set { rUT_GARZON = value; }
        }

        public Pedido()
        {

        }

        public Pedido(int iD_PEDIDO, DateTime fECHAYHORA, int tOTAL, string eSTADO, DateTime fECHAHORA_ENTREGA, int cANTIDADPEDIDOSINDIVIDUALES, string rUT_PERSONA, int nROMESA, string rUT_GARZON)
        {
            this.iD_PEDIDO = iD_PEDIDO;
            this.fECHAYHORA = fECHAYHORA;
            this.tOTAL = tOTAL;
            this.eSTADO = eSTADO;
            this.fECHAHORA_ENTREGA = fECHAHORA_ENTREGA;
            this.cANTIDADPEDIDOSINDIVIDUALES = cANTIDADPEDIDOSINDIVIDUALES;
            this.rUT_PERSONA = rUT_PERSONA;
            this.nROMESA = nROMESA;
            this.rUT_GARZON = rUT_GARZON;
        }


    }
}
