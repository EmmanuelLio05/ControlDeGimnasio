using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ControlDeGimnasio.Modelo.Datos {
    public class Socio {
        public Object Add(Modelo.Entidades.Socio oSocio) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_Insert";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", oSocio.Id);
                    oComm.Parameters.AddWithValue("@Nombre_S", oSocio.Nombre);
                    oComm.Parameters.AddWithValue("@Paterno_S", oSocio.Materno);
                    oComm.Parameters.AddWithValue("@Materno_S", oSocio.Paterno);
                    //oComm.Parameters.AddWithValue("@Imagen_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Direccion_S", oSocio.Direccion);
                    oComm.Parameters.AddWithValue("@Telefono_S", oSocio.Telefono);
                    oComm.Parameters.AddWithValue("@Fecha_I", oSocio.FechaInscripcion);
                    oComm.Parameters.AddWithValue("@E_Suscripcion", oSocio.Inscrito);
                    oComm.Parameters.AddWithValue("@Monto", oSocio.Monto);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Object Update(Modelo.Entidades.Socio oSocio) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_Update";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", oSocio.Id);
                    oComm.Parameters.AddWithValue("@Nombre_S", oSocio.Nombre);
                    oComm.Parameters.AddWithValue("@Paterno_S", oSocio.Materno);
                    oComm.Parameters.AddWithValue("@Materno_S", oSocio.Paterno);
                    //oComm.Parameters.AddWithValue("@Imagen_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Direccion_S", oSocio.Direccion);
                    oComm.Parameters.AddWithValue("@Telefono_S", oSocio.Telefono);
                    oComm.Parameters.AddWithValue("@Fecha_I", oSocio.FechaInscripcion);
                    oComm.Parameters.AddWithValue("@E_Suscripcion", oSocio.Inscrito);
                    oComm.Parameters.AddWithValue("@Monto", oSocio.Monto);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public void Delete(Int32 Numero_S) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_Disable";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", Numero_S);
                    oComm.ExecuteScalar();
                }
            }
        }

        public bool Verificar(Int32 Numero_S) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_GetOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", Numero_S);
                    return oComm.ExecuteReader().HasRows;
                }
            }
        }

        public Entidades.Socio GetOne(Int32 Numero_S) {
            var oEGeneral = new General();
            SqlDataReader drSocio;
            Entidades.Socio oSocio = new Entidades.Socio();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_GetOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", Numero_S);
                    drSocio = oComm.ExecuteReader();
                    if (drSocio.Read()) {
                        LlenaEntidad(ref oSocio, drSocio);
                        return oSocio;
                    } else return null;
                }
            }
        }

        public Entidades.Socios Busqueda(String sSql) {
            var oEGeneral = new General();
            SqlDataReader drSocio;
            Entidades.Socio oSocio = new Entidades.Socio();
            Entidades.Socios oSocios = new Entidades.Socios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    oComm.CommandType = CommandType.StoredProcedure;
                    drSocio = oComm.ExecuteReader();
                    while (drSocio.Read()) {
                        oSocio = new Entidades.Socio();
                        LlenaEntidad(ref oSocio, drSocio);
                        oSocios.Add(oSocio);
                    }
                    return oSocios;
                }
            }
        }

        public Entidades.Socios GetAll() {
            var oEGeneral = new General();
            SqlDataReader drSocio;
            Entidades.Socio oSocio = new Entidades.Socio();
            Entidades.Socios oSocios = new Entidades.Socios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socio_GetAll";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drSocio = oComm.ExecuteReader();
                    while (drSocio.Read()) {
                        oSocio = new Entidades.Socio();
                        LlenaEntidad(ref oSocio, drSocio);
                        oSocios.Add(oSocio);
                    }
                    return oSocios;
                }
            }
        }

        public Entidades.Socios GetInformacion() {
            var oEGeneral = new General();
            SqlDataReader drSocio;
            Entidades.Socio oSocio = new Entidades.Socio();
            Entidades.Socios oSocios = new Entidades.Socios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Informacion_Socios";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drSocio = oComm.ExecuteReader();
                    while (drSocio.Read()) {
                        oSocio = new Entidades.Socio();
                        oSocio.Inscrito = Convert.IsDBNull(drSocio["E_Suscripcion"]) ? false : Convert.ToBoolean(drSocio["E_Suscripcion"]);
                        if (oSocio.Inscrito)
                            oSocio.Nombre = "SI";
                        else
                            oSocio.Nombre = "NO";
                        oSocio.Id = Convert.IsDBNull(drSocio["Num_Clientes"]) ? 0 : Convert.ToInt32(drSocio["Num_Clientes"]);
                        oSocio.Monto = Convert.IsDBNull(drSocio["Monto_Total"]) ? 0.0m : Convert.ToDecimal(drSocio["Monto_Total"]);
                        oSocios.Add(oSocio);
                    }
                    return oSocios;
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Socio oSocio, SqlDataReader drSocio) {
            oSocio.Id = Convert.IsDBNull(drSocio["Numero_S"]) ? 0 : Convert.ToInt32(drSocio["Numero_S"]);
            oSocio.Nombre = Convert.IsDBNull(drSocio["Nombre_S"]) ? "" : Convert.ToString(drSocio["Nombre_S"]).Trim();
            oSocio.Paterno = Convert.IsDBNull(drSocio["Paterno_S"]) ? "" : Convert.ToString(drSocio["Paterno_S"]).Trim();
            oSocio.Materno = Convert.IsDBNull(drSocio["Materno_S"]) ? "" : Convert.ToString(drSocio["Materno_S"]).Trim();
            //oSocio.S = Convert.IsDBNull(drSocio["Imagen_S"]) ? ERROR : Convert.ToERROR(drSocio["Imagen_S"]);
            oSocio.Direccion = Convert.IsDBNull(drSocio["Direccion_S"]) ? "" : Convert.ToString(drSocio["Direccion_S"]).Trim();
            oSocio.Telefono = Convert.IsDBNull(drSocio["Telefono_S"]) ? "" : Convert.ToString(drSocio["Telefono_S"]).Trim();
            oSocio.FechaInscripcion = Convert.IsDBNull(drSocio["Fecha_I"]) ? new DateTime(1900, 01, 01) : Convert.ToDateTime(drSocio["Fecha_I"]);
            oSocio.Inscrito = Convert.IsDBNull(drSocio["E_Suscripcion"]) ? false : Convert.ToBoolean(drSocio["E_Suscripcion"]);
            oSocio.Monto = Convert.IsDBNull(drSocio["Monto"]) ? 0.0m : Convert.ToDecimal(drSocio["Monto"]);
        }
    }
}
