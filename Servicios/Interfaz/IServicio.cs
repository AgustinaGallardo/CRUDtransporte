using CRUDtransporte.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDtransporte.Servicios.Interfaz
{
    internal interface IServicio
    {
        int ObtenerProximo();

        List<TipoCarga> ObtenerTipoCargas();
    }
}
