using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class Categoria
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_CATEGORIA;

        public int ID_CATEGORIA
        {
            get { return iD_CATEGORIA; }
            set { iD_CATEGORIA = value; }
        }

        private string nOMBRECATEGORIA;

        public string NOMBRECATEGORIA
        {
            get { return nOMBRECATEGORIA; }
            set { nOMBRECATEGORIA = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Categoria()
        {

        }

        public Categoria(int iD_CATEGORIA, string nOMBRECATEGORIA, string eSTADO)
        {
            this.iD_CATEGORIA = iD_CATEGORIA;
            this.nOMBRECATEGORIA = nOMBRECATEGORIA;
            this.eSTADO = eSTADO;
        }


    }
}
