using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class UsaAparato {
        #region Atributos
        int _numero_socio;
        int _numero_aparato;
        #endregion

        #region Propiedades
        public int Socio {
            get { return _numero_socio; }
            set { _numero_socio = value; }
        }

        public int aparato {
            get { return _numero_aparato; }
            set { _numero_aparato = value; }
        }
        #endregion

        #region Metodos
        public UsaAparato() {
            _numero_aparato = 0;
            _numero_socio = 0;
        }
        #endregion
    }

    [Serializable()]
    public class UsaAparatos : BindingList<UsaAparato> {
    }
}
