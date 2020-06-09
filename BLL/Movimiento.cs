using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Movimiento
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_MOVIMIENTO;

        public int ID_MOVIMIENTO
        {
            get { return iD_MOVIMIENTO; }
            set { iD_MOVIMIENTO = value; }
        }

        private DateTime fECHA;

        public DateTime FECHA
        {
            get { return fECHA; }
            set { fECHA = value; }
        }

        private int cANTIDAD;

        public int CANTIDAD
        {
            get { return cANTIDAD; }
            set { cANTIDAD = value; }
        }

        private string tIPO;

        public string TIPO
        {
            get { return tIPO; }
            set { tIPO = value; }
        }

        private string rUT_PERSONA;

        public string RUT_PERSONA
        {
            get { return rUT_PERSONA; }
            set { rUT_PERSONA = value; }
        }

        private int iD_INSUMO;

        public int ID_INSUMO
        {
            get { return iD_INSUMO; }
            set { iD_INSUMO = value; }
        }

        public Movimiento()
        {

        }

        public Movimiento(int iD_MOVIMIENTO, DateTime fECHA, int cANTIDAD, string tIPO, string rUT_PERSONA, int iD_INSUMO)
        {
            this.iD_MOVIMIENTO = iD_MOVIMIENTO;
            this.fECHA = fECHA;
            this.cANTIDAD = cANTIDAD;
            this.tIPO = tIPO;
            this.rUT_PERSONA = rUT_PERSONA;
            this.iD_INSUMO = iD_INSUMO;
        }


    }
}
