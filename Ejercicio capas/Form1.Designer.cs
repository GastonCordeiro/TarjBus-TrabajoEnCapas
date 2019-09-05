namespace Ejercicio_capas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnCargar = new System.Windows.Forms.Button();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.lblImporte = new System.Windows.Forms.Label();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.btnExtraer = new System.Windows.Forms.Button();
			this.lblNumTarj = new System.Windows.Forms.Label();
			this.lblDNI = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtNumTarj = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvProfesionales = new System.Windows.Forms.DataGridView();
			this.NumerodeTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnModifi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(37, 235);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(75, 23);
			this.btnCargar.TabIndex = 0;
			this.btnCargar.Text = "Cargar";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Location = new System.Drawing.Point(34, 289);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(46, 13);
			this.lblSaldo.TabIndex = 1;
			this.lblSaldo.Text = "Saldo: 0";
			// 
			// lblImporte
			// 
			this.lblImporte.AutoSize = true;
			this.lblImporte.Location = new System.Drawing.Point(34, 160);
			this.lblImporte.Name = "lblImporte";
			this.lblImporte.Size = new System.Drawing.Size(45, 13);
			this.lblImporte.TabIndex = 2;
			this.lblImporte.Text = "Importe:";
			// 
			// txtImporte
			// 
			this.txtImporte.Location = new System.Drawing.Point(169, 160);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(100, 20);
			this.txtImporte.TabIndex = 3;
			// 
			// btnExtraer
			// 
			this.btnExtraer.Location = new System.Drawing.Point(147, 235);
			this.btnExtraer.Name = "btnExtraer";
			this.btnExtraer.Size = new System.Drawing.Size(75, 23);
			this.btnExtraer.TabIndex = 4;
			this.btnExtraer.Text = "Extraer";
			this.btnExtraer.UseVisualStyleBackColor = true;
			this.btnExtraer.Click += new System.EventHandler(this.BtnDescargar_Click);
			// 
			// lblNumTarj
			// 
			this.lblNumTarj.AutoSize = true;
			this.lblNumTarj.Location = new System.Drawing.Point(34, 78);
			this.lblNumTarj.Name = "lblNumTarj";
			this.lblNumTarj.Size = new System.Drawing.Size(98, 13);
			this.lblNumTarj.TabIndex = 5;
			this.lblNumTarj.Text = "Numero de Tarjeta:";
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Location = new System.Drawing.Point(34, 117);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(38, 13);
			this.lblDNI.TabIndex = 6;
			this.lblDNI.Text = "D.N.I.:";
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(169, 117);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(100, 20);
			this.txtDNI.TabIndex = 7;
			// 
			// txtNumTarj
			// 
			this.txtNumTarj.Location = new System.Drawing.Point(169, 78);
			this.txtNumTarj.Name = "txtNumTarj";
			this.txtNumTarj.Size = new System.Drawing.Size(100, 20);
			this.txtNumTarj.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(115, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "TARJETABUS";
			// 
			// dgvProfesionales
			// 
			this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerodeTarjeta,
            this.DNI,
            this.Importe});
			this.dgvProfesionales.Location = new System.Drawing.Point(363, 41);
			this.dgvProfesionales.Name = "dgvProfesionales";
			this.dgvProfesionales.Size = new System.Drawing.Size(440, 272);
			this.dgvProfesionales.TabIndex = 10;
			this.dgvProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesionales_CellContentClick);
			// 
			// NumerodeTarjeta
			// 
			this.NumerodeTarjeta.HeaderText = "Numero Tarjeta";
			this.NumerodeTarjeta.Name = "NumerodeTarjeta";
			// 
			// DNI
			// 
			this.DNI.HeaderText = "D.N.I.";
			this.DNI.Name = "DNI";
			// 
			// Importe
			// 
			this.Importe.HeaderText = "Importe";
			this.Importe.Name = "Importe";
			// 
			// btnModifi
			// 
			this.btnModifi.Location = new System.Drawing.Point(257, 235);
			this.btnModifi.Name = "btnModifi";
			this.btnModifi.Size = new System.Drawing.Size(75, 23);
			this.btnModifi.TabIndex = 11;
			this.btnModifi.Text = "Modificar";
			this.btnModifi.UseVisualStyleBackColor = true;
			this.btnModifi.Click += new System.EventHandler(this.BtnModifi_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 393);
			this.Controls.Add(this.btnModifi);
			this.Controls.Add(this.dgvProfesionales);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNumTarj);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblNumTarj);
			this.Controls.Add(this.btnExtraer);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.lblImporte);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.btnCargar);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.Label lblImporte;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Button btnExtraer;
		private System.Windows.Forms.Label lblNumTarj;
		private System.Windows.Forms.Label lblDNI;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtNumTarj;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProfesionales;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumerodeTarjeta;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
		private System.Windows.Forms.Button btnModifi;
	}
}

