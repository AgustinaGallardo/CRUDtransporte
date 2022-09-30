
using CRUDtransporte.Servicios.Implementacion;
using CRUDtransporte.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDtransporte
{
    public partial class AltaTransporte : Form
    {
        private IServicio gestor;
        public AltaTransporte()
        {
            InitializeComponent();
            gestor = new Servicio();
            ObtenerProximo();
            ObtenerTipos();
        }

        private void ObtenerTipos()
        {
            cboTipoCarga.ValueMember ="IdTipo";
            cboTipoCarga.DisplayMember ="nombreTipo";
            cboTipoCarga.DataSource =gestor.ObtenerTipoCargas();
            cboTipoCarga.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ObtenerProximo()
        {
            int Next = gestor.ObtenerProximo();
            if(Next>0)
            {
                lblNext.Text = "Camion Nro: " + Next.ToString();
            }
        }

        private void dgvCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCamiones.CurrentCell.ColumnIndex == 3)
            {

            }
        }

        private void AltaTransporte_Load(object sender, EventArgs e)
        {

        }
    }
}
