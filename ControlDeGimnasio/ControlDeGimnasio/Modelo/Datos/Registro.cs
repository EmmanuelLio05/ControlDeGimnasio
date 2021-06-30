using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    public class Registro {
        public Object In(Modelo.Entidades.Registro oRegistro) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Registro_In";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Hora_Entrada", oRegistro.HoraEntrada);
                    oComm.Parameters.AddWithValue("@Numero_S", oRegistro.Socio  );
                    oComm.Parameters.AddWithValue("@Id_R", oRegistro.ID);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Object Out(Modelo.Entidades.Registro oRegistro) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Registro_Out";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Hora_Salida", oRegistro.HoraSalida);
                    oComm.Parameters.AddWithValue("@Id_R", oRegistro.ID);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Entidades.Registros GetOne(Int32 Numero_S) {
            var oEGeneral = new General();
            SqlDataReader drRegistro;
            Entidades.Registro oRegistro = new Entidades.Registro();
            Entidades.Registros oRegistros = new Entidades.Registros();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Registro_GetBySocio";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", Numero_S);
                    drRegistro = oComm.ExecuteReader();
                    while (drRegistro.Read()) {
                        oRegistro = new Entidades.Registro();
                        LlenaEntidad(ref oRegistro, drRegistro);
                        oRegistros.Add(oRegistro);
                    }
                    return oRegistros;
                }
            }
        }

        public Entidades.Registros Busqueda(String sSql) {
            var oEGeneral = new General();
            SqlDataReader drRegistro;
            Entidades.Registro oRegistro = new Entidades.Registro();
            Entidades.Registros oRegistros = new Entidades.Registros();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    oComm.CommandType = CommandType.StoredProcedure;
                    drRegistro = oComm.ExecuteReader();
                    while (drRegistro.Read()) {
                        oRegistro = new Entidades.Registro();
                        LlenaEntidad(ref oRegistro, drRegistro);
                        oRegistros.Add(oRegistro);
                    }
                    return oRegistros;
                }
            }
        }

        public Entidades.Registros GetAll() {
            var oEGeneral = new General();
            SqlDataReader drRegistro;
            Entidades.Registro oRegistro = new Entidades.Registro();
            Entidades.Registros oRegistros = new Entidades.Registros();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Registro_GetAll";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drRegistro = oComm.ExecuteReader();
                    while (drRegistro.Read()) {
                        oRegistro = new Entidades.Registro();
                        LlenaEntidad(ref oRegistro, drRegistro);
                        oRegistros.Add(oRegistro);
                    }
                    return oRegistros;
                }
            }
        }

        public object SelectMaxId() {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Registro_GetMaxID";
                    oComm.CommandType = CommandType.StoredProcedure;
                    return oComm.ExecuteScalar();
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Registro oRegistro, SqlDataReader drRegistro) {
            oRegistro.HoraSalida = Convert.IsDBNull(drRegistro["Hora_Salida"]) ? new DateTime(1900, 01, 01) : Convert.ToDateTime(drRegistro["Hora_Salida"]);
            oRegistro.HoraEntrada = Convert.IsDBNull(drRegistro["Hora_Entrada"]) ? new DateTime(1900, 01, 01) : Convert.ToDateTime(drRegistro["Hora_Entrada"]);
            oRegistro.Socio = Convert.IsDBNull(drRegistro["Numero_S"]) ? 0 : Convert.ToInt32(drRegistro["Numero_S"]);
            oRegistro.ID = Convert.IsDBNull(drRegistro["Id_R"]) ? 0 : Convert.ToInt32(drRegistro["Id_R"]);
        }

    }
}
