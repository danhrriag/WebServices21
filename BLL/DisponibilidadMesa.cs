using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DisponibilidadMesa
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");


        private DateTime fECHAHORA;

        public DateTime FECHAHORA
        {
            get { return fECHAHORA; }
            set { fECHAHORA = value; }
        }

        private int iD_RESERVA;

        public int ID_RESERVA
        {
            get { return iD_RESERVA; }
            set { iD_RESERVA = value; }
        }

        private int nROMESA;

        public int NROMESA
        {
            get { return nROMESA; }
            set { nROMESA = value; }
        }

        public DisponibilidadMesa()
        {

        }

        public DisponibilidadMesa(DateTime fECHAHORA, int iD_RESERVA, int nROMESA)
        {
            this.fECHAHORA = fECHAHORA;
            this.iD_RESERVA = iD_RESERVA;
            this.nROMESA = nROMESA;
        }


    }
}
