namespace CRUDtransporte
{
    partial class AltaTransporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalCargas = new System.Windows.Forms.TextBox();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(12, 9);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(121, 24);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Camion Nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Carga";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(108, 145);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(188, 21);
            this.cboTipoCarga.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Cargas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Peso Maximo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Patente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Peso";
            // 
            // txtTotalCargas
            // 
            this.txtTotalCargas.Location = new System.Drawing.Point(398, 343);
            this.txtTotalCargas.Name = "txtTotalCargas";
            this.txtTotalCargas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCargas.TabIndex = 11;
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(108, 85);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(211, 20);
            this.txtPesoMaximo.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(108, 116);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(211, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(108, 59);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(211, 20);
            this.txtPatente.TabIndex = 14;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(346, 148);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(71, 20);
            this.txtPeso.TabIndex = 15;
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.AllowUserToAddRows = false;
            this.dgvCamiones.AllowUserToDeleteRows = false;
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTipoCarga,
            this.colPeso,
            this.colAcciones});
            this.dgvCamiones.Location = new System.Drawing.Point(35, 180);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.ReadOnly = true;
            this.dgvCamiones.Size = new System.Drawing.Size(477, 150);
            this.dgvCamiones.TabIndex = 16;
            this.dgvCamiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamiones_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTipoCarga
            // 
            this.colTipoCarga.HeaderText = "Tipo Carga";
            this.colTipoCarga.Name = "colTipoCarga";
            this.colTipoCarga.ReadOnly = true;
            this.colTipoCarga.Width = 200;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Accion";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Text = "Eliminar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(437, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(326, 410);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(437, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(398, 373);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPesoTotal.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Peso Total ";
            // 
            // AltaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 445);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCamiones);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.txtTotalCargas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNext);
            this.Name = "AltaTransporte";
            this.Text = "AltaTransporte";
            this.Load += new System.EventHandler(this.AltaTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalCargas;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}

