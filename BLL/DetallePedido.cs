using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetallePedido
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int cANTIDADPRODUCTO;

        public int CANTIDADPRODUCTO
        {
            get { return cANTIDADPRODUCTO; }
            set { cANTIDADPRODUCTO = value; }
        }

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        private int tOTAL_DETALLE;

        public int TOTAL_DETALLE
        {
            get { return tOTAL_DETALLE; }
            set { tOTAL_DETALLE = value; }
        }

        private string eSTADOPREPARACION;

        public string ESTADOPREPARACION
        {
            get { return eSTADOPREPARACION; }
            set { eSTADOPREPARACION = value; }
        }

        private int iD_PEDIDOINDIV;

        public int ID_PEDIDOINDIV
        {
            get { return iD_PEDIDOINDIV; }
            set { iD_PEDIDOINDIV = value; }
        }

        private int iD_PRODUCTO;

        public int ID_PRODUCTO
        {
            get { return iD_PRODUCTO; }
            set { iD_PRODUCTO = value; }
        }

        public DetallePedido()
        {

        }

        public DetallePedido(int cANTIDADPRODUCTO, string dESCRIPCION, int tOTAL_DETALLE, string eSTADOPREPARACION, int iD_PEDIDOINDIV, int iD_PRODUCTO)
        {
            this.cANTIDADPRODUCTO = cANTIDADPRODUCTO;
            this.dESCRIPCION = dESCRIPCION;
            this.tOTAL_DETALLE = tOTAL_DETALLE;
            this.eSTADOPREPARACION = eSTADOPREPARACION;
            this.iD_PEDIDOINDIV = iD_PEDIDOINDIV;
            this.iD_PRODUCTO = iD_PRODUCTO;
        }


    }
}
