using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Insumo
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_INSUMO;

        public int ID_INSUMO
        {
            get { return iD_INSUMO; }
            set { iD_INSUMO = value; }
        }

        private int nOMBREINSUMO;

        public int NOMBREINSUMO
        {
            get { return nOMBREINSUMO; }
            set { nOMBREINSUMO = value; }
        }

        private int sTOCKACTUAL;

        public int STOCKACTUAL
        {
            get { return sTOCKACTUAL; }
            set { sTOCKACTUAL = value; }
        }

        private int sTOCKCRITICO;

        public int STOCKCRITICO
        {
            get { return sTOCKCRITICO; }
            set { sTOCKCRITICO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string dESCRIPCIONINSUMO;

        public string DESCRIPCIONINSUMO
        {
            get { return dESCRIPCIONINSUMO; }
            set { dESCRIPCIONINSUMO = value; }
        }

        public Insumo()
        {

        }

        public Insumo(int iD_INSUMO, int nOMBREINSUMO, int sTOCKACTUAL, int sTOCKCRITICO, string eSTADO, string dESCRIPCIONINSUMO)
        {
            this.iD_INSUMO = iD_INSUMO;
            this.nOMBREINSUMO = nOMBREINSUMO;
            this.sTOCKACTUAL = sTOCKACTUAL;
            this.sTOCKCRITICO = sTOCKCRITICO;
            this.eSTADO = eSTADO;
            this.dESCRIPCIONINSUMO = dESCRIPCIONINSUMO;
        }
    }
}
