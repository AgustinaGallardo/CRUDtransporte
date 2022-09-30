
using CRUDtransporte.Datos;
using CRUDtransporte.Dominio;
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
        private Camion nuevo;
        public AltaTransporte()
        {
            InitializeComponent();
            gestor = new Servicio();
            ObtenerProximo();
            ObtenerTipos();
            nuevo = new Camion();
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
                nuevo.EliminarDetalle(dgvCamiones.CurrentRow.Index);
                dgvCamiones.Rows.Remove(dgvCamiones.CurrentRow);
                nuevo.CalcularPesoTotal();
                nuevo.CalcularCarga();
            }
        }

        private void AltaTransporte_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Tiene que agregar el tipo de carga", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            if(txtPeso.Text == "")
            {
                MessageBox.Show("Tiene que agregar el tipo de carga", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            foreach(DataGridViewRow item in dgvCamiones.Rows)
            {
                if(item.Cells["colTipoCarga"].Value.ToString().Equals(cboTipoCarga.Text))
                {
                    MessageBox.Show("La carga: " + cboTipoCarga.Text + " Ya esta seleecionada", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    return;
                }                
            }

            TipoCarga tp = (TipoCarga)cboTipoCarga.SelectedItem;
            double peso = Convert.ToDouble( txtPeso.Text);

            Carga carga = new Carga(peso,tp);

            nuevo.AgregarCarga(carga);

            dgvCamiones.Rows.Add(carga.Tipo.IdTipo, carga.Tipo.NombreTipo, carga.Peso);

            txtTotalCargas.Text = nuevo.CalcularCarga().ToString();
            txtPesoTotal.Text = nuevo.CalcularPesoTotal().ToString();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtPatente.Text == "")
            {
                MessageBox.Show("Tiene que agregar una patente", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

            GuardarCamion();
        }

        private void GuardarCamion()
        {
            nuevo.Patente = txtPatente.Text;
            nuevo.Estado = txtEstado.Text;
            nuevo.PesoMax = Convert.ToDouble(txtPesoMaximo.Text);

            if(Helper.ObtenerInstancia().ConformarCamion(nuevo))
            {
                MessageBox.Show("Se inserto con exito", "EXITO", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("No inserto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
}
