﻿using System;
using System;
using System.ComponentModel;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class Socio {
        #region Atributos
        private int _Numero;
        private string _Nombre;
        private string _Paterno;
        private string _Materno;
        private string _Direccion;
        private string _Telefono;
        private DateTime _FechaInscripcion;
        private Boolean _Inscrito;
        private decimal _Monto;

        #endregion

        #region Propiedades
        public decimal Monto {
            get { return _Monto; }
            set { _Monto = value; }
        }

        public bool Inscrito{
            get { return _Inscrito; }
            set { _Inscrito = value; }
        }

        public DateTime FechaInscripcion {
            get { return _FechaInscripcion; }
            set { _FechaInscripcion = value; }
        }

        public String Telefono {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public String Direccion {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public String Materno {
            get { return _Materno; }
            set { _Materno = value; }
        }

        public String Paterno {
            get { return _Paterno; }
            set { _Paterno = value; }
        }

        public String Nombre {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public Int32 Id {
            get { return _Numero; }
            set { _Numero = value; }
        }
        #endregion

        #region Constructor
        public Socio() {
            _Numero = 0;
            _Nombre= "";
            _Materno = "";
            _Paterno = "";
            _Direccion = "";
            _Telefono= "";
            _FechaInscripcion = new DateTime(1900,1,1);
            _Inscrito = true;
            _Monto = 0;
        }
        #endregion
    }

        [Serializable()]
        public class Socios : BindingList<Socio> {
        }
}
