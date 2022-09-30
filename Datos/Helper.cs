using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CRUDtransporte.Dominio;

namespace CRUDtransporte.Datos
{
    internal class Helper
    {
        SqlConnection cnn = new SqlConnection(Properties.Resources.cnnCRUDtransporte);
        private static Helper intancia;

        public static Helper ObtenerInstancia()
        {
            if (intancia == null)
                intancia = new Helper();
            return intancia;
        }

        public int ObtenerProximo(string sp_nombre,string OutPut)
        {
            cnn.Open();
            SqlCommand cmdNext = new SqlCommand();
            cmdNext.Connection = cnn;
            cmdNext.CommandText = sp_nombre;
            cmdNext.CommandType = CommandType.StoredProcedure;

            SqlParameter pOutPut = new SqlParameter();
            pOutPut.ParameterName = OutPut;
            pOutPut.Direction = ParameterDirection.Output;
            pOutPut.DbType = DbType.Int32;

            cmdNext.Parameters.Add(pOutPut);

            cmdNext.ExecuteNonQuery();
            cnn.Close();

            return (int)pOutPut.Value;
        }

        public DataTable ObtenerCombo(string sp_nombre)
        {
            DataTable tb = new DataTable();
            cnn.Open();
            SqlCommand cmdCombo = new SqlCommand();
            cmdCombo.Connection = cnn;
            cmdCombo.CommandText = sp_nombre;
            cmdCombo.CommandType = CommandType.StoredProcedure;

            tb.Load(cmdCombo.ExecuteReader());
            cnn.Close();
            return tb;
        }

        public bool ConformarCamion(Camion oCamion)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                SqlCommand cmdMaster = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                
               
                cmdMaster.Connection=cnn;
                cmdMaster.Transaction=t;
                cmdMaster.CommandType = CommandType.StoredProcedure;
                cmdMaster.CommandText="Insert_Maestro";

                cmdMaster.Parameters.AddWithValue("@patente", oCamion.Patente);
                cmdMaster.Parameters.AddWithValue("@estado", oCamion.Estado);
                cmdMaster.Parameters.AddWithValue("@pesoMax", oCamion.PesoMax);

                SqlParameter pOutPut = new SqlParameter();
                pOutPut.ParameterName = "@idCamion";
                pOutPut.Direction = ParameterDirection.Output;
                pOutPut.DbType = DbType.Int32;

                cmdMaster.Parameters.Add(pOutPut);

                cmdMaster.ExecuteNonQuery();

                int idCamion = (int)pOutPut.Value;

                foreach(Carga item in oCamion.Cargas)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.Transaction = t;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "Insert_detalle";

                    cmdDetalle.Parameters.AddWithValue("@peso", item.Peso);
                    cmdDetalle.Parameters.AddWithValue("@idTipo", item.Tipo.IdTipo);
                    cmdDetalle.Parameters.AddWithValue("@idCamion", idCamion);

                    cmdDetalle.ExecuteNonQuery();
                    
                }
                t.Commit();
            }
            catch (Exception )
            {
                if( t != null)
                {
                    t.Rollback();
                   return ok = false;
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }
    }
}
