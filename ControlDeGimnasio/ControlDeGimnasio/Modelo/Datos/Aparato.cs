﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    class Aparato {
        public Object Add(Modelo.Entidades.Aparato oAparato) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_Insert";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Estado_A", oAparato.Estado);
                    oComm.Parameters.AddWithValue("@Descripcion_A", oAparato.Descripcion);
                    //oComm.Parameters.AddWithValue("@Num_A", oAparato.Id);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Object Update(Modelo.Entidades.Aparato oAparato) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_Update";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Estado_A", oAparato.Estado);
                    oComm.Parameters.AddWithValue("@Descripcion_A", oAparato.Descripcion);
                    oComm.Parameters.AddWithValue("@Num_A", oAparato.Id);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public void Delete(Int32 Num_A) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_Disable";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Num_A", Num_A);
                    oComm.ExecuteScalar();
                }
            }
        }

        public bool Verificar(Int32 Num_A) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_GetOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Num_A", Num_A);
                    return oComm.ExecuteReader().HasRows;
                }
            }
        }

        public Entidades.Aparato GetOne(Int32 Num_A) {
            var oEGeneral = new General();
            SqlDataReader drAparato;
            Entidades.Aparato oAparato = new Entidades.Aparato();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_GetOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@Num_A", Num_A);
                    drAparato = oComm.ExecuteReader();
                    if (drAparato.Read()) {
                        LlenaEntidad(ref oAparato, drAparato);
                        return oAparato;
                    } else return null;
                }
            }
        }

        public Entidades.Aparatos Busqueda(String sSql) {
            var oEGeneral = new General();
            SqlDataReader drAparato;
            Entidades.Aparato oAparato = new Entidades.Aparato();
            Entidades.Aparatos oAparatos = new Entidades.Aparatos();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    oComm.CommandType = CommandType.StoredProcedure;
                    drAparato = oComm.ExecuteReader();
                    while (drAparato.Read()) {
                        oAparato = new Entidades.Aparato();
                        LlenaEntidad(ref oAparato, drAparato);
                        oAparatos.Add(oAparato);
                    }
                    return oAparatos;
                }
            }
        }

        public Entidades.Aparatos GetAll() {
            var oEGeneral = new General();
            SqlDataReader drAparato;
            Entidades.Aparato oAparato = new Entidades.Aparato();
            Entidades.Aparatos oAparatos = new Entidades.Aparatos();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Aparato_GetAll";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drAparato = oComm.ExecuteReader();
                    while (drAparato.Read()) {
                        oAparato = new Entidades.Aparato();
                        LlenaEntidad(ref oAparato, drAparato);
                        oAparatos.Add(oAparato);
                    }
                    return oAparatos;
                }
            }
        }

        public Entidades.Aparatos GetInformacion() {
            var oEGeneral = new General();
            SqlDataReader drAparato;
            Entidades.Aparato oAparato = new Entidades.Aparato();
            Entidades.Aparatos oAparatos = new Entidades.Aparatos();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Informacion_Aparatos";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drAparato = oComm.ExecuteReader();
                    while (drAparato.Read()) {
                        oAparato = new Entidades.Aparato();
                        oAparato.Estado = Convert.IsDBNull(drAparato["Estado_A"]) ? false : Convert.ToBoolean(drAparato["Estado_A"]);
                        if (oAparato.Estado)
                            oAparato.Descripcion = "SI";
                        else
                            oAparato.Descripcion = "NO";
                        oAparato.Id = Convert.IsDBNull(drAparato["Num_Equipos"]) ? 0 : Convert.ToInt32(drAparato["Num_Equipos"]);
                        oAparatos.Add(oAparato);
                    }
                    return oAparatos;
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Aparato oAparato, SqlDataReader drAparato) {
            oAparato.Estado = Convert.IsDBNull(drAparato["Estado_A"]) ? false : Convert.ToBoolean(drAparato["Estado_A"]);
            oAparato.Descripcion = Convert.IsDBNull(drAparato["Descripcion_A"]) ? "" : Convert.ToString(drAparato["Descripcion_A"]).Trim();
            oAparato.Id = Convert.IsDBNull(drAparato["Num_A"]) ? 0 : Convert.ToInt32(drAparato["Num_A"]);
        }
    }
}
