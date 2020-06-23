
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TopPlatos
    {
        OracleConnection ora = new OracleConnection("USER ID= SIGLO21 ;PASSWORD= duoc ;DATA SOURCE= localhost ;");

        private int ID_PRODUCTO;
        public int id_producto
        {
            get { return ID_PRODUCTO; }
            set { ID_PRODUCTO = value; }
        }
        private string NOMBREPRODUCTO;
        public string nombreproducto
        {
            get { return NOMBREPRODUCTO; }
            set { NOMBREPRODUCTO = value; }
        }

        private int CANTIDAD;
        public int Cantidad
        {
            get { return CANTIDAD; }
            set { CANTIDAD = value; }
        }
        public TopPlatos(){}

        public TopPlatos(int ID_PRODUCTO, string NOMBREPRODUCTO, int CANTIDAD)
        {
            this.ID_PRODUCTO = ID_PRODUCTO;
            this.NOMBREPRODUCTO = NOMBREPRODUCTO;
            this.CANTIDAD = CANTIDAD;
        }

        #region REPORTE TOP_PLATO
        public string top_platos(string finicio, string ffin)
        {
            List<TopPlatos> tp = null;
            try
            {
                ora.Open();
                OracleCommand command = new OracleCommand("TOP_PLATOS", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("finicio", OracleDbType.Varchar2).Value = finicio;
                command.Parameters.Add("ffin", OracleDbType.Varchar2).Value = ffin;
                command.Parameters.Add("out_cur", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    tp = (from DataRow row in dt.Rows
                          select new TopPlatos
                          {
                              id_producto = int.Parse(row["ID_PRODUCTO"].ToString()),
                              nombreproducto = row["NOMBREPRODUCTO"].ToString(),
                              Cantidad = int.Parse(row["CANTIDAD"].ToString()),
                          }).ToList();
                }
                ora.Close();
                string lista = JsonConvert.SerializeObject(tp);
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion
    }
}
 