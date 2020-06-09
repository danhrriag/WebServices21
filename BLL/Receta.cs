using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Receta
    {

        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private int iD_RECETA;

        public int ID_RECETA
        {
            get { return iD_RECETA; }
            set { iD_RECETA = value; }
        }

        private string pREPARACION;

        public string PREPARACION
        {
            get { return pREPARACION; }
            set { pREPARACION = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private int iD_PRODUCTO;

        public int ID_PRODUCTO
        {
            get { return iD_PRODUCTO; }
            set { iD_PRODUCTO = value; }
        }

        public Receta()
        {

        }

        public Receta(int iD_RECETA, string pREPARACION, string eSTADO, int iD_PRODUCTO)
        {
            this.iD_RECETA = iD_RECETA;
            this.pREPARACION = pREPARACION;
            this.eSTADO = eSTADO;
            this.iD_PRODUCTO = iD_PRODUCTO;
        }


    }
}
