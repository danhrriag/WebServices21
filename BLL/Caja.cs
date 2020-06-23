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
    public  class Caja
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_CAJA;

        public int ID_CAJA
        {
            get { return iD_CAJA; }
            set { iD_CAJA = value; }
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

        public Caja()
        {

        }

        public Caja(int iD_CAJA, string eSTADO, string dESCRIPCION)
        {
            this.iD_CAJA = iD_CAJA;
            this.eSTADO = eSTADO;
            this.dESCRIPCION = dESCRIPCION;
        }



        public List<CAJA> listarCaja()
        {
            List<CAJA> caja = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_CAJA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("cajas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                caja = (from DataRow row in dt.Rows
                        select new CAJA
                        {
                            ID_CAJA = short.Parse(row["ID_CAJA"].ToString()),
                            ESTADO = row["ESTADO"].ToString(),
                            DESCRIPCION = row["DESCRIPCION"].ToString(),
                        }).ToList();
            }
            ora.Close();
            return caja;
        }
    }
}
