using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDtransporte.Dominio
{
    internal class Camion
    {
        public int IdCamion { get; set; }
        public string Patente { get; set; }
        public string Estado { get; set; }
        public double PesoMax { get; set; }
        public List<Carga> Cargas { get; set; }

        public Camion()
        {
            IdCamion = 0;
            Patente = string.Empty;
            Estado = string.Empty;
            PesoMax = 0;
            Cargas = new List<Carga>();
        }

        public Camion(int idCamion, string patente, string estado, double pesoMax, List<Carga> cargas)
        {
            IdCamion = idCamion;
            Patente = patente;
            Estado = estado;
            PesoMax = pesoMax;
            Cargas = cargas;
        }
    }
}
