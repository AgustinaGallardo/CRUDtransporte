using System;
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
        SqlConnection conn = new SqlConnection(Properties.Resources.cnnCRUDtransporte);
        private static Helper intancia;

        public static Helper ObtenerInstancia()
        {
            if (intancia != null)
                intancia= new Helper();
            return intancia;
        }
    }
}
