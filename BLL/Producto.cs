using DAL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_PRODUCTO;

        public int ID_PRODUCTO
        {
            get { return iD_PRODUCTO; }
            set { iD_PRODUCTO = value; }
        }

        private string nOMBREPRODUCTO;

        public string NOMBREPRODUCTO
        {
            get { return nOMBREPRODUCTO; }
            set { nOMBREPRODUCTO = value; }
        }

        private int pRECIO;

        public int PRECIO
        {
            get { return pRECIO; }
            set { pRECIO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }


        private int iD_CATEGORIA;

        public int ID_CATEGORIA
        {
            get { return iD_CATEGORIA; }
            set { iD_CATEGORIA = value; }
        }

        public Producto()
        {
        }

        public Producto(int iD_PRODUCTO, string nOMBREPRODUCTO, int pRECIO, string eSTADO, string dESCRIPCION, int iD_CATEGORIA)
        {
            this.iD_PRODUCTO = iD_PRODUCTO;
            this.nOMBREPRODUCTO = nOMBREPRODUCTO;
            this.pRECIO = pRECIO;
            this.eSTADO = eSTADO;
            this.dESCRIPCION = dESCRIPCION;
            this.iD_CATEGORIA = iD_CATEGORIA;
        }

        


    }
}
