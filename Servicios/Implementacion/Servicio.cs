using CRUDtransporte.Datos.Implementacion;
using CRUDtransporte.Datos.Interfaz;
using CRUDtransporte.Dominio;
using CRUDtransporte.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDtransporte.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IDaoCamion dao;

        public Servicio()
        {
            dao = new DaoCamion();
        }
        public int ObtenerProximo()
        {
          return dao.ObtenerProximo();
        }

        public List<TipoCarga> ObtenerTipoCargas()
        {
            return dao.ObtenerTipoCargas(); 
        }
    }
}
