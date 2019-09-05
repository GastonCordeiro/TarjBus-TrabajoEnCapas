using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionDB
    {
		public SqlConnection conexion;
		public string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Documents\Visual Studio 2019\Clase-Persona-master\.gitignore\ClassLibrary1\TarjetaBus.mdf;Integrated Security=True;Connect Timeout=30";
		
		public ConexionDB()
		{
			conexion = new SqlConnection(cadenaConexion);
		}
		public void Abrirconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Broken || conexion.State ==
				ConnectionState.Closed)
					conexion.Open();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de abrir la conexión", e);
			}
		}
		public void Cerrarconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Open)
					conexion.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de cerrar la conexión", e);
			}
		}
	}
}

