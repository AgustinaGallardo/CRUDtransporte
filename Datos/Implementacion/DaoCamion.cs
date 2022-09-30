using CRUDtransporte.Datos.Interfaz;
using CRUDtransporte.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDtransporte.Datos.Implementacion
{
    internal class DaoCamion : IDaoCamion
    {
        public int ObtenerProximo()
        {
            string sp_nombre = "sp_proximo";
            string OutPut = "@next";
            return Helper.ObtenerInstancia().ObtenerProximo(sp_nombre, OutPut);

        }

        public List<TipoCarga> ObtenerTipoCargas()
        {
            List<TipoCarga> lst = new List<TipoCarga>();
            string sp_nombre = "sp_cargar_tipos";
            DataTable tb = Helper.ObtenerInstancia().ObtenerCombo(sp_nombre);
            foreach(DataRow dr in tb.Rows)
            {
                int id = Convert.ToInt32(dr["idTipo"].ToString());
                string nombre = dr["nombreTipo"].ToString();
                TipoCarga aux = new TipoCarga(id,nombre);
                lst.Add(aux);
            }
            return lst;
        }
    }
}
