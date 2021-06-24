using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class TomaClase {
        #region Atributos
        int _numero_socio;
        int _numero_clase;
        #endregion

        #region Propiedades
        public int Socio {
            get { return _numero_socio; }
            set { _numero_socio = value; }
        }

        public int Clase {
            get { return _numero_clase; }
            set { _numero_clase = value; }
        }
        #endregion

        #region Metodos
        public TomaClase() {
            _numero_clase = 0;
            _numero_socio = 0;
        }
        #endregion
    }

    [Serializable()]
    public class TomaClases : BindingList<TomaClase> {
    }
}

