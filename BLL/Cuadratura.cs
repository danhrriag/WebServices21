using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cuadratura
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_CUADRATURA;

        public int ID_CUADRATURA
        {
            get { return iD_CUADRATURA; }
            set { iD_CUADRATURA = value; }
        }

        private int mONTOESPERADO;

        public int MONTOESPERADO
        {
            get { return mONTOESPERADO; }
            set { mONTOESPERADO = value; }
        }

        private int mONTOREAL;

        public int MONTOREAL
        {
            get { return mONTOREAL; }
            set { mONTOREAL = value; }
        }

        private DateTime fECHA;

        public DateTime FECHA
        {
            get { return fECHA; }
            set { fECHA = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }


        private int iD_CAJA;

        public int ID_CAJA
        {
            get { return iD_CAJA; }
            set { iD_CAJA = value; }
        }

        public Cuadratura()
        {

        }

        public Cuadratura(int iD_CUADRATURA, int mONTOESPERADO, int mONTOREAL, DateTime fECHA, string eSTADO, int iD_CAJA)
        {
            this.iD_CUADRATURA = iD_CUADRATURA;
            this.mONTOESPERADO = mONTOESPERADO;
            this.mONTOREAL = mONTOREAL;
            this.fECHA = fECHA;
            this.eSTADO = eSTADO;
            this.iD_CAJA = iD_CAJA;
        }




    }
}
