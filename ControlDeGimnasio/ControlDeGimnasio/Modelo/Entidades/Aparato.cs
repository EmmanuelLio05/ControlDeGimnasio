using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class Aparato {
        #region Aparato
        private bool Estado_A;
        private String Descripcion_A;
        private Int32 Num_A;
        #endregion

        #region Propiedades
        public bool Estado {
            get { return Estado_A; }
            set { Estado_A = value; }
        }

        public String Descripcion {
            get { return Descripcion_A; }
            set { Descripcion_A = value; }
        }

        public Int32 Id {
            get { return Num_A; }
            set { Num_A = value; }
        }
        #endregion

        #region Metodos
        public Aparato() {
            Estado_A = false;
            Descripcion_A = "";
            Num_A = 0;
        }
        #endregion
    }

    [Serializable()]
    public class Aparatos : BindingList<Aparato> {
    }
}
