using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reserva
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_RESERVA;

        public int ID_RESERVA
        {
            get { return iD_RESERVA; }
            set { iD_RESERVA = value; }
        }

        private DateTime fECHA_REALIZACION;

        public DateTime FECHA_REALIZACION
        {
            get { return fECHA_REALIZACION; }
            set { fECHA_REALIZACION = value; }
        }

        private DateTime fECHA_RESERVA;

        public DateTime FECHA_RESERVA
        {
            get { return fECHA_RESERVA; }
            set { fECHA_RESERVA = value; }
        }

        private int cANTIDADPERSONAS;

        public int CANTIDADPERSONAS
        {
            get { return cANTIDADPERSONAS; }
            set { cANTIDADPERSONAS = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        private string rUT_PERSONA;

        public string RUT_PERSONA
        {
            get { return rUT_PERSONA; }
            set { rUT_PERSONA = value; }
        }

        public Reserva()
        {
        }

        public Reserva(int iD_RESERVA, DateTime fECHA_REALIZACION, DateTime fECHA_RESERVA, int cANTIDADPERSONAS, string eSTADO, string rUT_PERSONA)
        {
            this.iD_RESERVA = iD_RESERVA;
            this.fECHA_REALIZACION = fECHA_REALIZACION;
            this.fECHA_RESERVA = fECHA_RESERVA;
            this.cANTIDADPERSONAS = cANTIDADPERSONAS;
            this.eSTADO = eSTADO;
            this.rUT_PERSONA = rUT_PERSONA;
        }
    }
}
