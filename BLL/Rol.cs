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
    public class Rol
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int iD_ROL;

        public int ID_ROL
        {
            get { return iD_ROL; }
            set { iD_ROL = value; }
        }

        private string tIPO;

        public string TIPO
        {
            get { return tIPO; }
            set { tIPO = value; }
        }

        private string eSTADO;

        public string ESTADO
        {
            get { return eSTADO; }
            set { eSTADO = value; }
        }

        public Rol()
        {

        }

        public Rol(int iD_ROL, string tIPO, string eSTADO)
        {
            this.iD_ROL = iD_ROL;
            this.tIPO = tIPO;
            this.eSTADO = eSTADO;
        }
        public List<Rol> listarRol()
        {
            List<Rol> Rol = null;
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_LISTAR_ROL", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("rol", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                Rol = (from DataRow row in dt.Rows
                       select new Rol
                       {
                           ID_ROL = short.Parse(row["ID_ROL"].ToString()),
                           TIPO = row["TIPO"].ToString(),
                           ESTADO = row["ESTADO"].ToString()                                                      
                       }).ToList();
            }
            ora.Close();
            return Rol;
        }

    }
}
