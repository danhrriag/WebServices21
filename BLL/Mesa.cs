using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mesa
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int nROMESA;

        public int NROMESA
        {
            get { return nROMESA; }
            set { nROMESA = value; }
        }

        private string dESCRIPCION;

        public string DESCRIPCION
        {
            get { return dESCRIPCION; }
            set { dESCRIPCION = value; }
        }

        private int cANTIDADASIENTOS;

        public int CANTIDADASIENTOS
        {
            get { return cANTIDADASIENTOS; }
            set { cANTIDADASIENTOS = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Mesa()
        {

        }

        public Mesa(int nROMESA, string dESCRIPCION, int cANTIDADASIENTOS, string eSTADO)
        {
            this.nROMESA = nROMESA;
            this.dESCRIPCION = dESCRIPCION;
            this.cANTIDADASIENTOS = cANTIDADASIENTOS;
            this.eSTADO = eSTADO;
        }

        public bool AddMesa()
        {
            CommonBC.ModeloEntities.PRO_CREAR_MESA(nROMESA,dESCRIPCION,cANTIDADASIENTOS, eSTADO);
            return true;
        }

        public bool modMesa()
        {
            CommonBC.ModeloEntities.PRO_MODIFICAR_MESA(nROMESA, dESCRIPCION, cANTIDADASIENTOS, eSTADO);
            return true;
        }


        public List<Mesa> listarMesa()
        {
            List<Mesa> caja = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_MESA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("mesas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                caja = (from DataRow row in dt.Rows
                        select new Mesa
                        {
                            NROMESA = int.Parse(row["NROMESA"].ToString()),
                            DESCRIPCION = row["DESCRIPCION"].ToString(),
                            CANTIDADASIENTOS = int.Parse(row["CANTIDADASIENTOS"].ToString()),
                            ESTADO = row["ESTADO"].ToString(),
                        }).ToList();
            }
            ora.Close();
            return caja;
        }
        public List<Mesa> listarMesaID(int nro)
        {
            List<Mesa> caja = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_MESA_ID", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("mesas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("nro", OracleDbType.Decimal).Value = nro;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                caja = (from DataRow row in dt.Rows
                        select new Mesa
                        {
                            NROMESA = int.Parse(row["NROMESA"].ToString()),
                            DESCRIPCION = row["DESCRIPCION"].ToString(),
                            CANTIDADASIENTOS = int.Parse(row["CANTIDADASIENTOS"].ToString()),
                            ESTADO = row["ESTADO"].ToString(),
                        }).ToList();
            }
            ora.Close();
            return caja;
        }



    }
}
