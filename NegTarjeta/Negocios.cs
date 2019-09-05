using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using ClassLibrary1;

namespace NegTarjeta
{
	public class Negocios
	{
		DatosProfesionales objDatosProfes = new DatosProfesionales();

		public int abmProfesionales(string accion, TarjetaBus objProfesional)
		{
			return objDatosProfes.abmProfesionales(accion, objProfesional);
		}
		public DataSet listadoProfesionales(string cual)
		{
			return objDatosProfes.listadoProfesionales(cual);
		}
	}

}
