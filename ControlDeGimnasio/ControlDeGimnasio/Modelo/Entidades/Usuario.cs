using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class Usuario {
        #region Atributo
        private int nID;
        private String Nombre_U;
        private String Contraseña_U;
        private String Profesion_U;
        private String Direccion_U;
        private String Telefono_U;
        #endregion

        #region Propiedades
        public int ID {
            get { return nID; }
            set { nID = value; }
        }

        public String Nombre {
            get { return Nombre_U; }
            set { Nombre_U = value; }
        }

        public String Contraseña {
            get { return Contraseña_U; }
            set { Contraseña_U = value; }
        }

        public String Profesion {
            get { return Profesion_U; }
            set { Profesion_U = value; }
        }

        public String Direccion {
            get { return Direccion_U; }
            set { Direccion_U = value; }
        }

        public String Telefono
        {
            get { return Telefono_U; }
            set { Telefono_U = value; }
        }
        #endregion

        #region Metodos
        public Usuario()
        {
            nID = 0;
            Nombre_U = "";
            Contraseña_U = "";
            Profesion_U = "";
            Direccion_U = "";
            Telefono_U = "";
        }
        #endregion

    }

    [Serializable()]
    public class Usuarios : BindingList<Usuario> {
    }
}
