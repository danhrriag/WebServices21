using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleReceta
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int cANTIDADINSUMO;

        public int CANTIDADINSUMO
        {
            get { return cANTIDADINSUMO; }
            set { cANTIDADINSUMO = value; }
        }

        private int iD_INSUMO;

        public int ID_INSUMO
        {
            get { return iD_INSUMO; }
            set { iD_INSUMO = value; }
        }

        private int iD_RECETA;

        public int ID_RECETA
        {
            get { return iD_RECETA; }
            set { iD_RECETA = value; }
        }

        public DetalleReceta()
        {

        }

        public DetalleReceta(int cANTIDADINSUMO, int iD_INSUMO, int iD_RECETA)
        {
            this.cANTIDADINSUMO = cANTIDADINSUMO;
            this.iD_INSUMO = iD_INSUMO;
            this.iD_RECETA = iD_RECETA;
        }
    }
}
