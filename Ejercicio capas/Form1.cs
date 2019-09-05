using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
using NegTarjeta;

namespace Ejercicio_capas
{
    public partial class Form1 : Form
    {


		TarjetaBus Tarjeta1 = new TarjetaBus();

		
		public Form1()
        {
            InitializeComponent();
			dgvProfesionales.ColumnCount = 3;
			dgvProfesionales.Columns[0].HeaderText = "Numero de Tarjeta";
			dgvProfesionales.Columns[1].HeaderText = "D.N.I.:";
			dgvProfesionales.Columns[2].HeaderText = "Saldo";
			dgvProfesionales.Columns[0].Width = 60;
			dgvProfesionales.Columns[1].Width = 200;
			dgvProfesionales.Columns[2].Width = 200;
			LlenarDGV();


		}

		public TarjetaBus objEntProf = new TarjetaBus();

		public Negocios objNegProf = new Negocios();

		private void LlenarDGV()
		{
			dgvProfesionales.Rows.Clear();
			DataSet ds = new DataSet();
			ds = objNegProf.listadoProfesionales("Todos");
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					//Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString()
					dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1], dr[2]);
				}
			}
			else
				lblSaldo.Text = "No hay Tarjetas cargadas en el sistema";

			
		}
		private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
		{
			objEntProf.Notarjeta = int.Parse(txtNumTarj.Text);
			objEntProf.DniTitular = int.Parse(txtDNI.Text);
			objEntProf.Saldo = decimal.Parse(txtImporte.Text);
		}


		private void BtnCargar_Click(object sender, EventArgs e)
		{
			try
			{
				int nGrabados = -1;
				//llamo al método que carga los datos del objeto
				TxtBox_a_Obj();
				nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a lacapa de negocio
				if (nGrabados == -1)
					lblSaldo.Text = "No pudo grabar profesionales en el sistema";
				else
				{
					lblSaldo.Text = "Se grabó con éxito profesionales.";
					LlenarDGV();
					Limpiar();
				}
				//lblSaldo.Text = "N°Tarjeta: " + Tarjeta1.Notarjeta.ToString(txtNumTarj.Text) +
				//'\n' + "DNI: " + Tarjeta1.DniTitular.ToString(txtDNI.Text) +
				//'\n' + "Su SALDO: " + Tarjeta1.Cargar(decimal.Parse(txtImporte.Text));
			}
			catch
			{
				MessageBox.Show("Error");
			}
			
		}

		private void BtnDescargar_Click(object sender, EventArgs e)
		{
			try
			{
				lblSaldo.Text= "N°Tarjeta: " + Tarjeta1.Notarjeta.ToString(txtNumTarj.Text) +
					'\n' + "DNI: " + Tarjeta1.DniTitular.ToString(txtDNI.Text) +
					'\n' + "Su SALDO: " + Tarjeta1.Extraer(decimal.Parse(txtImporte.Text));

				
			}

			catch
			{
				MessageBox.Show("Error");
			}
		}

		private void DgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataSet ds = new DataSet();
			objEntProf.Notarjeta = Convert.ToInt32(dgvProfesionales.CurrentRow.Cells[0].Value);
			ds = objNegProf.listadoProfesionales(objEntProf.Notarjeta.ToString());
			if (ds.Tables[0].Rows.Count > 0)
			{
				Ds_a_TxtBox(ds);
				btnCargar.Visible = false;
				lblSaldo.Text = string.Empty;
			}

		}
		private void Ds_a_TxtBox(DataSet ds)
		{
			txtNumTarj.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
			txtDNI.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
			txtImporte.Text = ds.Tables[0].Rows[0]["Saldo"].ToString();
			txtNumTarj.Enabled = false;
		}
		private void Limpiar()
		{
			txtNumTarj.Text = string.Empty;
			txtDNI.Text = string.Empty;
			txtImporte.Text = string.Empty;
		}

		private void BtnModifi_Click(object sender, EventArgs e)
		{
			int nResultado = -1;
			TxtBox_a_Obj();
			nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invoco la capa de negocio
			if (nResultado != -1)
			{
				
				Limpiar();
				LlenarDGV();

				txtNumTarj.Enabled = true;
				MessageBox.Show("Aviso", "El Profesional fue Modificado con éxito");

			}
			else
				MessageBox.Show("Error", "Se produjo un error al intentar modificar el Profesional");

		}
	}
}
