using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
	public class TarjetaBus
	{
		#region Atributos

		private decimal idtarjeta;

		private decimal dnititular;

		private decimal saldo;

		#endregion

		#region Propiedades

		//get y set para manipular los datos miembros, atributos

		public decimal Notarjeta
		{
			get { return idtarjeta; }
			set { idtarjeta = value; }

		}

		public decimal DniTitular
		{
			get { return dnititular; }
			set { dnititular = value; }

		}

		public decimal Saldo
		{
			get { return saldo; }
			set {saldo = value; }
		}
		#endregion

		#region Constructores

		public TarjetaBus(long idtarj, long dnitit)
		{

			idtarjeta = idtarj;
			dnititular = dnitit;
			saldo = 0;

		}
		public TarjetaBus()
		{

		}

		#endregion

		#region Metodo

		public decimal Cargar(decimal monto)
		{

			saldo += monto;
			return saldo;
		}

		public decimal Extraer(decimal monto)
		{
			if (monto <= saldo)
			{
				saldo -= monto;

			}
			return saldo;
		}

		#endregion
	}

}
