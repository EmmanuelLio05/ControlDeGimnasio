using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    public class Clase {

        public Object Add(Entidades.Clase oClase) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.CommandText = "Clase_Insert";
                    oComm.Parameters.AddWithValue("@Descripcion_C", oClase.Descripcion);
                    oComm.Parameters.AddWithValue("@Hora_C", oClase.Hora);
                    oComm.Parameters.AddWithValue("@Nombre_C", oClase.Nombre);
                    oComm.Parameters.AddWithValue("@Entrenador_C", oClase.Entrenador);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Object Update(Modelo.Entidades.Clase oClase) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Clase_Update";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Descripcion_C", oClase.Descripcion);
                    oComm.Parameters.AddWithValue("@Hora_C", oClase.Hora);
                    oComm.Parameters.AddWithValue("@Nombre_C", oClase.Nombre);
                    oComm.Parameters.AddWithValue("@Entrenador_C", oClase.Entrenador);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public void Delete(String Nombre_C) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Clase_Disable";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Nombre_C", Nombre_C);
                    oComm.ExecuteScalar();
                }
            }
        }

        public bool Verificar(String Nombre_C) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Clases_SelectOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Nombre_C", Nombre_C);
                    return oComm.ExecuteReader().HasRows;
                }
            }
        }

        public Entidades.Clase GetOne(String Nombre_C) {
            var oEGeneral = new General();
            SqlDataReader drClase;
            Entidades.Clase oClase = new Entidades.Clase();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Clases_SelectOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Nombre_C", Nombre_C);
                    drClase = oComm.ExecuteReader();
                    if (drClase.Read()) {
                        LlenaEntidad(ref oClase, drClase);
                        return oClase;
                    } else return null;
                }
            }
        }

        public Entidades.Clases Busqueda(String sSql) {
            var oEGeneral = new General();
            SqlDataReader drClase;
            Entidades.Clase oClase = new Entidades.Clase();
            Entidades.Clases oClases = new Entidades.Clases();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    oComm.CommandType = CommandType.StoredProcedure;
                    drClase = oComm.ExecuteReader();
                    while (drClase.Read()) {
                        oClase = new Entidades.Clase();
                        LlenaEntidad(ref oClase, drClase);
                        oClases.Add(oClase);
                    }
                    return oClases;
                }
            }
        }

        public Entidades.Clases GetAll() {
            var oEGeneral = new General();
            SqlDataReader drClase;
            Entidades.Clase oClase = new Entidades.Clase();
            Entidades.Clases oClases = new Entidades.Clases();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Clases_SelectAll";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drClase = oComm.ExecuteReader();
                    while (drClase.Read()) {
                        oClase = new Entidades.Clase();
                        LlenaEntidad(ref oClase, drClase);
                        oClases.Add(oClase);
                    }
                    return oClases;
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Clase oClase, SqlDataReader drClase) {
            oClase.Descripcion = Convert.IsDBNull(drClase["Descripcion_C"]) ? "" : Convert.ToString(drClase["Descripcion_C"]).Trim();
            oClase.Hora = Convert.IsDBNull(drClase["Hora_C"]) ? new DateTime(1900, 01, 01) : Convert.ToDateTime(drClase["Hora_C"]);
            oClase.Nombre= Convert.IsDBNull(drClase["Nombre_C"]) ? "" : Convert.ToString(drClase["Nombre_C"]).Trim();
            oClase.Entrenador = Convert.IsDBNull(drClase["Entrenador_C"]) ? 0 : Convert.ToInt32(drClase["Entrenador_C"]);
        }
    }
}
