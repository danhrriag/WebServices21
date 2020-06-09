using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleOrdenCompra
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        private DateTime fECHA_ENTREGA;

        public DateTime FECHA_ENTREGA
        {
            get { return fECHA_ENTREGA; }
            set { fECHA_ENTREGA = value; }
        }

        private int cANTIDAD;

        public int CANTIDAD
        {
            get { return cANTIDAD; }
            set { cANTIDAD = value; }
        }

        private int pRECIOUNITARIO;

        public int PRECIOUNITARIO
        {
            get { return pRECIOUNITARIO; }
            set { pRECIOUNITARIO = value; }
        }

        private int dESCUENTO;

        public int DESCUENTO
        {
            get { return dESCUENTO; }
            set { dESCUENTO = value; }
        }

        private int pRECIONETOTOTAL;

        public int PRECIONETOTOTAL
        {
            get { return pRECIONETOTOTAL; }
            set { pRECIONETOTOTAL = value; }
        }

        private int iD_INSUMO;

        public int ID_INSUMO
        {
            get { return iD_INSUMO; }
            set { iD_INSUMO = value; }
        }

        private int nRO_ORDEN;

        public int NRO_ORDEN
        {
            get { return nRO_ORDEN; }
            set { nRO_ORDEN = value; }
        }

        public DetalleOrdenCompra()
        {

        }

        public DetalleOrdenCompra(string dESCRIPCION, DateTime fECHA_ENTREGA, int cANTIDAD, int pRECIOUNITARIO, int dESCUENTO, int pRECIONETOTOTAL, int iD_INSUMO, int nRO_ORDEN)
        {
            this.dESCRIPCION = dESCRIPCION;
            this.fECHA_ENTREGA = fECHA_ENTREGA;
            this.cANTIDAD = cANTIDAD;
            this.pRECIOUNITARIO = pRECIOUNITARIO;
            this.dESCUENTO = dESCUENTO;
            this.pRECIONETOTOTAL = pRECIONETOTOTAL;
            this.iD_INSUMO = iD_INSUMO;
            this.nRO_ORDEN = nRO_ORDEN;
        }

    }
}
