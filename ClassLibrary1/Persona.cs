using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Persona
    {

        #region Atributos

        private string nombre;

        private string apellido;

        private DateTime fechanac;

        private char tipodni;

        private long dni;

        private char sexo;

        private string cuit;

        #endregion


        #region Propiedades

        //get y set para manipular los datos miembros, atributos

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public DateTime Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }

        }

        public char Tipodni
        {
            get { return tipodni; }
            set { tipodni = value; }

        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }

        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }

        }


        #endregion

        #region Constructores
        
        public Persona(string nomb, string apell, long d, char tipd)
        {
            nombre = nomb;
            apellido = apell;
            dni = d;
            tipodni = tipd;

        }

        //C. con argumentos (nombre, apellido, tipodni, dni)
        //C. con todos los datos

        public Persona(string nomb, string apell, long d, char tipd, DateTime nac, char sex, string cui)
        {
            nombre = nomb;
            apellido = apell;
            dni = d;
            tipodni = tipd;
            fechanac = nac;
            sexo = sex;
            cuit = cui;

        }


        #endregion




    }
}
