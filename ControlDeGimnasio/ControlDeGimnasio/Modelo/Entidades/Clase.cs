using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class Clase {
        #region Atributos
        private String Descripcion_C;
        private DateTime Hora_C;
        private String Nombre_C;
        private Int32 Entrenador_C;
        #endregion

        #region Propiedades
        public String Descripcion {
            get { return Descripcion_C; }
            set { Descripcion_C = value; }
        }

        public DateTime Hora {
            get { return Hora_C; }
            set { Hora_C = value; }
        }

        public String Nombre {
            get { return Nombre_C; }
            set { Nombre_C = value; }
        }

        public Int32 Entrenador {
            get { return Entrenador_C; }
            set { Entrenador_C = value; }
        }
        #endregion

        #region Metodos
        public Clase() {
            Descripcion_C = "";
            Hora_C = new DateTime(1900, 01, 01);
            Nombre_C = "";
            Entrenador_C = 0;
        }
        #endregion
    }

    [Serializable()]
    public class Clases : BindingList<Clase> {
    }
}
