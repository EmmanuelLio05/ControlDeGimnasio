using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeGimnasio.Modelo.Datos {
    public class Usuario {

        public Object Add(Entidades.Usuario oUsuario) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.CommandText = "Usuario_Insert";
                    oComm.Parameters.AddWithValue("@nID", oUsuario.ID);   
                    oComm.Parameters.AddWithValue("@Nombre_U", oUsuario.Nombre);
                    oComm.Parameters.AddWithValue("@Contraseña_U", oUsuario.Contraseña);
                    oComm.Parameters.AddWithValue("@Profesion_U", oUsuario.Profesion);
                    oComm.Parameters.AddWithValue("@Direccion_U", oUsuario.Direccion);
                    oComm.Parameters.AddWithValue("@Telefono_U", oUsuario.Telefono);
                    return oComm.ExecuteScalar();
                }
            }
        }

        public Object Update(Modelo.Entidades.Usuario oUsuario) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Usuario_Update";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@nID", oUsuario.ID); 
                    oComm.Parameters.AddWithValue("@Nombre_U", oUsuario.Nombre);
                    oComm.Parameters.AddWithValue("@Contraseña_U", oUsuario.Contraseña);
                    oComm.Parameters.AddWithValue("@Profesion_U", oUsuario.Profesion);
                    oComm.Parameters.AddWithValue("@Direccion_U", oUsuario.Direccion);
                    oComm.Parameters.AddWithValue("@Telefono_U", oUsuario.Telefono);
                    return oComm.ExecuteScalar();
                }
            }
        }

        //nID 
        public void Delete(int nID) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Usuario_Disable";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@nID", nID);
                    oComm.ExecuteScalar();
                }
            }
        }

        //nID 
        public bool Verificar(int nID) {
            var oEGeneral = new General();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Usuarios_SelectOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@nID", nID);
                    return oComm.ExecuteReader().HasRows;
                }
            }
        }

        //nID 
        public Entidades.Usuario GetOne(int nID) {
            var oEGeneral = new General();
            SqlDataReader drUsuario;
            Entidades.Usuario oUsuario = new Entidades.Usuario();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Usuarios_SelectOne";
                    oComm.CommandType = CommandType.StoredProcedure;
                    oComm.Parameters.AddWithValue("@nID", nID);
                    drUsuario = oComm.ExecuteReader();
                    if (drUsuario.Read()) {
                        LlenaEntidad(ref oUsuario, drUsuario);
                        return oUsuario;
                    } else return null;
                }
            }
        }

        public Entidades.Usuarios Busqueda(String sSql) {
            var oEGeneral = new General();
            SqlDataReader drUsuario;
            Entidades.Usuario oUsuario = new Entidades.Usuario();
            Entidades.Usuarios oUsuarios = new Entidades.Usuarios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Ejecuta_SQL";
                    oComm.Parameters.AddWithValue("@sql", sSql);
                    oComm.CommandType = CommandType.StoredProcedure;
                    drUsuario = oComm.ExecuteReader();
                    while (drUsuario.Read()) {
                        oUsuario = new Entidades.Usuario();
                        LlenaEntidad(ref oUsuario, drUsuario);
                        oUsuarios.Add(oUsuario);
                    }
                    return oUsuarios;
                }
            }
        }

        public Entidades.Usuarios GetAll() {
            var oEGeneral = new General();
            SqlDataReader drUsuario;
            Entidades.Usuario oUsuario = new Entidades.Usuario();
            Entidades.Usuarios oUsuarios = new Entidades.Usuarios();

            using (var oCon = oEGeneral.Conectar()) {
                oCon.Open();
                using (var oComm = new SqlCommand()) {
                    oComm.Connection = oCon;
                    oComm.CommandText = "Usuarios_SelectAll";
                    oComm.CommandType = CommandType.StoredProcedure;
                    drUsuario = oComm.ExecuteReader();
                    while (drUsuario.Read()) {
                        oUsuario = new Entidades.Usuario();
                        LlenaEntidad(ref oUsuario, drUsuario);
                        oUsuarios.Add(oUsuario);
                    }
                    return oUsuarios;
                }
            }
        }

        private void LlenaEntidad(ref Entidades.Usuario oUsuario, SqlDataReader drUsuario) {
            oUsuario.ID = Convert.IsDBNull(drUsuario["nID"]) ? 0 : Convert.ToInt32(drUsuario["nID"]);
            oUsuario.Nombre = Convert.IsDBNull(drUsuario["Nombre_U"]) ? "" : Convert.ToString(drUsuario["Nombre_U"]).Trim();
            oUsuario.Contraseña = Convert.IsDBNull(drUsuario["Contraseña_U"]) ? "" : Convert.ToString(drUsuario["Contraseña_U"]).Trim();
            oUsuario.Profesion = Convert.IsDBNull(drUsuario["Profesion_U"]) ? "" : Convert.ToString(drUsuario["Profesion_U"]).Trim();
            oUsuario.Direccion = Convert.IsDBNull(drUsuario["Direccion_U"]) ? "" : Convert.ToString(drUsuario["Direccion_U"]).Trim();
            oUsuario.Telefono = Convert.IsDBNull(drUsuario["Telefono_U"]) ? "" : Convert.ToString(drUsuario["Telefono_U"]).Trim();
        }
    }
}
