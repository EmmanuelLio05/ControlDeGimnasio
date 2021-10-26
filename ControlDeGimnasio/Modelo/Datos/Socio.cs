using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common.DbConnection;
using System.Linq;
using System.Web;

namespace Modelo.Datos {
    public class Socio {
        public Object Add(Modelo.Entidades.Socio oSocio) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socios_Insert";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Nombre_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Imagen_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Direccion_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Telefono_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Fecha_I", oSocio.I);
                    oComm.Parameters.AddWithValue("@E_Suscripcion", oSocio.Suscripcion);
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
                    oComm.CommandText = "Socios_Update";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Nombre_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Imagen_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Direccion_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Telefono_S", oSocio.S);
                    oComm.Parameters.AddWithValue("@Fecha_I", oSocio.I);
                    oComm.Parameters.AddWithValue("@E_Suscripcion", oSocio.Suscripcion);
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
                    oComm.CommandText = "Socios_Delete";
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
                    oComm.CommandText = "Socios_SelectOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_S", Numero_S);
                    return oComm.ExecuteReader().HasRows;
                }
            }
        }

        public object SelectMaxId() {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socios_SelectMaxId";
                    oComm.CommandType = CommandType.StoredProcedure;
                    return oComm.ExecuteScalar();
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
                    oComm.CommandText = "Socios_SelectOne";
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

        public Entidades.Socios GetAll(int nHoja, int nNoRegistros = 50) {
            var oEGeneral = new General();
            SqlDataReader drSocio;
            Entidades.Socio oSocio = new Entidades.Socio();
            Entidades.Socios oSocios = new Entidades.Socios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socios_SelectAll";
                    oComm.Parameters.AddWithValue("@Numero_pagina", nHoja);
                    oComm.Parameters.AddWithValue("@Numero_NoRegistros", nNoRegistros);
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
                    oComm.CommandText = "Socios_SelectAll";
                    oComm.Parameters.AddWithValue("@Numero_pagina", 1);
                    oComm.Parameters.AddWithValue("@Numero_NoRegistros", 2000);
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

        public object CountPaginas(int nLogitud = 50) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Socios_SelectNoHojas";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Numero_NoRegistros", nLogitud);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public object CountPaginas(String sSql) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    return oComm.ExecuteScalar();
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Socio oSocio, SqlDataReader drSocio) {
            oSocio.S = Convert.IsDBNull(drSocio["Numero_S"]) ? 0 : Convert.ToInt32(drSocio["Numero_S"]);
            oSocio.S = Convert.IsDBNull(drSocio["Nombre_S"]) ? "" : Convert.ToString(drSocio["Nombre_S"]).Trim();
            oSocio.S = Convert.IsDBNull(drSocio["Imagen_S"]) ? ERROR : Convert.ToERROR(drSocio["Imagen_S"]);
            oSocio.S = Convert.IsDBNull(drSocio["Direccion_S"]) ? "" : Convert.ToString(drSocio["Direccion_S"]).Trim();
            oSocio.S = Convert.IsDBNull(drSocio["Telefono_S"]) ? "" : Convert.ToString(drSocio["Telefono_S"]).Trim();
            oSocio.I = Convert.IsDBNull(drSocio["Fecha_I"]) ? new DateTime(1900, 01, 01) : Convert.ToDateTime(drSocio["Fecha_I"]);
            oSocio.Suscripcion = Convert.IsDBNull(drSocio["E_Suscripcion"]) ? false : Convert.Tobool(drSocio["E_Suscripcion"]);
            oSocio.Monto = Convert.IsDBNull(drSocio["Monto"]) ? 0.0f : Convert.ToDouble(drSocio["Monto"]);
        }
    }
}
