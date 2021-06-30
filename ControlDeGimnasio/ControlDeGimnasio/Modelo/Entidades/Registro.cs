using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Entidades {
    public class Registro {
        #region Atributos
        private DateTime Hora_Salida;
        private DateTime Hora_Entrada;
        private Int32 Numero_S;
        private String Nombre_S;
        private Int32 Id_R;
        #endregion

        #region Propiedades
        public DateTime HoraSalida {
            get { return Hora_Salida; }
            set { Hora_Salida = value; }
        }

        public DateTime HoraEntrada {
            get { return Hora_Entrada; }
            set { Hora_Entrada = value; }
        }

        public Int32 Socio {
            get { return Numero_S; }
            set { Numero_S = value; }
        }

        public String NombreSocio {
            get { return Nombre_S; }
            set { Nombre_S = value; }
        }

        public Int32 ID {
            get { return Id_R; }
            set { Id_R = value; }
        }
        #endregion

        #region Metodos
        public Registro() {
            Hora_Salida = new DateTime(1900, 01, 01);
            Hora_Entrada = new DateTime(1900, 01, 01);
            Numero_S = 0;
            Id_R = 0;
            Nombre_S = "";
        }
        #endregion
    }

    [Serializable()]
    public class Registros : BindingList<Registro> {
    }
}
