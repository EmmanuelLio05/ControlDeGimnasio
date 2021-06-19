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
        #endregion

        #region Propiedades
        public int ID {
            get { return nID; }
            set { nID = value; }
        }
        #endregion

    }

    [Serializable()]
    public class Usuarios : BindingList<Usuario> {
    }
}
