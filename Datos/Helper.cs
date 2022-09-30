﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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




    }
}
